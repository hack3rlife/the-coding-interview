using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjectsTree
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var root = @"C:\git\TheCodingInterview";

            Console.WriteLine(root);

            var sb = new StringBuilder();
            sb.AppendFormat("The Coding Interview ([total]) \r\n");

            Console.WriteLine(sb.ToString());

            var total = 0;
            var count = 0;

            var directories = Directory.GetDirectories(root);

            foreach (var directory in directories)
            {
                try
                {
                    if (directory.Contains("$tf")
                        || directory.Contains("$tf1")
                        || directory.Contains(".vs"))
                        continue;

                    var sbDirectory = new StringBuilder();

                    var directoryPath = directory.Split('\\');
                    var folderName = directoryPath[directoryPath.Length - 1];

                    Console.WriteLine(folderName);

                    var files = Directory.GetFiles(directory, "*.csproj", SearchOption.AllDirectories);

                    total += files.Length;
                    count = files.Length;

                    var fileName = string.Format("{0}\\{1}.txt", directory, folderName);

                    Console.WriteLine(fileName);

                    sb.AppendFormat("+ {0} ({1}) \r\n", folderName, count);

                    var curr = 1;

                    sbDirectory.AppendFormat("{0} ({1}) \r\n", folderName, count);

                    Dictionary<string, IList<string>> projs = new Dictionary<string, IList<string>>();
                    IList<string> list = new List<string>();

                    foreach (var file in files)
                    {
                        var filesPath = file.Split('\\');

                        var topDirectory = filesPath[filesPath.Length - 3];
                        var source = filesPath[filesPath.Length - 2];
                        var projectName = filesPath[filesPath.Length - 1];

                        var relativePath = string.Format("{0}\\{1}", source, projectName);



                        if (projs.ContainsKey(topDirectory))
                        {
                            list = projs[topDirectory];
                            list.Add(relativePath);
                        }
                        else
                        {
                            list = new List<string>();
                            list.Add(relativePath);
                            projs.Add(topDirectory, list);
                        }



                        //sbDirectory.AppendFormat("+{0}\r\n", topDirectory);
                        //sbDirectory.AppendFormat("\t-{0}\r\n", source);
                        //sbDirectory.AppendFormat("\t\t*{0}\r\n", projectName);

                        sb.AppendFormat("\t{0}: {1} \r\n", curr++, projectName.Replace(".csproj", string.Empty));
                    }

                    foreach (var item in projs)
                    {
                        sbDirectory.AppendFormat("+{0}\r\n", item.Key);

                        var value = item.Value;

                        for (int i = 0; i < value.Count; i++)
                        {
                            sbDirectory.AppendFormat("\t\t*{0}\r\n", value[i]);

                        }

                    }

                    File.WriteAllText(fileName, sbDirectory.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            sb.Replace("[total]", total.ToString());

            File.WriteAllText(string.Format("{0}\\readme.txt", root), sb.ToString());
        }
    }
}
