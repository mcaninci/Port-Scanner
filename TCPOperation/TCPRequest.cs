using Infrastructure.Data.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;


namespace TCPOperation
{
    public class TCPRequest
    {

        int tcpTimeout = TCPConst.timeout;
        string host;
        private class isTcpPortOpen
        {
            public TcpClient MainClient { get; set; }
            public bool tcpOpen { get; set; }
        }


        public TCPRequest(string host, int? timeout = null)
        {
            this.host = host;
            if (timeout != null)
            {
                tcpTimeout = (int)timeout;
            }

        }


      /// <summary>
      /// The method  check port status for main host
      /// </summary>
      /// <param name="port"></param>
      /// <returns></returns>
        public bool Connect(int port)
        {
            var tcpClient = new TcpClient();

            var state = new isTcpPortOpen
            {
                MainClient = tcpClient,
                tcpOpen = true
            };

            IAsyncResult ar = tcpClient.BeginConnect(this.host, port, AsyncCallback, state);
            state.tcpOpen = ar.AsyncWaitHandle.WaitOne(tcpTimeout, false);

            if (state.tcpOpen == false || tcpClient.Connected == false)
            {
                return false;

            }
            return true;
        }



       /// <summary>
       /// The method is used by tcp client callback
       /// </summary>
       /// <param name="asyncResult"></param>
        private void AsyncCallback(IAsyncResult asyncResult)
        {
            var state = (isTcpPortOpen)asyncResult.AsyncState;
            TcpClient client = state.MainClient;

            try
            {
                client.EndConnect(asyncResult);
            }
            catch
            {
                return;
            }

            if (client.Connected && state.tcpOpen)
            {
                return;
            }

            client.Close();
        }


    }
}
