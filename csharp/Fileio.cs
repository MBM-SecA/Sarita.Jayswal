using System;
using System.IO;

public class FileIO
{
   public void LearnFileHandling()
   {
      // string fileName = "file.txt";
     // if (File.Exists(fileName))
     // {string fileContent = File.ReadAllText(fileName);
     // Console.WriteLine(fileContent);
     // }
      //File.WriteAllText(fileName,"This is a text file");
      

   }
 public  void LearnFileInfo()
   {
      // string fileName = "file.txt";
      // FileInfo fileInfo = new FileInfo(fileName);
      // var size = fileInfo.Length;
      // var createDate = fileInfo.CreationTime;
      // Console.WriteLine($"File Size: {size} bytes");
       //Console.WriteLine($"Created: {createDate}");



   }
   public void LearnDirectories()
   {
string directoryName = "A";
Directory.CreateDirectory(directoryName);
   }
   //q2: Create a folder "Parent", create 10 subfolders in "Parent".
   //should contain a c# file with hello world program
   
}