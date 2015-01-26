using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ApiJsonError
{
    public static class ApiJsonError
    {
        public static void abort(int status_code, string message)
        {
            throw new ApiException(status_code, message);
        }

        public static void abort(HttpStatusCode status_code, string message)
        {
            throw new ApiException(status_code, message);
        }
    }
}
