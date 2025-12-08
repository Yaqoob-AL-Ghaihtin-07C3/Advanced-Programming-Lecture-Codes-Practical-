hereusing System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
public class SmartPasswordTextBox : TextBox
{
public bool ShowStrengthLabel { get; set; } = true;
private bool showPassword = false;
private Label strengthLabel;
public SmartPasswordTextBox()
{
this.UseSystemPasswordChar = true;
strengthLabel = new Label();
strengthLabel.AutoSize = true;
strengthLabel.ForeColor = Color.Gray;
strengthLabel.Location = new Point(this.Left, this.Bottom + 2);
}
protected override void OnKeyUp(KeyEventArgs e)
{
base.OnKeyUp(e);
if (ShowStrengthLabel)
UpdateStrength();
}
protected override void OnMouseClick(MouseEventArgs e)
{
base.OnMouseClick(e);
if (e.X > this.Width - 25)
{
showPassword = !showPassword;
this.UseSystemPasswordChar = !showPassword;
this.Invalidate();
}
}
protected override void OnPaint(PaintEventArgs e)
{
base.OnPaint(e);
e.Graphics.DrawString(showPassword ? "👁" : "👁🗨 ", this.Font,
Brushes.DarkGray, new PointF(this.Width - 20, 2));
}
private void UpdateStrength()
{
int score = 0;
string pass = this.Text;
if (Regex.IsMatch(pass, ".{6,}")) score++;
if (Regex.IsMatch(pass, "[A-Z]")) score++;
if (Regex.IsMatch(pass, "[0-9]")) score++;
if (Regex.IsMatch(pass, "[^A-Za-z0-9]")) score++;
string level = "Weak";
Color color = Color.Red;
if (score == 2) { level = "Medium"; color = Color.Orange; }
if (score >= 3) { level = "Strong"; color = Color.Green; }
strengthLabel.Text = "Strength: " + level;
strengthLabel.ForeColor = color;
if (this.Parent != null &&
!this.Parent.Controls.Contains(strengthLabel))
this.Parent.Controls.Add(strengthLabel);
}
}
