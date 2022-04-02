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
        Video video;
        

        public Download(Video video)
        {
            this.video = video;
            Console.WriteLine("Создана команда по скачиванию видео по адресу {0}",video.Url);
        }

        // Выполнить
        public override async void Run()
        {
           video.Download();
        }

        // Отменить
        public override void Cancel()
        {
            //Наверное можно реализовать отмену через Cancelation Token, но как это сделать я пока не знаю
            Console.WriteLine("Отмена этой команды не реализована"); 
        }
    }
}
