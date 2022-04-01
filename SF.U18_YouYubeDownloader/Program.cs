//videos.GetAsync(string videoUrl) — получить описание видео;
//await videos.DownloadAsync(string videoUrl, string outputFilePath) — запустить скачивание видео. 
//Чтобы кодирование видео проходило быстрее, можно передать в этот метод третий параметр:
//builder => builder.SetPreset(ConversionPreset.UltraFast).

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
            Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ!");
            var url = "https://youtube.com/shorts/X08e-weUiEQ?feature=share";

            while (true)
            {
                Console.Write("Введите адрес видео с Youtube (0 - выход): ");
                url = Console.ReadLine();
                if (url == "0")
                    break;


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
                        command = new Commands.GetInfo(url);
                    if (choice == 2)
                        command = new Commands.Download(url);
                    if (check)
                        command.Run();
                }
            }
            
            url = "https://youtube.com/shorts/X08e-weUiEQ?feature=share";
            Doasync(url);

            Console.ReadKey();
        }
        async static void Doasync (string url)
        {
            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(url);

            var title = video.Title; 
            var author = video.Author.Title; 
            var duration = video.Duration; 

            Console.WriteLine(title);
            Console.WriteLine(author);  
            Console.WriteLine(duration);

            
            await youtube.Videos.DownloadAsync(url, "video.mp4", builder => builder.SetPreset(ConversionPreset.UltraFast));
         
        }
    }
}
