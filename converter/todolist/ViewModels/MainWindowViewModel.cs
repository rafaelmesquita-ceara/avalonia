using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace todolist.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private double _celsius;
        private double _fahrenheit;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Celsius
        {
            get => _celsius;
            set
            {
                if (_celsius != value)
                {
                    _celsius = value;
                    OnPropertyChanged();
                    UpdateFahrenheit();
                }
            }
        }

        public double Fahrenheit
        {
            get => _fahrenheit;
            set
            {
                if (_fahrenheit != value)
                {
                    _fahrenheit = value;
                    OnPropertyChanged();
                    UpdateCelsius();
                }
            }
        }

        private void UpdateFahrenheit()
        {
            Fahrenheit = Celsius * 9 / 5 + 32;
        }
        private void UpdateCelsius()
        {
            Celsius = (Fahrenheit - 32 ) * 5 / 9;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}