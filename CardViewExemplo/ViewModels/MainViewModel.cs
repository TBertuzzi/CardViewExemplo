using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms;

namespace CardViewExemplo.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            Views = new ObservableCollection<View>()
            {
                new Xamarin.Forms.Image() { Source = "bertuzzi.jpg",  Aspect = Aspect.AspectFill },
                new  Xamarin.Forms.Image() { Source = "bertuzzi2.jpg",  Aspect = Aspect.AspectFill },
                new  Xamarin.Forms.Image() { Source = "bertuzzi3.jpg", Aspect = Aspect.AspectFill }
            };

            PositionCommand = new Command(() =>
            {
                Debug.WriteLine("Posição selecionada.");
            });
        }

        int _position;
        public int Position
        {
            set
            {
                _position = value;
                OnPropertyChanged("Position");
            }
            get
            {
                return _position;
            }
        }

        ObservableCollection<View> _views;
        public ObservableCollection<View> Views
        {
            set
            {
                _views = value;
                OnPropertyChanged("Views");
            }
            get
            {
                return _views;
            }
        }

        public Command PositionCommand { protected set; get; }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
