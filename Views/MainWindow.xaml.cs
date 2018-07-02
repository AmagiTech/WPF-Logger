using ConsoleLoggerDemo.ViewModels;
using System.Windows;

namespace ConsoleLoggerDemo.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel model { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            model = new MainWindowViewModel();
            DataContext = model;
        }       
    }
}
