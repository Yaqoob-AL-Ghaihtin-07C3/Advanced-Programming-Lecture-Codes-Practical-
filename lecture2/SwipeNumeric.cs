using System;
using System.Windows.Forms;
using System.Drawing;
public class SwipeNumeric : TextBox
{
public int Value { get; set; } = 0;
private int startX;
private bool dragging = false;
public SwipeNumeric()
{
this.Text = Value.ToString();
this.TextAlign = HorizontalAlignment.Center;
}
protected override void OnMouseDown(MouseEventArgs e)
{
base.OnMouseDown(e);
dragging = true;
startX = e.X;
}
protected override void OnMouseMove(MouseEventArgs e)
{
base.OnMouseMove(e);
if (dragging)
{
int diff = e.X - startX;
if (diff > 5) { Value++; startX = e.X; }
if (diff < -5) { Value--; startX = e.X; }
this.Text = Value.ToString();
}
}
protected override void OnMouseUp(MouseEventArgs e)
{
base.OnMouseUp(e);
dragging = false;
}
}
