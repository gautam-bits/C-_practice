using System;
using System.IO;
namespace Chapter5

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Write the location *****\n");

            string path = Console.ReadLine();
            string[] files = Directory.GetFiles(path);
            for(int i =0; i< files.Length; i++)
                files[i] = Path.GetFileName(files[i]);
            Console.WriteLine(path);
            foreach (var x in files)
                Console.WriteLine(x);

            Episode_det temp = new Episode_det();
           
            for(int i =0; i < files.Length; i++  )
            {

                if (files[i].Substring(files[i].Length - 3) == "srt")
                {

                    string[] ssize = files[i].Split(null);
                    temp.series_name = ssize[0];
                    temp.series_no = Int32.Parse(ssize[2].Substring(0, 1));
                    temp.episode_no = Int32.Parse(ssize[2].Substring(2, 2));
                    temp.episode_name = ssize[4].Substring(0, ssize[4].IndexOf("."));

                    string sourceFile = Path.Combine(path, @"\", files[i]);

                    System.IO.FileInfo fi = new System.IO.FileInfo(sourceFile);
                    Console.WriteLine(sourceFile);
                    if (fi.Exists)
                    {
                        string finalpath = Path.Combine(path, @"\", temp.series_name, " - ", "S0", temp.series_no.ToString(), "E", temp.episode_no.ToString(), " - ", temp.episode_name, ".srt");

                        fi.MoveTo(finalpath);
                    }
                    else
                        Console.WriteLine("foff3");
             
                    string sourceFile2 = Path.Combine(path, @"\", temp.series_name , " " , "S0", temp.series_no.ToString(), "E", temp.episode_no.ToString(), ".mp4");

                    System.IO.FileInfo fi2 = new System.IO.FileInfo(sourceFile2);
                    Console.WriteLine(sourceFile2);
                    if (fi2.Exists)
                    {
                        string finalpath2 = Path.Combine(path, @"\", temp.series_name, " - ", "S0", temp.series_no.ToString(), "E", temp.episode_no.ToString(), " - ", temp.episode_name, ".mp4");

                        fi2.MoveTo(finalpath2);
                    }
                    else
                        Console.WriteLine("foff4");


                }
            }



        }
        }
    }
