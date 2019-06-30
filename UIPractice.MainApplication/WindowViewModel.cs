using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UIPractice.MainApplication
{
    public class WindowViewModel : BaseVIewModel
    {
        private Window _window;

        public string WindowTitle { get { return _window.Title; } }

        public WindowViewModel(Window window)
        {
            _window = window;
            _window.StateChanged += (sender, e) => {
                // Call Method
            };
        }
    }
}
