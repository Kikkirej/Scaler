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
                if (args[0].Equals("help"))
                {
                    Console.WriteLine(@"https://www.tenforums.com/tutorials/5990-change-dpi-scaling-level-displays-windows-10-a.html#option4");
                    Console.WriteLine("100%: 96");
                    Console.WriteLine("125%: 120");
                    Console.WriteLine("150%: 144");
                    Console.WriteLine("Hilfsdialog: help");
                    Console.WriteLine("Deaktivieren: disable");
                    Console.WriteLine("ScalerCount: count <number>");
                    return;
                }
                else if (args[0].Equals("disable"))
                {
                    new Scaler().DisableScale();
                    return;
                }
                else if (args[0].Equals("count"))
                {
                    Console.Write("not implemented");
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
                new Scaler(newScale).Scale();
            }
            catch (Exception)
            {
                Console.WriteLine("Nicht genug Rechte.");
                throw;
            }
        }
    }
}
