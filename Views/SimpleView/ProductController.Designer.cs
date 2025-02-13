namespace PROJET_C__GESTIONRESTO.Views.SimpleView
{
    partial class ProductController
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            chkbSelection = new Guna.UI2.WinForms.Guna2CheckBox();
            lblDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            picImage = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 6;
            guna2Panel1.Controls.Add(chkbSelection);
            guna2Panel1.Controls.Add(lblDescription);
            guna2Panel1.Controls.Add(lblPrice);
            guna2Panel1.Controls.Add(lblName);
            guna2Panel1.Controls.Add(guna2HtmlLabel3);
            guna2Panel1.Controls.Add(guna2HtmlLabel2);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.Controls.Add(picImage);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(3, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.Color = Color.FromArgb(77, 77, 77);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.ShadowDecoration.Enabled = true;
            guna2Panel1.Size = new Size(210, 265);
            guna2Panel1.TabIndex = 0;
            guna2Panel1.MouseClick += guna2Panel1_MouseClick;
            // 
            // chkbSelection
            // 
            chkbSelection.AutoSize = true;
            chkbSelection.CheckedState.BorderRadius = 0;
            chkbSelection.CheckedState.BorderThickness = 0;
            chkbSelection.CheckedState.FillColor = Color.FromArgb(255, 140, 26);
            chkbSelection.Location = new Point(182, 242);
            chkbSelection.Name = "chkbSelection";
            chkbSelection.Size = new Size(15, 14);
            chkbSelection.TabIndex = 5;
            chkbSelection.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkbSelection.UncheckedState.BorderRadius = 0;
            chkbSelection.UncheckedState.BorderThickness = 0;
            chkbSelection.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            chkbSelection.CheckedChanged += chkbSelection_CheckedChanged;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Transparent;
            lblDescription.ForeColor = Color.DimGray;
            lblDescription.Location = new Point(35, 208);
            lblDescription.MaximumSize = new Size(40, 17);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(40, 17);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Location = new Point(46, 156);
            lblPrice.MaximumSize = new Size(50, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(29, 17);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "price";
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.Location = new Point(89, 128);
            lblName.MaximumSize = new Size(100, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(33, 17);
            lblName.TabIndex = 2;
            lblName.Text = "name";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel3.Location = new Point(9, 185);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(73, 17);
            guna2HtmlLabel3.TabIndex = 1;
            guna2HtmlLabel3.Text = "Description :";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel2.Location = new Point(9, 156);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(31, 17);
            guna2HtmlLabel2.TabIndex = 1;
            guna2HtmlLabel2.Text = "Prix :";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel1.Location = new Point(9, 128);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(75, 17);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Designation :";
            // 
            // picImage
            // 
            picImage.BackgroundImage = Properties.Resources.taro1;
            picImage.BackgroundImageLayout = ImageLayout.Stretch;
            picImage.CustomizableEdges = customizableEdges1;
            picImage.ErrorImage = Properties.Resources.dairy_products;
            picImage.FillColor = Color.Transparent;
            picImage.ImageRotate = 0F;
            picImage.Location = new Point(2, 1);
            picImage.Name = "picImage";
            picImage.ShadowDecoration.CustomizableEdges = customizableEdges2;
            picImage.Size = new Size(208, 121);
            picImage.TabIndex = 0;
            picImage.TabStop = false;
            // 
            // ProductController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2Panel1);
            Name = "ProductController";
            Size = new Size(222, 278);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox picImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CheckBox chkbSelection;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblDescription;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblName;
    }
}
