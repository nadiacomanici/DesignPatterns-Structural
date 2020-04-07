using System;
using System.Collections.Generic;
using Composite_Files_Demo.Classes;

namespace Composite_Files_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootFolder = new Folder("root");

            rootFolder.Add(new File("readme.txt", 130));
            rootFolder.Add(new File("instructions.doc", 3200));
            rootFolder.Add(new File("file.git", 50));

            var folderVisualStudio = new Folder("ProjectFolder");
            folderVisualStudio.Add(new File("app.config", 215));
            folderVisualStudio.Add(new File("Project1.csproj", 15));
            folderVisualStudio.Add(new File("Program.cs", 1600));
            rootFolder.Add(folderVisualStudio);

            var folderProperties = new Folder("Properties");
            folderProperties.Add(new File("AssemblyInfo.cs", 56));
            folderVisualStudio.Add(folderProperties);

            rootFolder.Display(0);
            Console.WriteLine($"Total size: {rootFolder.SizeInKB} KB");

            //int totalSizeInKB = 0;

            //foreach (var file in files)
            //{
            //    totalSizeInKB += file.SizeInKB;
            //    file.Display(0);
            //}

            //Console.WriteLine($" + {folderVisualStudio.Name}");
            //foreach (var file in folderVisualStudio.Files)
            //{
            //    totalSizeInKB += file.SizeInKB;
            //    file.Display(1);
            //}

            //Console.WriteLine($" + {folderProperties.Name}");
            //foreach (var file in folderProperties.Files)
            //{
            //    totalSizeInKB += file.SizeInKB;
            //    file.Display(1);
            //}

            //Console.WriteLine($"Total size: {totalSizeInKB} KB");
        }
    }
}
