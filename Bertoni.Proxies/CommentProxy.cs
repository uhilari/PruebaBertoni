using Bertoni.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bertoni.Proxies
{
    public class CommentProxy : BaseProxy, IDisposable
    {
        public async Task<IList<Comment>> GetAsync(int photoId)
        {
            var response = await Client.GetStringAsync("https://jsonplaceholder.typicode.com/comments?postId=" + photoId);
            return JsonConvert.DeserializeObject<List<Comment>>(response);
        }
    }
}
