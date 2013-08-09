﻿using System.Drawing;
using System.Windows;

namespace UIA.Extensions.InternalExtensions
{
    static class SystemExtensions
    {
        public static Rect AsWindowsRect(this Rectangle rectangle)
        {
            return new Rect(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }
    }
}
