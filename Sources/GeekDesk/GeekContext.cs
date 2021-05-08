using DotNEToolkit;
using GeekDesk.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekDesk
{
    public class FreeContext : SingletonObject<FreeContext>
    {
        public DockLauncherVM LauncherVM { get; private set; }

        public int Initialize()
        {
            this.LauncherVM = new DockLauncherVM();
            return ResponseCode.SUCCESS;
        }

        public void Release()
        { }
    }
}
