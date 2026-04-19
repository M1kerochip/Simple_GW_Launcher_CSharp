@Echo off
Echo.
Echo This script takes a SuperCard Pro file, and uses HxC Floppy Emulator software to create a disk picture, data picture and various disk images.
Echo.
Echo HxC Floppy Emulator software is available from: https://hxc2001.com/download/floppy_drive_emulator/
Echo.
Echo Using the latest beta of HxC is recommended. (And is available from: https://hxc2001.com/download/floppy_drive_emulator/HxCFloppyEmulator_soft_beta.zip )
Echo.


REM Aufit: Create .stx, create protections.txt and create disk surface image:
Aufit-1.3\Aufit.exe -suffix aufit.1.3 -scale 1.4 -disk -protections -save stx %1
