using System;
using System.Collections.Generic;
using System.Text;
using System.IO;  //this is needed in order to use file handling.

namespace ConsoleApp1
{
    /*  File.WriteAllText("FileName", content) ->  make a file with content inside into a specified directory.
     *          writing new file with the same name will overwrite over previous file.
     *  File.ReadAllText("FileName"); -> read  the content of the file in the specified directory.
     *  File.AppendAllText() -> appends text to the end of the file.
     *  File.Create() -> create a file in the specified location.
     *  File.Delete() -> delete a file in the specified location
     *  File.Copy() -> copies a file to a new location.
     *  File.Move() -> moves a file into a new location.
     *  Flle.Exists(FileName) -> check if the file exists in the directory
     *      **All method automatically closes the file.
     */
    class Day21_FileHandling
    {   //directory includes the filename too. Think of useradd in Linux.
        //C# directory has to include \\ not one.
        static void WriteAllTextExample(string dir, string content)
        {
            File.WriteAllText(dir, content);  //write the content into the directory.
        }

        static void ReadAllTextExample(string dir)
        {
            string text = File.ReadAllText(dir);
            Console.WriteLine(text);
        }

        static void AppendAllText(string dir, string content)
        {
            File.AppendAllText(dir, content);
        }

        static void FileCreate(string dir)
        {
            File.Create(dir);
        }

        static void FileDelete(string dir)
        {   
            File.Delete(dir);
        }

        static void FileCopy(string dir1, string dir2)
        {   //this can change the name at the same time.
            File.Copy(dir1, dir2);
        }

        static void FileMove(string dir1, string dir2)
        {   //this can change the name at the same time.
            File.Move(dir1, dir2);
        }

   
    }
}
