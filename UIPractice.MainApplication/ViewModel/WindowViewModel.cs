using System.Windows;
using System.Windows.Input;

namespace UIPractice.MainApplication
{
    public class WindowViewModel : BaseViewModel
    {
        private bool _isClicked;

        private MousePositionInfo _mousePosition;
        public MousePositionInfo MousePosition
        {
            get => _mousePosition;
            set
            {
                _mousePosition = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayText));
            }
        }

        public string DisplayText => _isClicked
            ? $"Clicked at {MousePosition}"
            : $"Mouse Position: {MousePosition}";

        public ICommand MouseMoveCommand { get; }
        public ICommand MouseClickCommand { get; }

        public WindowViewModel()
        {
            _isClicked = false;
            MouseMoveCommand = new RelayCommand<MouseEventArgs>(OnMouseMove);
            MouseClickCommand = new RelayCommand<MouseButtonEventArgs>(OnMouseClick);
            MousePosition = new MousePositionInfo(0, 0);
        }

        private void OnMouseMove(MouseEventArgs e)
        {
            if (e != null)
            {
                _isClicked = false;
                var element = e.Source as UIElement;
                var position = e.GetPosition(element);
                MousePosition = new MousePositionInfo((int)position.X, (int)position.Y);
            }
        }

        private void OnMouseClick(MouseButtonEventArgs e)
        {
            if (e != null)
            {
                _isClicked = true;
                var element = e.Source as UIElement;
                var position = e.GetPosition(element);
                MousePosition = new MousePositionInfo((int)position.X, (int)position.Y);
            }
        }
    }
}
