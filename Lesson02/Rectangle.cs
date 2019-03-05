using System;
using System.Security;

namespace Lesson02
{
    public class Rectangle
    {
        public event EventHandler Changed;

        private double _length;
        private double _width = 5;

        public double Length
        {
            get { return _length; }
            set
            {
                _length = value;
                if (Changed != null) Changed(this, EventArgs.Empty);
            }
        }

        public double GetArea()
        {
            return _length * _width;
        } 
    }
}