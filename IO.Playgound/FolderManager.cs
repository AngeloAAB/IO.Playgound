using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IO.Playgound
{
    public class FolderManager
    {
        public void Create(string folderName, string dirPath = @"..\..\..\")
        {
            if (Directory.Exists($"{dirPath}{folderName}"))
            {
                Console.WriteLine($"Folder {folderName} already Exists");
            }
            else
            {
                Directory.CreateDirectory($"{dirPath}{folderName}");
                Console.WriteLine($"Folder {folderName} succesfully created.");
            }            
        }

        public void Create(string[] folderNames, string dirPath = @"..\..\..\")
        {
            foreach (var folderName in folderNames)
            {

                if (Directory.Exists($"{dirPath}{folderName}"))
                {
                    Console.WriteLine($"Folder {folderName} already Exists");
                }
                else
                {
                    Directory.CreateDirectory($"{dirPath}{folderName}");
                    Console.WriteLine($"Folder {folderName} succesfully created.");
                }            
            }
        }

        public void Delete(string folderName, bool deleteSubs, string dirPath = @"..\..\..\")
        {
            if (Directory.Exists($"{dirPath}{folderName}"))
            {
                Console.WriteLine($"Are you sure you want to delete {folderName}?");
                Console.WriteLine("Enter Y for Yes/ N for No");
                var T = Console.ReadLine();
                bool request = T != "Y" ? false : true;
                if (request)
                {
                    try
                    {
                        Directory.Delete($"{dirPath}{folderName}", deleteSubs);

                        Console.WriteLine($"{folderName} Delete successfully");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Can't Delete {folderName}, Error {e.Message}");
                    }
                }
            }
        }
    }
}
