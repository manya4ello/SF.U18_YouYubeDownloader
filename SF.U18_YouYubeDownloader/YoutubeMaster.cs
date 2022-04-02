using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.U18_YouYubeDownloader
{
    /// <summary>
    /// Получается аналог Sender
    /// </summary>
    public class YoutubeMaster
    {
        Commands.Command _command;

        public void SetCommand(Commands.Command command) => _command = command;

        // Выполнить
        public void Run()
        {
            _command.Run();
        }

        // Отменить
        public void Cancel()
        {
            _command.Cancel();
        }
    }
}
