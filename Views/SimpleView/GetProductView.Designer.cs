namespace PROJET_C__GESTIONRESTO.Views.SimpleView
{
    partial class GetProductView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblListEmpty = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            btnValide = new Guna.UI2.WinForms.Guna2Button();
            LpProducts = new FlowLayoutPanel();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            txtSearchbar = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 8;
            guna2Panel1.Controls.Add(lblListEmpty);
            guna2Panel1.Controls.Add(btnClose);
            guna2Panel1.Controls.Add(btnValide);
            guna2Panel1.Controls.Add(LpProducts);
            guna2Panel1.Controls.Add(guna2Separator1);
            guna2Panel1.Controls.Add(txtSearchbar);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.Color = Color.FromArgb(89, 89, 89);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.ShadowDecoration.Enabled = true;
            guna2Panel1.ShadowDecoration.Shadow = new Padding(8, 0, 8, 8);
            guna2Panel1.Size = new Size(516, 605);
            guna2Panel1.TabIndex = 0;
            // 
            // lblListEmpty
            // 
            lblListEmpty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblListEmpty.BackColor = Color.Transparent;
            lblListEmpty.Font = new Font("Montserrat", 15.7999973F, FontStyle.Bold);
            lblListEmpty.ForeColor = Color.FromArgb(189, 190, 188);
            lblListEmpty.Location = new Point(141, 274);
            lblListEmpty.Name = "lblListEmpty";
            lblListEmpty.Size = new Size(235, 31);
            lblListEmpty.TabIndex = 8;
            lblListEmpty.Text = "Liste des Menus Vide";
            lblListEmpty.Visible = false;
            // 
            // btnClose
            // 
            btnClose.BorderRadius = 5;
            btnClose.CustomizableEdges = customizableEdges1;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Black;
            btnClose.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(394, 563);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(101, 28);
            btnClose.TabIndex = 4;
            btnClose.Text = "Annuler";
            btnClose.Click += btnClose_Click;
            // 
            // btnValide
            // 
            btnValide.BorderRadius = 5;
            btnValide.CustomizableEdges = customizableEdges3;
            btnValide.DisabledState.BorderColor = Color.DarkGray;
            btnValide.DisabledState.CustomBorderColor = Color.DarkGray;
            btnValide.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnValide.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnValide.FillColor = Color.FromArgb(77, 77, 255);
            btnValide.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnValide.ForeColor = Color.White;
            btnValide.Location = new Point(288, 563);
            btnValide.Name = "btnValide";
            btnValide.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnValide.Size = new Size(101, 28);
            btnValide.TabIndex = 4;
            btnValide.Text = "Ok";
            btnValide.Click += btnValide_Click;
            // 
            // LpProducts
            // 
            LpProducts.AutoScroll = true;
            LpProducts.Location = new Point(17, 76);
            LpProducts.Name = "LpProducts";
            LpProducts.Size = new Size(481, 475);
            LpProducts.TabIndex = 3;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(17, 59);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(481, 11);
            guna2Separator1.TabIndex = 2;
            // 
            // txtSearchbar
            // 
            txtSearchbar.BorderColor = Color.FromArgb(150, 150, 150);
            txtSearchbar.BorderRadius = 10;
            txtSearchbar.CustomizableEdges = customizableEdges5;
            txtSearchbar.DefaultText = "";
            txtSearchbar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchbar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchbar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchbar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchbar.FocusedState.BorderColor = Color.FromArgb(255, 117, 26);
            txtSearchbar.Font = new Font("Segoe UI", 9F);
            txtSearchbar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchbar.Location = new Point(306, 29);
            txtSearchbar.Name = "txtSearchbar";
            txtSearchbar.Padding = new Padding(10, 5, 0, 0);
            txtSearchbar.PasswordChar = '\0';
            txtSearchbar.PlaceholderText = "Search....??";
            txtSearchbar.SelectedText = "";
            txtSearchbar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSearchbar.Size = new Size(183, 23);
            txtSearchbar.TabIndex = 1;
            txtSearchbar.Leave += txtSearchbar_Leave;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(23, 29);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(126, 23);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Choice products";
            // 
            // GetProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(516, 605);
            Controls.Add(guna2Panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "GetProductView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GetProductView";
            Load += GetProductView_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchbar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private FlowLayoutPanel LpProducts;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnValide;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblListEmpty;
    }
}