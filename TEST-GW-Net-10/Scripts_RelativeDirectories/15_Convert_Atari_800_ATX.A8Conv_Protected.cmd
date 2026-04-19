@Echo off
Echo.
Echo This script takes a Kryoflux (heavy flux) or SuperCard Pro file, and uses a8rawconv by Phaeron to create various disk images.
Echo.
Echo a8rawconv is available from https://forums.atariage.com/topic/231835-a8rawconv-a-new-raw-disk-conversion-utility/
Echo.
Echo Using the latest release of a8raw is recommended
Echo.


REM Convert to Atari 400/800/XE/XL (Protected) using a8rawconv
a8rawconv-0.95\a8rawconv.exe -finput:%1 -foutput:%1.A8rawConv.atx
