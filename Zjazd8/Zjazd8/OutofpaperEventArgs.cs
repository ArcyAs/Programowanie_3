using System;

namespace Zjazd8
{
    public class OutofpaperEventArgs : EventArgs
    {
        private int page_number;

        public OutofpaperEventArgs(int page_number)
        {
            this.page_number = page_number;
        }
    }
}