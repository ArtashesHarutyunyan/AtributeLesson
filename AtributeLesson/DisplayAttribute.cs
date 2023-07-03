using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactWriter
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class DisplayAttribute : Attribute
    {
        public string Label { get; }
        public ConsoleColor Color { get; }

        public DisplayAttribute(string label, ConsoleColor color = ConsoleColor.Red)
        {
            Label = label ?? throw new ArgumentNullException(nameof(label));
            Color = color;
        }
        
    }
}
