using System;
using System.Drawing;

namespace Utilities
{
    public enum Severity
    {
        Low,
        Medium,
        High
    }

    public class PriorityLevel
    {
        public PriorityLevel(Severity severity, String name, Color color)
        {
            Severity = severity;
            Name = name;
            Color = color;
        }

        public string Name { get; }
        public Color Color { get; }
        public Severity Severity { get; }
    }

}
