using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using weather.Models;
using System.Net;
using weather.Adapter;

namespace weather.Services
{
    class  weatherSevices
    { public async Task<Root> todaySpecial()
    {

        HttpClient httpClient = new HttpClient();
        var response = await httpClient.GetAsync(new Adapter.Adapter().strURL);
        if (response.StatusCode == HttpStatusCode.OK)
        {
            var stringContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Root>(stringContent);

        }
        return null;
    }
}
}
