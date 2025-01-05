namespace PROJET_C__GESTIONRESTO.Views.SimpleView
{
    partial class orderModal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderModal));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnHeader = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            pId = new DataGridViewTextBoxColumn();
            pName = new DataGridViewTextBoxColumn();
            pPrice = new DataGridViewTextBoxColumn();
            pCat = new DataGridViewTextBoxColumn();
            pCatId = new DataGridViewTextBoxColumn();
            pAction = new DataGridViewImageColumn();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            pSId = new DataGridViewTextBoxColumn();
            pDesignation = new DataGridViewTextBoxColumn();
            pSPrice = new DataGridViewTextBoxColumn();
            pSQty = new DataGridViewTextBoxColumn();
            pSCat = new DataGridViewTextBoxColumn();
            pSDel = new DataGridViewTextBoxColumn();
            pSCatId = new DataGridViewTextBoxColumn();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            gBType = new GroupBox();
            RadBtnDeliver = new RadioButton();
            RadBtnOut = new RadioButton();
            RadbtnHere = new RadioButton();
            gBClient = new GroupBox();
            comboTable = new ComboBox();
            txtPhone = new TextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnHeader.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            guna2Panel1.SuspendLayout();
            gBType.SuspendLayout();
            gBClient.SuspendLayout();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(label1);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(1373, 45);
            pnHeader.TabIndex = 2;
            pnHeader.MouseDown += pnHeader_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 5);
            label1.Name = "label1";
            label1.Size = new Size(128, 33);
            label1.TabIndex = 1;
            label1.Text = "New Order";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoScrollMinSize = new Size(3, 0);
            panel2.BackColor = Color.White;
            panel2.Controls.Add(guna2Separator1);
            panel2.Controls.Add(guna2DataGridView2);
            panel2.Controls.Add(guna2DataGridView1);
            panel2.Controls.Add(guna2Button3);
            panel2.Controls.Add(guna2HtmlLabel1);
            panel2.Controls.Add(guna2TextBox1);
            panel2.Controls.Add(guna2Panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(1373, 814);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(17, 72);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(850, 21);
            guna2Separator1.TabIndex = 9;
            // 
            // guna2DataGridView2
            // 
            guna2DataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(10, 10, 10);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 193, 38);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView2.ColumnHeadersHeight = 33;
            guna2DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView2.Columns.AddRange(new DataGridViewColumn[] { pId, pName, pPrice, pCat, pCatId, pAction });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(61, 228, 179);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView2.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView2.Location = new Point(17, 105);
            guna2DataGridView2.Name = "guna2DataGridView2";
            guna2DataGridView2.ReadOnly = true;
            guna2DataGridView2.RowHeadersVisible = false;
            guna2DataGridView2.RowHeadersWidth = 51;
            guna2DataGridView2.ScrollBars = ScrollBars.Vertical;
            guna2DataGridView2.Size = new Size(850, 346);
            guna2DataGridView2.TabIndex = 8;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 33;
            guna2DataGridView2.ThemeStyle.ReadOnly = true;
            guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView2.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView2.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // pId
            // 
            pId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            pId.FillWeight = 187.165771F;
            pId.HeaderText = "Sr#";
            pId.MinimumWidth = 60;
            pId.Name = "pId";
            pId.ReadOnly = true;
            pId.Width = 70;
            // 
            // pName
            // 
            pName.FillWeight = 24.0641727F;
            pName.HeaderText = "designation";
            pName.MinimumWidth = 6;
            pName.Name = "pName";
            pName.ReadOnly = true;
            // 
            // pPrice
            // 
            pPrice.FillWeight = 24.0641727F;
            pPrice.HeaderText = "Price";
            pPrice.MinimumWidth = 6;
            pPrice.Name = "pPrice";
            pPrice.ReadOnly = true;
            // 
            // pCat
            // 
            pCat.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            pCat.FillWeight = 240.641739F;
            pCat.HeaderText = "Category";
            pCat.MinimumWidth = 40;
            pCat.Name = "pCat";
            pCat.ReadOnly = true;
            pCat.Width = 180;
            // 
            // pCatId
            // 
            pCatId.HeaderText = "";
            pCatId.MinimumWidth = 6;
            pCatId.Name = "pCatId";
            pCatId.ReadOnly = true;
            pCatId.Visible = false;
            // 
            // pAction
            // 
            pAction.FillWeight = 24.0641727F;
            pAction.HeaderText = "";
            pAction.Image = Properties.Resources.plus;
            pAction.ImageLayout = DataGridViewImageCellLayout.Zoom;
            pAction.MinimumWidth = 6;
            pAction.Name = "pAction";
            pAction.ReadOnly = true;
            pAction.Resizable = DataGridViewTriState.True;
            pAction.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(40, 19, 2);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle5.Padding = new Padding(5, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(233, 48, 48);
            dataGridViewCellStyle5.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            guna2DataGridView1.ColumnHeadersHeight = 33;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { pSId, pDesignation, pSPrice, pSQty, pSCat, pSDel, pSCatId });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(216, 213, 207);
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(226, 14, 30);
            dataGridViewCellStyle6.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(15, 481);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.ReadOnly = true;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.ScrollBars = ScrollBars.Vertical;
            guna2DataGridView1.ShowCellToolTips = false;
            guna2DataGridView1.Size = new Size(856, 321);
            guna2DataGridView1.TabIndex = 7;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 33;
            guna2DataGridView1.ThemeStyle.ReadOnly = true;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // pSId
            // 
            pSId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            pSId.HeaderText = "Sr#";
            pSId.MinimumWidth = 50;
            pSId.Name = "pSId";
            pSId.ReadOnly = true;
            pSId.Width = 60;
            // 
            // pDesignation
            // 
            pDesignation.HeaderText = "Designation";
            pDesignation.MinimumWidth = 100;
            pDesignation.Name = "pDesignation";
            pDesignation.ReadOnly = true;
            // 
            // pSPrice
            // 
            pSPrice.HeaderText = "Price";
            pSPrice.MinimumWidth = 6;
            pSPrice.Name = "pSPrice";
            pSPrice.ReadOnly = true;
            // 
            // pSQty
            // 
            pSQty.HeaderText = "Quantity";
            pSQty.MinimumWidth = 6;
            pSQty.Name = "pSQty";
            pSQty.ReadOnly = true;
            // 
            // pSCat
            // 
            pSCat.HeaderText = "Category";
            pSCat.MinimumWidth = 6;
            pSCat.Name = "pSCat";
            pSCat.ReadOnly = true;
            // 
            // pSDel
            // 
            pSDel.HeaderText = "";
            pSDel.MinimumWidth = 6;
            pSDel.Name = "pSDel";
            pSDel.ReadOnly = true;
            // 
            // pSCatId
            // 
            pSCatId.HeaderText = "";
            pSCatId.MinimumWidth = 6;
            pSCatId.Name = "pSCatId";
            pSCatId.ReadOnly = true;
            pSCatId.Visible = false;
            // 
            // guna2Button3
            // 
            guna2Button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button3.AutoRoundedCorners = true;
            guna2Button3.BorderRadius = 17;
            guna2Button3.Cursor = Cursors.Hand;
            guna2Button3.CustomImages.CheckedImage = (Image)resources.GetObject("resource.CheckedImage");
            guna2Button3.CustomImages.HoveredImage = (Image)resources.GetObject("resource.HoveredImage");
            guna2Button3.CustomImages.Image = (Image)resources.GetObject("resource.Image");
            guna2Button3.CustomImages.ImageOffset = new Point(10, 0);
            guna2Button3.CustomImages.ImageSize = new Size(30, 30);
            customizableEdges1.BottomLeft = false;
            customizableEdges1.TopLeft = false;
            guna2Button3.CustomizableEdges = customizableEdges1;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.FromArgb(255, 51, 51);
            guna2Button3.Font = new Font("Segoe UI", 9F);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.HoverState.FillColor = Color.Black;
            guna2Button3.ImageSize = new Size(30, 30);
            guna2Button3.Location = new Point(803, 26);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.PressedColor = SystemColors.AppWorkspace;
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button3.Size = new Size(64, 37);
            guna2Button3.TabIndex = 6;
            guna2Button3.TextAlign = HorizontalAlignment.Left;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe Print", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = SystemColors.ControlDarkDark;
            guna2HtmlLabel1.Location = new Point(17, 23);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(148, 40);
            guna2HtmlLabel1.TabIndex = 5;
            guna2HtmlLabel1.Text = "Products List";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox1.BorderRadius = 20;
            customizableEdges3.BottomRight = false;
            customizableEdges3.TopRight = false;
            guna2TextBox1.CustomizableEdges = customizableEdges3;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(567, 26);
            guna2TextBox1.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "search...";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox1.Size = new Size(236, 37);
            guna2TextBox1.TabIndex = 4;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(guna2Button2);
            guna2Panel1.Controls.Add(guna2Button1);
            guna2Panel1.Controls.Add(gBType);
            guna2Panel1.Controls.Add(gBClient);
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.Dock = DockStyle.Right;
            guna2Panel1.Location = new Point(889, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel1.Size = new Size(484, 814);
            guna2Panel1.TabIndex = 2;
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 20;
            guna2Button2.CustomizableEdges = customizableEdges5;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Orange;
            guna2Button2.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(134, 392);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button2.Size = new Size(161, 43);
            guna2Button2.TabIndex = 2;
            guna2Button2.Text = "Exit";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 20;
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(95, 190, 31);
            guna2Button1.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(304, 392);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new Size(156, 43);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "Save";
            // 
            // gBType
            // 
            gBType.Controls.Add(RadBtnDeliver);
            gBType.Controls.Add(RadBtnOut);
            gBType.Controls.Add(RadbtnHere);
            gBType.Location = new Point(13, 21);
            gBType.Name = "gBType";
            gBType.Size = new Size(447, 85);
            gBType.TabIndex = 0;
            gBType.TabStop = false;
            gBType.Text = "Type";
            // 
            // RadBtnDeliver
            // 
            RadBtnDeliver.AutoSize = true;
            RadBtnDeliver.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            RadBtnDeliver.Location = new Point(340, 36);
            RadBtnDeliver.Name = "RadBtnDeliver";
            RadBtnDeliver.Size = new Size(84, 27);
            RadBtnDeliver.TabIndex = 0;
            RadBtnDeliver.TabStop = true;
            RadBtnDeliver.Text = "Deliver";
            RadBtnDeliver.UseVisualStyleBackColor = true;
            // 
            // RadBtnOut
            // 
            RadBtnOut.AutoSize = true;
            RadBtnOut.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            RadBtnOut.Location = new Point(179, 36);
            RadBtnOut.Name = "RadBtnOut";
            RadBtnOut.Size = new Size(109, 27);
            RadBtnOut.TabIndex = 0;
            RadBtnOut.TabStop = true;
            RadBtnOut.Text = "take away";
            RadBtnOut.UseVisualStyleBackColor = true;
            // 
            // RadbtnHere
            // 
            RadbtnHere.AutoSize = true;
            RadbtnHere.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            RadbtnHere.Location = new Point(28, 36);
            RadbtnHere.Name = "RadbtnHere";
            RadbtnHere.Size = new Size(94, 27);
            RadbtnHere.TabIndex = 0;
            RadbtnHere.TabStop = true;
            RadbtnHere.Text = "eat here";
            RadbtnHere.UseVisualStyleBackColor = true;
            // 
            // gBClient
            // 
            gBClient.Controls.Add(comboTable);
            gBClient.Controls.Add(txtPhone);
            gBClient.Controls.Add(txtSurname);
            gBClient.Controls.Add(txtName);
            gBClient.Controls.Add(label5);
            gBClient.Controls.Add(label4);
            gBClient.Controls.Add(label3);
            gBClient.Controls.Add(label2);
            gBClient.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            gBClient.Location = new Point(13, 122);
            gBClient.Name = "gBClient";
            gBClient.Size = new Size(447, 249);
            gBClient.TabIndex = 0;
            gBClient.TabStop = false;
            gBClient.Text = "Client";
            // 
            // comboTable
            // 
            comboTable.Enabled = false;
            comboTable.FormattingEnabled = true;
            comboTable.Location = new Point(121, 198);
            comboTable.Name = "comboTable";
            comboTable.Size = new Size(312, 28);
            comboTable.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(121, 146);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "phone";
            txtPhone.Size = new Size(312, 27);
            txtPhone.TabIndex = 1;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(121, 93);
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "surname";
            txtSurname.Size = new Size(312, 27);
            txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(121, 38);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "name";
            txtName.Size = new Size(312, 27);
            txtName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(26, 206);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 0;
            label5.Text = "Table *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(26, 146);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 0;
            label4.Text = "tel *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(26, 93);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 0;
            label3.Text = "Prenom *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(26, 45);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 0;
            label2.Text = "Nom *";
            // 
            // orderModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 859);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(pnHeader);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MinimumSize = new Size(1300, 800);
            Name = "orderModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "orderModal";
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            guna2Panel1.ResumeLayout(false);
            gBType.ResumeLayout(false);
            gBType.PerformLayout();
            gBClient.ResumeLayout(false);
            gBClient.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel pnHeader;
        private Label label1;
        private Panel panel2;
        private GroupBox gBClient;
        private GroupBox gBType;
        private RadioButton RadbtnHere;
        private RadioButton RadBtnDeliver;
        private RadioButton RadBtnOut;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboTable;
        private TextBox txtPhone;
        private TextBox txtSurname;
        private TextBox txtName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private DataGridViewTextBoxColumn pSId;
        private DataGridViewTextBoxColumn pDesignation;
        private DataGridViewTextBoxColumn pSPrice;
        private DataGridViewTextBoxColumn pSQty;
        private DataGridViewTextBoxColumn pSCat;
        private DataGridViewTextBoxColumn pSDel;
        private DataGridViewTextBoxColumn pSCatId;
        public Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        public Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private DataGridViewTextBoxColumn pId;
        private DataGridViewTextBoxColumn pName;
        private DataGridViewTextBoxColumn pPrice;
        private DataGridViewTextBoxColumn pCat;
        private DataGridViewTextBoxColumn pCatId;
        private DataGridViewImageColumn pAction;
    }
}