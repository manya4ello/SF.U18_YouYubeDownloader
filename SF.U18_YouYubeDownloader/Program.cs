
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace SF.U18_YouYubeDownloader
{
    internal class Program
    {
       
         static void Main(string[] args)
        {
            
            YoutubeMaster youtubeMaster = new YoutubeMaster();
            var youtube = new YoutubeClient();

            Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ!");
            string url = default;

            while (true)
            {
                Console.Write("Введите адрес видео с Youtube (0 - выход): ");
                url = Console.ReadLine();
                if (url == "0")
                    break;
                
                var newvideo = new Video(url, youtube);

                while (true)
                {
                    Commands.Command command = default; 
                    Console.Write("1 - получить информацию о видео, 2 - скачать, 0 - выход: ");
                    string input = Console.ReadLine();
                    if (input == "0")
                        break;
                    int choice = 0;
                    var check = int.TryParse(input, out choice);
                    if (choice == 1)
                        youtubeMaster.SetCommand(new Commands.GetInfo(newvideo));
                    if (choice == 2)
                        youtubeMaster.SetCommand(new Commands.Download(newvideo));
                    if (check && (choice == 1 | choice == 2))
                         youtubeMaster.Run();
                        
                            
                }
            }
                      
            Console.ReadKey();
        }
       
    }
}
