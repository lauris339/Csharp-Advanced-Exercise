using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace HTTPuzklausa
{
    class Program
    {
        public class Token
        {
            public string token { get; set; }
        }
        class ResponseClass
        {
            public string name { get; set; }
            public int distance { get; set; }
        }

        static void Main(string[] args)
        {
            Method();
            

        }

         private static async void Method()
        {
            Dictionary<string, string> _content = new Dictionary<string, string>();
            _content.Add("username", "tesonet");
            _content.Add("password", "partyanimal");
            
            var content = new FormUrlEncodedContent(_content);
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.PostAsync("http://playground.tesonet.lt/v1/tokens", content);
            var responseString = await response.Content.ReadAsStringAsync();
            Token token = JsonConvert.DeserializeObject<Token>(responseAsString);
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.token);
            var serveriai = await httpClient.GetAsync("http://playground.tesonet.lt/v1/tokens");
            var responseAsString = await serveriai.Content.ReadAsStringAsync();
            var atsakymas = JsonConvert.DeserializeObject<List<ResponseClass>>(responseAsString);
            foreach (var item in atsakymas)
            {
                Console.WriteLine(item.name + " " + item.distance);
            }
            
        }


    }
}
