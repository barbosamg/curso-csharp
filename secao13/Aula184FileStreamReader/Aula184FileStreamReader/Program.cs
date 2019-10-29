using System;
using System.IO;

namespace Aula184FileStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\wamp64\www\UDEMY\c#\secao13\184.txt";
            //FileStream fs = null;
            //StreamReader sr = null;

            //try
            //{
            //    fs = new FileStream(path, FileMode.Open);
            //    sr = new StreamReader(fs);
            //    string line = sr.ReadLine();
            //    Console.WriteLine(line);
            //}catch(IOException ex){
            //    Console.WriteLine("An error acurred");
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    if (sr != null) sr.Close();
            //    if (fs != null) fs.Close();
            //}

            //OU DESSA FORMA
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error acurred");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }

        }
    }
}
