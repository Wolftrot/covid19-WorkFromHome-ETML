<#
.NOTES
    *****************************************************************************
	ETML
	Name: 	Check-Args.ps1
    Author:	Samy I.Pelaez
    Date:	17.03.2020
 	*****************************************************************************
    Modifications
 	Date  : -
 	Author: -
 	Reason: -
 	*****************************************************************************
.SYNOPSIS
    Display Arguments
 	
.DESCRIPTION
    Display Arguments
  	
.PARAMETER args
    var -> whatever
 	
.EXAMPLE
   
  CURRENTPATH> .\122-8-Script-Check-Args.ps1 a b c ab abc
    a
    b
    c
    ab
    abc
#>

$Args | Format-Table

