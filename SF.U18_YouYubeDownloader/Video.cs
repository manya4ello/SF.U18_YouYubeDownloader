using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace SF.U18_YouYubeDownloader
{
    /// <summary>
    /// Аналог Receiver
    /// </summary>
    public class Video
    {
        public string Url { get; set; }
        YoutubeClient client { get; set; }

        public Video (string url, YoutubeClient client)
            {
            this.Url = url;
            this.client = client;
            }
        async public void Getinfo()
        {
            try
            {
                var description = await client.Videos.GetAsync(Url);

                var title = description.Title;
                var author = description.Author.Title;
                var duration = description.Duration;

                Console.WriteLine($"\nПолучена информация: \n" +
                    $"Название: \t{title}\n" +
                    $"Автор: \t{author}\n" +
                    $"Длительность: \t{duration}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        async public void Download()
        {
            try
            {
                var description = await client.Videos.GetAsync(Url);
                client.Videos.DownloadAsync(Url, description.Title+".mp4", builder => builder.SetPreset(ConversionPreset.UltraFast));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
