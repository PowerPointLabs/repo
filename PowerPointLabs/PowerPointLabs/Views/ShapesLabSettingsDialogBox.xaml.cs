﻿using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

using PowerPointLabs.DataSources;
using PowerPointLabs.Utils;

namespace PowerPointLabs.Views
{
    /// <summary>
    /// Interaction logic for ShapesLabSettingsDialogBox.xaml
    /// </summary>
    public partial class ShapesLabSettingsDialogBox
    {
        public enum Option
        {
            Ok,
            Cancel
        }

        public Option UserOption { get; private set; }
        public string DefaultSavingPath
        {
            get
            {
                return _settingsDataSource.DefaultSavingPath;
            }
        }

        private readonly ShapesLabSettingsDataSource _settingsDataSource = new ShapesLabSettingsDataSource();

        public ShapesLabSettingsDialogBox()
        {
            InitializeComponent();
        }
        
        public ShapesLabSettingsDialogBox(string defaultPath)
            : this()
        {
            savePathBrowserIconImage.Source = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                    Properties.Resources.Load_icon.GetHbitmap(),
                    IntPtr.Zero,
                    Int32Rect.Empty,
                    BitmapSizeOptions.FromEmptyOptions());

            _settingsDataSource.DefaultSavingPath = defaultPath;
            
            savePathInput.IsReadOnly = true;
            savePathInput.Text = _settingsDataSource.DefaultSavingPath;

            UserOption = Option.Cancel;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            UserOption = Option.Ok;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            UserOption = Option.Cancel;
            Close();
        }

        private void SavePathBrowserButton_Click(object sender, RoutedEventArgs e)
        {
            var folderDialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                SelectedPath = _settingsDataSource.DefaultSavingPath,
                Description = TextCollection.FolderDialogDescription
            };

            var selectEmptyFolder = false;

            // loop until user chooses an empty folder, or click "Cancel" button
            while (!selectEmptyFolder)
            {
                // this launcher will scroll the view to selected path
                var result = FolderDialogLauncher.ShowFolderBrowser(folderDialog);

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    var newPath = folderDialog.SelectedPath;

                    if (!FileDir.IsDirectoryEmpty(newPath))
                    {
                        System.Windows.MessageBox.Show(TextCollection.FolderNonEmptyErrorMsg);
                    }
                    else
                    {
                        selectEmptyFolder = true;
                        _settingsDataSource.DefaultSavingPath = newPath;
                        savePathInput.Text = _settingsDataSource.DefaultSavingPath;
                    }
                }
                else
                {
                    // if user cancel the dialog, break the loop
                    break;
                }
            }
        }
    }
}
