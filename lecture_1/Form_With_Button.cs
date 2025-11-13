using System;
using System.Windows.Forms;

class MyFirstForm : Form
{
    public MyFirstForm()
    {
        this.Text = "Hello, Windows Forms!";
        Button button = new Button();
        button.Text = "Click Me!";
        button.Click += new EventHandler(button_Click);
        this.Controls.Add(button);
    }

    void button_Click(object sender, EventArgs e)
    {
        MessageBox.Show("click...");
    }
}

class MyFirstApp
{
    static void Main()
    {
        Form form = new MyFirstForm();
        Application.Run(form);
    }
}
