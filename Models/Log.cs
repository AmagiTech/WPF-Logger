using System;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace ConsoleLoggerDemo
{

    public class Logger
    {
        public static int Limit => 100;    
        public ObservableCollection<ILoggable> Logs { get; private set; }
        public Logger()
        {
            Logs = new ObservableCollection<ILoggable>();
        }
        public void Clear() => Logs.Clear();
        public void Add(ILoggable log)
        {
            if (Logs.Count == Limit)
                Logs.RemoveAt(0);
            Logs.Add(log);
        }
        public void Log(params string[] logs) => Add(new Log(logs));
        public void Error(params string[] logs) => Add(new Error(logs));
        public void Info(params string[] logs) => Add(new Info(logs));
        public void Success(params string[] logs) => Add(new Success(logs));
        public void Warning(params string[] logs) => Add(new Warning(logs));
    }

    public interface ILoggable
    {
        string Text { get; }
        SolidColorBrush Background { get; }
        SolidColorBrush Foreground { get; }
    }
    public class Log : ILoggable
    {
        public SolidColorBrush Background => Brushes.White;

        public SolidColorBrush Foreground => Brushes.Black;
        public string Text { get; private set; }
        public Log(params string[] logs)
        {
            string logText = $"Log({DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}): ";
            logText = logText + string.Join(",", logs);
            Text = logText;
        }

    }
    public class Error : ILoggable
    {
        public SolidColorBrush Background => Brushes.Red;

        public SolidColorBrush Foreground => Brushes.White;
        public string Text { get; private set; }
        public Error(params string[] logs)
        {
            string logText = $"Error({DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}): ";
            logText = logText + string.Join(",", logs);
            Text = logText;
        }
    }
    public class Info : ILoggable
    {

        public string Text { get; private set; }
        public Info(params string[] logs)
        {
            string logText = $"Info({DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}): ";
            logText = logText + string.Join(",", logs);
            Text = logText;
        }
        public SolidColorBrush Background => Brushes.White;

        public SolidColorBrush Foreground => Brushes.Blue;
    }
    public class Success : ILoggable
    {
        public string Text { get; private set; }
        public Success(params string[] logs)
        {
            string logText = $"Success({DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}): ";
            logText = logText + string.Join(",", logs);
            Text = logText;
        }
        public SolidColorBrush Background => Brushes.Green;

        public SolidColorBrush Foreground => Brushes.White;
    }

    public class Warning : ILoggable
    {
        public string Text { get; private set; }
        public Warning(params string[] logs)
        {
            string logText = $"Warning({DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}): ";
            logText = logText + string.Join(",", logs);
            Text = logText;
        }
        public SolidColorBrush Background => Brushes.Orange;

        public SolidColorBrush Foreground => Brushes.White;
    }
}
