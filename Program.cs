using System;
using System.Windows.Forms;
using System.Drawing;

public class Hello : Form
{
    public Hello()
    {
        this.Paint += new PaintEventHandler(f1_paint);
        this.Size = new Size(600, 400);
        this.Text = "Colors";
        this.BackColor = Color.Black;
    }

    private void f1_paint(object sender, PaintEventArgs e)
    {

        // Get Graphics Object
        Graphics g = e.Graphics;

        // Method under System.Drawing.Graphics
        g.DrawString("Violet", new Font("Verdana", 20),
        new SolidBrush(Color.Violet), 40, 40);

        g.DrawString("Blue", new Font("Verdana", 20),
        new SolidBrush(Color.Blue), 40, 80);

        g.DrawString("Light blue", new Font("Verdana", 20),
          new SolidBrush(Color.LightBlue), 40, 120);

        g.DrawString("Green", new Font("Verdana", 20),
        new SolidBrush(Color.Green), 40, 160);

        g.DrawString("Yellow", new Font("Verdana", 20),
        new SolidBrush(Color.Yellow), 40, 200);

        g.DrawString("Orange", new Font("Verdana", 20),
        new SolidBrush(Color.Orange), 40, 240);

        g.DrawString("Red", new Font("Verdana", 20),
        new SolidBrush(Color.Red), 40, 280);

    }

    public static void Main()
    {
        Application.Run(new Hello());
    }

}