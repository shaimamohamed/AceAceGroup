using AceAceGroupTestApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

namespace AceAceGroupTestApplication.Service
{
    public class OneSignalAPIService
    {
        #region Helper
        // Get All Apps
        public List<OneSignalApplication> OneSignalGetApps(OneSignalApplication oneSignalGetAppsRequest)
        {
            List<OneSignalApplication> MyApps = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://onesignal.com");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "YWY4NzkxYzYtODM5Yi00MmY3LTg1ZjgtNmQyYjI1NDdhMmFh");


                var response = client.GetAsync("/api/v1/apps").Result;
                if (response.IsSuccessStatusCode)
                {
                    var stringResult = response.Content.ReadAsStringAsync().Result;
                    MyApps = JsonConvert.DeserializeObject<List<OneSignalApplication>>(stringResult);
                }
            }
            return MyApps;
        }
        // Get ann App
        public OneSignalApplication OneSignalGetannApp(string id)
        {
            OneSignalApplication oneSignalApplication = null;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "YWY4NzkxYzYtODM5Yi00MmY3LTg1ZjgtNmQyYjI1NDdhMmFh");


                var response = client.GetAsync("https://onesignal.com/api/v1/apps/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    var stringResult = response.Content.ReadAsStringAsync().Result;
                    oneSignalApplication = JsonConvert.DeserializeObject<OneSignalApplication>(stringResult);
                }
            }

            return oneSignalApplication;
        }
        // Get Create App
        public bool OneSignalCreateApp(OneSignalApplication oneSignalCreateAppRequest)
        {
            bool success = false;
            using (HttpClient client = new HttpClient())
            {
                // ////////////// Header
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "YWY4NzkxYzYtODM5Yi00MmY3LTg1ZjgtNmQyYjI1NDdhMmFh");
                // //////////////////
                var json = JsonConvert.SerializeObject(oneSignalCreateAppRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PostAsync("https://onesignal.com/api/v1/apps", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    success = true;
                }
            }

            return success;
        }
        // Get Update App
        public bool OneSignalUpdateApp(OneSignalApplication oneSignalUpdateAppRequest)
        {
            bool success = false;
            using (HttpClient client = new HttpClient())
            {
                // ////////////// Header
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "YWY4NzkxYzYtODM5Yi00MmY3LTg1ZjgtNmQyYjI1NDdhMmFh");
                // //////////////////
                var json = JsonConvert.SerializeObject(oneSignalUpdateAppRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                string url = "https://onesignal.com/api/v1/apps" + "/"+ oneSignalUpdateAppRequest.ID;
                var response = client.PutAsync(url, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    success = true;
                }
            }

            return success;
        }

        #endregion
    }
}