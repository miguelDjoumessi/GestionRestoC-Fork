namespace PROJET_C__GESTIONRESTO.Views.MenuViews
{
    partial class MenuController
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuController));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnHeader = new Guna.UI2.WinForms.Guna2Panel();
            btnShowMenu = new Guna.UI2.WinForms.Guna2Button();
            lblTheme = new Guna.UI2.WinForms.Guna2HtmlLabel();
            picMenu = new Guna.UI2.WinForms.Guna2PictureBox();
            lblDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnFooter = new Guna.UI2.WinForms.Guna2Panel();
            btnMenu = new Guna.UI2.WinForms.Guna2CircleButton();
            RbDefMenu = new RadioButton();
            ContextMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            Edit = new ToolStripMenuItem();
            delete = new ToolStripMenuItem();
            pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu).BeginInit();
            pnFooter.SuspendLayout();
            ContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(btnShowMenu);
            pnHeader.Controls.Add(lblTheme);
            pnHeader.CustomizableEdges = customizableEdges3;
            pnHeader.Dock = DockStyle.Top;
            pnHeader.FillColor = Color.Black;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnHeader.Size = new Size(240, 41);
            pnHeader.TabIndex = 0;
            // 
            // btnShowMenu
            // 
            btnShowMenu.BackColor = Color.Transparent;
            btnShowMenu.BorderRadius = 9;
            btnShowMenu.CustomizableEdges = customizableEdges1;
            btnShowMenu.DisabledState.BorderColor = Color.DarkGray;
            btnShowMenu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnShowMenu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnShowMenu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnShowMenu.FillColor = Color.Cyan;
            btnShowMenu.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowMenu.ForeColor = Color.Black;
            btnShowMenu.Location = new Point(154, 9);
            btnShowMenu.Name = "btnShowMenu";
            btnShowMenu.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnShowMenu.Size = new Size(78, 21);
            btnShowMenu.TabIndex = 1;
            btnShowMenu.Text = "Afficher";
            btnShowMenu.Click += btnShowMenu_Click;
            // 
            // lblTheme
            // 
            lblTheme.BackColor = Color.Transparent;
            lblTheme.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTheme.ForeColor = SystemColors.ButtonHighlight;
            lblTheme.Location = new Point(15, 10);
            lblTheme.Name = "lblTheme";
            lblTheme.Size = new Size(47, 19);
            lblTheme.TabIndex = 0;
            lblTheme.Text = "THEME";
            // 
            // picMenu
            // 
            picMenu.BackgroundImage = (Image)resources.GetObject("picMenu.BackgroundImage");
            picMenu.BackgroundImageLayout = ImageLayout.Stretch;
            picMenu.CustomizableEdges = customizableEdges5;
            picMenu.FillColor = Color.Transparent;
            picMenu.ImageRotate = 0F;
            picMenu.Location = new Point(0, 39);
            picMenu.Name = "picMenu";
            picMenu.ShadowDecoration.CustomizableEdges = customizableEdges6;
            picMenu.Size = new Size(240, 256);
            picMenu.TabIndex = 1;
            picMenu.TabStop = false;
            picMenu.Click += picMenu_Click;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Black;
            lblDescription.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold);
            lblDescription.ForeColor = Color.Cornsilk;
            lblDescription.Location = new Point(63, 98);
            lblDescription.MaximumSize = new Size(190, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(79, 21);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Description";
            lblDescription.TextAlignment = ContentAlignment.TopCenter;
            // 
            // pnFooter
            // 
            pnFooter.BackColor = Color.Transparent;
            pnFooter.Controls.Add(btnMenu);
            pnFooter.Controls.Add(RbDefMenu);
            pnFooter.CustomizableEdges = customizableEdges8;
            pnFooter.Dock = DockStyle.Bottom;
            pnFooter.FillColor = Color.Black;
            pnFooter.Location = new Point(0, 294);
            pnFooter.Name = "pnFooter";
            pnFooter.ShadowDecoration.CustomizableEdges = customizableEdges9;
            pnFooter.Size = new Size(240, 40);
            pnFooter.TabIndex = 3;
            // 
            // btnMenu
            // 
            btnMenu.CheckedState.FillColor = Color.FromArgb(50, 255, 255, 255);
            btnMenu.CustomImages.CheckedImage = (Image)resources.GetObject("resource.CheckedImage");
            btnMenu.CustomImages.Image = (Image)resources.GetObject("resource.Image");
            btnMenu.CustomImages.ImageAlign = HorizontalAlignment.Center;
            btnMenu.DialogResult = DialogResult.Retry;
            btnMenu.DisabledState.BorderColor = Color.DarkGray;
            btnMenu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMenu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMenu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMenu.FillColor = Color.Transparent;
            btnMenu.Font = new Font("Segoe UI", 9F);
            btnMenu.ForeColor = Color.White;
            btnMenu.HoverState.FillColor = Color.FromArgb(50, 255, 255, 255);
            btnMenu.Location = new Point(205, 6);
            btnMenu.Name = "btnMenu";
            btnMenu.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnMenu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnMenu.Size = new Size(30, 30);
            btnMenu.TabIndex = 1;
            btnMenu.Click += guna2CircleButton1_Click;
            // 
            // RbDefMenu
            // 
            RbDefMenu.AutoSize = true;
            RbDefMenu.ForeColor = Color.White;
            RbDefMenu.Location = new Point(11, 10);
            RbDefMenu.Name = "RbDefMenu";
            RbDefMenu.Size = new Size(97, 19);
            RbDefMenu.TabIndex = 0;
            RbDefMenu.Text = "Menu du jour";
            RbDefMenu.UseVisualStyleBackColor = true;
            RbDefMenu.CheckedChanged += RbDefMenu_CheckedChanged;
            // 
            // ContextMenu
            // 
            ContextMenu.Items.AddRange(new ToolStripItem[] { Edit, delete });
            ContextMenu.Name = "guna2ContextMenuStrip1";
            ContextMenu.RenderStyle.ArrowColor = Color.FromArgb(0, 8, 42, 212);
            ContextMenu.RenderStyle.BorderColor = Color.Gainsboro;
            ContextMenu.RenderStyle.ColorTable = null;
            ContextMenu.RenderStyle.RoundedEdges = true;
            ContextMenu.RenderStyle.SelectionArrowColor = Color.White;
            ContextMenu.RenderStyle.SelectionBackColor = Color.FromArgb(38, 135, 199);
            ContextMenu.RenderStyle.SelectionForeColor = Color.White;
            ContextMenu.RenderStyle.SeparatorColor = Color.Gainsboro;
            ContextMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ContextMenu.Size = new Size(128, 48);
            // 
            // Edit
            // 
            Edit.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Edit.Name = "Edit";
            Edit.Padding = new Padding(3, 1, 0, 1);
            Edit.Size = new Size(130, 22);
            Edit.Text = "Editer";
            Edit.Click += Edit_Click;
            // 
            // delete
            // 
            delete.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete.Name = "delete";
            delete.Size = new Size(127, 22);
            delete.Text = "Supprimer";
            delete.Click += delete_Click;
            // 
            // MenuController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDescription);
            Controls.Add(pnFooter);
            Controls.Add(picMenu);
            Controls.Add(pnHeader);
            Name = "MenuController";
            Size = new Size(240, 334);
            Load += MenuController_Load;
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu).EndInit();
            pnFooter.ResumeLayout(false);
            pnFooter.PerformLayout();
            ContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTheme;
        private Guna.UI2.WinForms.Guna2PictureBox picMenu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescription;
        private Guna.UI2.WinForms.Guna2Panel pnFooter;
        private RadioButton RbDefMenu;
        private Guna.UI2.WinForms.Guna2CircleButton btnMenu;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextMenu;
        private ToolStripMenuItem Edit;
        private ToolStripMenuItem delete;
        private Guna.UI2.WinForms.Guna2Button btnShowMenu;
    }
}
