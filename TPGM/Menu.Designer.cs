
namespace TPGM
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bureauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materielsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartenirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authentificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bureauToolStripMenuItem,
            this.personneToolStripMenuItem,
            this.materielsToolStripMenuItem,
            this.apartenirToolStripMenuItem,
            this.authentificationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bureauToolStripMenuItem
            // 
            this.bureauToolStripMenuItem.Name = "bureauToolStripMenuItem";
            this.bureauToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.bureauToolStripMenuItem.Text = "Bureau";
            this.bureauToolStripMenuItem.Click += new System.EventHandler(this.bureauToolStripMenuItem_Click);
            // 
            // personneToolStripMenuItem
            // 
            this.personneToolStripMenuItem.Name = "personneToolStripMenuItem";
            this.personneToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.personneToolStripMenuItem.Text = "Personne";
            this.personneToolStripMenuItem.Click += new System.EventHandler(this.personneToolStripMenuItem_Click);
            // 
            // materielsToolStripMenuItem
            // 
            this.materielsToolStripMenuItem.Name = "materielsToolStripMenuItem";
            this.materielsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.materielsToolStripMenuItem.Text = "Materiels";
            this.materielsToolStripMenuItem.Click += new System.EventHandler(this.materielsToolStripMenuItem_Click);
            // 
            // apartenirToolStripMenuItem
            // 
            this.apartenirToolStripMenuItem.Name = "apartenirToolStripMenuItem";
            this.apartenirToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.apartenirToolStripMenuItem.Text = "Apartenir";
            // 
            // authentificationToolStripMenuItem
            // 
            this.authentificationToolStripMenuItem.Name = "authentificationToolStripMenuItem";
            this.authentificationToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.authentificationToolStripMenuItem.Text = "Authentification";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TPGM.Properties.Resources.blue_backgrounds_solid_light_65833_2048x1152;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 461);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bureauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materielsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apartenirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authentificationToolStripMenuItem;
    }
}