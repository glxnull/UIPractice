using System.Windows;

namespace UIPractice.MainApplication
{
    public partial class Theme : ResourceDictionary
    {
        public Theme()
        {
            InitializeComponent();
        }

        private void CloseButtonClickCommand(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(Application.Current.MainWindow);
        }

        private void MinimizeButtonClickCommand(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void MaximazeButtonClickCommand(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = (Application.Current.MainWindow.WindowState == WindowState.Maximized) 
                ? WindowState.Normal
                : WindowState.Maximized;
        }
    }
}
