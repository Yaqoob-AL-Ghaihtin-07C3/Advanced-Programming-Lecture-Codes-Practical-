using System.Drawing;
using System.Windows.Forms;

// تعريف مفوض لمعالج الحدث
delegate void ButtonClickHandler();

class Program : Form
{
    Button b1, b2;
    TextBox t;
    
    // تعريف الحدث المخصص
    public event ButtonClickHandler OnClick;

    public Program()
    {
        CreateTool(t = new TextBox(), new Rectangle(50, 20, 60, 20), "fact", this);
        CreateTool(b1 = new Button(), new Rectangle(10, 50, 60, 20), "fact", this);
        CreateTool(b2 = new Button(), new Rectangle(120, 50, 60, 20), "abs", this);

        // الاشتراك في الحدث
        this.OnClick += SayHello;

        // إطلاق الحدث عند النقر على الزر
        b1.Click += (sender, e) => OnClick?.Invoke();
    }

    void SayHello() => MessageBox.Show("Hello!");

    void CreateTool(Control control, Rectangle rectangle, string txt, Control parent)
    {
        control.Text = txt;
        control.Bounds = rectangle;
        parent.Controls.Add(control);
    }

    static void Main()
    {
        Application.Run(new Program());
    }
}
