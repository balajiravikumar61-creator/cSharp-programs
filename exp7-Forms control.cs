using System;
using System.Windows.Forms;

public class Form1 : Form
{
    Label l;
    TextBox t;
    Button b;

    public Form1()
    {
        l = new Label();
        l.Text = "Enter your name:";
        l.SetBounds(20, 20, 150, 25);

        t = new TextBox();
        t.SetBounds(20, 50, 150, 25);

        b = new Button();
        b.Text = "Submit";
        b.SetBounds(20, 90, 100, 30);
        b.Click += ShowMessage;

        Controls.Add(l);
        Controls.Add(t);
        Controls.Add(b);
    }

    void ShowMessage(object sender, EventArgs e)
    {
        MessageBox.Show("Hello " + t.Text);
    }

    static void Main()
    {
        Application.Run(new Form1());
    }
}
