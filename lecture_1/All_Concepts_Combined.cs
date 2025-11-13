using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApp3
{
    // Delegates
    delegate void ButtonClickHandler();
    public delegate TResult MyFunc<in T1, in T2, out TResult>(T1 arg1, T2 arg2);

    // Generic Class
    class MyInt<T>
    {
        T value;
        public void SetValue(T value) { this.value = value; }
        public T GetValue() { return this.value; }
    }

    class Program : Form
    {
        // UI Elements
        Button b1, b2, b3;
        TextBox t;

        // Custom Event
        public event ButtonClickHandler OnClick;

        // Generic Delegates instances
        MyFunc<int, int, int> add = (x, y) => x + y;
        MyFunc<float, float, float> addd = (x, y) => x + y;
        
        // Generic Class instance
        MyInt<int> myint = new MyInt<int>();

        // Methods for events
        void SayHello() => MessageBox.Show("Hello!");
        void SayGoodbye() => MessageBox.Show("Goodbye!");

        public Program()
        {
            // Create UI
            CreateTool(t = new TextBox(), new Rectangle(50, 20, 60, 20), "fact", this);
            CreateTool(b1 = new Button(), new Rectangle(10, 50, 60, 20), "fact", this);
            CreateTool(b2 = new Button(), new Rectangle(120, 50, 60, 20), "abs", this);

            // Subscribe to event
            this.OnClick += SayHello;
            this.OnClick += SayGoodbye;

            // Trigger events
            b1.Click += (sender, e) => OnClick?.Invoke();
            b2.Click += (sender, e) =>
            {
                MessageBox.Show(add(2, 2).ToString());
                MessageBox.Show(addd(2.2f, 2.3f).ToString());
                myint.SetValue(222);
                MessageBox.Show(myint.GetValue().ToString());
            };
        }

        void CreateTool(Control control, Rectangle rectangle, string txt, Control parent)
        {
            control.Text = txt;
            control.Bounds = rectangle;
            parent.Controls.Add(control);
        }

        static void Main(string[] args)
        {
            new Program().ShowDialog();
        }
    }
}
