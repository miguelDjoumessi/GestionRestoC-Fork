namespace PROJET_C__GESTIONRESTO.Views.MenuViews
{
    partial class MenuItemView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuItemView));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            picDelete = new Guna.UI2.WinForms.Guna2PictureBox();
            lblDescription = new Label();
            lblPrice = new Label();
            lblName = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            picProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 6;
            guna2Panel1.Controls.Add(picDelete);
            guna2Panel1.Controls.Add(lblDescription);
            guna2Panel1.Controls.Add(lblPrice);
            guna2Panel1.Controls.Add(lblName);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(picProduct);
            guna2Panel1.CustomBorderColor = Color.FromArgb(140, 140, 140);
            guna2Panel1.CustomBorderThickness = new Padding(2);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.FillColor = Color.FromArgb(242, 242, 242);
            guna2Panel1.Location = new Point(3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.BorderRadius = 10;
            guna2Panel1.ShadowDecoration.Color = Color.FromArgb(100, 26, 26, 26);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.ShadowDecoration.Depth = 25;
            guna2Panel1.ShadowDecoration.Enabled = true;
            guna2Panel1.ShadowDecoration.Shadow = new Padding(0, 0, 10, 10);
            guna2Panel1.Size = new Size(491, 166);
            guna2Panel1.TabIndex = 0;
            // 
            // picDelete
            // 
            picDelete.BackgroundImage = (Image)resources.GetObject("picDelete.BackgroundImage");
            picDelete.BackgroundImageLayout = ImageLayout.Zoom;
            picDelete.Cursor = Cursors.Hand;
            picDelete.CustomizableEdges = customizableEdges1;
            picDelete.FillColor = Color.Transparent;
            picDelete.ImageRotate = 0F;
            picDelete.Location = new Point(458, 132);
            picDelete.Name = "picDelete";
            picDelete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            picDelete.Size = new Size(25, 25);
            picDelete.TabIndex = 5;
            picDelete.TabStop = false;
            picDelete.Click += picDelete_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(262, 79);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(66, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "description";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(227, 47);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(27, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Prix";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(266, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(188, 79);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 1;
            label3.Text = "Description :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(188, 47);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Prix :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(188, 15);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "Designation :";
            // 
            // picProduct
            // 
            picProduct.BackgroundImage = Properties.Resources.taro;
            picProduct.BackgroundImageLayout = ImageLayout.Stretch;
            picProduct.BorderRadius = 6;
            customizableEdges3.BottomRight = false;
            customizableEdges3.TopRight = false;
            picProduct.CustomizableEdges = customizableEdges3;
            picProduct.FillColor = Color.Transparent;
            picProduct.ImageRotate = 0F;
            picProduct.Location = new Point(4, 3);
            picProduct.Name = "picProduct";
            picProduct.ShadowDecoration.CustomizableEdges = customizableEdges4;
            picProduct.Size = new Size(172, 160);
            picProduct.TabIndex = 0;
            picProduct.TabStop = false;
            // 
            // MenuItemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2Panel1);
            Name = "MenuItemView";
            Size = new Size(506, 180);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox picProduct;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox picDelete;
    }
}
