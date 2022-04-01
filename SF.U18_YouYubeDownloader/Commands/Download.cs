using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace SF.U18_YouYubeDownloader.Commands
{
    /// <summary>
    /// Конкретная реализация команды.
    /// </summary>
    class Download : Command
    {
        String url;

        public Download(String url)
        {
            this.url = url;
            Console.WriteLine("Создана команда по скачиванию видео по адресу {0}",url);
        }

        // Выполнить
        public override async void Run()
        {
            Console.WriteLine("Команда отправлена");
           // video.Operation();
        }

        // Отменить
        public override void Cancel()
        { }
    }
}
