using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UIPractice.MainApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new WindowViewModel();
        }

        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            if (DataContext is WindowViewModel windowViewModel)
            {
                windowViewModel.MouseMoveCommand.Execute(e);
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (DataContext is WindowViewModel windowViewModel)
            {
                windowViewModel.MouseClickCommand.Execute(e);
            }
        }
    }
}
