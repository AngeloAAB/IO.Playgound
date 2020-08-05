using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace IO.Playgound
{
    class Program
    {
        static void Main(string[] args)
        {

            var dir = new FolderManager();
                dir.Create("Test");
                dir.Create(@"Test\Sub Test");
                dir.Delete("Test", true);

            string[] folders =
            {
                @"Workspace\",
                @"Workspace\Archive",
                @"Workspace\Temp"
            };

               dir.Create(folders);

        }
    }
}

