using System.Windows.Forms;

class MyFirstForm : Form
{
    public MyFirstForm()
    {
        this.Text = "Hello, Windows Forms!";
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
