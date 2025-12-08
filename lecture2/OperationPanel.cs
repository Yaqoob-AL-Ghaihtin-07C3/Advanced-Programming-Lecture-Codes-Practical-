using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab5
{
    class OperationPanel : Panel
    {
        public enum Operation { Sum, Sub, Mult, Div }
        private Operation _currentOperation;
        private readonly TextBox[] _textBoxes = new TextBox[3];
        private readonly Label[] _labels = new Label[3];
        private Label _labelOperator, _labelEquals;
        private Button _buttonOperation;
        public Operation OperationType
        {
            set
            {
                _currentOperation = value;
                UpdateOperationText();
            }
            get { return _currentOperation; }
        }

        public OperationPanel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Size = new Size(550, 150);
            BackColor = Color.WhiteSmoke;
            AutoSize = true;
            AutoScaleMode = AutoSizeMode.GrowAndShrink;
            List<string> labelTexts = new List<string> { "جتانلا", " ددعلا الثاني", "لولأا ددعلا" };

            for (int i = 0; i < 3; i++)
            {
                _labels[i] = CreateLabel(labelTexts[i], new Point((110 + 100)
                    * i + 10, 13));
                _textBoxes[i] = CreateTextBox(new Point((80 + 120) * i + 10,
                    50));
                Controls.Add(_labels[i]);
                Controls.Add(_textBoxes[i]);
            }

            _labelOperator = new Label { Text = "+", Location = new Point(350,
                51) };
            _labelEquals = new Label { Text = "=", Location = new Point(150,
                51) };
            _buttonOperation = new Button { Text = "عمج", Location = new
                Point(380, 94), Size = new Size(100, 30) };
            _buttonOperation.Click += OnButtonOperationClick;
            Controls.AddRange(new Control[] { _labelOperator, _labelEquals,
                _buttonOperation });
        }

        private Label CreateLabel(string text, Point location)
        {
            return new Label
            {
                Size = new Size(100, 23),
                Location = location,
                Text = text
            };
        }

        private TextBox CreateTextBox(Point location)
        {
            return new TextBox
            {
                Size = new Size(120, 20),
                Location = location
            };
        }

        private void UpdateOperationText()
        {
            switch (_currentOperation)
            {
                case Operation.Sum:
                    _labelOperator.Text = "+";
                    _buttonOperation.Text = "عمج";
                    break;
                case Operation.Sub:
                    _labelOperator.Text = "-";
                    _buttonOperation.Text = "حرط";
                    break;
                case Operation.Mult:
                    _labelOperator.Text = "*";
                    _buttonOperation.Text = "برض";
                    break;
                case Operation.Div:
                    _labelOperator.Text = "/";
                    _buttonOperation.Text = "ةمسق";
                    break;
            }
        }

        private void OnButtonOperationClick(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                float n1 = float.Parse(_textBoxes[2].Text.Trim());
                float n2 = float.Parse(_textBoxes[1].Text.Trim());
                float result = CalculateResult(n1, n2);
                _textBoxes[0].Text = result.ToString();
            }
            else
            {
                MessageBox.Show("مقر لخدا..");
            }
        }

        private bool ValidateInput()
        {
            return !string.IsNullOrWhiteSpace(_textBoxes[2].Text) && !
                string.IsNullOrWhiteSpace(_textBoxes[1].Text);
        }

        private float CalculateResult(float n1, float n2)
        {
            switch (_currentOperation)
            {
                case Operation.Sum: return n1 + n2;
                case Operation.Sub: return n1 - n2;
                case Operation.Mult: return n1 * n2;
                case Operation.Div: return n2 != 0 ? n1 / n2 : 0;
                default: return 0;
            }
        }

        public double TextN1
        {
            get { return double.Parse(_textBoxes[2].Text); }
            set { _textBoxes[2].Text = value.ToString(); }
        }

        public double TextN2
        {
            get { return double.Parse(_textBoxes[1].Text); }
            set { _textBoxes[1].Text = value.ToString(); }
        }

        public double TextN3 => double.Parse(_textBoxes[0].Text);
    }
}
