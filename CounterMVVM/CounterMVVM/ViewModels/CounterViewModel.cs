using System;
using System.ComponentModel;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Input;
namespace CounterMVVM
{
    public class CounterViewModel : INotifyPropertyChanged
    {
        private int _counterValue;
        public event PropertyChangedEventHandler PropertyChanged;

        public int CounterValue
        {
            get { return _counterValue; }
            set
            {
                if (_counterValue != value)
                {
                    _counterValue = value;
                    OnPropertyChanged(nameof(CounterValue));
                }
            }
        }
        public ICommand IncrementCommand { get; }
        public ICommand DecrementCommand { get; }

        public CounterViewModel()
        {
            IncrementCommand = new RelayCommand(Increment, CanIncrement);
            DecrementCommand = new RelayCommand(Decrement, CanDecrement);
            if (File.Exists("result.txt"))
            {
                int value;
                if (int.TryParse(File.ReadAllText("result.txt"), out value))
                {
                    CounterValue = value;
                }
                else
                {
                    CounterValue = 0;
                }
            }
            else
            {
                CounterValue = 0;
            }
        }

        private void Increment()
        {
            CounterValue++;
        }

        private bool CanIncrement()
        {
            return CounterValue < int.MaxValue;
        }

        private void Decrement()
        {
            CounterValue--;
        }

        private bool CanDecrement()
        {
            return CounterValue > 0;
        }

        public string GetText()
        {
            return CounterValue.ToString();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
