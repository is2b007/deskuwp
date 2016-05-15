using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using deskx_uwp.protobuf;
using Google.Protobuf;
using System.IO;

namespace desk_uwp.protobuf
{
    class webGen
    {
        private WebRequest web;
        MemoryStream memStream = new MemoryStream();

        public webGen(string url, string method, string contentType)
        {
            web = WebRequest.Create(url);
            //WebRequest webRequest = WebRequest.Create("http://localhost:8000/desk/login/");
            web.Credentials = CredentialCache.DefaultCredentials;
            //web.Method = "POST";
            web.Method = method;
            web.ContentType = contentType;
            //web.ContentType = "application/deskdata";

        }

        public async Task sendRequestData(Request source)
        {
            MessageExtensions.WriteTo(source, await web.GetRequestStreamAsync());
        }

        public async Task<MemoryStream> getResponse()
        {
            WebResponse response = await web.GetResponseAsync();
            Stream responseStream = response.GetResponseStream();
            responseStream.CopyTo(memStream);
            return memStream;
        }
    }
}
