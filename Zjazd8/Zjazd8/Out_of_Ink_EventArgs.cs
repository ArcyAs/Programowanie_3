using System;

namespace Zjazd8
{
    public class OutOfInkEventArgs : EventArgs
    {
        public string Color;

        public OutOfInkEventArgs(string c)
        {
            Color = c;
        }
    }
}