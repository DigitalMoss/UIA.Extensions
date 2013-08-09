﻿using System.Windows.Forms;

namespace UIA.Extensions.AutomationProviders.Defaults
{
    public class NumericRangeValue : RangeValueControl
    {
        private readonly NumericUpDown _numericUpDown;

        public NumericRangeValue(NumericUpDown numericUpDown) : base(numericUpDown)
        {
            _numericUpDown = numericUpDown;
        }

        public override double Value { get; set; }
        public override bool IsReadOnly { get; set; }
        public override double Maximum { get; set; }
        public override double Minimum { get; set; }
        public override double LargeChange { get; set; }
        public override double SmallChange { get; set; }
    }
}
