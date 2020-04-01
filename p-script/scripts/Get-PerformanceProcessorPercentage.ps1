#$processorID = Get-PerformanceCounterID -Name 'Processeur'
#$percentProcessorTimeID = Get-PerformanceCounterID -Name '% temps processeur'

$processor = Get-PerformanceCounterLocalName 238
$percentProcessorTime = Get-PerformanceCounterLocalName 14590
 
(Get-Counter "\$processor(*)\$percentProcessorTime").CounterSamples