using System;
using System.IO;
using System.Linq;
public class FileIO
{
    public void LearnDirectories()
    {
        Directory.CreateDirectory(@"C:\Gitworksnet\Sarita.Jayswal\ABC");
        string fileHello = File.ReadAllText("Hello.cs");
        for (int i = 0; i < 10; i++)
        {
            Directory.CreateDirectory($"C:/Gitworksnet/Sarita.Jayswal/ABC/{i + 1}Folder");
            File.WriteAllText($"C:/Gitworksnet/Sarita.Jayswal/ABC/{i + 1}Folder/Hello.cs", fileHello);
        }
    }
    static void Main (string[] args)
    {
        FileIO fileIO = new FileIO();
        fileIO.LearnDirectories();
    }
}