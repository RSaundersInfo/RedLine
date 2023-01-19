; -- Inno Setup Script --
; Setup script for RedLine program 
; Rob Saunders 2021-2023

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!

#define AppName "RedLine"
#define PrgName "RedLine"
#define BaseSource "C:\Dev\Personal\RedLine\RedLine"


[Setup]
AppName={#AppName}
AppVersion=1.5.0
AppPublisher=Rob Saunders
;AppReadmeFile can be a URL.  It creates a link in the Add/Remove programs footer
AppReadmeFile={app}\Readme.txt
WizardStyle=modern
DefaultDirName=C:\{#AppName}
;DefaultGroupName="{#BaseFolder}"
; If no icons will be created in "{group}", set to no to have the wizard
; not ask for a Start Menu folder name:
DisableProgramGroupPage=yes
DisableWelcomePage=yes
UninstallDisplayIcon={app}\{#PrgName}.exe
Compression=lzma2
SolidCompression=yes
OutputDir={#BaseSource}\Setup
OutputBaseFilename=Setup{#PrgName}
;OutputManifestFile=Setup-Manifest.txt
SourceDir="{#BaseSource}\bin\Release"
AllowNoIcons=yes

;color options don't seem to do anything with the modern setting above
;BackColor=clBlue
;BackColor2=clWhite
;BackColorDirection=lefttoright

InfoAfterFile=readme.txt
;Seems that InfoBeforeFile causing a virus warning
;InfoBeforeFile=readme.txt
;LicenseFile=readme.txt
SetupIconFile=C:\Dev\Personal\RedLine\RedLine\RedLine.ico
;SetupLogging=yes
;UserInfoPage=yes

VersionInfoCompany="Rob Saunders"
VersionInfoCopyright="(c) 2021-2023"

[Files]
Source: "Readme.txt"; DestDir: "{app}"; Flags: isreadme
Source: "{#PrgName}.exe"; DestDir: "{app}"
Source: "{#PrgName}.exe.config"; DestDir: "{app}"
Source: "{#PrgName}.pdb"; DestDir: "{app}"
Source: "{#PrgName}Settings.xml"; DestDir: "{app}"


[Icons]
Name: "{autoprograms}\{#AppName}"; Filename: "{app}\{#PrgName}.exe"
Name: "{autodesktop}\{#AppName}"; Filename: "{app}\{#PrgName}.exe"; Check: not WizardNoIcons


