using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace logInTesting
{
    public static class ConfigClient
    {
        public static HttpClient _client { get; set; } //in order to open once for each application

        public static void InitializeClient()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Properties.Settings.Default.ServerAddress);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //_client.Timeout = new TimeSpan(0, 50, 0);
        }
    }
}
