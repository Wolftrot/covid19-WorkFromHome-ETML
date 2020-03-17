<#
.NOTES
    *****************************************************************************
	ETML
	Name: 	Create-Group.ps1
    Author:	Samy I.Pelaez
    Date:	17.03.2020
 	*****************************************************************************
    Modifications
 	Date  : -
 	Author: -
 	Reason: -
 	*****************************************************************************
.SYNOPSIS
    Create a group in HKLM
 	
.DESCRIPTION
    Create a group in HKLM
  	
.PARAMETER groupName
    Name of the local group to be created

.PARAMETER description
    Description of the local group to be created
 	
.EXAMPLE
   > .\122-8-Script-Create-Group.p1.ps1 Pokemon_Security "Security group for the pokemons"

    Group created
    Name             Description                    
    ----             -----------                    
    Pokemon_Security Security group for the pokemons

#>

# name of the group
param($groupName, $description)



#display help if parameter is missing or incorrect type
if(!$groupName -or $groupName -isnot [string] -or !$description -or $description -isnot [string])
{
    Get-Help $MyInvocation.Mycommand.Path
    
}
else
{
    #create group
    New-LocalGroup -Name $groupName -Description $description
    Write-Host Group created -ForegroundColor Yellow

    
}# endif




