using ConsoleLoggerDemo.ViewModels;
using System.Windows.Controls;

namespace ConsoleLoggerDemo.Views
{
    public partial class LoggerConsoleView : Page
    {
        public LoggerConsoleView(LoggerConsoleViewModel loggerConsoleViewModel)
        {
            InitializeComponent();
            DataContext = loggerConsoleViewModel;
            loggerConsoleViewModel.Logger.Logs.CollectionChanged += (se, ev) =>
            {
                Scroll.ScrollToBottom();
            };
        }
    }
}
