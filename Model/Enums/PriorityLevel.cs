﻿using System;
using System.Drawing;

namespace Model.Enums
{
    public class PriorityLevel
    {
        public PriorityLevel(Severity severity, String name, Color color, Color selectionColor)
        {
            Severity = severity;
            Name = name;
            Color = color;
            SelectionColor = selectionColor;
        }

        public string Name { get; }
        public Color Color { get; }
        public Color SelectionColor { get; }
        public Severity Severity { get; }
    }
}
