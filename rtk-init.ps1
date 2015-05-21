 $Assembly = [System.Reflection.Assembly]::LoadFrom("C:\Program Files (x86)\Quamotion\bin\Quamotion.Devices.dll")
 
 $rtkSettings = New-Object -TypeName Quamotion.Devices.RemoteTestKit.RemoteTestKitSettings -ArgumentList "Public"
 
 $rtkSettings.UserName = $env:rtkUserName
 $rtkSettings.Password = $env:rtkPassword