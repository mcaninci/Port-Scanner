using System;

namespace IpOperation
{
    public class IpValidation
    {
        public static bool IsRangeValid(string ipMin,string ipMax)
        {
         long _ipMin=   Convert.ToIpInt(ipMin);
         long _ipMax=  Convert.ToIpInt(ipMax);
            if (_ipMax-_ipMin<0)
            {
                return false;
            }

            return true;
        }
    }
}
