REM *****************************************************************************
REM Auteur : Samy I Pelaez (aka Wolftrot)
REM Date   : 06.05.2020
REM But    : ETML Code Norm PHP website projet tree generation and samples .js .php .html
REM ***********************************************
REM
REM === Racine du projet ===
md projet-%date%-%USERNAME%
cd projet-%date%-%USERNAME%
REM 	/// Archivage et sauvetages \\\
md archives
REM
REM 	/// Scripts concernant une base de données \\\
md db 
cd db
md schemas
md scripts
md back-ups
cd ..
REM
REM 	/// Documents d'analyse, conception, etc. \\\
md documentation
cd documentation
md analisis
md conception
md reports
cd..
REM
REM 	/// Documents sources fournis par le client (images, logos, icônes, etc.) \\\
md sources
REM
REM 	/// Racine du site \\\
md www
cd www
REM
REM 		°°° Ressources °°°
md resources
cd resources
REM
REM 			+++ Styles liés au thème +++ 
md css 
cd css
echo	/**  																	>  style.css
echo	*ETML  																	>> style.css
echo	*Auteur: %USERNAME% 	  												>> style.css
echo	*Date: %date%  															>> style.css
echo	*Description: main domain css		  									>> style.css
echo	*/  																	>> style.css
echo	/*target element*/ 														>> style.css
echo	html { }																>> style.css
echo	body { }																>> style.css
echo	/*target class*/ 														>> style.css
echo	.class { }																>> style.css
echo	/*target id*/ 															>> style.css
echo	#id { }  																>> style.css
echo	/*target pseudo-element*/ 												>> style.css
echo	a:hover { }  															>> style.css
echo	/*target nested*/ 														>> style.css
echo	a nestedClass { }  														>> style.css
echo	a > childClass { }														>> style.css
echo	/*target meta key*/ 													>> style.css
echo	a[target="_blank"] { }  												>> style.css
echo	[title~="flower"] { }													>> style.css
echo	input[type="text"] { }  												>> style.css
echo	/*define variables*/ 													>> style.css
echo	:root { --main-bg-color: coral;}										>> style.css
echo	/*implement variable*/ 													>> style.css
echo	#div1 { background-color: var(--main-bg-color); }						>> style.css
cd ..
REM
REM 			+++ Illustrations liées au thème +++ 
md images
REM
REM 			+++ Librairies +++ 
md lib
cd ..
REM
REM 		°°° Fichiers de codes pour les pages °°°
md src
cd src
REM
REM 			+++ Code html des pages +++ 
md html 
cd html
echo 	^<!doctype html^> 																				>> sample.html
echo 	^<html lang="fr"^> 																				>> sample.html
echo 	^<head^> 																						>> sample.html
echo 		^<!-- 																						>> sample.html
echo 		Author: %USERNAME% 																			>> sample.html
echo 		Date: %date% 																				>> sample.html
echo 		Description: domain home page																>> sample.html
echo 		--^> 																						>> sample.html
echo 		^<meta charset="utf-8"^> 																	>> sample.html
echo 		^<meta name="author" content="%USERNAME%"^> 												>> sample.html
echo 		^<!-- 																						>> sample.html
echo 		^<meta name="keywords" xml:lang="fr" lang="fr" content="marketing, portal, shopping"/^> 	>> sample.html
echo 		--^> 																						>> sample.html
echo 		^<!-- 																						>> sample.html
echo 		^<meta name="description" content="domain index page"/^> 									>> sample.html
echo 		--^> 																						>> sample.html
echo 		^<title^>HOME^</title^> 																	>> sample.html
echo 		^<link^ rel="stylesheet" type="text/css" href="resources\css\style.css" media="screen"/^> 	>> sample.html
echo 	^</head^> 																						>> sample.html
echo 		^<body^> 																					>> sample.html
echo 		^</body^> 																					>> sample.html
echo 	^</html^> 																						>> sample.html
cd ..
REM
REM 			+++ Code JavaScript +++ 
md js 
cd js
echo	/**  																	>  sample.js
echo	*ETML  																	>> sample.js
echo	*Auteur: %USERNAME% 													>> sample.js
echo	*Date: %date%  															>> sample.js
echo	*Description: sample ETML js doc		  								>> sample.js
echo	*/  																	>> sample.js
echo	class Sample  															>> sample.js
echo	{  																		>> sample.js
echo		/**  																>> sample.js
echo		*This is a class description following ETML coding norms  			>> sample.js
echo		*@param 	explained  												>> sample.js
echo		*@return 	explained  												>> sample.js
echo		*/  																>> sample.js
echo		function lowerCamelCase($paramNameInLowerCamelCase)  				>> sample.js
echo		{  																	>> sample.js
echo			return(something)  												>> sample.js
echo		}  																	>> sample.js
echo	}  																		>> sample.js
cd ..
REM
REM 			+++ Code php des pages +++ 
md php
cd php
echo	^<?php   																						>  home.php
echo	/**  																							>> home.php
echo	*ETML  																							>> home.php
echo	*Auteur: %USERNAME% 																			>> home.php
echo	*Date: %date%  																					>> home.php
echo	*Description: Domain home page 			  														>> home.php
echo	*/  																							>> home.php
echo	class Sample  																					>> home.php
echo	{  																								>> home.php
echo		/**  																						>> home.php
echo		*This is a class description following ETML coding norms  									>> home.php
echo		*@param $paramNameInLowerCamelCase : explained  											>> home.php
echo		*@return explained  																		>> home.php
echo		*/  																						>> home.php
echo		public function lowerCamelCase($paramNameInLowerCamelCase)  								>> home.php
echo		{  																							>> home.php
echo			return(something)  																		>> home.php
echo		}  																							>> home.php
echo	}  																								>> home.php
echo	?^>  																							>> home.php
echo 	^<!doctype html^> 																				>> home.php
echo 	^<html lang="fr"^> 																				>> home.php
echo 	^<head^> 																						>> home.php
echo 		^<!-- 																						>> home.php
echo 		Author: %USERNAME% 																			>> home.php
echo 		Date: %date% 																				>> home.php
echo 		Description: domain home page																>> home.php
echo 		--^> 																						>> home.php
echo 		^<meta charset="utf-8"^> 																	>> home.php
echo 		^<meta name="author" content="%USERNAME%"^> 												>> home.php
echo 		^<!-- 																						>> home.php
echo 		^<meta name="keywords" xml:lang="fr" lang="fr" content="marketing, portal, shopping"/^> 	>> home.php
echo 		--^> 																						>> home.php
echo 		^<!-- 																						>> home.php
echo 		^<meta name="description" content="domain index page"/^> 									>> home.php
echo 		--^> 																						>> home.php
echo 		^<title^>HOME^</title^> 																	>> home.php
echo 		^<link^ rel="stylesheet" type="text/css" href="resources\css\style.css" media="screen"/^> 	>> home.php
echo 	^</head^> 																						>> home.php
echo 		^<body^> 																					>> home.php
echo 		^</body^> 																					>> home.php
echo 	^</html^> 																						>> home.php
cd ..
cd ..
REM
REM 		°°° Fichiers spécifiques utilisés dans les contenus des pages °°°
md userContent
cd userContent
REM
REM 			+++ Contenus d'illustrations +++ 
md images 
REM
REM 			+++ Contenus de formats autres (pdf, ...) +++ 
md pdf
md contracts
md uploads
md docs
cd..
REM
REM 			+++ Modèles (DW, ...) +++ 
md templates
REM
REM				Construction du fichier index.html à la racine du site ...
echo ^<!doctype html^> 																				> index.html
echo ^<html lang="fr"^> 																			>> index.html
echo ^<head^> 																						>> index.html
echo 	^<!-- 																						>> index.html
echo 	Author: %USERNAME% 																			>> index.html
echo 	Date: %date% 																				>> index.html
echo 	Description: domain index page 																>> index.html
echo 	--^> 																						>> index.html
echo 	^<meta charset="utf-8"^> 																	>> index.html
echo 	^<meta name="author" content="%USERNAME%"^> 												>> index.html
echo 	^<!-- 																						>> index.html
echo 	^<meta name="keywords" xml:lang="fr" lang="fr" content="marketing, portal, shopping"/^> 	>> index.html
echo 	--^> 																						>> index.html
echo 	^<!-- 																						>> index.html
echo 	^<meta name="description" content="domain index page"/^> 									>> index.html
echo 	--^> 																						>> index.html
echo 	^<meta http-equiv="Refresh" CONTENT="0;URL=src/php/home.php"/^> 							>> index.html
echo 	^<title^>Lanceur de page responsive^</title^> 												>> index.html
echo 	^<!-- 																						>> index.html
echo 	^<link^ rel="stylesheet" type="text/css" href="resources\css\style.css" media="screen"/^> 	>> index.html
echo 	--^> 																						>> index.html
echo ^</head^> 																						>> index.html
echo 	^<body^> 																					>> index.html
echo 	^</body^> 																					>> index.html
echo ^</html^> 																						>> index.html
