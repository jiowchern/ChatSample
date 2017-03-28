del bin\*.*
copy ..\Regulus.Project.Chat.Game\bin\Debug\*.* bin\*.*
copy ..\..\Regulus\Tool\Server\bin\debug\*.* bin\*.*
copy ..\..\Regulus\Tool\GhostProviderGenerator\bin\debug\*.* bin\*.*
cd bin
GhostProviderGenerator.exe ..\generate.ini
server.exe launchini ..\config.ini

pause

