using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Read
{
    public class ColorsList
    {
        private System.Drawing.Color[] colors;

        private int colorIndex;

        public ColorsList() {
            colors = new System.Drawing.Color[3] { Color.DARK_GREY,Color.LIGHT_GREY, Color.WHITE};
            colorIndex = 0;
        }

        public System.Drawing.Color NextColor() {
            if (colorIndex >= colors.Length) {
                colorIndex = 0;
            }
            return colors[colorIndex++];
        }
    }
}
