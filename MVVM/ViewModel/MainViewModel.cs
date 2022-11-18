using System;
using System.Collections.Generic;
using System.Text;
using Dateien_Umbenennen.Core;

namespace Dateien_Umbenennen.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        private object myVar;

        public object MyProperty        //30:49
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public MainViewModel()
        {

        }
    }
}
