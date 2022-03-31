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
            while (true)
            {
                Console.Write("Введите адрес видео с Youtube:");
                string input = Console.ReadLine();
                if (input == "0")
                    break;
            }
            
            var url = "https://youtube.com/shorts/X08e-weUiEQ?feature=share";
            Doasync(url);

            Console.ReadKey();
        }
        async static void Doasync (string url)
        {
            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(url);

            Console.WriteLine(video);
            await youtube.Videos.DownloadAsync(url, "video.mp4");
        }
    }
}
