using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class FicExplorateur : Form
    {
        public FicExplorateur()
        {
            InitializeComponent();
        }

        private void TsbQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FicExplorateur_Load(object sender, EventArgs e)
        {
            RemplirTreeView();
            slMessage.Text = "Prêt";
        }

        private void RemplirTreeView()
        {
            tvRepertoire.Nodes.Clear();

            try
            {
                foreach (var drive in Environment.GetLogicalDrives())
                {
                    string display = drive.TrimEnd(Path.DirectorySeparatorChar);
                    var rootNode = new TreeNode(display) { Tag = drive };
                    rootNode.Nodes.Add(new TreeNode("..."));
                    tvRepertoire.Nodes.Add(rootNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la lecture des disques : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TvRepertoire_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            var node = e.Node;
            if (node == null) return;

            if (node.Nodes.Count == 1 && node.Nodes[0].Text == "...")
            {
                node.Nodes.Clear();
                string path = node.Tag as string ?? node.FullPath;
                try
                {
                    var dirs = Directory.GetDirectories(path);
                    foreach (var dir in dirs.OrderBy(d => d))
                    {
                        var dirName = Path.GetFileName(dir);
                        if (string.IsNullOrEmpty(dirName)) dirName = dir;
                        dirName = dirName.Trim();
                        var child = new TreeNode(dirName) { Tag = dir };
                        try
                        {
                            if (Directory.GetDirectories(dir).Length > 0)
                                child.Nodes.Add(new TreeNode("..."));
                        }
                        catch { }
                        node.Nodes.Add(child);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    node.Nodes.Add(new TreeNode("[Accès refusé]"));
                }
                catch (Exception ex)
                {
                    node.Nodes.Add(new TreeNode($"[Erreur: {ex.Message}]"));
                }
            }
        }

        private void TvRepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag as string;
            RemplirListView(path);
        }

        private void RemplirListView(string path)
        {
            lvFichiers.Items.Clear();
            if (string.IsNullOrEmpty(path)) return;

            try
            {
                var dirInfo = new DirectoryInfo(path);
                var files = dirInfo.GetFiles();
                foreach (var f in files.OrderBy(f => f.Name))
                {
                    var item = new ListViewItem(f.Name);
                    item.SubItems.Add($"{f.Length:N0}");
                    item.SubItems.Add(f.CreationTime.ToString());
                    item.SubItems.Add(f.LastWriteTime.ToString());
                    item.Tag = f.FullName;
                    lvFichiers.Items.Add(item);
                }

                slMessage.Text = $"Contenu: {path} ({files.Length} fichier(s))";
            }
            catch (UnauthorizedAccessException)
            {
                slMessage.Text = $"Accès refusé : {path}";
            }
            catch (DirectoryNotFoundException)
            {
                slMessage.Text = $"Dossier introuvable : {path}";
            }
            catch (Exception ex)
            {
                slMessage.Text = $"Erreur lecture : {ex.Message}";
            }
        }

        private void LvFichiers_DoubleClick(object sender, EventArgs e)
        {
            if (lvFichiers.SelectedItems.Count == 0) return;
            var item = lvFichiers.SelectedItems[0];
            var fullPath = item.Tag as string;
            if (!string.IsNullOrEmpty(fullPath) && File.Exists(fullPath))
            {
                try
                {
                    System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{fullPath}\"");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Impossible d'ouvrir le fichier : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TsaPetitesIcones_Click(object sender, EventArgs e) => lvFichiers.View = View.SmallIcon;
        private void TsaGrandesIcones_Click(object sender, EventArgs e) => lvFichiers.View = View.LargeIcon;
        private void TsaListe_Click(object sender, EventArgs e) => lvFichiers.View = View.List;
        private void TsaDetail_Click(object sender, EventArgs e) => lvFichiers.View = View.Details;
    }
}