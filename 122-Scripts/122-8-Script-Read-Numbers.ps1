<#
.NOTES
    *****************************************************************************
	ETML
	Name: 	Read-Numbers.ps1
    Author:	Samy I.Pelaez
    Date:	17.03.2020
 	*****************************************************************************
    Modifications
 	Date  : 17.03.2020
 	Author: -
 	Reason: -
 	*****************************************************************************
.SYNOPSIS
    Read and display an inputed number within the ceiling parametrized
 	
.DESCRIPTION
    Read and display an inputed number within the ceiling inputed in parameter
  	
.PARAMETER nbMax
    int -> Ceiling/Upper Limit
 	
.EXAMPLE
   CURRENTPATH > .\122-8-Script-Read-Numbers.ps1 -nbMax 33
    Le nombre afficher  : 22
    22
    Le nombre afficher  : 11
    11
    Le nombre afficher  : 22
    22
    Le nombre afficher  : 55
    55
#>

# Ceiling of input
param($nbMax)

#Display help if parameter is missing or incorrect type
if(!$nbMax -or $nbMax -isnot [int])
{
    Get-Help $MyInvocation.Mycommand.Path
    
}
else
{
    $num = 0
    
    #Repeat it until incorrect input
    while($num -is [int] -and $num -lt $nbMax)
    {
        #Ask/read input
        [int]$num =  Read-Host "Le nombre afficher "

        #Display input
        Write-Host $num
    }

}# endif