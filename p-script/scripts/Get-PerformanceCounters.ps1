$processorID = Get-PerformanceCounterID -Name 'Processeur'
$percentProcessorTimeID = Get-PerformanceCounterID -Name '% temps processeur'

$processor = Get-PerformanceCounterLocalName $processorID
$percentProcessorTime = Get-PerformanceCounterLocalName $percentProcessorTimeID
 
(Get-Counter "\$processor(*)\$percentProcessorTime").CounterSamples