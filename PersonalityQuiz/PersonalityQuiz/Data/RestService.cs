using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PersonalityQuiz.Data
{
    public class RestService : IRestService
    {
        HttpClient _client;

        public List<Legend> LegendList { get; private set; }

        public RestService()
        {
            _client = new HttpClient();
        }
        public async Task<Legend> GetLegendAsync()
        {
            var uri = new Uri(string.Format(Constants.LegendUrl, string.Empty));
            Legend legend = new Legend();

            try
            {
                var response = await _client.GetAsync(uri);
                Debug.WriteLine("XXXX: " + response.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    // Debug.WriteLine(content);
                    legend = JsonConvert.DeserializeObject<Legend>(content);
                    Debug.WriteLine(legend);
                }
            }catch(Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return legend;
        }
        public async Task<List<Legend>> RefreshDataAsync()
        {
            LegendList = new List<Legend>();

            var uri = new Uri(string.Format(Constants.LegendListUrl, string.Empty));

            try
            {
                for (int i = 0; i < 30; i++)
                {
                    var response = await _client.GetAsync(uri);
                    Debug.WriteLine("XXXX: " + response.ToString());
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        // Debug.WriteLine(content);
                        LegendList = JsonConvert.DeserializeObject<List<Legend>>(content);
                        //Debug.WriteLine(legend);
                        //LegendList.Add(legend);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return LegendList;
        }

        public Task SaveLegendAsync(Legend item, bool isNewItem)
        {
            throw new NotImplementedException();
        }

        public Task DeleteLegendAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}