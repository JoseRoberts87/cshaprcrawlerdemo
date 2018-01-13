using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Demo
{
    public class StoreData
    {


        public static void StoreToDatabase(string writethis)
        {
            string path = Directory.GetCurrentDirectory();
            string mypath = @".. \" + path;
            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\rober\\Documents\\Visual Studio 2015\\Projects\\ConsoleApplication1\\myfile.txt");
            file.WriteLine(writethis);
            file.Close();
        }
    }
}
