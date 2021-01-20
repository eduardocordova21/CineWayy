using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CineWayy.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
