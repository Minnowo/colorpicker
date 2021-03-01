using System;
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
    public partial class ColorComboBox : UserControl
    {
        public decimal[] Values
        {
            get
            {
                return values;
            }
            set
            {
                if (value.Length == values.Length)
                {
                    values = value;
                    UpdateTextBox();
                }
            }
        }
        public decimal[] MinValues
        {
            get
            {
                return minValues;
            }
            set
            {
                if(value.Length == values.Length)
                {
                    minValues = value;
                    UpdateTextBox();
                }
            }
        }
        public decimal[] MaxValues
        {
            get
            {
                return maxValues;
            }
            set
            {
                if (value.Length == values.Length)
                {
                    maxValues = value;
                    UpdateTextBox();
                }
            }
        }

        public byte DecimalPlaces
        {
            get
            {
                return decimalPlaces;
            }
            set
            {
                if (value <= 7)
                    decimalPlaces = value;
            }
        }

        [DefaultValue(true)]
        private decimal[] minValues = new decimal[] { 0M, 0M, 0M};
        [DefaultValue(true)]
        private decimal[] maxValues = new decimal[] { 255M, 255M, 255M };
        [DefaultValue(true)]
        private decimal[] values = new decimal[] { 0, 0, 0 };
        [DefaultValue(true)]
        private byte decimalPlaces = 1;
        public string seperator { get; set; } = "   ";
        private int buttonHeldIndex;
        private IncreaseDecrease onUpdate;
        private Timer buttonHeldTimer;

        public ColorComboBox()
        {
            InitializeComponent();
            //Size = new Size(width, Size.Height);
            buttonHeldTimer = new Timer() { Interval = 50 };
            buttonHeldTimer.Tick += ButtonHeldTimer_Tick;

            ColorComboBox_ClientSizeChanged(null, EventArgs.Empty);
        }


        public void UpdateTextBox()
        {
            if (values.Length == minValues.Length && values.Length == maxValues.Length)
            {
                StringBuilder str = new StringBuilder();
                for(int i = 0; i < values.Length; i++)
                {
                    if(i != values.Length - 1)
                    {
                        str.Append($"{MathHelper.ExtendToXZeros(values[i].Clamp(minValues[i], maxValues[i]), decimalPlaces)}{seperator}");
                    }
                    else
                    {
                        str.Append($"{MathHelper.ExtendToXZeros(values[i].Clamp(minValues[i], maxValues[i]), decimalPlaces)}");
                    }
                }

                MainTextBox.Text = str.ToString();
            }
        }

        private void UpButton_MouseDown(object sender, MouseEventArgs e)
        {
            buttonHeldIndex = ((Button)sender).TabIndex;
            onUpdate = IncreaseDecrease.Increase;
            buttonHeldTimer.Start();
        }
        private void DownButton_MouseDown(object sender, MouseEventArgs e)
        {
            buttonHeldIndex = ((Button)sender).TabIndex;
            onUpdate = IncreaseDecrease.Decrease;
            buttonHeldTimer.Start();
        }
        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            buttonHeldTimer.Stop();
        }


        private void ButtonHeldTimer_Tick(object sender, EventArgs e)
        {
            switch (onUpdate)
            {
                case IncreaseDecrease.Increase:
                    values[buttonHeldIndex] = values[buttonHeldIndex] + 1;
                    break;
                case IncreaseDecrease.Decrease:
                    values[buttonHeldIndex] = values[buttonHeldIndex] - 1;
                    break;
            }
            UpdateTextBox();
        }

        private void ColorComboBox_ClientSizeChanged(object sender, EventArgs e)
        {
            UpButtonPanel.Controls.Clear();
            DownButtonPanel.Controls.Clear();
            int upButtonWidth = UpButtonPanel.Size.Width / values.Length;
            int downButtonWidth = DownButtonPanel.Size.Width / values.Length;

            for (int i = 0; i < values.Length; i++)
            {
                Button b = new Button() { Text = "", Width = downButtonWidth, Height = DownButtonPanel.Height };
                b.Margin = new Padding(0);
                b.Location = new Point(i * downButtonWidth, 0);
                b.AutoSize = true;
                b.MouseDown += DownButton_MouseDown;
                b.MouseUp += Button_MouseUp;
                DownButtonPanel.Controls.Add(b);
            }
            for (int i = 0; i < values.Length; i++)
            {
                Button b = new Button() { Text = "", Width = upButtonWidth, Height = UpButtonPanel.Height };
                b.Margin = new Padding(0);
                b.Location = new Point(i * upButtonWidth, 0);
                b.AutoSize = true;
                b.MouseDown += UpButton_MouseDown;
                b.MouseUp += Button_MouseUp;
                UpButtonPanel.Controls.Add(b);
            }
        }
    }
}
