using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Bertoni.Proxies
{
    public abstract class BaseProxy
    {
        protected HttpClient Client { get; } = new HttpClient();

        public void Dispose()
        {
            Client.Dispose();
        }
    }
}
