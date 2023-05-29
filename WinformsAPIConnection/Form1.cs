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
        private List<WeatherForecast> weatherForecasts;

        private List<JM_Job> jobs;

        private List<JM_Client> clients;

        private List<JM_Tool> tools;

        private List<JM_Vehicle> vehicles;

        private List<JM_User> users;

        private HttpClient client = new HttpClient { BaseAddress = new Uri("http://localhost:22537/") };

        DataGridView jobsdataGridView;

        DataGridView vehiclesGridViewProp;

        TabControl JobCardTabs_Prop;



        public Form1()
        {
            InitializeComponent();
            this.JobCardTabs_Prop = this.Controls["JobCardTabs"] as TabControl;
            this.vehiclesGridViewProp = this.JobCardTabs.Controls["vehiclesTab"].Controls["vehiclesGridView"] as DataGridView;
            this.jobsdataGridView = this.JobCardTabs.Controls["tabPage1"].Controls["JobsGridView"] as DataGridView;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json));
            LoadWeatherDataFromAPI();
            LoadJobsFromAPI();
            LoadClientsFromAPI();
            LoadToolsFromAPI();
            LoadVehiclesFromAPI();
            LoadUsersFromAPI();

        }

        #region LoadData

        private async void LoadUsersFromAPI()
        {
            if (client != null)
            {
                HttpResponseMessage responseMessage = await client.GetAsync("api/jm_user", HttpCompletionOption.ResponseContentRead);
                string usersArray = await responseMessage.Content.ReadAsStringAsync();
                this.users = JsonConvert.DeserializeObject<List<JM_User>>(usersArray);
            }
        }

        private async void LoadVehiclesFromAPI()
        {
            if (client != null)
            {
                HttpResponseMessage responseMessage = await client.GetAsync("api/jm_vehicle", HttpCompletionOption.ResponseContentRead);
                string vehiclesArray = await responseMessage.Content.ReadAsStringAsync();
                this.vehicles = JsonConvert.DeserializeObject<List<JM_Vehicle>>(vehiclesArray);
                this.vehiclesGridViewProp.DataSource = this.vehicles;
            }
        }

        private async void LoadToolsFromAPI()
        {
            if (client != null)
            {
                HttpResponseMessage responseMessage = await client.GetAsync("api/jm_tool", HttpCompletionOption.ResponseContentRead);
                string toolsArray = await responseMessage.Content.ReadAsStringAsync();
                this.tools = JsonConvert.DeserializeObject<List<JM_Tool>>(toolsArray);
            }
        }

        private async void LoadClientsFromAPI()
        {
            if (client != null)
            {
                HttpResponseMessage responseMessage = await client.GetAsync("api/jm_client", HttpCompletionOption.ResponseContentRead);
                string clientsArray = await responseMessage.Content.ReadAsStringAsync();
                this.clients = JsonConvert.DeserializeObject<List<JM_Client>>(clientsArray);
            }
        }

        private async void LoadJobsFromAPI()
        {
            if (client != null)
            {
                HttpResponseMessage responseMessage = await client.GetAsync("api/jm_job", HttpCompletionOption.ResponseContentRead);
                string jobsArray = await responseMessage.Content.ReadAsStringAsync();
                this.jobs = JsonConvert.DeserializeObject<List<JM_Job>>(jobsArray);
                this.jobsdataGridView.DataSource = this.jobs;

            }
        }

        private async void LoadWeatherDataFromAPI()
        {
            if (client != null)
            {
                try
                {
                    HttpResponseMessage responseMessage = await client.GetAsync("weatherforecast", HttpCompletionOption.ResponseContentRead);
                    string resultArray = await responseMessage.Content.ReadAsStringAsync();
                    this.weatherForecasts = JsonConvert.DeserializeObject<List<WeatherForecast>>(resultArray);
                }
                catch (Exception e)
                {

                }
            }
        }

        #endregion



    }
}
