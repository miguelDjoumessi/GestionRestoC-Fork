namespace PROJET_C__GESTIONRESTO.Views.MenuViews
{
    partial class MenuDash
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
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            LPanelMenu = new FlowLayoutPanel();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Montserrat SemiBold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(29, 23);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(73, 35);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Menu";
            // 
            // guna2Separator1
            // 
            guna2Separator1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Separator1.Location = new Point(29, 64);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(874, 10);
            guna2Separator1.TabIndex = 2;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox1.BorderRadius = 11;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(703, 34);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.Padding = new Padding(10, 5, 10, 5);
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "Search...";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(200, 24);
            guna2TextBox1.TabIndex = 3;
            // 
            // LPanelMenu
            // 
            LPanelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LPanelMenu.AutoScroll = true;
            LPanelMenu.Location = new Point(79, 94);
            LPanelMenu.Name = "LPanelMenu";
            LPanelMenu.Padding = new Padding(25, 0, 25, 0);
            LPanelMenu.Size = new Size(762, 583);
            LPanelMenu.TabIndex = 4;
            LPanelMenu.Paint += LPanelMenu_Paint;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 6;
            btnAdd.CustomizableEdges = customizableEdges3;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.FromArgb(0, 194, 13);
            btnAdd.Font = new Font("Open Sans ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.WhiteSmoke;
            btnAdd.Location = new Point(118, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAdd.Size = new Size(40, 40);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "+";
            btnAdd.Click += btnAdd_Click;
            // 
            // MenuDash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(915, 689);
            Controls.Add(btnAdd);
            Controls.Add(LPanelMenu);
            Controls.Add(guna2TextBox1);
            Controls.Add(guna2Separator1);
            Controls.Add(guna2HtmlLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuDash";
            Text = "MenuDash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private FlowLayoutPanel LPanelMenu;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
    }
}