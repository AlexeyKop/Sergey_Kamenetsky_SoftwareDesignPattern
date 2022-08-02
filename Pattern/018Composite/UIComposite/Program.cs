using static System.Console;
using System.Reflection.Emit;

namespace UIComposite
{


    class Program
    {
        static void Main()
        {
            var panel1 = new Panel("panel1");
            var tb1 = new TextBox("textBox1");
            var tb2 = new TextBox("textBox2");
            panel1.Children.Add(tb1);
            var panel2 = new Panel("panel2");
            var tb3 = new TextBox("textBox3");
            var lbl1 = new Label("label1");
            lbl1.Children.Add(new TextBlock("textBlock1"));
            panel2.Children.Add(tb3);
            panel2.Children.Add(lbl1);
            panel1.Children.Add(panel2);
            panel1.Children.Add(tb2);
            WriteLine(panel1);

            //panel1
            //  textBox1
            //  panel2
            //    textBox3
            //    label1
            //      textBlock1
            //  textBox2



        }
    }
}