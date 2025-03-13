using System;

namespace T1SemTest
{
    public class Program
    {
        public static void Main()
        {
            FileSystem fileSystem = new FileSystem();

            File file1 = new File("Save 1 - The Citadel", ".data", 2348);
            File file2 = new File("Save 2 - Artemis Tau", ".data", 6378);
            File file3 = new File("Save 3 -- Serprent Nebula", ".data", 973);
            Folder folder1 = new Folder("Save Files");
            folder1.Add(file1);
            folder1.Add(file2);
            folder1.Add(file3);

            File file4 = new File("AnImage", ".jpg", 5342);
            File file5 = new File("SomeFile", ".txt", 832);
            Folder folder2 = new Folder("Some folder");
            folder2.Add(file4);
            folder2.Add(file5);
            Folder folder3 = new Folder("example");
            folder3.Add(folder2);

            Folder folder4 = new Folder("New folder");

            File file6 = new File("ProfilePic", ".jpg", 4675);
            File file7 = new File("MySong", ".mp3", 11236);

            fileSystem.Add(file6);
            fileSystem.Add(file7);
            fileSystem.Add(folder1);
            fileSystem.Add(folder3);
            fileSystem.Add(folder4);

            fileSystem.PrintContents();


            Console.ReadLine();
        }
    }
}
