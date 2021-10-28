using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIHandson.Models
{
    public class SystemInformation
    {

        public String MachineName
        {
            get;
            set;
        }

        public String OsName
        {
            get;
            set;
        }

        public String IPAddress
        {
            get;
            set;
        }
    }
}