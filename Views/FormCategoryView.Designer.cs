namespace PROJET_C__GESTIONRESTO.Views
{
    partial class FormCategoryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoryView));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            Id = new DataGridViewTextBoxColumn();
            cId = new DataGridViewTextBoxColumn();
            cName = new DataGridViewTextBoxColumn();
            cEdit = new DataGridViewImageColumn();
            cDelete = new DataGridViewImageColumn();
            lblCounter = new Label();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(590, 110);
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges1;
            // 
            // btnAdd
            // 
            btnAdd.CheckedState.ImageSize = new Size(64, 64);
            btnAdd.DialogResult = DialogResult.None;
            btnAdd.HoverState.ImageSize = new Size(58, 58);
            btnAdd.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            btnAdd.Location = new Point(38, 89);
            btnAdd.PressedState.ImageSize = new Size(55, 55);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            // 
            // label2
            // 
            label2.Location = new Point(50, 43);
            label2.Size = new Size(164, 28);
            label2.Text = "Category List";
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button1.CustomImages.CheckedImage = (Image)resources.GetObject("resource.CheckedImage");
            guna2Button1.CustomImages.HoveredImage = (Image)resources.GetObject("resource.HoveredImage");
            guna2Button1.CustomImages.Image = (Image)resources.GetObject("resource.Image");
            guna2Button1.CustomImages.ImageAlign = HorizontalAlignment.Center;
            guna2Button1.CustomImages.ImageOffset = new Point(0, -5);
            guna2Button1.CustomImages.ImageSize = new Size(30, 30);
            guna2Button1.DialogResult = DialogResult.None;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.HoverState.FillColor = Color.Orange;
            guna2Button1.Location = new Point(849, 110);
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 20, 20);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCategory.ColumnHeadersHeight = 40;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { Id, cId, cName, cEdit, cDelete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCategory.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCategory.GridColor = Color.FromArgb(231, 229, 255);
            dgvCategory.Location = new Point(49, 251);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCategory.RowHeadersVisible = false;
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.Size = new Size(880, 384);
            dgvCategory.TabIndex = 6;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvCategory.ThemeStyle.BackColor = Color.White;
            dgvCategory.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvCategory.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(20, 20, 20);
            dgvCategory.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCategory.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvCategory.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvCategory.ThemeStyle.HeaderStyle.Height = 40;
            dgvCategory.ThemeStyle.ReadOnly = true;
            dgvCategory.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCategory.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategory.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvCategory.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvCategory.ThemeStyle.RowsStyle.Height = 29;
            dgvCategory.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvCategory.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.FillWeight = 80F;
            Id.HeaderText = "Sr#";
            Id.MinimumWidth = 100;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 110;
            // 
            // cId
            // 
            cId.HeaderText = "";
            cId.MinimumWidth = 6;
            cId.Name = "cId";
            cId.ReadOnly = true;
            cId.Visible = false;
            // 
            // cName
            // 
            cName.FillWeight = 79.37956F;
            cName.HeaderText = "Name";
            cName.MinimumWidth = 6;
            cName.Name = "cName";
            cName.ReadOnly = true;
            // 
            // cEdit
            // 
            cEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cEdit.FillWeight = 50F;
            cEdit.HeaderText = "";
            cEdit.Image = (Image)resources.GetObject("cEdit.Image");
            cEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            cEdit.MinimumWidth = 50;
            cEdit.Name = "cEdit";
            cEdit.ReadOnly = true;
            cEdit.Resizable = DataGridViewTriState.True;
            cEdit.SortMode = DataGridViewColumnSortMode.Automatic;
            cEdit.Width = 50;
            // 
            // cDelete
            // 
            cDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cDelete.FillWeight = 91.2408752F;
            cDelete.HeaderText = "";
            cDelete.Image = (Image)resources.GetObject("cDelete.Image");
            cDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            cDelete.MinimumWidth = 50;
            cDelete.Name = "cDelete";
            cDelete.ReadOnly = true;
            cDelete.Resizable = DataGridViewTriState.True;
            cDelete.SortMode = DataGridViewColumnSortMode.Automatic;
            cDelete.Width = 50;
            // 
            // lblCounter
            // 
            lblCounter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCounter.AutoSize = true;
            lblCounter.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCounter.Location = new Point(848, 209);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(25, 27);
            lblCounter.TabIndex = 8;
            lblCounter.Text = "1";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2PictureBox1.BackgroundImage = (Image)resources.GetObject("guna2PictureBox1.BackgroundImage");
            guna2PictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2PictureBox1.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.FillColor = Color.Empty;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(875, 201);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2PictureBox1.Size = new Size(54, 41);
            guna2PictureBox1.TabIndex = 9;
            guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            guna2PictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2PictureBox2.BackgroundImage = (Image)resources.GetObject("guna2PictureBox2.BackgroundImage");
            guna2PictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            guna2PictureBox2.CustomizableEdges = customizableEdges6;
            guna2PictureBox2.FillColor = Color.Empty;
            guna2PictureBox2.ImageRotate = 0F;
            guna2PictureBox2.Location = new Point(794, 201);
            guna2PictureBox2.Name = "guna2PictureBox2";
            guna2PictureBox2.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2PictureBox2.Size = new Size(48, 41);
            guna2PictureBox2.TabIndex = 10;
            guna2PictureBox2.TabStop = false;
            // 
            // FormCategoryView
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 670);
            Controls.Add(guna2PictureBox2);
            Controls.Add(guna2PictureBox1);
            Controls.Add(lblCounter);
            Controls.Add(dgvCategory);
            Name = "FormCategoryView";
            Text = "FormCategoryView";
            Load += FormCategoryView_Load;
            Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(guna2Button1, 0);
            Controls.SetChildIndex(dgvCategory, 0);
            Controls.SetChildIndex(lblCounter, 0);
            Controls.SetChildIndex(guna2PictureBox1, 0);
            Controls.SetChildIndex(guna2PictureBox2, 0);
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvCategory;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn cId;
        private DataGridViewTextBoxColumn cName;
        private DataGridViewImageColumn cEdit;
        private DataGridViewImageColumn cDelete;
        private Label lblCounter;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}