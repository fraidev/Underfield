using System;

namespace Underfield
{
    public class FluentReadProperty
    {
        private bool _display;

        public FluentReadProperty(Type type)
        {
        }

        public void Display()
        {
            _display = true;
        }

    }
}