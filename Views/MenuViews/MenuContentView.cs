using PROJET_C__GESTIONRESTO.LogicApp;
using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Views.SimpleView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJET_C__GESTIONRESTO.Views.MenuViews
{
    public partial class MenuContentView : Form
    {
        private bool resizing = false;
        private Point lastMousePosition;
        private int menuId;
        private MenuItemProcess menuItemProcess = new();
        public MenuContentView(int menuId, string theme, string description)
        {
            InitializeComponent();
            this.menuId = menuId;
            lblTheme.Text = theme;
            lblDescribe.Text = description;
            CentraliseLabel(lblTheme);
            lblDescribe.Location = new Point(
                (picImage.ClientSize.Width - lblDescribe.Width) / 2,
                (picImage.ClientSize.Height - lblDescribe.Height) / 2
            );
        }

        private void MenuContentView_Load(object sender, EventArgs e)
        {
            FillListProduct();
        }

        private void txtSearchbar_Leave(object sender, EventArgs e)
        {
            FillListProduct();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            var modal = new GetProductView();
            var result = modal.ShowDialog();
            if (result == DialogResult.OK)
            {
                var prodSelected = modal.products;
                if (prodSelected.Count > 0)
                    foreach (var prod in prodSelected)
                    {
                        Menuitem menuitem = new();
                        menuitem.Product = prod;
                        menuitem.Menu = menuId;

                        menuItemProcess.CreateProduct(menuitem);
                    }
            }
            FillListProduct();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        protected void FillListProduct()
        {
            var list = menuItemProcess.FindMenuItemBy(menuId, txtSearchbar.Text);
            LPanelList.Controls.Clear();
            if (list.Count > 0)
            {
                if (!LPanelList.Visible)
                    toggleVisibilityListMenu();

                foreach (var item in list)
                {
                    var product = item.ProductNavigation;
                    MenuItemView elt = new(product, item.Id);

                    LPanelList.Controls.Add(elt);
                }
                return;
            }
            toggleVisibilityListMenu();
        }

        protected void toggleVisibilityListMenu()
        {
            if (LPanelList.Visible)
            {
                LPanelList.Visible = false;
                lblListEmpty.Visible = true;
            }
            else
            {
                LPanelList.Visible = true;
                lblListEmpty.Visible = false;
            }

        }

        protected void CentraliseLabel(Label lb)
        {
            lb.Location = new Point(
                (lb.Parent.ClientSize.Width - lb.Width) / 2,
                (lb.Parent.ClientSize.Height - lb.Height) / 2
            );
        }
        // Pour l'ajout d'un ombre porter derriere le formulaire
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x20000; // CS_DROPSHADOW
                return cp;
            }
        }

        // Simulation du redimensionnement de la fenetre
        //protected override void WndProc(ref Message m)
        //{
        //    const int WM_NCHITTEST = 0x84;
        //    const int HTCLIENT = 1;
        //    const int HTCAPTION = 2;
        //    const int HTLEFT = 10;
        //    const int HTRIGHT = 11;
        //    const int HTTOP = 12;
        //    const int HTTOPLEFT = 13;
        //    const int HTTOPRIGHT = 14;
        //    const int HTBOTTOM = 15;
        //    const int HTBOTTOMLEFT = 16;
        //    const int HTBOTTOMRIGHT = 17;

        //    base.WndProc(ref m);

        //    if (m.Msg == WM_NCHITTEST)
        //    {
        //        Point pos = PointToClient(Cursor.Position);
        //        int borderWidth = 10;

        //        if (pos.X <= borderWidth && pos.Y <= borderWidth)
        //            m.Result = (IntPtr)HTTOPLEFT;
        //        else if (pos.X >= Width - borderWidth && pos.Y <= borderWidth)
        //            m.Result = (IntPtr)HTTOPRIGHT;
        //        else if (pos.X <= borderWidth && pos.Y >= Height - borderWidth)
        //            m.Result = (IntPtr)HTBOTTOMLEFT;
        //        else if (pos.X >= Width - borderWidth && pos.Y >= Height - borderWidth)
        //            m.Result = (IntPtr)HTBOTTOMRIGHT;
        //        else if (pos.X <= borderWidth)
        //            m.Result = (IntPtr)HTLEFT;
        //        else if (pos.X >= Width - borderWidth)
        //            m.Result = (IntPtr)HTRIGHT;
        //        else if (pos.Y <= borderWidth)
        //            m.Result = (IntPtr)HTTOP;
        //        else if (pos.Y >= Height - borderWidth)
        //            m.Result = (IntPtr)HTBOTTOM;
        //    }
        //}

        private void pnWindow_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left && e.Location.X >= pnWindow.Width - 10 && e.Location.Y >= pnWindow.Height - 10)
            //{
            //    resizing = true;
            //    lastMousePosition = e.Location;
            //}
        }

        private void pnWindow_MouseMove(object sender, MouseEventArgs e)
        {
            //if (resizing)
            //{
            //    pnWindow.Cursor = Cursors.SizeWE;
            //    this.Width += e.X - lastMousePosition.X;
            //    this.Height += e.Y - lastMousePosition.Y;
            //    lastMousePosition = e.Location;
            //}
        }

        private void pnWindow_MouseUp(object sender, MouseEventArgs e)
        {
            //resizing = false;
        }

        private void pnWindow_MouseHover(object sender, EventArgs e)
        {
        }

    }
}
