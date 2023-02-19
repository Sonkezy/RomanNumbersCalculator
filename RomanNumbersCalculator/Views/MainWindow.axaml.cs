using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Logging;
using RomanNumbersCalculator.ViewModels;

namespace RomanNumbersCalculator.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

    }
}
