using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Web.Http;
using System.Web.Http;
using WebAPIHandson.Models;

namespace WebAPIHandson.Controllers
{
    public class SystemInformationController : ApiController
    {
        public List<SystemInformation> GetSystemInformation()
        {
            List<SystemInformation> info = new List<SystemInformation>();
            String sysIp = "";

            String sysOs = "";


            String machineName1 = Environment.MachineName;

            SystemInformation SysInfo = new SystemInformation();

            SysInfo.MachineName = machineName1;

            System.OperatingSystem osInfo = System.Environment.OSVersion;

            sysOs = osInfo.Platform.ToString();

            SysInfo.OsName = sysOs;


            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    sysIp = ip.ToString();
                }
            }

            SysInfo.IPAddress = sysIp;

            info.Add(SysInfo);
            return info;
        }

    }
}