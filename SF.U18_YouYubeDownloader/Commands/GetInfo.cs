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
    class GetInfo : Command
    {
        Video video;

        public GetInfo(Video video)
        {
            this.video = video;
            Console.WriteLine("Создана команда по получению информации по адресу {0}", video.Url);
        }

        // Выполнить
        public override async void Run()
        {
            video.Getinfo();
        }

        // Отменить
        public override void Cancel()
        {
            Console.WriteLine("Невозможно отменить данную команду");
        }
    }
}
