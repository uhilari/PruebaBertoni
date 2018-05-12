using Bertoni.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bertoni.Proxies
{
    public class AlbumProxy: BaseProxy, IDisposable
    {
        public async Task<IList<Album>> GetAsync()
        {
            var response = await Client.GetStringAsync("https://jsonplaceholder.typicode.com/albums");
            return JsonConvert.DeserializeObject<List<Album>>(response);
        }
    }
}
