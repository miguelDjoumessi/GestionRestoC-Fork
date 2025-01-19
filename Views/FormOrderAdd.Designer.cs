namespace PROJET_C__GESTIONRESTO.Views
{
    partial class FormOrderAdd
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label2 = new Label();
            txtQty = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2Panel1.Size = new Size(525, 89);
            // 
            // label1
            // 
            label1.Location = new Point(108, 38);
            label1.Size = new Size(117, 28);
            label1.Text = "Package";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackgroundImage = Properties.Resources.box;
            guna2PictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2PictureBox1.FillColor = Color.Transparent;
            guna2PictureBox1.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Location = new Point(0, 274);
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Panel2.Size = new Size(525, 62);
            guna2Panel2.Paint += guna2Panel2_Paint;
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
            btnSave.Click += btnSave_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 125);
            label2.Name = "label2";
            label2.Size = new Size(102, 30);
            label2.TabIndex = 4;
            label2.Text = "Quantity *";
            // 
            // txtQty
            // 
            txtQty.CustomizableEdges = customizableEdges6;
            txtQty.DefaultText = "";
            txtQty.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtQty.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtQty.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtQty.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtQty.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQty.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQty.ForeColor = Color.Black;
            txtQty.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQty.Location = new Point(65, 161);
            txtQty.Margin = new Padding(6);
            txtQty.Name = "txtQty";
            txtQty.PasswordChar = '\0';
            txtQty.PlaceholderText = "enter the quantity";
            txtQty.SelectedText = "";
            txtQty.ShadowDecoration.CustomizableEdges = customizableEdges7;
            txtQty.Size = new Size(375, 41);
            txtQty.TabIndex = 7;
            // 
            // FormOrderAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 336);
            Controls.Add(txtQty);
            Controls.Add(label2);
            Name = "FormOrderAdd";
            Text = "FormOrderAdd";
            Controls.SetChildIndex(guna2Panel2, 0);
            Controls.SetChildIndex(guna2Panel1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtQty, 0);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            guna2Panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        public Guna.UI2.WinForms.Guna2TextBox txtQty;
    }
}