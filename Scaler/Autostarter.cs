using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scaler
{
    class Autostarter
    {
        public void Register()
        {
            String codebase = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            codebase = codebase.Replace(@"codebase:", "").Replace("file:", "").Replace("///", "").Replace("/", "\\");
            RegistryKey rkey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            rkey.SetValue("Scaler", value: "\"" + codebase + "\"");
        }

        public void Unregister()
        {
            RegistryKey rkey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            rkey.DeleteValue("Scaler");
        }
    }
}
