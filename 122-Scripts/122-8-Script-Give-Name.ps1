<#
.NOTES
    *****************************************************************************
	ETML
	Name: 	Give-Name.ps1
    Author:	Samy I.Pelaez
    Date:	17.03.2020
 	*****************************************************************************
    Modifications
 	Date  : 17.03.2020
 	Author: -
 	Reason: -
 	*****************************************************************************
.SYNOPSIS
    Inputs a name as parameter 
 	
.DESCRIPTION
    Inputs a name as parameter
  	
.PARAMETER name
    String -> name
 	
.EXAMPLE
    Give-Name.ps1 -name "Pikachu"
    Name created : Pikachu
 	
#>

param($name)

#display help if parameter is missing or incorrect type
if(!$name -or $name -isnot [string])
{
    Get-Help $MyInvocation.Mycommand.Path
    
}
else
{
    
    write-host "Name created : $name"
    
}# endif

