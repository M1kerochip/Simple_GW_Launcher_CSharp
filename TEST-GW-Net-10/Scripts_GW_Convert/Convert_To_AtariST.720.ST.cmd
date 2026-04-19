@Echo off
Echo.
Echo This script takes a supported disk image file, and uses GreaseWeazle software to create a different disk image file. (EG heavy flux to .ST)
Echo.
Echo GreaseWeazle software is available from: https://hxc2001.com/download/floppy_drive_emulator/
Echo.


REM Convert to Atari .ST image (UnProtected) Using GreaseWeazle
GreaseWeazle\gw convert --format atarist.720 %1 %1.GW.AtariST_720.st 