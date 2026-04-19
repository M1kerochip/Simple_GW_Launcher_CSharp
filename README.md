# Simple Greaseweazle Launcher in C#
A simple C# .Net 4.8 front end, for Greaseweazle, to capture a flux file, save the onscreen text to a log file and execute a script when the disk is dumped. It also has a configurable right-click menu, to store several GW configs, for ease of use. It is *very* simple, with minimal error checking.

It saves the settings into ProgramName.json. 

It can optionally load a right-click menu, from ProgramName.Arguments.json. (Example included)
These are a set of GW.EXE arguments, eg, read 3.5", write 3.5" etc.

No effort has been made to walk anyone through building an argument string. (I did say it was *very* simple.)

Looks like so:

![alt text](Launcher_v1.2.0.1.png)
