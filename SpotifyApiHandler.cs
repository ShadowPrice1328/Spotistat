using Newtonsoft.Json;
using SpotifyAPI.Web;
using Spotistat;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

internal class SpotifyApiHandler
{
    private readonly SpotifyClient client;
    public readonly string accessToken;

    public SpotifyApiHandler()
    {
        accessToken = GetAccessTokenAsync().Result;
        client = new SpotifyClient(accessToken);
    }

    public async Task<dynamic> GetArtistInfoAsync(string artistId) => await client.Artists.Get(artistId);
    public async Task<dynamic> GetAlbumsInfoAsync(string artistId) => await client.Artists.GetAlbums(artistId);
    private async Task<string> GetAccessTokenAsync()
    {
        string refreshToken = Codes.refreshToken;
        string base64 = Codes.base64;

        using (HttpClient httpClient = new HttpClient())
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + base64);
            string tokenEndpoint = "https://accounts.spotify.com/api/token";

            var tokenRequestContent = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                { "grant_type", "refresh_token" },
                { "refresh_token", refreshToken }
            });

            var tokenResponse = await httpClient.PostAsync(tokenEndpoint, tokenRequestContent);
            var responseString = await tokenResponse.Content.ReadAsStringAsync();

            User user = JsonConvert.DeserializeObject<User>(responseString);

            return user.access_token;
        }
    }
}
