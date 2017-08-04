using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cw
{
    public class Files
    {
        public string name;
        public string size;
        public string content;


        public Files (string name, string content, string size)
        {
            this.name = name;
            this.content = content;
            this.size = size;
       
        }
        public void GetInformation()
        {
            Console.WriteLine("name is {0}\n content is {1}\n size is{2}B",name,content, size);
        }

    }
    public class TextFiles : Files
    {
        public TextFiles(string name, string content, string size)
             : base(name, content, size)
        {

        }
        public void DisplayT()
        {
            Console.WriteLine("name is {0}\n content is {1}\n size is {2}",name, content, size);
        }


    }
    public class ImageFiles : Files
    {
        public string resolutionI;
        public ImageFiles (string name, string content, string size, string resolutionI)
             : base (name,content,size)
        {
            this.resolutionI = resolutionI;
        }
        public void DisplayI()
        {
            Console.WriteLine("name is {0}\n content is {1}\n size is {2}\n resolution is {3}", name,content,size,resolutionI);
        }
    }
    public class MovieFiles : Files
    {
        public string resolutionV;
        public string lenghtM;
        public MovieFiles(string name, string content, string size, string resolutionV, string lenghtM)
             : base (name,content,size)
        {
            this.resolutionV = resolutionV;
            this.lenghtM = lenghtM;
        }
        public void DisplayV()
        {
            Console.WriteLine("name is {0}\n content is {1}\n size is {2}\n resolution is {3}\n lenght is {4}",name, content, size, resolutionV,lenghtM);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            @”Text:file.txt(6B);Some string content
            Image:img.bmp(19MB);1920х1080
            Text:data.txt(12B);Another string
            Text:data1.txt(7B);Yet another string
            Movie:logan.2017.mkv(19GB);1920х1080;2h12m”;
            */
           // string input =Console.ReadLine();
          
            var input = @"Text: file.txt(6B); Some string content
                       Image: img.bmp(19MB); 1920х1080
                       Text:data.txt(12B); Another string
                       Text:data1.txt(7B); Yet another string
                       Movie:logan.2017.mkv(19GB); 1920х1080; 2h12m".Split(new string[] {":",".","(",")",";"}, StringSplitOptions.None);

           
            /*for (int i = 0; i < input.Length; i++)
            {
                var r = input[i].Split(':', ';', '(');
                if (r[0] == "Text")
                {
                    TextFiles testText = new TextFiles(r[3],r[1],r[2]);
                    testText.DisplayT();
                }
                if (r[0] == "Image")
                {
                    ImageFiles testImage = new ImageFiles();
                    testImage.DisplayI();
                }
                if (r[0] == "Movie")
                {
                    MovieFiles testImage = new MovieFiles();
                    testImage.DisplayV();
                }*/
            }

        }
    }
}
