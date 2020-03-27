<#
.NOTES
    *****************************************************************************
	ETML
	Name: 	samibrizModifyIni.ps1
    Author:	Samy I.Pelaez
    Date:	24.03.2020
 	*****************************************************************************
    Modifications
 	Date  : -
 	Author: -
 	Reason: -
 	*****************************************************************************
.SYNOPSIS
   Vous faites partie d’un service informatique d’une petite entreprise familiale et on vous demande de faire un script qui permet d’ajouter une information dans un fichier
 	
.DESCRIPTION
    Développez un script nommé LoginModifyIni.ps1 dont le but est de modifier un fichier en y ajoutant une ligne à un endroit définit par le paramètre inputPart.
    Login représente votre login ETML !
    Particularités du script (en plus d’être issu du modèle CanevasV2.ps1) :
    •	Traiter toutes les sources d'erreurs possibles.
    •	Le script doit suivre les normes de codage de l’ETML.
    •	Un message/aide s’affiche si les paramètres ne sont pas transmis ou si l’argument « -help » est renseigné.
    •	Lors du lancement du script il faut fournir les paramètres suivants : le ficher à modifier, l’endroit où la ligne doit être ajoutée et la ligne à ajouter.

    Attention à faire les essais sur le disque D ou un différent du disque système
    Astuce : pour modifier un fichier, on peut recopier dans un fichier temporaire les lignes et y ajouter au bon moment ce qui doit l’être !
    Le fichier inventory.ini se trouve sur le réseau

.PARAMETER filePath
    File to Modify

.PARAMETER nbLine
    Line coordinates where to input

.PARAMETER inputPart
    input
 	
.EXAMPLE
  > TODO

#>
param($filePath, $nbLine, $inputPart)

#display help if parameter is missing or incorrect type
if(!$filePath -or $filePath -isnot [string] -or !$nbLine -or $nbLine -isnot [string] -or !$inputPart -or $inputPart -isnot [string])
{
    Get-Help $MyInvocation.Mycommand.Path
    
}
