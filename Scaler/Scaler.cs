using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scaler
{
    class Scaler
    {
        private readonly int ratio = 480;

        public Scaler(int ratio)
        {
            if(this.ratio<96 || this.ratio > 480)
            {
                throw new Exception("Es ist nur eine Skalierung von 96 bis 480 möglich. Mehr Informationen gibt das Flag \"help\".");
            }
            this.ratio = ratio;
        }

        public Scaler()
        {

        }

        public void Scale()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            key.SetValue("LogPixels", ratio);
            key.SetValue("Win8DpiScaling", 1);
        }

        public void DisableScale()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            key.SetValue("Win8DpiScaling", 0);
        }
    }
}
