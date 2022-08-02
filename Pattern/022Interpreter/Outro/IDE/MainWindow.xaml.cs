using LanguageInterpreterLibrary.Analyzers;
using LanguageInterpreterLibrary.Exceptions;
using System;
using System.Windows;
using System.Windows.Input;

namespace IDE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Action action = () =>
            {
                try
                {
                    Tokenizer lexer = new Tokenizer(tb.Text);
                    var r = lexer.Analysis();

                    var pp = new Parser(lexer.Tokens);
                    output.Text = string.Join("\n", pp.res);
                    errorBlock.Text = "Build successful";
                }
                catch (Exception ex)
                {
                    errorBlock.Text = $"{ex.GetType().Name} ";
                    if (ex is InterpreterException ie)
                    {
                        var pos = ie.ErrorPosition;
                        errorBlock.Text += $"{ie.Text} {pos}";
                        tb.Focus();
                        tb.SelectionStart = pos;
                        tb.SelectionLength = 1;
                    }

                }
            };
            buildBtn.Click += (s, e) => action();
            tb.KeyDown += (s, e) => { if (e.Key != Key.F9) return; action(); };
        }
    }
}
