@Echo off
Echo.
Echo This script takes a SuperCard Pro file, and uses HxC Floppy Emulator software to create a disk picture, data picture and various disk images.
Echo.
Echo HxC Floppy Emulator software is available from: https://hxc2001.com/download/floppy_drive_emulator/
Echo.
Echo Using the latest beta of HxC is recommended. (And is available from: https://hxc2001.com/download/floppy_drive_emulator/HxCFloppyEmulator_soft_beta.zip )
Echo.

REM Create PNG of disk image
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows_x64\hxcfe -finput:%1 -foutput:%1.01_disk_HxC.png -conv:PNG_DISK_IMAGE
