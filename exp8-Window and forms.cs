using System;
using System.Windows.Forms;

class MyForm : Form
{
    public MyForm()
    {
        Text = "My First Form";
        Width = 300;
        Height = 200;

        Label l = new Label();
        l.Text = "Welcome to C#";
        l.SetBounds(70, 50, 150, 30);

        Controls.Add(l);
    }

    static void Main()
    {
        Application.Run(new MyForm());
    }
}
