using System;
namespace T1_oop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileSystem f = new FileSystem();
            File file1 = new File("AnImage", "jpg", 2348);
            File file2 = new File("SomeFile", "txt", 832);
            File file3 = new File("Save 1 - Sanya", "data", 800);
            File file4 = new File("Save 2 - Baweja", "data", 800);
            f.Add(file1);

            Folder folder1 = new Folder("Images");
            folder1.Add(file2);
            f.Add(folder1);

            Folder folder2 = new Folder("RandomFolderName");
            Folder folder3 = new Folder("SanyaFolder");
            folder2.Add(file3);
            folder2.Add(file4);
            folder3.Add(folder2);
            f.Add(folder3);


            Folder folder4 = new Folder("f4");
            f.Add(folder4);

            f.PrintContents();
           
            

            Console.ReadLine();
        }
    }
}

