using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using static Spotistat.Spotistat;

namespace Spotistat
{
    internal class UiManager
    {
        private readonly Spotistat form;
        private readonly TemplateManager templateManager;
        private readonly SpotifyApiHandler handler;

        public List<string> albumList = new List<string>();
        public List<string> singleList = new List<string>();
        public UiManager(Spotistat form, TemplateManager templateManager, SpotifyApiHandler handler)
        {
            this.form = form;
            this.templateManager = templateManager;
            this.handler = handler;
        }
        public async Task DisplayInfo(string id)
        {
            Default();
            form.errorProvider1.SetError(form.Find, null);

            dynamic songs;
            dynamic artist;

            artist = await handler.GetArtistInfoAsync(id);
            songs = await handler.GetAlbumsInfoAsync(id);

            FillFields(songs, artist);
            Movement();
        }
        public async Task LoadTemplateInfo(string selectedName)
        {
            List<Template> templates = templateManager.GetTemplates();

            foreach (Template template in templates)
            {
                if (template.Name == selectedName)
                {
                    await DisplayInfo(template.ID);
                }
            }
        }
        public void FocusError(string error)
        {
            form.errorProvider1.SetError(form.Find, error);
            form.Find.Focus();
            form.Save.Enabled = false;
        }
        public void HandleUrlBoxLeave()
        {
            if (form.UrlBox.Text.Length == 0)
            {
                form.UrlBox.ForeColor = Color.Gray;
                form.UrlBox.Font = new Font(form.UrlBox.Font, FontStyle.Italic);
                form.UrlBox.Text = "URL of artist...";
            }
        }
        public void HandleUrlBoxEnter()
        {
            if (form.UrlBox.Text == "URL of artist...")
            {
                form.UrlBox.ForeColor = Color.Black;
                form.UrlBox.Font = new Font(form.UrlBox.Font, FontStyle.Regular);
                form.UrlBox.Text = "";
            }
        }
        public void ClearUrlBox()
        {
            form.UrlBox.Text = "URL of artist...";
            form.UrlBox.ForeColor = Color.Gray;
            form.UrlBox.Font = new Font(form.UrlBox.Font, FontStyle.Italic);
            FocusError(null);

            form.listbox.Text = null;
            form.Delete.Enabled = false;
        }
        public void FillDropdown()
        {
            List<Template> templates = templateManager.GetTemplates();

            if (templates != null && templates.Count != 0)
            {
                form.listbox.Enabled = true;

                foreach (Template template in templates)
                {
                    // Add only new instances
                    if (!form.listbox.Items.Contains(template.Name)) form.listbox.Items.Add(template.Name);
                }
            }
            else
            {
                form.listbox.Enabled = false;
                form.Delete.Enabled = false;
            }
        }
        private void DivideContent(dynamic songs, dynamic artist)
        {
            for (int i = 0; i < songs.Items.Count; i++)
            {
                if (songs.Items[i].AlbumGroup == "album") albumList.Add(songs.Items[i].Name);
                if (songs.Items[i].AlbumGroup == "single") singleList.Add(songs.Items[i].Name);
            }

            DistinctNames();
        }

        private void DistinctNames()
        {
            // Checking identical names
            albumList = albumList.GroupBy(x => x.ToLower()).Select(y => y.First()).ToList();
            singleList = singleList.GroupBy(x => x.ToLower()).Select(y => y.First()).ToList();
        }

        public void FillFields(dynamic songs, dynamic artist)
        {
            DivideContent(songs, artist);

            // Labels filling
            form.name.Text = artist.Name;
            form.name.Visible = true;

            form.followers.Text = artist.Followers.Total.ToString();
            form.popularity.Text = artist.Popularity.ToString();

            // Picture filling
            form.picture.Visible = true;

            if (artist.Images.Count != 0) form.picture.ImageLocation = artist.Images[1].Url; //if artist has pictures
            else form.picture.Image = Properties.Resources.noimage; //if there's no image

            // Filling info from lists
            form.genres.Text = artist.Genres.Count > 0 ? form.genres.Text = string.Join("\r", artist.Genres) : "no genres...";
            form.albums.Text = albumList.Count > 0 ? form.albums.Text = '\u25BA' + " " + string.Join("\r" + '\u25BA' + " ", albumList) : "no albums...";
            form.lastAlbum.Text = albumList.Count > 0 ? '\u25BA' + " " + albumList[0] : "no albums...";
            form.lastSingle.Text = singleList.Count > 0 ? '\u2022' + singleList[0] : "no singles...";
        }
        public void Movement()
        {
            // Moves albums down

            if (form.genres.Location.Y + form.genres.Size.Height > form.albums.Location.Y)
            {
                form.albums.Location = new Point(120, form.genres.Location.Y + form.genres.Size.Height + 12);
                form.lAlbums.Location = new Point(13, form.albums.Location.Y);
            }

            // Moves last album and single down

            if (form.albums.Location.Y + form.albums.Size.Height > form.lastAlbum.Location.Y)
            {
                form.lastAlbum.Location = new Point(120, form.albums.Location.Y + form.albums.Size.Height + 12);
                form.lLastAlbum.Location = new Point(13, form.lastAlbum.Location.Y);

                form.lastSingle.Location = new Point(120, form.lastAlbum.Location.Y + form.lastAlbum.Size.Height + 12);
                form.lLastSingle.Location = new Point(13, form.lastSingle.Location.Y);
            }

            // Moves name of artist and picture down

            if (form.name.Location.Y + form.name.Size.Height > form.picture.Location.Y)
            {
                form.picture.Location = new Point(475, form.name.Location.Y + form.name.Size.Height + 12);
            }

            // Moves picture and name to the right

            int pictureStartPos = 475;

            if (form.lastSingle.Location.X + form.lastSingle.Size.Width > pictureStartPos) pictureStartPos = form.lastSingle.Location.X + form.lastSingle.Size.Width + 10;
            if (form.albums.Location.X + form.albums.Size.Width > pictureStartPos) pictureStartPos = form.albums.Location.X + form.albums.Size.Width + 10;
            if (form.genres.Location.X + form.genres.Size.Width > pictureStartPos) pictureStartPos = form.genres.Location.X + form.genres.Size.Width + 10;


            form.picture.Location = new Point(pictureStartPos, 67);
            form.name.Location = new Point(pictureStartPos, 17);

            if (form.name.Location.Y + form.name.Size.Height > form.picture.Location.Y) form.picture.Location = new Point(pictureStartPos, form.name.Location.Y + form.name.Size.Height + 12);
        }
        public void Default()
        {
            albumList = new List<string>();
            singleList = new List<string>();

            form.lastAlbum.Visible = true;
            form.lLastSingle.Visible = true;
            form.lastSingle.Visible = true;
            form.picture.Visible = false;

            form.picture.Image = null;
            form.name.Visible = false;

            form.lastSingle.Text = "";
            form.lastAlbum.Text = "";
            form.albums.Text = "";
            form.genres.Text = "";
            form.popularity.Text = "";
            form.followers.Text = "";

            form.name.Location = new Point(475, 17);
            form.picture.Location = new Point(475, 67);
            form.lFollowers.Location = new Point(13, 125);
            form.followers.Location = new Point(120, 125);
            form.lAlbums.Location = new Point(13, 215);
            form.albums.Location = new Point(120, 215);
            form.lLastAlbum.Location = new Point(13, 243);
            form.lastAlbum.Location = new Point(120, 243);
            form.lLastSingle.Location = new Point(13, 271);
            form.lastSingle.Location = new Point(120, 271);
            form.lGenres.Location = new Point(13, 187);
            form.genres.Location = new Point(120, 187);
            form.lPopularity.Location = new Point(13, 157);
            form.popularity.Location = new Point(120, 157);
        }
    }
}
