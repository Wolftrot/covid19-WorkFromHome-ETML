<#
.NOTES
    *****************************************************************************
	ETML
	Name: 	Write-Numbers.ps1
    Author:	Samy I.Pelaez
    Date:	17.03.2020
 	*****************************************************************************
    Modifications
 	Date  : 17.03.2020
 	Author: -
 	Reason: -
 	*****************************************************************************
.SYNOPSIS
    Create an array with 2 limits
 	
.DESCRIPTION
    Inputs 2 numbers in parameters and creates an array with the 2 nums as limits,
    then display the array in lines
  	
.PARAMETER floor
    int -> FirstName
 	
.PARAMETER ceiling
    int -> LastName
 	
.EXAMPLE
	LOCATION: > .\122-8-Script-Write-Numbers.ps1 -floor 4 -ceiling 10
	4
	5
	6
	7
	8
	9
	10
#>

# "..." value by default
param($floor, $ceiling)

#display help if parameter is missing or incorrect type
if(!$floor -or !$ceiling -or $floor -isnot [int] -or $ceiling -isnot [int])
{
    Get-Help $MyInvocation.Mycommand.Path
    
}
else
{
    #create arrange using the limits
    $arr = $floor..$ceiling

    #display by lines
    $arr | Format-Table
    
}# endif