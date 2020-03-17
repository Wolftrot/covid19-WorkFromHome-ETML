<#
.NOTES
    *****************************************************************************
	ETML
	Name: 	Create-User.ps1
    Author:	Samy I.Pelaez
    Date:	17.03.2020
 	*****************************************************************************
    Modifications
 	Date  : -
 	Author: -
 	Reason: -
 	*****************************************************************************
.SYNOPSIS
    Create a user
 	
.DESCRIPTION
    Create a user
  	
.PARAMETER userName
    Name of the local user to be created

.PARAMETER description
    Description of the local user to be created

.PARAMETER pwd
    Password of the local user to be created
 	
.EXAMPLE
  > .\122-8-Script-Create-User.p1.ps1 pikachu "yellow-mouse" PIKACHU025

    User created
    Name    Enabled Description 
    ----    ------- ----------- 
    pikachu True    yellow-mouse

#>

# name of the group
param($userName, $description, $pwd)



#display help if parameter is missing or incorrect type
if(!$userName -or $userName -isnot [string] -or !$description -or $description -isnot [string] -or !$pwd)
{
    Get-Help $MyInvocation.Mycommand.Path
    
}
else
{
    $pwd = ConvertTo-SecureString $pwd -AsPlainText -Force

    #create group
    New-LocalUser -Name $userName -Description $description -Password $pwd
    Write-Host User created -ForegroundColor Yellow

    
}# endif




