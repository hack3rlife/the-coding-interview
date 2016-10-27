#Set-ExecutionPolicy -ExecutionPolicy RemoteSigned

$scriptDirectory = (Get-Item $MyInvocation.MyCommand.Path).Directory.FullName

$slnDir = ".\"
$slnName = "Algorithms"

$dteObj = New-Object -ComObject "VisualStudio.DTE.14.0"
$dteObj.Solution.Create($scriptDirectory, $slnName)
	(ls . -Recurse *.csproj) | % { $dteObj.Solution.AddFromFile($_.FullName, $false) }
$dteObj.Solution.SaveAs( (Join-Path $scriptDirectory 'Algorithms.sln') ) 
$dteObj.Quit()

ls -in *.sln -r | select -last 1 | %{ ii $_.FullName }