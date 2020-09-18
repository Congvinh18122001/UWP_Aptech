using Food.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using Food.Viewsmodels;
using Food.Adapters;
namespace Food.Services
{
    class productService
    {
        public async Task<fooddata> todaySpecial()
        {
            
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(new Adapter().strURL);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<fooddata>(stringContent);

            }
            return null;
        }
    }
}
