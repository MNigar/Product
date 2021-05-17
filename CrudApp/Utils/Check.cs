using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Utils
{
    public class Check
    {
        public static bool CheckFormat(string contentType)
        {
            if (contentType == "image/png" || contentType == "image/jpeg" || contentType == "image/jpg")
            {
                return true;
            }
            else
                return false;
        }
    }
}
