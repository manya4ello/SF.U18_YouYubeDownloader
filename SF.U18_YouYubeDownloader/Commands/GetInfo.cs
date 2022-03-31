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
        }

        // Выполнить
        public override async void Run()
        {
            //Console.WriteLine("Команда отправлена");
            //videos.GetAsync(string videoUrl);
            //receiver.Operation();
        }

        // Отменить
        public override void Cancel()
        {
            Console.WriteLine("Невозможно отменить данную команду");
        }
    }
}
