﻿using System;
using System.Threading.Tasks;

namespace Nupp2.Views.Home.Button
{
    public class NotifierService
    {
        public async Task Update(string key, int value)
        {
            if (Notify != null)
            {
                await Notify.Invoke(key, value);
            }
        }

        public event Func<string, int, Task> Notify;
    }
}