using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiJsonError
{
    public class ApiException : HttpResponseException
    {
        public ApiException(HttpStatusCode code, string message)
            : this(new ApiError(code, message))
        {
        }

        public ApiException(HttpStatusCode code)
            : this(new ApiError(code, Enum.GetName(typeof(HttpStatusCode), code)))
        {
        }

        public ApiException(int code, string message)
            : this(new ApiError(code, message))
        {
        }

        public ApiException(ApiError error)
            : base(error.CreateResponse())
        {
            this.ApiError = error;
        }

        public ApiError ApiError
        {
            get;
            private set;
        }
    }
}
