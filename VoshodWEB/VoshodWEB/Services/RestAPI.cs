using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using VoshodWEB.Models;
using System.Net.Http.Headers;
using Newtonsoft.Json;
namespace VoshodWEB.Services
{
    public sealed class RestAPI
    {
        private readonly static HttpClient _client;
        internal readonly static string _apiIP;
        static RestAPI()
        {
            _apiIP = "http://192.168.43.179:5000/music/";

            _client = new HttpClient() { MaxResponseContentBufferSize = int.MaxValue, Timeout = TimeSpan.FromSeconds(600),BaseAddress = new Uri(_apiIP) };
        }
        public static async Task<MusicModel[]> GetTracks()
        {
            try
            {
                HttpResponseMessage msg = await _client.GetAsync("");
                if (msg.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<MusicModel[]>(await msg.Content.ReadAsStringAsync());
                }
            }
            catch(Exception ex)
            {
                _client.CancelPendingRequests();
            }
            return Array.Empty<MusicModel>();
        }
        public static MusicModel GetTrack(string name)
        {
            try
            {
                return new MusicModel() { Title = $"Song {name}", Source = name };
            }
            catch
            {
                _client.CancelPendingRequests();
            }
            return null;
        }
    }
}
