﻿# Remote Shutdown Manager
The project is a windows application, which gives an ability to shutdown, suspend, hibernate PC, **restart** or turn screen off using HTTP GET request.

The application stays in a system tray area, where you can trigger custom command shutdown as well.

The program has following settings:

1. Load program at Windows startup
2. Security code
3. System tray menu customization
4. Custom port number

Screenshots:

![Icon](Screenshots/Icon.png)

![Menu](Screenshots/Menu.png)

![Settings](Screenshots/Settings.png)

Example of remote requests:

1. No code, default command

http://remote-host-name:5001/

2. Secret code, default command

http://remote-host-name:5001/secret/

3. Sectret code custom command:

* http://remote-host-name:5001/secret/hibernate
* http://remote-host-name:5001/secret/shutdown
* http://remote-host-name:5001/secret/suspend
* http://remote-host-name:5001/secret/turnscreenoff/
* http://remote-host-name:5001/secret/lock/
* http://remote-host-name:5001/secret/restart/
* http://remote-host-name:5001/secret/forceshutdown
The following will execute a program if added to the settings:
* http://remote-host-name:5001/secret/program1
* http://remote-host-name:5001/secret/program2
	NOTE: program files need to be added into the Remote Shutdown Manager directory i.e. calc.exe
	folders may be used if placed inside the Remote Shutdown Manager directory i.e. progfolder/calc.exe


The application can be easily used with IFTTT or AutoVoice to shutdown PC remotely.

[![Build status](https://ci.appveyor.com/api/projects/status/u1txabmiwqqlgcot?svg=true)](https://ci.appveyor.com/project/karpach/remote-shutdown-pc)
