using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nsColorPicker
{
    public partial class Form1 : Form
    {
        int x;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += Form1_KeyDown;

            x = 0;
            label1.Text = _ColorPicker1.SelectedColor.argb.ToString();
            label2.AutoSize = false;
            label2.Text = "";
            label2.BackColor = _ColorPicker1.SelectedColor;
            label2.Width = 50;
            label2.Height = 50;

            _ColorPicker1.ColorChanged += OnColorChanged;
        }

        private void OnColorChanged(object sender, ColorEventArgs e)
        {
            label1.Text = _ColorPicker1.SelectedColor.xyz.ToString();
            label2.BackColor = _ColorPicker1.SelectedColor.xyz;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Z:
                    break;
                case Keys.Space:
                    x++;
                    switch (x)
                    {
                        case 0:
                            _ColorPicker1.DrawStyle = DrawStyles.HSBHue;
                            Console.WriteLine("HSB Hue");
                            break;
                        case 1:
                            _ColorPicker1.DrawStyle = DrawStyles.HSBSaturation;
                            Console.WriteLine("HSB Saturation");
                            break;
                        case 2:
                            _ColorPicker1.DrawStyle = DrawStyles.HSBBrightness;
                            Console.WriteLine("HSB Brightness");
                            break;
                        case 3:
                            _ColorPicker1.DrawStyle = DrawStyles.Red;
                            Console.WriteLine("RGB Red");
                            break;
                        case 4:
                            _ColorPicker1.DrawStyle = DrawStyles.Green;
                            Console.WriteLine("RGB Green");
                            break;
                        case 5:
                            _ColorPicker1.DrawStyle = DrawStyles.Blue;
                            Console.WriteLine("RGB Blue");
                            break;
                        case 6:
                            _ColorPicker1.DrawStyle = DrawStyles.HSLHue;
                            Console.WriteLine("HSL Hue");
                            break;
                        case 7:
                            _ColorPicker1.DrawStyle = DrawStyles.HSLSaturation;
                            Console.WriteLine("HSL Saturation");
                            break;
                        case 8:
                            _ColorPicker1.DrawStyle = DrawStyles.HSLLightness;
                            Console.WriteLine("HSL Lightness");
                            break;
                        case 9:
                            _ColorPicker1.DrawStyle = DrawStyles.xyz;
                            Console.WriteLine("xyz ");
                            break;
                        default:
                            x = 0;
                            _ColorPicker1.DrawStyle = DrawStyles.HSBHue;
                            break;
                    }
                    break;
            }
        }
    }
}
