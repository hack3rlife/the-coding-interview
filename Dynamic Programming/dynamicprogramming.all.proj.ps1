#Set-ExecutionPolicy -ExecutionPolicy RemoteSigned

$scriptDirectory = (Get-Item $MyInvocation.MyCommand.Path).Directory.FullName
$dteObj = New-Object -ComObject "VisualStudio.DTE.14.0"

$slnDir = ".\"
$slnName = "Dynamic Programming"

$dteObj.Solution.Create($scriptDirectory, $slnName)
(ls . -Recurse *.csproj) | % { $dteObj.Solution.AddFromFile($_.FullName, $false) }
$dteObj.Solution.SaveAs( (Join-Path $scriptDirectory 'Dynamic Programming.sln') ) 
$dteObj.Quit()

ls -in *.sln -r | select -first 1 | %{ ii $_.FullName }