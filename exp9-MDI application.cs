create a custom dialog box:

using System;
using System.Windows.Forms;

class MyDialog : Form
{
    public MyDialog()
    {
        Text = "Custom Dialog Box";
        Width = 300;
        Height = 150;

        Label l = new Label();
        l.Text = "Do you want to continue?";
        l.SetBounds(30, 20, 220, 25);

        Button b = new Button();
        b.Text = "OK";
        b.SetBounds(90, 60, 80, 30);
        b.Click += (s, e) => Close();

        Controls.Add(l);
        Controls.Add(b);
    }

    static void Main()
    {
        MyDialog d = new MyDialog();
        d.ShowDialog();
    }
}

design an mdi application with menu:

using System;
using System.Windows.Forms;

class MainForm : Form
{
    public MainForm()
    {
        Text = "MDI Application";
        IsMdiContainer = true;
        Width = 600;
        Height = 400;

        MenuStrip menu = new MenuStrip();
        ToolStripMenuItem file = new ToolStripMenuItem("File");
        ToolStripMenuItem open = new ToolStripMenuItem("Open");

        open.Click += (s, e) =>
        {
            Form child = new Form();
            child.Text = "Child Window";
            child.MdiParent = this;
            child.Show();
        };

        file.DropDownItems.Add(open);
        menu.Items.Add(file);

        Controls.Add(menu);
        MainMenuStrip = menu;
    }

    static void Main()
    {
        Application.Run(new MainForm());
    }
}
