using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ImageSorter
{
    public partial class Bildsortierer : Form
    {
        public string imageSource;
        public string imageDestination;

        private CategoryNamePopup namePopup;

        public Bildsortierer()
        {
            InitializeComponent();
            CategoryPanel.SizeChanged += new System.EventHandler(OnPanelSizeChanged);
            this.Icon = Properties.Resources.Bildsortierer;
        }

        private void CreateCategory_Click(object sender, EventArgs e)
        {
            namePopup = new CategoryNamePopup(new System.EventHandler(CreateCategoryApply_Click), new System.EventHandler(CreateCategoryCancel_Click));
            CreateCategory.Enabled = false;
            namePopup.Show();
        }

        public void CreateCategoryApply_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Create Category: " + namePopup.GetName());
            CreateCategory.Enabled = true;
            ((Button)sender).Parent.Hide();
            Directory.CreateDirectory(imageDestination + "\\" + namePopup.GetName());
            LoadDestinationSubfolders();
        }

        public void CreateCategoryCancel_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Creation of Category cancelled.");
            CreateCategory.Enabled = true;
            ((Button)sender).Parent.Hide();
        }

        public void OnPanelSizeChanged(object sender, EventArgs e)
        {
            if(CategoryPanel.HasChildren)
            {
                foreach(Control item in CategoryPanel.Controls)
                {
                    if(item is Button)
                    {
                        Button bt = (Button)item;
                        bt.Size = new Size(CategoryPanel.Width - 10, bt.Size.Height);
                    }
                }
            }
        }

        private void ImageSourceButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sourceDialog = new FolderBrowserDialog();
            DialogResult result = sourceDialog.ShowDialog();
            if (result.ToString().Equals("OK"))
            {
                imageSource = sourceDialog.SelectedPath;
                LoadFirstImageInSourceFolders();
            }
            Debug.WriteLine(imageSource);
        }

        private void ImageDestinationButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sourceDialog = new FolderBrowserDialog();
            DialogResult result = sourceDialog.ShowDialog();
            if (result.ToString().Equals("OK"))
            {
                imageDestination = sourceDialog.SelectedPath;
                LoadDestinationSubfolders();
                CreateCategory.Enabled = true;
            }
            Debug.WriteLine(imageDestination);
        }

        public struct Folder
        {
            public bool folderEmpty;
            public string folderPath;
            public List<Folder> subFolder;
        }

        public Folder GetFolderStructure(string path)
        {
            Folder folder = new Folder();
            folder.folderPath = path;
            string[] subfolders = Directory.GetDirectories(path);
            //string[] files = Directory.GetFiles(path);
            if(subfolders.Length > 0)
            {
                folder.subFolder = new List<Folder>();
                foreach(string item in subfolders)
                {
                    folder.subFolder.Add(GetFolderStructure(item));
                }
            }
            return folder;
        }

        private Folder FindNextImageFromFolder(Folder folder)
        {
            if (folder.folderEmpty)
                return folder;

            if(folder.subFolder != null && folder.subFolder.Count() > 0)
            {
                // Folder has subfolders
                int removedFolders = 0;
                for (int i = 0; i < folder.subFolder.Count() - removedFolders; i++)
                {
                    if (!folder.subFolder[i - removedFolders].folderEmpty)
                    {
                        Folder newFolder = FindNextImageFromFolder(folder.subFolder[i - removedFolders]);
                        if (newFolder.folderPath == null)
                        {
                            folder.subFolder.RemoveAt(i - removedFolders);
                            removedFolders++;
                        }
                        else
                            folder.subFolder[i - removedFolders] = newFolder;
                    }
                }
            }
            else if (Directory.GetFiles(folder.folderPath).Count() > 0)
            {
                if (!LoadImageFromFolderPath(folder.folderPath))
                    folder.folderEmpty = true;
            }
            else
            {
                folder.folderEmpty = true;
                Directory.Delete(folder.folderPath);
                return new Folder();
            }
            return folder;
        }

        private bool LoadImageFromFolderPath(string path)
        {
            string[] files = Directory.GetFiles(path);
            foreach (string imageFile in files)
            {
                string fileType = Path.GetExtension(imageFile);
                if (fileType.Equals(".jpg") || fileType.Equals(".JPG") || fileType.Equals(".jpeg") || fileType.Equals(".JPEG") || fileType.Equals(".png") || fileType.Equals(".PNG"))
                {
                    // Load image into the Picture Viewer
                    PictureViewer.ImageLocation = imageFile;
                    Filename.Text = imageFile.Remove(0, path.Length + 1);
                    return true;
                }
            }
            return false;
        }

        private void LoadFirstImageInSourceFolders()
        {
            if (imageSource.Equals(""))
                return;

            Folder mainFolder = new Folder()
            {
                folderPath = imageSource,
                subFolder = new List<Folder>()
            };

            string[] directories = Directory.GetDirectories(imageSource);
            int numberOfSubfolders = directories.Count();
            
            if (numberOfSubfolders > 0)
            {
                // Create the folder structure to be used inside the program
                //for (int i = 0; i < numberOfSubfolders; i++)
                foreach(string file in directories)
                {
                    mainFolder.subFolder.Add(GetFolderStructure(file));
                }

                int removedFolders = 0;
                for (int i = 0; i < mainFolder.subFolder.Count() - removedFolders; i++)
                {
                    if(mainFolder.subFolder[i].subFolder != null && mainFolder.subFolder[i].subFolder.Count() > 0)
                    {
                        // Folder has subfolders
                        mainFolder.subFolder[i] = FindNextImageFromFolder(mainFolder.subFolder[i]);
                    }
                }
            }
            else if (Directory.GetFiles(imageSource).Count() > 0)
            {
                if(!LoadImageFromFolderPath(imageSource))
                {
                    PictureViewer.Image = null;
                    MessageBox.Show("Keine Bilder im Gewählten Verzeichnis gefunden oder alle erfolgreich verschoben. Wählen Sie ein neues Verzeichnis!", "Keine Bilder gefunden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // There are neither Files nor Folder in the selected Directory. Throw an Info to the User and Clear the Picture Viewer
                PictureViewer.Image = null;
                MessageBox.Show("Keine Bilder im Gewählten Verzeichnis gefunden oder alle erfolgreich verschoben. Wählen Sie ein neues Verzeichnis!", "Keine Bilder gefunden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDestinationSubfolders()
        {
            if (imageDestination.Equals(""))
                return;
            
            CategoryPanel.Controls.Clear();

            int i = 0;
            foreach(string folder in Directory.GetDirectories(imageDestination))
            {
                Button saveToDestination = new Button();
                saveToDestination.Text = folder.Remove(0, imageDestination.Count() + 1);
                saveToDestination.Click += new System.EventHandler(MoveFileFromTo);
                saveToDestination.Parent = CategoryPanel;
                saveToDestination.Anchor = AnchorStyles.Top;
                saveToDestination.Location = new Point(5, 25 * i + (i - 1) + 10);
                saveToDestination.Size = new Size(saveToDestination.Width, 25);
                saveToDestination.Font = new Font("Microsoft Sans Serif", 10);
                i++;
            }

            OnPanelSizeChanged(new object(), new EventArgs());
        }

        private void MoveFileFromTo(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string destinationPath = imageDestination + "\\" + clickedButton.Text;
            Debug.WriteLine(destinationPath);
            File.Move(PictureViewer.ImageLocation, destinationPath + "\\" + GetFileNameFromPath(PictureViewer.ImageLocation));
            LoadFirstImageInSourceFolders();
        }

        private string GetFileNameFromPath(string path)
        {
            string[] splittedPath = path.Split('\\');
            return splittedPath[splittedPath.Length - 1];
        }

        private void PictureViewer_DoubleClick(object sender, EventArgs e)
        {
            string location = ((PictureBox)sender).ImageLocation;
            System.Diagnostics.Process.Start(location);
        }
    }
}