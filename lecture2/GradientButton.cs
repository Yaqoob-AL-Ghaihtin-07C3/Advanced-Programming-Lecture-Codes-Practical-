using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
public class GradientButton : Button
{
public Color Color1 { get; set; } = Color.RoyalBlue;
public Color Color2 { get; set; } = Color.MediumPurple;
protected override void OnPaint(PaintEventArgs e)
{
using (LinearGradientBrush brush =
new LinearGradientBrush(this.ClientRectangle, Color1,
Color2, 90F))
{
e.Graphics.FillRectangle(brush, this.ClientRectangle);
}
TextRenderer.DrawText(e.Graphics, this.Text, this.Font,
this.ClientRectangle, Color.White,
TextFormatFlags.HorizontalCenter |
TextFormatFlags.VerticalCenter);
}
}
