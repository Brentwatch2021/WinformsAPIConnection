using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsAPIConnection.Models;

namespace WinformsAPIConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDataFromAPI();
        }

        private async void LoadDataFromAPI()
        {
            // http://localhost:22537/weatherforecast

            //HttpClient client = new HttpClient { BaseAddress = new Uri("http://localhost:22537/") };

            //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json));


            //var responseMessage = await client.GetAsync("weatherforecast");

            //var resultArray = await result

            var client = new HttpClient { BaseAddress = new Uri("http://localhost:22537/") };

            // Assign default header (Json Serialization)
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json));

            // Make an API call and receive HttpResponseMessage
            var responseMessage = await client.GetAsync("weatherforecast", HttpCompletionOption.ResponseContentRead);

            // Convert the HttpResponseMessage to string
            var resultArray = await responseMessage.Content.ReadAsStringAsync();

            // Deserialize the Json string into type using JsonConvert
            var weatherForecasts = JsonConvert.DeserializeObject<List<WeatherForecast>>(resultArray);
        }
    }
}
