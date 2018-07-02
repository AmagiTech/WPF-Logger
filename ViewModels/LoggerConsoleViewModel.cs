using System.Windows.Input;

namespace ConsoleLoggerDemo.ViewModels
{
    public class LoggerConsoleViewModel
    {
        public Logger Logger { get; private set; }
        public LoggerConsoleViewModel(Logger logger)
        {
            Logger = logger;
        }


        public ICommand ClearCommand {
            get {
                return new DelegateCommand(() =>
                {
                    Logger.Clear();
                });
            }
        }
    }
}
