﻿using System;
using System.Threading.Tasks;

namespace Nupp2.Views.Home
{
    public class ViewState
    {
        /*public string SelectedColor { get; private set; }*/

        public event Func<Task> Notify;
        public ProductTypeView Product { get; set; }

        public event Action OnChange;

        public event Action OnRemove;
        /*public void SetColor(string color)
        {
            SelectedColor = color;
            NotifyStateChanged();
        }*/

        public void NotifyStateChanged() => OnChange?.Invoke();
        public void NotifyStateRemoveChanged() => OnRemove?.Invoke();
    }
}