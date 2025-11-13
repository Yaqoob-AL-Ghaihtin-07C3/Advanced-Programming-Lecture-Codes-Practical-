using System.Drawing;
using System.Windows.Forms;

class Program : Form
{
    Button b1, b2, b3;
    TextBox t;

    public Program()
    {
        CreateTool(t = new TextBox(), new Rectangle(50, 20, 60, 20), "fact", this);
        CreateTool(b1 = new Button(), new Rectangle(10, 50, 60, 20), "", this);
        CreateTool(b2 = new Button(), new Rectangle(120, 50, 60, 20), "abs", this);
    }

    void CreateTool(Control control, Rectangle rectangle, string txt, Control parent)
    {
        control.Text = txt;
        control.Bounds = rectangle;
        parent.Controls.Add(control);
    }

    // ملاحظة: هذا الكود يحتاج إلى نقطة دخول (Main) لكي يعمل
    static void Main()
    {
        Application.Run(new Program());
    }
}
