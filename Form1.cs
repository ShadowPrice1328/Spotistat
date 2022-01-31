using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using SpotifyAPI.Web;
using System.Net.Http;
using System.IO;
using System.Linq;

namespace Spotistat
{
    public partial class Spotistat : Form
    {
        public Spotistat()
        {
            InitializeComponent();
            TemplatesToList();
        }
        private void Find_Click(object sender, EventArgs e)
        {
            string id;
            try
            {
                string[] parts = UrlBox.Text.Split('/', '?');
                id = parts[4];
            }
            catch
            {
                UrlBox.Focus();
                errorProvider1.SetError(Find, "Wrong URL!");
                Save.Enabled = false;
                return;
            }

            Info(id);

            Save.Enabled = true;
            Delete.Enabled = false;
            listbox.Text = null;
        }
        public void Default()
        {
            //---Default locations and values of elements
            lastalbum.Visible = true;
            lLastsingle.Visible = true;
            lastsingle.Visible = true;

            picture.Visible = false;
            picture.Image = null;

            name.Visible = false;

            lastsingle.Text = "";
            lastalbum.Text = "";
            albums.Text = "";
            genres.Text = "";
            popularity.Text = "";
            followers.Text = "";

            name.Location = new Point(475, 17);
            picture.Location = new Point(475, 67);

            lFollowers.Location = new Point(13, 125);
            followers.Location = new Point(120, 125);

            lAlbums.Location = new Point(13, 215);
            albums.Location = new Point(120, 215);

            lLastalbum.Location = new Point(13, 243);
            lastalbum.Location = new Point(120, 243);

            lLastsingle.Location = new Point(13, 271);
            lastsingle.Location = new Point(120, 271);

            lGenres.Location = new Point(13, 187);
            genres.Location = new Point(120, 187);

            lPopularity.Location = new Point(13, 157);
            popularity.Location = new Point(120, 157);
        }
        public void Movement()
        {
            //------I have no desire to comment on this.

            //---Move albums dowm
            if (genres.Location.Y + genres.Size.Height > albums.Location.Y)
            {
                albums.Location = new Point(120, genres.Location.Y + genres.Size.Height + 12);
                lAlbums.Location = new Point(13, albums.Location.Y);
            }

            //---Move last album and single down
            if (albums.Location.Y + albums.Size.Height > lastalbum.Location.Y)
            {
                lastalbum.Location = new Point(120, albums.Location.Y + albums.Size.Height + 12);
                lLastalbum.Location = new Point(13, lastalbum.Location.Y);

                lastsingle.Location = new Point(120, lastalbum.Location.Y + lastalbum.Size.Height + 12);
                lLastsingle.Location = new Point(13, lastsingle.Location.Y);
            }

            //---Move name (picture) to down
            if (name.Location.Y + name.Size.Height > picture.Location.Y)
            {
                picture.Location = new Point(475, name.Location.Y + name.Size.Height + 12);
            }


            //---Move picture and name to the right
            int pictureStartPos = 475;

            if (lastsingle.Location.X + lastsingle.Size.Width > pictureStartPos) pictureStartPos = lastsingle.Location.X + lastsingle.Size.Width + 10;
            if (albums.Location.X + albums.Size.Width > pictureStartPos) pictureStartPos = albums.Location.X + albums.Size.Width + 10;
            if (genres.Location.X + genres.Size.Width > pictureStartPos) pictureStartPos = genres.Location.X + genres.Size.Width + 10;


            picture.Location = new Point(pictureStartPos, 67);
            name.Location = new Point(pictureStartPos, 17);

            if (name.Location.Y + name.Size.Height > picture.Location.Y)
            {
                picture.Location = new Point(pictureStartPos, name.Location.Y + name.Size.Height + 12);
            }
        }
        public void Info(string id)
        {
            //------Showing all info about artist

            Default();
            errorProvider1.SetError(Find, null);

            var spotify = new SpotifyClient(Token());
            var artist = spotify.Artists.Get(id).GetAwaiter().GetResult();
            var songs = spotify.Artists.GetAlbums(id).GetAwaiter().GetResult();

            //---Parsing albums and singles
            List<string> albums = new List<string>();
            List<string> singles = new List<string>();

            for (int i = 0; i < songs.Items.Count; i++) //division into types
            {
                if (songs.Items[i].AlbumGroup == "album")
                {
                    albums.Add(songs.Items[i].Name);
                }
                if (songs.Items[i].AlbumGroup == "single")
                {
                    singles.Add(songs.Items[i].Name);
                }
            }

            //---Checking identical names
            albums = albums.GroupBy(x => x.ToLower()).Select(y => y.First()).ToList();
            singles = singles.GroupBy(x => x.ToLower()).Select(y => y.First()).ToList();

            //---Labels filling
            name.Text = artist.Name;
            followers.Text = artist.Followers.Total.ToString();
            popularity.Text = artist.Popularity.ToString();

            //---Picture filling
            picture.Visible = true;

            if (artist.Images.Count != 0) //if artist has pictures
            {
                picture.ImageLocation = artist.Images[1].Url;
            }
            else //if there's no image
            {
                picture.Image = Properties.Resources.noimage;
            }

            name.Visible = true;

            //---Filling info from lists
            genres.Text = artist.Genres.Count > 0 ? genres.Text = string.Join("\r", artist.Genres) : "no genres...";
            this.albums.Text = albums.Count > 0 ? this.albums.Text = '\u25BA' + " " + string.Join("\r" + '\u25BA' + " ", albums) : "no albums...";
            lastalbum.Text = albums.Count > 0 ? '\u25BA' + " " + albums[0] : "no albums...";
            lastsingle.Text = singles.Count > 0 ? '\u2022' + singles[0] : "no singles...";

            Movement();
        }
        public void TemplatesToList()
        {
            //---Parsing all templates to ComboBox
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\templates.json";

            List<Template> templates = new List<Template>();

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            templates = JsonConvert.DeserializeObject<List<Template>>(File.ReadAllText(path)); //reading and converting text to set of templates

            if (templates != null) //if file is not empty
            {
                foreach (Template template in templates) //check every template
                {
                    if (!listbox.Items.Contains(template.name)) //don't add if there's duplicate
                    {
                        listbox.Items.Add(template.name);
                    }
                }
            }
        }
        public string Token()
        {
            //---Grabbing a token

            DotNetEnv.Env.Load(); //loading all enviromental values
            DotNetEnv.Env.TraversePath().Load(); //...from all directories of project

            //DON'T CHANGE

            Token token = new Token();
            string refresh_token = "AQD0d8TVAJfpVYX0PivC11GAxs0BWiDjvjGlG5b5m_FB4DdZsaHgUGLYLezLfKGzuZ3UmMjSXppS1gOEWnnTKjBJk4BCT1gAAIH0ZdtEeXV6sUxiYQ1fdheNBQEk5BB5fd8";
            string base64 = token.token; //<--PASTE THERE YOUR TOKEN INSTEAD OF token.token

            //---POST request
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Basic " + base64); //headers
            string link = "https://accounts.spotify.com/api/token";

            var values = new Dictionary<string, string>
            {
                { "grant_type", "refresh_token" },
                { "refresh_token", refresh_token}
            }; //parameters

            var content = new FormUrlEncodedContent(values);
            var response = client.PostAsync(link, content).GetAwaiter().GetResult();
            var responseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            User user = JsonConvert.DeserializeObject<User>(responseString);

            return user.access_token;
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            UrlBox.ForeColor = Color.Gray;
            UrlBox.Font = new Font(UrlBox.Font, FontStyle.Italic);
            UrlBox.Text = "URL of artist...";
            errorProvider1.SetError(Find, null);

            Default();
            listbox.Text = null;
            Delete.Enabled = false;
        }
        private void UrlBox_Leave(object sender, EventArgs e)
        {
            if (UrlBox.Text.Length == 0)
            {
                UrlBox.ForeColor = Color.Gray;
                UrlBox.Font = new Font(UrlBox.Font, FontStyle.Italic);
                UrlBox.Text = "URL of artist...";
            }
        }
        private void UrlBox_Enter(object sender, EventArgs e)
        {
            if (UrlBox.Text == "URL of artist...")
            {
                UrlBox.ForeColor = Color.Black;
                UrlBox.Font = new Font(UrlBox.Font, FontStyle.Regular);
                UrlBox.Text = "";
            }
        }
        private void UrlBox_TextChanged(object sender, EventArgs e)
        {
            Save.Enabled = false;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            //---Creating templates of artists
            string[] parts = UrlBox.Text.Split('/', '?');
            string id = parts[4];

            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\templates.json";

            List<Template> templates = new List<Template>();

            Template temporary = new Template(id, name.Text); //creates a NEW temporary template 

            if (File.Exists(path) && File.ReadAllText(path) != "")
            {
                templates = JsonConvert.DeserializeObject<List<Template>>(File.ReadAllText(path)); //reading and converting text to set of templates
            }

            if (templates == null || !templates.Any(x => x.ID == temporary.ID)) //if file is empty or previous template != this template
            {
                templates.Add(temporary); //creates a new instance
            }

            string json = JsonConvert.SerializeObject(templates, Formatting.Indented); //converts every template to JSON

            File.WriteAllText(path, json); //saving
            TemplatesToList();
        }
        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = listbox.GetItemText(listbox.SelectedItem);

            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\templates.json";

            List<Template> templates = JsonConvert.DeserializeObject<List<Template>>(File.ReadAllText(path)); //reading and converting text to set of templates

            foreach (Template template in templates)
            {
                if (template.name == selectedName)
                {
                    Info(template.ID); //showing info about selected artist
                }
            }

            Delete.Enabled = true;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            string selectedName = listbox.GetItemText(listbox.SelectedItem);

            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\templates.json";

            List<Template> templates = JsonConvert.DeserializeObject<List<Template>>(File.ReadAllText(path)); //reading and converting text to set of templates

            foreach (Template template in templates.ToList()) //looking for needed artist
            {
                if (template.name == selectedName)
                {
                    templates.Remove(template);
                    listbox.Items.Remove(listbox.GetItemText(listbox.SelectedItem));
                }
            }
            string json = JsonConvert.SerializeObject(templates, Formatting.Indented);
            File.WriteAllText(path, json);
            TemplatesToList();
        }
        public class User
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public int expires_in { get; set; }
            public string scope { get; set; }
        }
        public class Template
        {
            public string ID { get; set; }
            public string name { get; set; }
            public Template(string ID, string name)
            {
                this.ID = ID;
                this.name = name;
            }
        }
    }
}