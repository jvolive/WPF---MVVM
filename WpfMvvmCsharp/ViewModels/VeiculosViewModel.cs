using System.ComponentModel;
using System.Windows.Input;
using WpfMvvmCsharp.Models;

namespace WpfMvvmCsharp.ViewModels
{
    public class VeiculosViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public Veiculos? Veiculo { get; set; }

        public ICommand BuscarVeiculos { get; set; }

        public VeiculosViewModel() {
            BuscarVeiculos = new RelayCommand(Obter Veiculo); 
        }

        public void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
