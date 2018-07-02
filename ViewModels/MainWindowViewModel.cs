using ConsoleLoggerDemo.Views;
using System;
using System.Windows.Input;

namespace ConsoleLoggerDemo.ViewModels
{
    public class MainWindowViewModel
    {
        public Logger logger { get; set; }
        public LoggerConsoleView Logger { get; private set; }

        public MainWindowViewModel()
        {
            logger = new Logger();
            Logger =

             new LoggerConsoleView(
                new LoggerConsoleViewModel(logger));
            logger.Log("Kayıt");
            logger.Info(Environment.MachineName);
            logger.Error("Hata");
            logger.Success("Basari");
            logger.Warning("Uyari");

            logger.Log("Kayıt");
            logger.Info("Bilgi");
            logger.Error("Hata");
            logger.Success("Basari");
            logger.Warning("Uyari");
        }
        public ICommand ErrorCommand {
            get {
                return new DelegateCommand(() =>
                {
                    try
                    {
                        int x = 0;
                        var z = 1 / x;

                    }
                    catch (Exception ex)
                    {

                        logger.Error(ex.ToString());
                    }
                });
            }
        }
        public ICommand InfoCommand {
            get {
                return new DelegateCommand(() =>
                {
                    logger.Info("some info text");
                });
            }
        }
        public ICommand WarningCommand {
            get {
                return new DelegateCommand(() =>
                {
                    logger.Warning("some warning text");
                });
            }
        }
        public ICommand LogCommand {
            get {
                return new DelegateCommand(() =>
                {
                    logger.Log("some log text");
                });
            }
        }
        public ICommand SuccessCommand {
            get {
                return new DelegateCommand(() =>
                {
                    logger.Success("some success text");
                });
            }
        }
    }
}
