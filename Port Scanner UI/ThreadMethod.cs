﻿using Infrastructure.Data.Interface;
using Infrastructure.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCPOperation;

namespace Port_Scanner_UI
{
    public class ThreadMethod : IThreadOperation
    {
        public bool executeMethod(LinkedList<string> Ip, IPortRange portRange, Ilogger logger)
        {
            LinkedListNode<string> currentHost = Ip.First;
            TCPRequest tcpRequest = new TCPRequest(currentHost.Value, TCPConst.timeout);
           
            while (true)
            {
                if (!portRange.MorePorts())
                {
                    portRange.ResetPorts();
                    logger.WriteLog("Log :"+currentHost.Value +portRange.GetStartPort()+"-"+portRange.GetEndPort()+"  port range is completed by thread  ");
                    currentHost = currentHost.Next;
                    if (currentHost == null)
                    {
                        break;
                    }
                   
                    tcpRequest.UpdateHost(currentHost.Value);
                  
                  
                  
                 
                }
                int portNum = portRange.NextPort();
                bool isPortOpen = tcpRequest.Connect(portNum);
                if (isPortOpen)
                {
                    logger.WriteLog(currentHost.Value + ":" + portNum + " is open");
                }
            }


            return true;
        }
    }
}
