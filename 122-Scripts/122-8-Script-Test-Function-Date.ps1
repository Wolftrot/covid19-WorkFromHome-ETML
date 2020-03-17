<#
.NOTES
    *****************************************************************************
	ETML
	Name: 	Test-Function-Date.ps1
    Author:	ISI
    Date:	Fev2020
 	*****************************************************************************
    Modifications
 	Date  : 17.03.2020
 	Author: Samy I.Pelaez
 	Reason: Exercice - Refactoring
 	*****************************************************************************
.SYNOPSIS
    Display information about today
 	
.DESCRIPTION
    Display a message with the date of the day
  	
.PARAMETER color
    string -> color
 	
.EXAMPLE
   
   CURRENTPATH > Write-Date -color Red
   Nous sommes le : 17.03.2020 19:13:36
#>

# Ceiling of input
param($color)

function Write-Date($color)
{
    
    #validate param
    if(!$color -or $color -isnot [string])
    {
        Get-Help $MyInvocation.Mycommand.Path
    
    }
    else
    {
    
        #proceed
        $date=Get-Date
        write-host "Nous sommes le :" $date -ForegroundColor $color
    
    }# endif

}



