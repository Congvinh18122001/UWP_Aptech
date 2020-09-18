using Food.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Food.Adapters;
namespace Food.Services
{
    class foodService
    {
        public async Task<foodDetail> todaySpecial(int id)
        {

            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(new Adapter().foodDetailURL(id));
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<foodDetail>(stringContent);

            }
            return null;
        }
    }
}
