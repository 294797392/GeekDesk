using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFToolkit.MVVM;

namespace FreeDesk.ViewModels
{
    public class DockLauncherVM : ViewModelBase
    {
        public ObservableCollection<AppVM> ApplicationList { get; private set; }

        public DockLauncherVM()
        {
            this.ApplicationList = new ObservableCollection<AppVM>();
        }
    }
}
