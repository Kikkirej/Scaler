using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scaler
{
    class CountCheck
    {
        RegistryKey key;

        public CountCheck()
        {
            key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Scale");
        }


        public void Init(int initalCount)
        {
            key.SetValue("count", initalCount);
        }

        public int getAndDecreaseCount()
        {
            Object currentCount = key.GetValue("count");
            if (currentCount == null)
            {
                return null;
            }
            int count;
            if(Int32.TryParse(currentCount.ToString(), out count))
            {
                if (count > 0)
                {
                    key.SetValue("count", count - 1);
                }
                return count;
            }
            else
            {
                return 0;
            }
        }
    }
}
