using ImageFileView.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ImageFileView.Helper
{
    public class FolderTraversal
    {
        public static ObservableCollection<ImagePair> GetFiles(string Path)
        {
            if(!Directory.Exists(Path)) return new ObservableCollection<ImagePair>();
            var data = new DirectoryInfo(Path)
                            .GetFiles()
                            .Select(e => new ImagePair(e.Name, e.FullName));

            return new ObservableCollection<ImagePair>(data);
        }

        public static TreeViewItem CatalogInfo(string Path)
        {
            TreeViewItem tvItem = new TreeViewItem();

            DirectoryInfo catalogs = new DirectoryInfo(Path);
            tvItem.Header = catalogs.Name;
            tvItem.Tag = catalogs.FullName;

            foreach (var currentCatalog in catalogs.GetDirectories())
            {
                tvItem.Items.Add(CatalogInfo(currentCatalog.FullName));
            }

            foreach (var current in catalogs.GetFiles())
            {
                tvItem.Items.Add(new TreeViewItem()
                {
                    Header = current.Name,
                    Tag = current.FullName
                });
            }

            return tvItem;
        }
    }
}
