﻿using System;
using System.Windows.Forms;
using UIA.Fluent.AutomationProviders;

namespace UIA.Fluent
{
    public static class AutomationExtensions
    {
        public static AutomationConfigurer ExposeAutomation(this Control control)
        {
            return new AutomationConfigurer(control);
        }

        public static AutomationConfigurer AsValueControl(this Control control, Func<string> getter, Action<string> setter)
        {
            return new AutomationConfigurer(control, new ValueProvider(control, getter, setter));
        }
    }
}
