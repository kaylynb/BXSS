﻿using System;

namespace util
{
    using System.Collections.Generic;

    public class SetButton : Button
    {
        public SetButton()
            : this("Set", new List<ISettable>())
        {
        }

        public new Action Clicked { get; set; }

        public SetButton(string text, List<ISettable> settableObjects)
        {
            Text = text;
            SettableObjects = settableObjects;

            base.Clicked = OnClick;
        }

        public List<ISettable> SettableObjects { get; set; } 

        private void OnClick()
        {
            foreach (var settableObject in SettableObjects)
                settableObject.Set();

            Clicked();
        }
    }
}
