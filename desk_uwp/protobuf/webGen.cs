using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using deskx_uwp.protobuf;
using Google.Protobuf;
using System.IO;

namespace desk_uwp.protobuf
{
    internal class WebGen
    {
        internal MemoryStream MemStream = new MemoryStream();

        public WebRequest Web { get; set; }

        public WebGen(string url, string method, string contentType)
        {
            try
            {
                Web = WebRequest.Create(url);
                Web.Credentials = CredentialCache.DefaultCredentials;
                Web.Method = method;
                Web.ContentType = contentType;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                throw;
            }
        }

        public async Task SendRequestData(IMessage source)
        {
            source?.WriteTo(await Web.GetRequestStreamAsync());
        }

        public async Task<MemoryStream> GetResponse()
        {
            try
            {
                WebResponse response = await Web.GetResponseAsync();
                Stream responseStream = response.GetResponseStream();
                responseStream.CopyTo(MemStream);
                return MemStream;
            }
            catch (WebException e)
            {

                if (e.Status == WebExceptionStatus.Timeout)
                {
                    return await GetResponse();
                    // Handle timeout exception
                }
                else throw;
            }
            
        }
    }
}
