set-location 'c:\inetpub\wwwroot\LarrysList\LarrysList_Dev\'

#stop sites and services 
Import-Module WebAdministration
Stop-WebSite 'LarrysList_Dev_Api'


#delete everything 
Remove-item c:\inetpub\wwwroot\LarrysList\LarrysList_Dev\LarrysListApi -recurse


#deploy api
New-Item c:\inetpub\wwwroot\LarrysList\LarrysList_Dev\LarrysListApi -type directory
copy-item c:\Users\Administrator\.hudson\jobs\LarrysList_Dev\workspace\LarrysList\bin c:\inetpub\wwwroot\BurnPlus\BurnPlus_Live\BurnPlusApi -recurse
copy-item c:\Users\Administrator\.hudson\jobs\LarrysList_Dev\workspace\LarrysList\web.config c:\inetpub\wwwroot\BurnPlus\BurnPlus_Live\BurnPlusApi
copy-item c:\Users\Administrator\.hudson\jobs\LarrysList_Dev\workspace\LarrysList\global.asax c:\inetpub\wwwroot\BurnPlus\BurnPlus_Live\BurnPlusApi
copy-item c:\Users\Administrator\.hudson\jobs\LarrysList_Dev\workspace\LarrysList\nlog.config c:\inetpub\wwwroot\BurnPlus\BurnPlus_Live\BurnPlusApi

#start sites and services 
Start-WebSite 'LarrysList_Dev_Api'






















