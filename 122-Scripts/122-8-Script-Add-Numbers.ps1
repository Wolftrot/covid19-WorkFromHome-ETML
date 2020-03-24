<#
.NOTES
    *****************************************************************************
	ETML
	Name: 	Add-Numbers.ps1
    Author:	Samy I.Pelaez
    Date:	17.03.2020
 	*****************************************************************************
    Modifications
 	Date  : -
 	Author: -
 	Reason: -
 	*****************************************************************************
.SYNOPSIS
    Sum the numbers
 	
.DESCRIPTION
    Get all the numbers in the inputs and sum them. Then Display the sum
  	
.PARAMETER Args
    Multiple inputs
 	
.EXAMPLE
   > .\122-8-Script-Add-Numbers.ps1 5 23 3.12 pikachu
    5
    23
    3.12
    pikachu
    La somme vaut : 31,12
#>

# Ceiling of input
param()

# Evaluate if its a numeric value
function Is-Num($int)
{
    $b =  $int -match '[\d]{1,}'
    return $b
   
}


$sum = 0

#sum all the parameters
for($i= 0; $i -lt $args.Count; $i++)
{
    write-host $args[$i]

    if(Is-Num($args[$i])){$sum += $args[$i]}
}

#Display the sum
write-host La somme vaut :  $sum






