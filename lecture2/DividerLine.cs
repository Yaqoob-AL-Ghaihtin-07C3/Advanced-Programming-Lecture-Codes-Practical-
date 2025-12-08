using System.Drawing;
using System.Windows.Forms;
public class DividerLine : Control
{
public bool Vertical { get; set; } = false;
public int Thickness { get; set; } = 2;
public Color LineColor { get; set; } = Color.Silver;
protected override void OnPaint(PaintEventArgs e)
{
base.OnPaint(e);
using (Pen pen = new Pen(LineColor, Thickness))
{
if (Vertical)
{
int x = this.Width / 2;
e.Graphics.DrawLine(pen, x, 0, x, this.Height);
}
else
{
int y = this.Height / 2;
e.Graphics.DrawLine(pen, 0, y, this.Width, y);
} } } }
