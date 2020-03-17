<#
.NOTES
    *****************************************************************************
	ETML
	Name: 	Modify-CSV.ps1
    Author:	Samy I.Pelaez
    Date:	17.03.2020
 	*****************************************************************************
    Modifications
 	Date  : -
 	Author: -
 	Reason: -
 	*****************************************************************************
.SYNOPSIS
    Modify a file adding an email per person added to original csv
 	
.DESCRIPTION
    Modify a csv file adding a person email outputed under the
    format : firstName.lastName@etml.com
  	
.PARAMETER originFile
    csv file containing firstName and lastName of the people

.PARAMETER destinationFile
    output csv with the email concatenation
 	
.EXAMPLE
  > .\122-8-FileHandling-Modify-CSV.ps1 -originFile .\test-classe.csv -destinationFile .\test-classe-destination-from-script.csv
    Modification of [ .\test-classe.csv ] outputed to [ .\test-classe-destination-from-script.csv ], successfuly

#>

# Params
param($originFile, $destinationFile)



#display help if parameter is missing or incorrect type
if(!$originFile -or $originFile -isnot [string] -or !$destinationFile -or $destinationFile -isnot [string])
{
    Get-Help $MyInvocation.Mycommand.Path
    
}
else
{
    #If file exist
    if(Test-Path $originFile)
    {
        #import
        $entries = Import-Csv $originFile
        #transform and export
        $entries | Select-Object *,@{Name = "EMAIL"; Expression = {$_.PRENOM+'.'+$_.NOM+"@etml.com"}} |Export-CSV $destinationFile

        Write-Host "Modification of [ $originFile ] outputed to [ $destinationFile ], successfuly" -ForegroundColor yellow
    }
    #If file does not exist
    else
    {
        Write-Host 'OriginFile could not be found' -ForegroundColor yellow
    }
    
}# endif




