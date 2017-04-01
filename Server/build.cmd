md bin
del bin\*.* /Y

copy ..\Regulus.Project.Chat.Game\bin\Debug\*.* bin\*.*
copy ..\Regulus\Tool\Server\bin\debug\*.* bin\*.*
copy ..\Regulus\Tool\GhostProviderGenerator\bin\debug\*.* bin\*.*
cd bin
RegulusRemoteProtocolGenerator.exe ..\generate.ini