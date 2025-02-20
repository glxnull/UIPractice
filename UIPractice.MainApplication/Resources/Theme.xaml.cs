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
            if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
        }
    }
}
