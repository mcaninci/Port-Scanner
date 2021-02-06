using Microsoft.AspNetCore.HttpOverrides;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace IpOperation
{
    public class Convert
    {
        public static long ToInt(string addr)
        {
            return (long)(uint)IPAddress.NetworkToHostOrder(
                 (int)IPAddress.Parse(addr).Address);
        }

        public static string ToString(long address)
        {
            return IPAddress.Parse(address.ToString()).ToString();
        }

        public  List<string> rangeToIpList(string ipMin, string ipMax)
        {

            IPNetwork net = IPNetwork.Parse("192.168.0.1/23");
            var ips = IPNetwork.Subnet(net, 32);

            Console.WriteLine("{0} was subnetted into /{1} ips", net, ips.Count);
            Console.WriteLine("First: {0}", subneted[0]);
            Console.WriteLine("Last : {0}", subneted[subneted.Count - 1]);
            Console.WriteLine("All  :");

            foreach (IPNetwork ipnetwork in ips)
            {
                Console.WriteLine("{0}", ipnetwork);
            }
            return null;
        }


    }
}
