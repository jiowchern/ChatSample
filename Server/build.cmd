md bin
del bin\*.* /Y

copy ..\Regulus.Project.Chat.Game\bin\Debug\*.* bin\*.*
copy ..\Regulus\Tool\Server\bin\debug\*.* bin\*.*
rem copy ..\Regulus\Tool\GhostProviderGenerator\bin\debug\*.* bin\*.*
rem cd bin
rem RegulusRemoteProtocolGenerator.exe ..\generate.ini