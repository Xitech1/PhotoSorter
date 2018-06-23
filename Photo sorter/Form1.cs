using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_sorter
{
    public partial class Form1 : Form
    {
        private PhotoSorter photoSorter = new PhotoSorter();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_choose_directory_Click(object sender, EventArgs e)
        {
            photoSorter.GetFileNames();
            txtb_Directory.Text = photoSorter.GetDirectoryName();
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            photoSorter.CreateFolders(photoSorter.GetDirectoryName());
            photoSorter.SortPhotosByDate(dtp_date.Value);
        }
    }
}
