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
   > .\122-8-Script-Check-Param.ps1 a 1
    Param position validated to 0 : a
    Following no obligatory params : 1
#>

# Ceiling of input
param(
    [Parameter(Mandatory=$True,Position=0,ValueFromPipeline=$True)] [string]$RequiredParam,
    [Parameter(Mandatory=$False,Position=1,ValueFromPipeline=$True)]$NotRequiredParam)


write-host "Param position validated to 0 : $RequiredParam"

write-host "Following no obligatory params : $NotRequiredParam"








