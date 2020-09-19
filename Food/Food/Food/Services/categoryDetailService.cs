using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Food.Adapters;
using Food.models;
using Newtonsoft.Json;

namespace Food.Services
{
    class categoryDetailService
    {
        public async Task<CatModel> todaySpecial(int id)
        {

            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(new Adapter().categoryDetailURL(id));
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<CatModel>(stringContent);

            }
            return null;
        }
    }
}
