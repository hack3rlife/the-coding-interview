 $msBuildExe = 'C:\Program Files (x86)\MSBuild\14.0\Bin\msbuild.exe'
 $path = "C:\git\thecodinginterview\Tools\ProjectsTree\ProjectsTree\ProjectsTree.csproj"
 $output = 'C:\git\thecodinginterview\Tools\ProjectsTree\ProjectsTree\bin\Debug\ProjectsTree.exe'
 

 Write-Host  -foregroundcolor green "Building: " ($msBuildExe) $($path) 
 & ($msBuildExe) $($path) /t:rebuild /m
 #Write-Host $($msBuildExe) $($path) /t:rebuild /m

  if($LASTEXITCODE -eq 0)
                {
                    Write-Host "Build SUCCESS" -ForegroundColor Green
                    $cmd = 'C:\windows\system32\cmd.exe'
                    Write-Host "Executng " -ForegroundColor Green "$output"
                    & $output
                }
                else
                {
                    Write-Host "Build FAILED" -ForegroundColor Red
                }

$msg = Read-Host "Enter commit msg:"

git checkout -b mymaster origin/master
git add *
git commit -a -m $msg
git push origin master