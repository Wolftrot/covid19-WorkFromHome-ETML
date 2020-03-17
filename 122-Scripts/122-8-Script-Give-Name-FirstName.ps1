<#
.NOTES
    *****************************************************************************
	ETML
	Name: 	Give-Name-FirstName.ps1
    Author:	Samy I.Pelaez
    Date:	17.03.2020
 	*****************************************************************************
    Modifications
 	Date  : 17.03.2020
 	Author: -
 	Reason: -
 	*****************************************************************************
.SYNOPSIS
    Stores a FirstName and a LastName 
 	
.DESCRIPTION
    Stores a FirstName and a LastName
  	
.PARAMETER firstName
    string -> FirstName
 	
.PARAMETER lastName
    string -> LastName
 	
.EXAMPLE
    CURRENTPATH: > .\122-8-Script-Give-Name-FirstName.ps1 -firstName "Pikachu" -lastName "ThunderBolt"
    FirstName created : Pikachu
    LastName created : ThunderBolt
#>

# "..." value by default
param($firstName, $lastName)

#display help if parameter is missing or incorrect type
if(!$firstName -or !$lastName -or $firstName -isnot [string] -or $lastName -isnot [string])
{
    Get-Help $MyInvocation.Mycommand.Path
    
}
else
{
    
    write-host "FirstName created : $firstName"
    write-host "LastName created : $lastName"
    
}# endif


