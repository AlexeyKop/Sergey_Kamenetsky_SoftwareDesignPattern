using ImageFileView.Helper;
using ImageFileView.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace ImageFileView
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.btnPointWay.Click += delegate
            {
                using (var ofd = new FolderBrowserDialog())
                {
                    if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        tView.Items.Add(FolderTraversal.CatalogInfo(ofd.SelectedPath));
                    }
                }
            };
            this.tView.MouseDoubleClick += delegate {
                imageView.ItemsSource =
                    FolderTraversal.GetFiles((string)(tView.SelectedItem as TreeViewItem).Tag);
            };
            this.imageView.SelectionChanged += delegate
            {
                (imageView.SelectedItem as ImagePair)?.View();
            };

        }
 

       
    }
}
