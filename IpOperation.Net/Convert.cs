
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace IpOperation
{
    public class Convert
    {
 
        public static long ToIpInt(string ip)
        {
            return (long)(uint)IPAddress.NetworkToHostOrder(
                 (int)IPAddress.Parse(ip).Address);
        }

        public static string ToIpString(long address)
        {
            return IPAddress.Parse(address.ToString()).ToString();
        }

        public static List<string> RangeToIpList(string ipMin, string ipMax)
        {
            List<string> ipList = new List<string>();
            var start = ToIpInt(ipMin);
            var end = ToIpInt(ipMax);

            for (int i = 0; i <= end-start; i++)
            {
                ipList.Add(ToIpString(start+i));
            }

            return ipList;
        }

    }
}
