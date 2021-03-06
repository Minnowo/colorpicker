﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nsColorPicker
{
    [DefaultEvent("ColorChanged")]
    public partial class ColorPicker : UserControl
    {
        public event ColorEventHandler ColorChanged;

        public _Color SelectedColor
        {
            get
            {
                return selectedColor;
            }
            private set
            {
                if (selectedColor != value)
                {
                    selectedColor = value;
                    colorBox.SelectedColor = selectedColor;
                    colorSlider.SelectedColor = selectedColor;
                    OnColorChanged();
                }
            }
        }

        public _Color AbsoluteColor
        {
            get
            {
                return absoluteColor;
            }
            private set
            {
                if (absoluteColor != value)
                {
                    absoluteColor = value;
                    colorBox.SelectedColor = selectedColor;
                    colorSlider.SelectedColor = selectedColor;
                    OnColorChanged();
                }
            }
        }

        public DrawStyles DrawStyle
        {
            get
            {
                return drawStyle;
            }
            set
            {
                colorBox.DrawStyle = value;
                colorSlider.DrawStyle = value;
                Invalidate();
            }
        }

        [DefaultValue(DrawStyles.HSBHue)]
        private DrawStyles drawStyle = DrawStyles.HSBHue;
        private _Color selectedColor;
        private _Color absoluteColor;
        private ColorPickerBox colorBox;
        private ColorPickerSlider colorSlider;
        public ColorPicker()
        {
            InitializeComponent();
            Size = new Size(290, 516);
            colorBox.ColorChanged += ColorBox_ColorChanged;
            colorSlider.ColorChanged += ColorSlider_ColorChanged;
            selectedColor = Color.FromArgb(255, 0, 0);
        }

        private void ColorSlider_ColorChanged(object sender, ColorEventArgs e)
        {
            SelectedColor = e.Color;
            absoluteColor = e.AbsoluteColor;
        }

        private void ColorBox_ColorChanged(object sender, ColorEventArgs e)
        {
            SelectedColor = e.Color;
            absoluteColor = e.AbsoluteColor;
        }

        private void OnColorChanged()
        {
            if(ColorChanged != null)
                ColorChanged(this, new ColorEventArgs(selectedColor, absoluteColor, DrawStyles.HSBHue));
        }

        private void InitializeComponent()
        {
            this.colorBox = new nsColorPicker.ColorPickerBox();
            this.colorSlider = new nsColorPicker.ColorPickerSlider();
            this.SuspendLayout();
            // 
            // colorBox
            // 
            this.colorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBox.CrosshairVisible = false;
            this.colorBox.DrawStyle = nsColorPicker.DrawStyles.HSBHue;
            this.colorBox.Location = new System.Drawing.Point(0, 0);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(258, 258);
            this.colorBox.TabIndex = 0;
            // 
            // colorSlider
            // 
            this.colorSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorSlider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorSlider.CrosshairVisible = false;
            this.colorSlider.DrawStyle = nsColorPicker.DrawStyles.HSBHue;
            this.colorSlider.Location = new System.Drawing.Point(257, 0);
            this.colorSlider.Name = "colorSlider";
            this.colorSlider.Size = new System.Drawing.Size(32, 258);
            this.colorSlider.TabIndex = 1;
            // 
            // ColorPicker
            // 
            this.AutoSize = true;
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.colorSlider);
            this.Name = "ColorPicker";
            this.Size = new System.Drawing.Size(292, 261);
            this.ResumeLayout(false);

        }
    }
}
