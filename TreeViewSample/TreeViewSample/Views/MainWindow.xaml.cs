using System.Windows;
using TreeViewSample.Models;
using TreeViewSample.ViewModels;

namespace TreeViewSample.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var model = new MainWindowModel();
            var vm = new MainWindowViewModel(model);
            DataContext = vm;
        }
    }
}
