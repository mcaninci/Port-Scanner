# Port-Scanner
Port Scanner Tool

# Description

Port scanner application developed with .The application supports both ip range and ip notation for input data.Net.The application is support running multi threads and you can change the count of threads while scanning.If you change the thread count, the application will change thread count for next ip address.

You can acces executable version with ![port Scanner V1](https://github.com/mcaninci/Port-Scanner/blob/master/Port%20Scanner%20Version/Port%20Scanner%20V1.1.rar)

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

![alt text](https://i.hizliresim.com/TE5geS.png)

![alt text](https://i.hizliresim.com/3alX6Y.png)
