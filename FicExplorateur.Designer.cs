namespace WinFormsApp1
{
    partial class FicExplorateur
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {   
            this.components = new System.ComponentModel.Container();
            this.tsCommandes = new System.Windows.Forms.ToolStrip();
            this.tsbQuitter = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbApparence = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsaPetitesIcones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsaGrandesIcones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsaListe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsaDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMessage = new System.Windows.Forms.StatusStrip();
            this.slMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.scSeparateur = new System.Windows.Forms.SplitContainer();
            this.tvRepertoire = new System.Windows.Forms.TreeView();
            this.ilTree = new System.Windows.Forms.ImageList(this.components);
            this.panelRight = new System.Windows.Forms.Panel();
            this.lvFichiers = new System.Windows.Forms.ListView();
            this.chNom = new System.Windows.Forms.ColumnHeader();
            this.chTaille = new System.Windows.Forms.ColumnHeader();
            this.chCreation = new System.Windows.Forms.ColumnHeader();
            this.chModification = new System.Windows.Forms.ColumnHeader();
            this.ilPetit = new System.Windows.Forms.ImageList(this.components);
            this.ilGrand = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scSeparateur)).BeginInit();
            this.scSeparateur.Panel1.SuspendLayout();
            this.scSeparateur.Panel2.SuspendLayout();
            this.scSeparateur.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.ssMessage.SuspendLayout();
            this.tsCommandes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsCommandes
            // 
            this.tsCommandes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQuitter,
            this.tsSeparator,
            this.tsddbApparence});
            this.tsCommandes.Location = new System.Drawing.Point(0, 0);
            this.tsCommandes.Name = "tsCommandes";
            this.tsCommandes.Size = new System.Drawing.Size(900, 27);
            this.tsCommandes.TabIndex = 0;
            // 
            // tsbQuitter
            // 
            this.tsbQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbQuitter.Name = "tsbQuitter";
            this.tsbQuitter.Size = new System.Drawing.Size(52, 24);
            this.tsbQuitter.Text = "Quitter";
            this.tsbQuitter.Click += new System.EventHandler(this.TsbQuitter_Click);
            // 
            // tsSeparator
            // 
            this.tsSeparator.Name = "tsSeparator";
            this.tsSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // tsddbApparence
            // 
            this.tsddbApparence.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsaPetitesIcones,
            this.tsaGrandesIcones,
            this.tsaListe,
            this.tsaDetail});
            this.tsddbApparence.Name = "tsddbApparence";
            this.tsddbApparence.Size = new System.Drawing.Size(88, 24);
            this.tsddbApparence.Text = "Apparence";
            // 
            // tsaPetitesIcones
            // 
            this.tsaPetitesIcones.Name = "tsaPetitesIcones";
            this.tsaPetitesIcones.Size = new System.Drawing.Size(187, 26);
            this.tsaPetitesIcones.Text = "Petites icônes";
            this.tsaPetitesIcones.Click += new System.EventHandler(this.TsaPetitesIcones_Click);
            // 
            // tsaGrandesIcones
            // 
            this.tsaGrandesIcones.Name = "tsaGrandesIcones";
            this.tsaGrandesIcones.Size = new System.Drawing.Size(187, 26);
            this.tsaGrandesIcones.Text = "Grandes icônes";
            this.tsaGrandesIcones.Click += new System.EventHandler(this.TsaGrandesIcones_Click);
            // 
            // tsaListe
            // 
            this.tsaListe.Name = "tsaListe";
            this.tsaListe.Size = new System.Drawing.Size(187, 26);
            this.tsaListe.Text = "Liste";
            this.tsaListe.Click += new System.EventHandler(this.TsaListe_Click);
            // 
            // tsaDetail
            // 
            this.tsaDetail.Name = "tsaDetail";
            this.tsaDetail.Size = new System.Drawing.Size(187, 26);
            this.tsaDetail.Text = "Détails";
            this.tsaDetail.Click += new System.EventHandler(this.TsaDetail_Click);
            // 
            // ssMessage
            // 
            this.ssMessage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slMessage});
            this.ssMessage.Location = new System.Drawing.Point(0, 493);
            this.ssMessage.Name = "ssMessage";
            this.ssMessage.Size = new System.Drawing.Size(900, 26);
            this.ssMessage.TabIndex = 1;
            // 
            // slMessage
            // 
            this.slMessage.Name = "slMessage";
            this.slMessage.Size = new System.Drawing.Size(37, 20);
            this.slMessage.Text = "Prêt";
            // 
            // scSeparateur
            // 
            this.scSeparateur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSeparateur.Location = new System.Drawing.Point(0, 27);
            this.scSeparateur.Name = "scSeparateur";
            // 
            // scSeparateur.Panel1
            // 
            this.scSeparateur.Panel1.Controls.Add(this.tvRepertoire);
            // 
            // scSeparateur.Panel2
            // 
            this.scSeparateur.Panel2.Controls.Add(this.panelRight);
            this.scSeparateur.Size = new System.Drawing.Size(900, 466);
            this.scSeparateur.SplitterDistance = 300;
            this.scSeparateur.TabIndex = 2;
            // 
            // tvRepertoire
            // 
            this.tvRepertoire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRepertoire.HideSelection = false;
            this.tvRepertoire.ImageIndex = 0;
            this.tvRepertoire.ImageList = this.ilTree;
            this.tvRepertoire.Location = new System.Drawing.Point(0, 0);
            this.tvRepertoire.Name = "tvRepertoire";
            this.tvRepertoire.Size = new System.Drawing.Size(300, 466);
            this.tvRepertoire.TabIndex = 0;
            this.tvRepertoire.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TvRepertoire_BeforeExpand);
            this.tvRepertoire.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvRepertoire_AfterSelect);
            // 
            // ilTree
            // 
            this.ilTree.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilTree.ImageSize = new System.Drawing.Size(16, 16);
            this.ilTree.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.lvFichiers);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(596, 466);
            this.panelRight.TabIndex = 0;
            // 
            // lvFichiers
            // 
            this.lvFichiers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNom,
            this.chTaille,
            this.chCreation,
            this.chModification});
            this.lvFichiers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFichiers.FullRowSelect = true;
            this.lvFichiers.HideSelection = false;
            this.lvFichiers.Location = new System.Drawing.Point(0, 0);
            this.lvFichiers.Name = "lvFichiers";
            this.lvFichiers.Size = new System.Drawing.Size(596, 466);
            this.lvFichiers.TabIndex = 0;
            this.lvFichiers.UseCompatibleStateImageBehavior = false;
            this.lvFichiers.View = System.Windows.Forms.View.Details;
            this.lvFichiers.DoubleClick += new System.EventHandler(this.LvFichiers_DoubleClick);
            // 
            // chNom
            // 
            this.chNom.Text = "Nom";
            this.chNom.Width = 300;
            // 
            // chTaille
            // 
            this.chTaille.Text = "Taille";
            this.chTaille.Width = 100;
            // 
            // chCreation
            // 
            this.chCreation.Text = "Création";
            this.chCreation.Width = 150;
            // 
            // chModification
            // 
            this.chModification.Text = "Modification";
            this.chModification.Width = 150;
            // 
            // ilPetit
            // 
            this.ilPetit.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilPetit.ImageSize = new System.Drawing.Size(16, 16);
            this.ilPetit.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilGrand
            // 
            this.ilGrand.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilGrand.ImageSize = new System.Drawing.Size(32, 32);
            this.ilGrand.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FicExplorateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.ClientSize = new System.Drawing.Size(900, 519);
            this.Controls.Add(this.scSeparateur);
            this.Controls.Add(this.tsCommandes);
            this.Controls.Add(this.ssMessage);
            this.Name = "FicExplorateur";
            this.Text = "Explorateur Windows";
            this.Load += new System.EventHandler(this.FicExplorateur_Load);
            this.scSeparateur.Panel1.ResumeLayout(false);
            this.scSeparateur.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSeparateur)).EndInit();
            this.scSeparateur.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ssMessage.ResumeLayout(false);
            this.ssMessage.PerformLayout();
            this.tsCommandes.ResumeLayout(false);
            this.tsCommandes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCommandes;
        private System.Windows.Forms.ToolStripButton tsbQuitter;
        private System.Windows.Forms.ToolStripSeparator tsSeparator;
        private System.Windows.Forms.ToolStripDropDownButton tsddbApparence;
        private System.Windows.Forms.ToolStripMenuItem tsaPetitesIcones;
        private System.Windows.Forms.ToolStripMenuItem tsaGrandesIcones;
        private System.Windows.Forms.ToolStripMenuItem tsaListe;
        private System.Windows.Forms.ToolStripMenuItem tsaDetail;
        private System.Windows.Forms.StatusStrip ssMessage;
        private System.Windows.Forms.ToolStripStatusLabel slMessage;
        private System.Windows.Forms.SplitContainer scSeparateur;
        private System.Windows.Forms.TreeView tvRepertoire;
        private System.Windows.Forms.ImageList ilTree;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.ListView lvFichiers;
        private System.Windows.Forms.ColumnHeader chNom;
        private System.Windows.Forms.ColumnHeader chTaille;
        private System.Windows.Forms.ColumnHeader chCreation;
        private System.Windows.Forms.ColumnHeader chModification;
        private System.Windows.Forms.ImageList ilPetit;
        private System.Windows.Forms.ImageList ilGrand;
    }
}