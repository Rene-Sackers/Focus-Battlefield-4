# Focus Battlefiel 4

## What?
In Windows 10, build 14393, if you have Battlefield 4 set to "borderless" fullscreen mode, it won't show in the taskbar, and you can't alt + tab to it.

This application fixes that.

## How?

Simple.

1. Find bf4.exe
2. Find the main window handle
3. Call [SwitchToThisWindow](https://msdn.microsoft.com/en-us/library/ms633553.aspx)
4. ???
5. Profit!

For you: Just launch FocusBattlefield.exe

## Where?!

[Releases](https://github.com/Rene-Sackers/Focus-Battlefield-4/releases)

## P.S.

Pin it to your taskbar if you play frequently. Just click the icon, and it switches to BF4.
