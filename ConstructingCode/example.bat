@echo off

rem A batch file to look at the output from the static Main entry point of an application.

ProgrammingConstructs
@if "%ERRORLEVEL%" == "0" goto success

:fail
 echo The application failed!
 goto end
:success
 echo The application has succeeded!
:end
 echo return value = %ERRORLEVEL%
 echo All Done!.