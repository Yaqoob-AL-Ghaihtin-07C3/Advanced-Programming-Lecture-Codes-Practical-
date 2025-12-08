using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab5
{
    class PanelOperation : Panel
    {

        private readonly TextBox[] txt = new TextBox[3];
        private readonly Label[] label = new Label[3];
        private readonly ComboBox cbx = new ComboBox();
        private readonly List<string> labelsText = new List<string>() { "
جتانلا", "يناثلا ددعلا", "لولأا ددعلا" };
        public double TextN1 { get => GetDouble(txt[2]); set => txt[2].Text =
value.ToString(); }
        public double TextN2 { get => GetDouble(txt[1]); set => txt[1].Text =
value.ToString(); }
        public double TextN3 => GetDouble(txt[0]);

        public PanelOperation()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Size = new Size(600, 200);
            AutoSize = true;
            AutoScaleMode = AutoSizeMode.GrowAndShrink;
            // نيوانعلاو لوقحلا ءاشنإ
            for (int i = 0; i < 3; i++)
            {
                label[i] = new Label()
                {
                    Size = new Size(150, 40),
                    Location = new Point((i == 2) ? i * 150 + 100 : i * 150 +
50, 10),
                    Text = labelsText[i],
                    Font = new Font("Tahoma", 12F)
                };

                txt[i] = new TextBox()
                {
                    Size = new Size(150, 50),
                    Location = new Point((i == 2) ? i * 150 + 100 : i * 150 +
20, 50),
                    Font = new Font("Tahoma", 12F)
                };
                txt[i].KeyPress += OnlyNumbers;

                Controls.Add(label[i]);
                Controls.Add(txt[i]);
            }

            // ةلدسنملا ةمئاقلا ءاشنإ
            cbx.Width = 70;
            cbx.Font = new Font("Tahoma", 12F);
            cbx.Location = new Point(txt[1].Left + txt[1].Width + 2, 50);
            cbx.Items.AddRange(new string[] { "+", "-", "*", "/" });
            cbx.SelectedIndexChanged += (s, e) => PerformOperation();

            Controls.Add(cbx);
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            // (e.KeyChar) Keys.Back
            e.Handled = true;
        }

        private double GetDouble(TextBox txtBox)
        {
            return double.TryParse(txtBox.Text, out double value) ? value : 0;
        }

        private void PerformOperation()
        {
            if (cbx.SelectedItem == null || string.IsNullOrWhiteSpace(txt
[1].Text) || string.IsNullOrWhiteSpace(txt[2].Text))
                return;

            double num1 = TextN1, num2 = TextN2;
            string result = txt[0].Text;

            switch (cbx.SelectedItem.ToString())
            {
                case "+":
                    result = (num1 + num2).ToString();
                    break;
                case "-":
                    result = (num1 - num2).ToString();
                    break;
                case "*":
                    result = (num1 * num2).ToString();
                    break;
                case "/":
                    result = (num2 != 0) ? (num1 / num2).ToString() : "أطخ";
                    break;
            }

            txt[0].Text = result;
        }
    }
}
