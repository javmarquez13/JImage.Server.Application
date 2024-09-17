using System.IO;
using System;
using System.Windows.Forms;
using JImage.Server.ViewModels.ViewModels.ApplyImageManual;
using JImage.Server.Views.Views.BaseModal;
using System.Threading.Tasks;

namespace JImage.Server.Views.Views.ApplyImageManual
{
    public partial class ApplyImageManualView : BaseView
    {
        private readonly ApplyImageManualViewModel _viewModel;
        public ApplyImageManualView(ApplyImageManualViewModel viewModel) 
            : base(Title: "Apply Image Manual", 
                   viewModel: viewModel) 
        {
            InitializeComponent();
            this._viewModel = viewModel;
        }


        public async Task LoadDirectories()
        {
            this._viewModel.IsBusy = true;
            try
            {
                // Load the directories into the TreeView
                treeViewDirectories.Nodes.Clear();
                TreeNode rootNode = new TreeNode("My Computer");
                rootNode.Tag = "MyComputer";
                treeViewDirectories.Nodes.Add(rootNode);
                await LoadSubDirectoriesAsync(rootNode);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                this._viewModel.IsBusy = false;
            }
        }

        private async Task LoadSubDirectoriesAsync(TreeNode node)
        {
            await Task.Run(() =>
            {
                try
                {
                    string path = @"C:\Publish"; // Default root path

                    if (node.Tag.ToString() == "MyComputer")
                    {
                        foreach (var drive in DriveInfo.GetDrives())
                        {
                            

                            TreeNode driveNode = new TreeNode(drive.Name)
                            {                              
                                Tag = drive.Name
                            };

                            if (drive.Name == "C:\\") continue;

                            BeginInvoke(new Action(() =>
                            {
                                node.Nodes.Add(driveNode);
                            }));

                            LoadSubDirectoriesAsync(driveNode).Wait(); // Load subdirectories for each drive
                        }
                    }
                    else
                    {
                        path = node.Tag.ToString();
                        foreach (var directory in Directory.GetDirectories(path))
                        {
                            TreeNode directoryNode = new TreeNode(Path.GetFileName(directory))
                            {
                                Tag = directory
                            };

                            BeginInvoke(new Action(() =>
                            {
                                node.Nodes.Add(directoryNode);
                            }));

                            LoadSubDirectoriesAsync(directoryNode).Wait(); // Load subdirectories for each directory
                        }
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    // Handle access exceptions
                }
            });
        }


        private async void treeViewDirectories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is string path)
            {
                await LoadFilesAsync(path);
            }
        }

        private async Task LoadFilesAsync(string path)
        {
            await Task.Run(() =>
            {
                try
                {
                    // Clear items on the main thread
                    BeginInvoke(new Action(() =>
                    {
                        lViewFiles.Items.Clear();
                    }));

                    foreach (var file in Directory.GetFiles(path))
                    {
                        // Add items to the ListView on the main thread
                        BeginInvoke(new Action(() =>
                        {
                            ListViewItem item = new ListViewItem(Path.GetFileName(file))
                            {
                                Tag = file
                            };
                            lViewFiles.Items.Add(item);
                        }));
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    // Handle access exceptions
                }
            });
        }
    }
}
