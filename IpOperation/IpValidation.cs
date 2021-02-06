using System;

namespace IpOperation
{
    public class IpValidation
    {
        public static bool isRangeValid(string ipMin,string ipMax)
        {
         long _ipMin=   Convert.ToInt(ipMin);
         long _ipMax=  Convert.ToInt(ipMax);
            if (_ipMax-_ipMin<0)
            {
                return false;
            }

            return true;
        }
    }
}
