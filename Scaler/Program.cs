using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Scaler
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int newScale = 480;
            if (args.Length > 0)
            {
                if (args[0].Equals("help")){
                    Console.WriteLine(@"https://www.tenforums.com/tutorials/5990-change-dpi-scaling-level-displays-windows-10-a.html#option4");
                    Console.WriteLine("100%: 96");
                    Console.WriteLine("125%: 120");
                    Console.WriteLine("150%: 144");
                    return;
                }
                else
                {
                    try
                    {
                        newScale = Int32.Parse(args[0]);
                    }
                    catch (Exception)
                    {
                        
                    }
                }
            }
            try
            {
                RegistryKey key= Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
                key.SetValue("LogPixels", newScale);
                key.SetValue("Win8DpiScaling", 1);
            }
            catch (Exception)
            {
                Console.WriteLine("Nicht genug Rechte.");
                throw;
            }
        }
    }
}
