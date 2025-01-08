namespace PROJET_C__GESTIONRESTO.Views
{
    partial class FormCategoryAdd
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoryAdd));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label2 = new Label();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2Panel1.Size = new Size(528, 116);
            // 
            // label1
            // 
            label1.Location = new Point(132, 46);
            label1.Size = new Size(177, 28);
            label1.Text = "new Category";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackgroundImage = (Image)resources.GetObject("guna2PictureBox1.BackgroundImage");
            guna2PictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2PictureBox1.FillColor = Color.Empty;
            guna2PictureBox1.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            guna2PictureBox1.Location = new Point(11, 11);
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(104, 94);
            // 
            // guna2Panel2
            // 
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Panel2.Size = new Size(528, 62);
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.None;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.None;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(87, 162);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.CustomizableEdges = customizableEdges6;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.Black;
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(87, 200);
            txtName.Margin = new Padding(6, 6, 6, 6);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "ex: fruit";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges7;
            txtName.Size = new Size(317, 40);
            txtName.TabIndex = 6;
            // 
            // FormCategoryAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 360);
            Controls.Add(txtName);
            Controls.Add(label2);
            Name = "FormCategoryAdd";
            Text = "FormCategoryAdd";
            Controls.SetChildIndex(guna2Panel2, 0);
            Controls.SetChildIndex(guna2Panel1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtName, 0);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            guna2Panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
    }
}