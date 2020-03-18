<#
.NOTES
    *****************************************************************************
	ETML
	Name: 	Get-DbInfos.ps1
    Author:	Samy I.Pelaez
    Date:	18.03.2020
 	*****************************************************************************
    Modifications
 	Date  : -
 	Author: -
 	Reason: -
 	*****************************************************************************
.SYNOPSIS
    Connects and extracts data from a test db
 	
.DESCRIPTION
    Connects, logs, and extracts data from a test db quering the 2 first letters of the aka column
  	
.PARAMETER twoStartingNameLetters
    the first 2 letters of the aka
 	
.EXAMPLE
  > .\122-8-FileHandling-Modify-CSV.ps1 -originFile .\test-classe.csv -destinationFile .\test-classe-destination-from-script.csv
    Modification of [ .\test-classe.csv ] outputed to [ .\test-classe-destination-from-script.csv ], successfuly
.LINK
  1.- The first step is to download the ADO.Net MySQL driver, which can be found here.  
        https://dev.mysql.com/downloads/connector/net/
        Note the directory where this will be installed.
  2.- Load the .dll in the script

  Install-Module -Name SimplySql

#>

# Params
param($twoStartingLettersOfAka)



#display help if parameter is missing or incorrect type
if(!$twoStartingLettersOfAka -or $twoStartingLettersOfAka -isnot [string] )
{
    Get-Help $MyInvocation.Mycommand.Path
    
}
else
{

    #Informations pour la connexion à la db
    $mysqlServer = "localhost\mysql"
    $sqlDBName = "db_powershell"
    $userId = 'sa'
    $userPwd = convertto-secureString '.Etml-' -AsPlainText -Force

    #connection obj
    $mysqlConnection = New-Object Mysql.Data.MySqlClient.MysqlConnection

    write-host $mysqlConnection

    #Connection insertion
    $mysqlConnection.ConnectionString = "Server = $mysqlServer; Database = $sqlDBName; Integrated Security = true; User ID = $userId; Password = $userPwd; CharSet=utf8;"
    
    write-host $mysqlConnection.ConnectionString  -ForegroundColor Yellow
    write-host $mysqlConnection.ConnectionTimeout  -ForegroundColor Yellow
    write-host $mysqlConnection.State  -ForegroundColor Yellow
    write-host $mysqlConnection.DataSource  -ForegroundColor Yellow

    $p = $mysqlConnection.Ping()
    write-host "ping to db is : $p" -ForegroundColor Yellow

    try
    {   
        $mysqlConnection.Open()

        #Connection open
        write-host "connection established" -ForegroundColor Yellow

        $mysqlConnection.Close()
    }
    catch
    {
        write-host "connection failed" -ForegroundColor Yellow
    }

    



}# endif




