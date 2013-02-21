using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ChefosForm
{
    public class ColorsList
    {
        private System.Drawing.Color[] colors;

        private int colorIndex;

        public ColorsList() {
            colors = new Color[3] { Color.FromArgb(229,229,229), Color.White, Color.FromArgb(193,193,193) };
            colorIndex = 0;
        }

        public Color NextColor() {
            if (colorIndex >= colors.Length) {
                colorIndex = 0;
            }
            return colors[colorIndex++];
        }
    }
}
