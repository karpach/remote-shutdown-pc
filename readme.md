# Remote Shutdown Manager
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

3. Secret code custom command:

* http://remote-host-name:5001/secret/hibernate
* http://remote-host-name:5001/secret/shutdown
* http://remote-host-name:5001/secret/suspend
* http://remote-host-name:5001/secret/turnscreenoff/
* http://remote-host-name:5001/secret/lock/
* http://remote-host-name:5001/secret/restart/
* http://remote-host-name:5001/secret/forceshutdown

4. Delaying a command

It is possible to delay a command. When delayed, a dialog will be shown, allowing the user to abort the operation.
Simply add the parameter ?delay={seconds} to your get request

* http://remote-host-name:5001/secret/command?delay=60

The application can be easily used with IFTTT or AutoVoice to shutdown PC remotely.

[![Build and Test](https://github.com/karpach/remote-shutdown-pc/actions/workflows/build.yml/badge.svg)](https://github.com/karpach/remote-shutdown-pc/actions)
