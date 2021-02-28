using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsColorPicker
{
    public delegate void ColorEventHandler(object sender, ColorEventArgs e);

    public class ColorEventArgs : EventArgs
    {
        public ColorEventArgs(_Color color, ColorFormat colorType)
        {
            Color = color;
            ColorType = colorType;
        }

        public ColorEventArgs(_Color color, DrawStyles drawStyle)
        {
            Color = color;
            DrawStyle = drawStyle;
        }

        public _Color Color;
        public ColorFormat ColorType;
        public DrawStyles DrawStyle;
    }
}
