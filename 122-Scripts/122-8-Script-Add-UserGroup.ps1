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
    Adds a user to a group
 	
.DESCRIPTION
    Adds a specific user to a specific group
  	
.PARAMETER userName
    Name of the local user to be added

.PARAMETER groupName
    Name of the group where to add the use
 	
.EXAMPLE
  > .\122-8-Script-Add-UserGroup.ps1 pikachu pokemon_security
    User pikachu added to pokemon_security

#>

# name of the group
param($userName, $groupName)



#display help if parameter is missing or incorrect type
if(!$userName -or $userName -isnot [string] -or !$groupName -or $groupName -isnot [string])
{
    Get-Help $MyInvocation.Mycommand.Path
    
}
else
{
    Add-LocalGroupMember -Group $groupName -Member $userName
    Write-Host User $userName added to $groupName  -ForegroundColor Yellow
    
}# endif




