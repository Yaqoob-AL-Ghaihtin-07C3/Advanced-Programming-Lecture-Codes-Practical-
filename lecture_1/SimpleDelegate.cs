using System;
using System.Windows.Forms;

// 1. تعريف المفوض
delegate void MyDelegate(string message);

class Program
{
    // دالة تتوافق مع توقيع المفوض
    static void ShowMessage(string message)
    {
        MessageBox.Show(message);
    }

    // يمكن أيضًا استخدام تعبير لامدا
    static MyDelegate msg = (s) => MessageBox.Show(s);

    static void Main()
    {
        // 2. إنشاء نسخة من المفوض وتوجيهها إلى الدالة
        MyDelegate del = ShowMessage;

        // 3. استدعاء الدالة عبر المفوض
        del("Hello, World!");
    }
}
