using Bertoni.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bertoni.Proxies
{
    public class PhotoProxy: BaseProxy, IDisposable
    {
        public async Task<IList<Photo>> GetAsync(int albumId)
        {
            var response = await Client.GetStringAsync("https://jsonplaceholder.typicode.com/photos?albumId=" + albumId);
            return JsonConvert.DeserializeObject<List<Photo>>(response);
        }
    }
}
