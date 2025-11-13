using System.Windows.Forms;

// تعريف فئة عامة
class MyInt<T>
{
    T value;
    public void SetValue(T value) { this.value = value; }
    public T GetValue() { return this.value; }
}

class Program : Form
{
    public Program()
    {
        MyInt<int> myint = new MyInt<int>();
        myint.SetValue(222);
        MessageBox.Show(myint.GetValue().ToString());
    }

    static void Main()
    {
        Application.Run(new Program());
    }
}
