@Echo off
Echo.
Echo This script takes a SuperCard Pro file, and uses HxC Floppy Emulator software to create a disk picture, data picture and various disk images.
Echo.
Echo HxC Floppy Emulator software is available from: https://hxc2001.com/download/floppy_drive_emulator/
Echo.
Echo Using the latest beta of HxC is recommended. (And is available from: https://hxc2001.com/download/floppy_drive_emulator/HxCFloppyEmulator_soft_beta.zip )
Echo.


REM Convert to HFE v3 .hfe image (For Gotek etc running Flash Floppy, HxC etc)
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows_x64\hxcfe -finput:%1 -foutput:%1.HxC_HFEv3.hfe -conv:HXC_HFEV3
