# Port-Scanner
Port Scanner Tool

# Description

Port scanner application developed with .Net.

You can acces executable version with ![port Scanner V1](https://github.com/mcaninci/Port-Scanner/tree/master/Port%20Scanner%20V1.0/Port%20Scanner)

# Attention
If you get "An operation on a socket could not be performed because the system lacked sufficient buffer space or because a queue was full" error, please follow below steps.

1.Open Registry  ( regedit )

2.Find below path:
HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters

3.Add below parameters in Parameter path:

Value Name: MaxUserPort
Value Type: DWORD
Value data: 65534

Value Name: TcpTimedWaitDelay
Value data: 30
Value Type: DWORD

# App ScreenShot

![alt text](https://i.hizliresim.com/VUlOkP.png)

![alt text](https://i.hizliresim.com/FwGodQ.png)
