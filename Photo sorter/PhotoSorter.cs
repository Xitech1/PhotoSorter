using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class PhotoSorter
{
    string directory;
    string[] fileNames;
    const string sortedDirectoryName = @"\Sorted\";
    const int propertyItemID = 36867;
    public void GetFileNames()
    {
        using (var fbd = new FolderBrowserDialog())
        {
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                directory = fbd.SelectedPath;
                fileNames = Directory.GetFiles(fbd.SelectedPath);
            }
        }
    }

    public string GetDirectoryName()
    {
        return directory;
    }

    public void CreateFolders(string directoryPath)
    {
        if (!Directory.Exists(directoryPath + sortedDirectoryName))
        {
            Directory.CreateDirectory(directoryPath + sortedDirectoryName);
        }
    }

    public void SortPhotosByDate(DateTime date)
    {
        Regex r = new Regex(":");

        foreach (var item in fileNames)
        {
            using (FileStream fs = new FileStream(item, FileMode.Open, FileAccess.Read))
            using (Image myImage = Image.FromStream(fs, false, false))
            {
                try
                {
                    PropertyItem propItem = myImage.GetPropertyItem(36867);
                    string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                    DateTime taken = DateTime.Parse(dateTaken);

                    if (taken > date)
                    {
                        myImage.Save(directory + sortedDirectoryName + Path.GetFileName(item));
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("PropertyItem not found - skipping");
                }
               
            }
        }
    }
}
