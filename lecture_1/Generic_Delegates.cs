using System.Windows.Forms;

// تعريف مفوض عام
public delegate TResult MyFunc<in T1, in T2, out TResult>(T1 arg1, T2 arg2);

class Program : Form
{
    // استخدام المفوض العام مع أنواع مختلفة
    MyFunc<int, int, int> add = (x, y) => x + y;
    MyFunc<float, float, float> addd = (x, y) => x + y;

    public Program()
    {
        MessageBox.Show(add(2, 2).ToString());
        MessageBox.Show(addd(2.2f, 2.3f).ToString());
    }

    static void Main()
    {
        Application.Run(new Program());
    }
}
