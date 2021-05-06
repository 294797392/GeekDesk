using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFToolkit.MVVM;

namespace FreeDesk.ViewModels
{
    public class AppVM : ViewModelBase
    {
        #region 实例变量

        private string args;

        #endregion

        #region 属性

        public string Arguments
        {
            get { return this.args; }
            set
            {
                this.args = value;
                this.NotifyPropertyChanged("Arguments");
            }
        }

        #endregion
    }
}
