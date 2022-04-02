using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.U18_YouYubeDownloader.Commands
{
    /// <summary>
    /// Базовый класс команды
    /// </summary>
     public abstract class Command
    {
        public abstract void Run();
        public abstract void Cancel();
    }
}
