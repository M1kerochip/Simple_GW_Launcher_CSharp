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

REM Create PNG of disk data
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows_x64\hxcfe -finput:%1 -foutput:%1.02_data_HxC.png -conv:PNG_IMAGE

REM Create PNG of disk stream
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows_x64\hxcfe -finput:%1 -foutput:%1.03_stream_HxC.png -conv:PNG_STREAM_IMAGE


REM Convert to HFE v3 .hfe image (For Gotek etc running Flash Floppy, HxC etc)
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows_x64\hxcfe -finput:%1 -foutput:%1.HxC_HFEv3.hfe -conv:HXC_HFEV3

REM Convert to Mame MFI (Protected)
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows_x64\hxcfe -finput:%1 -foutput:%1.HxC.mfi -conv:MAME_MFI


REM Convert to IBM PC .IMG (Unprotected)
HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows_x64\hxcfe -finput:%1 -foutput:%1.HxC.img -conv:RAW_LOADER


REM Convert to .IPF
REM HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.HxC.ipf -conv:SPS_IPF

REM Show Info
REM HxCFloppyEmulator_soft_beta\HxCFloppyEmulator_Software\Windows\hxcfe -finput:%1 -foutput:%1.info_HxC.txt -infos
