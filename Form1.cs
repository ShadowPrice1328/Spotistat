using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using SpotifyAPI.Web;
using System.Net.Http;

namespace Spotistat
{
    public partial class Spotistat : Form
    {
        public Spotistat()
        {
            InitializeComponent();

            DotNetEnv.Env.Load();
            DotNetEnv.Env.TraversePath().Load();
        }
        private void Find_Click(object sender, EventArgs e)
        {
            Default();
            Info();
        }
        public void Default()
        {
            lastalbum.Visible = true;
            lLastsingle.Visible = true;
            lastsingle.Visible = true;

            picture.Visible = false;
            picture.Image = null;

            name.Visible = false;

            lastsingle.Text = "";
            lastalbum.Text = "";
            albumsf.Text = "";
            genres.Text = "";
            popularity.Text = "";
            followers.Text = "";

            name.Location = new Point(475, 17);
            picture.Location = new Point(475, 67);

            lFollowers.Location = new Point(13, 125);
            followers.Location = new Point(120, 125);

            lAlbums.Location = new Point(13, 215);
            albumsf.Location = new Point(120, 215);

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
            //---Move albums dowm
            if (genres.Location.Y + genres.Size.Height > albumsf.Location.Y)
            {
                albumsf.Location = new Point(120, genres.Location.Y + genres.Size.Height + 12);
                lAlbums.Location = new Point(13, albumsf.Location.Y);
            }

            //---Move last album down
            if (albumsf.Location.Y + albumsf.Size.Height > lastalbum.Location.Y)
            {
                lastalbum.Location = new Point(120, albumsf.Location.Y + albumsf.Size.Height + 12);
                lLastalbum.Location = new Point(13, lastalbum.Location.Y);
            }
            //---Move last single down
            if (albumsf.Location.Y + albumsf.Size.Height > lastsingle.Location.Y)
            {
                lastsingle.Location = new Point(120, lastalbum.Location.Y + lastalbum.Size.Height + 12);
                lLastsingle.Location = new Point(13, lastsingle.Location.Y);
            }

            //---Move name to down
            if (name.Location.Y + name.Size.Height > picture.Location.Y)
            {
                picture.Location = new Point(475, name.Location.Y + name.Size.Height + 12);
            }

            //---Move picture and name to the right
            if (albumsf.Location.X + albumsf.Size.Width > picture.Location.X || genres.Location.X + genres.Size.Width > picture.Location.X || lastsingle.Location.X + lastsingle.Size.Width > picture.Location.X)
            {
                picture.Location = new Point(albumsf.Location.X + albumsf.Size.Width + 10, 67);
                name.Location = new Point(albumsf.Location.X + albumsf.Size.Width + 10, 17);

                if (name.Location.Y + name.Size.Height > picture.Location.Y)
                {
                    picture.Location = new Point(albumsf.Location.X + albumsf.Size.Width + 10, name.Location.Y + name.Size.Height + 12);
                }
            }
        }
        public void Info()
        {

            //---Grabbing artist's ID from URL
            string[] parts = UrlBox.Text.Split('/', '?');
            string id = parts[4];

            var spotify = new SpotifyClient(Token());
            var artist = spotify.Artists.Get(id).GetAwaiter().GetResult();
            var songs = spotify.Artists.GetAlbums(id).GetAwaiter().GetResult();

            //---Choosing albums and singles
            List<string> albumsName = new List<string>();
            List<string> singlesName = new List<string>();

            for (int i = 0; i < songs.Items.Count; i++)
            {
                if (songs.Items[i].AlbumGroup == "album")
                {
                    albumsName.Add(songs.Items[i].Name);
                }
                if (songs.Items[i].AlbumGroup == "single")
                {
                    singlesName.Add(songs.Items[i].Name);
                }
            }

            //----Checking identical names
            int indexA = albumsName.Count - 1;
            int indexS = singlesName.Count - 1;

            while (indexA > 0) //---ALBUMS
            {
                if (albumsName[indexA].ToLower() == albumsName[indexA - 1].ToLower())
                {
                    if (indexA < albumsName.Count - 1)
                        (albumsName[indexA], albumsName[albumsName.Count - 1]) = (albumsName[albumsName.Count - 1], albumsName[indexA]);
                    albumsName.RemoveAt(albumsName.Count - 1);
                    indexA--;
                }
                else
                    indexA--;
            }

            while (indexS > 0) //---SINGLES
            {
                if (singlesName[indexS].ToLower() == singlesName[indexS - 1].ToLower())
                {
                    if (indexS < singlesName.Count - 1)
                        (singlesName[indexS], singlesName[singlesName.Count - 1]) = (singlesName[singlesName.Count - 1], singlesName[indexS]);
                    singlesName.RemoveAt(singlesName.Count - 1);
                    indexS--;
                }
                else
                    indexS--;
            }

            //---Labels
            name.Text = artist.Name;
            followers.Text = artist.Followers.Total.ToString();
            genres.Text = artist.Genres.Count > 0 ? genres.Text = string.Join("\r", artist.Genres) : "no genres...";
            popularity.Text = artist.Popularity.ToString();
            picture.Visible = true;
            picture.ImageLocation = artist.Images[1].Url;
            name.Visible = true;

            albumsf.Text = albumsName.Count > 0 ? albumsf.Text = '\u25BA' + " " + string.Join("\r" + '\u25BA' + " ", albumsName) : "no albums...";
            lastalbum.Text = albumsName.Count > 0 ? '\u25BA' + " " + albumsName[0] : "no albums...";
            lastsingle.Text = singlesName.Count > 0 ? '\u2022' + singlesName[0] : "no singles...";

            Movement();
        }
        public string Token()
        {
            string refresh_token = Environment.GetEnvironmentVariable("REFRESH_TOKEN");
            string base64 = Environment.GetEnvironmentVariable("BASE64");

            //---POST request
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Basic " + base64);
            string query = "https://accounts.spotify.com/api/token";

            var values = new Dictionary<string, string>
            {
                { "grant_type", "refresh_token" },
                { "refresh_token", refresh_token}
            };

            var content = new FormUrlEncodedContent(values);
            var response = client.PostAsync(query, content).GetAwaiter().GetResult();
            var responseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            //---Grabbing a token from json
            string json = JsonConvert.SerializeObject(responseString);
            json = json.Substring(1);
            json = json.Remove(json.Length - 1, 1);
            json = json.Replace("\\", "");

            User user = JsonConvert.DeserializeObject<User>(json);

            return user.access_token;
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            UrlBox.ForeColor = Color.Gray;
            UrlBox.Font = new Font(UrlBox.Font, FontStyle.Italic);
            UrlBox.Text = "URL of artist...";
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
        public class User
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public int expires_in { get; set; }
            public string scope { get; set; }
        }
    }
}