using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

using Newtonsoft.Json;

namespace ApiJsonError
{

    public class ApiError
    {
        public string error;
        public HttpStatusCode status_code;

        public ApiError(HttpStatusCode code, string msg)
        {
            this.error = msg;
            this.status_code = code;
        }

        public ApiError(int code, string msg)
            : this((HttpStatusCode)code, msg)
        {
        }

        public HttpResponseMessage CreateResponse()
        {
            var resp = new HttpResponseMessage(this.status_code)
            {
                Content = new StringContent(JsonConvert.SerializeObject(this))
            };
            return resp;
        }
    }

    
}
