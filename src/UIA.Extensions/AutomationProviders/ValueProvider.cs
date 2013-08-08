﻿using System;
using System.Collections.Generic;
using System.Windows.Automation;
using System.Windows.Automation.Provider;
using System.Windows.Forms;

namespace UIA.Extensions.AutomationProviders
{
    public class ValueProvider : ControlProvider, IValueProvider
    {
        private readonly Func<string> _getter;
        private readonly Action<string> _setter;

        public ValueProvider(Control control, Func<string> getter, Action<string> setter)
            : base(control)
        {
            _getter = getter;
            _setter = setter;
        }

        protected override List<int> SupportedPatterns
        {
            get { return new List<int> { ValuePatternIdentifiers.Pattern.Id }; }
        }

        public void SetValue(string value)
        {
            _setter(value);
        }

        public string Value
        {
            get { return _getter(); }
        }

        public bool IsReadOnly { get; private set; }
    }
}