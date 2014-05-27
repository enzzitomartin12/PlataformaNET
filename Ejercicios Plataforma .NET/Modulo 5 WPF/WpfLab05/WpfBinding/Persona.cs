using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WpfBinding
{
    public sealed class Persona: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }   
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value == nombre)
                {
                    return;
                }
                nombre = value;
                OnPropertyChanged("Nombre");
            }
        }

    }
}
