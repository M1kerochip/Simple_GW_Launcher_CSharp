@CLS
@CLS OFF

REM Create symbolic links to the arguments json, for each debug/release built exe.


REM Links the existing arguements JSON to the .NET 10 Release build exe
DEL ..\bin\Release\net10.0-windows\TEST_GW.Arguments.json /Q
MKLINK /H ..\bin\Release\net10.0-windows\TEST_GW.Arguments.json EXENAME.Arguments.json

REM Links the existing arguements JSON to the .NET 10 Debug build exe
DEL ..\bin\Debug\net10.0-windows\TEST_GW.Arguments.json /Q
MKLINK /H ..\bin\Debug\net10.0-windows\TEST_GW.Arguments.json EXENAME.Arguments.json


REM Links the existing arguements JSON to the .NET 4 Release build exe
DEL "..\..\TEST-GW-Net-48\bin\Release\TEST_GW _Net4.Arguments.json" /Q
MKLINK /H "..\..\TEST-GW-Net-48\bin\Release\TEST_GW _Net4.Arguments.json" EXENAME.Arguments.json

REM Links the existing arguements JSON to the .NET 4 Debug build exe
DEL "..\..\TEST-GW-Net-48\bin\Debug\TEST_GW _Net4.Arguments.json" /Q
MKLINK /H "..\..\TEST-GW-Net-48\bin\Debug\TEST_GW _Net4.Arguments.json" EXENAME.Arguments.json

pause