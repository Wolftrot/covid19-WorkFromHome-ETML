<#
.NOTES
    *****************************************************************************
	ETML
	Name: 	Canevas.ps1
    Author:	...
    Date:	xx.xx.xxxx
 	*****************************************************************************
    Modifications
 	Date  : -
 	Author: -
 	Reason: -
 	*****************************************************************************
.SYNOPSIS
    Summary 
 	
.DESCRIPTION
    Description (explanation of script)
  	
.PARAMETER param1
    Description first parameter
 	
.PARAMETER param2
    Description second parameter
 	
.PARAMETER param3
    Description third parameter
 	
.EXAMPLE
    Example of using the script with results obtained
 	
.LINK
    https://enseignement.section-inf.ch/moduleICT/122/Index.html
#>

# "..." value by default
param([string]$param1="...", [string]$param2, [string]$param3)

#display help if parameter is missing or incorrect type
if(!$param2 -or !$param3)
{
    Get-Help $MyInvocation.Mycommand.Path
    
}
else
{
    
    write-host "coucou"
    
}# endif


