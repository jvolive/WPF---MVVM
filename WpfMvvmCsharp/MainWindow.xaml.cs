using System.Windows;
using WpfMvvmCsharp.Views;

namespace WpfMvvmCsharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            main.Content = new VeiculoBuscar();
        }
    }
}
