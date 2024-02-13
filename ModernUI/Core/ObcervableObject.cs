using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ModernUI.Core
{
    internal class ObcervableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
