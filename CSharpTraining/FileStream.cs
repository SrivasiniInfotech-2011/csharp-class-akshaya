using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
namespace CSharp
{
    class FileStreamClass
    {
        static void Main(string[] args)
        {
            try
            {
                if (!Directory.Exists(@"D:\Test"))
                {
                    Directory.CreateDirectory(@"D:\Test");
                }
                if (File.Exists(@"D:\Test\test1.ini"))
                {
                    File.Move(@"D:\Test\test1.ini", @"D:\test1.ini");
                }
                string[] arry = Directory.GetFiles(@"D:\Test", "*.ini");
                FileStream objFile = new FileStream(@"D:\Test\test1.ini", FileMode.CreateNew, FileAccess.Write);
                StreamWriter objWriter = new StreamWriter(objFile);
                Console.Write("Enter the content to go into the file: ");
                string writeline = Console.ReadLine();
                objWriter.WriteLine(writeline);
                objWriter.Flush();
                objWriter.Close();

                System.IO.FileStream objFile1 = new System.IO.FileStream(@"D:\Test\test1.ini", FileMode.Open, FileAccess.Read);

                StreamReader objReader = new StreamReader(objFile1);
                objReader.BaseStream.Seek(0, SeekOrigin.Begin);
                while (!objReader.EndOfStream)
                {
                    string str = objReader.ReadLine();
                    Console.WriteLine(str);
                }
                //string str = objReader.ReadToEnd();
                objReader.Close();
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Exception caught : {0}", e.Message);
            }
            catch (FileNotFoundException filenotfound)
            {
                Console.WriteLine("Exception caught : {0}", filenotfound.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Exception caught : {0}", ex.Message);
            }

        }
    }
}
