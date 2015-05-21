# Installing Remote test kit
# Set this to the file name of the Windows Installer Installation Package,
# excluding the ".msi" extension.
$rtkMSIFileName = "remotetestkit-en"

$Source = "https://appkitbox.com/en/wp-content/download/remotetestkit-en.exe"
$rtkMSIFile = "$PSScriptRoot\$rtkMSIFileName.exe"
# Invoke-WebRequest $source -OutFile $rtkMSIFile

$process = Start-Process "$rtkMSIFile" -ArgumentList "/SP /verysilent /suppressmsgboxes" -Wait -Passthru
echo "Installer returned $($process.ExitCode)"

# Installing Quamotion
# Set this to the file name of the Windows Installer Installation Package,
# excluding the ".msi" extension.
$qmMSIFileName = "Quamotion.Setup"

$Source = "http://qmcdn.blob.core.windows.net/release-unstable/en-us/Quamotion.Setup.msi"
$qmMSIFile = "$PSScriptRoot\$qmMSIFileName.msi"
# Invoke-WebRequest $source -OutFile $qmMSIFile

# Initialize file names
$timestamp = Get-Date -Format "yyyyMMdd_HHmmss"
$psLogFile = "$PSScriptRoot\Deploy.$timestamp.log"
$msiLogFile = "$PSScriptRoot\$msiFileName.$timestamp.log"
$msiArguments = "ADDLOCAL=ALL /l*v ""$msiLogFile"" /qn /i ""$qmMSIFile"""
$process = Start-Process -FilePath "msiexec.exe" -ArgumentList $msiArguments -Wait -Passthru
echo "Installer returned $($process.ExitCode)"

exit