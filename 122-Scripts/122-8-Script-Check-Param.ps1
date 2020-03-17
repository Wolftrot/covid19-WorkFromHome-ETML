<#
.NOTES
    *****************************************************************************
	ETML
	Name: 	Check-Param.ps1
    Author:	Samy I.Pelaez
    Date:	17.03.2020
 	*****************************************************************************
    Modifications
 	Date  : -
 	Author: -
 	Reason: -
 	*****************************************************************************
.SYNOPSIS
    Compares the params to 0
 	
.DESCRIPTION
    Parameter name and nb are compared to 0
  	
.PARAMETER name
    Contains a name
.PARAMETER nb
    Contains a nb
 	
.EXAMPLE
   > .\122-8-Script-Check-Param.ps1 -name "pikachu" -nb 0
    The name is equal to 0 : False
    The number is equal to 0 : True
#>

# Ceiling of input
param($name, $nb)


$nametest = $name -eq 0
$nbtest = $nb -eq 0

write-host "The name is equal to 0 : $nametest"
write-host "The number is equal to 0 : $nbtest"






