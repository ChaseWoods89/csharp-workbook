using System;
using System.IO;

namespace FilePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines =
            System.IO.File.ReadAllLines(@"C:\Users\Chase\Desktop\words_alpha.txt");

            System.IO.File.WriteAllLines(@"/Users/Chase/Desktop/words2.txt", lines);

            StreamReader stream = File.OpenText(@"C:\Users\Chase\Desktop\words_alpha.txt");

            FileStream outstream = File.OpenWrite(@"/Users/Chase/Desktop/words3.txt");

            StreamWriter s = new StreamWriter(outstream);

            String line = stream.ReadLine();
           
          // while (stream.ReadLine() != null){
            //   s.WriteLine(line);
              // line = stream.ReadLine();
          // } 

           FileStream picReader = File.OpenRead(@"/Users/Chase/Desktop/kitty.jpg");
           FileStream picWriter = File.OpenWrite(@"/Users/Chase/Desktop/cat2.jpg");
            int b = picReader.ReadByte();
            while(b != -1){
                picWriter.WriteByte(Convert.ToByte(b));
                b = picReader.ReadByte();
            }

            picReader.Close();
            picWriter.Close();


            
            s.Close();
            stream.Close();

          /* 
          for(line = stream.ReadLine(); line != null; line = stream.ReadLine()){

             Console.WriteLine(line);
             

            }
           
          */ 
            }
        }
    }
