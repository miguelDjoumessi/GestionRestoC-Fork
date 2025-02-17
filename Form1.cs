using Guna.UI2.WinForms;
using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Orm;
using PROJET_C__GESTIONRESTO.Services;
using PROJET_C__GESTIONRESTO.Usefull.Mail;
using PROJET_C__GESTIONRESTO.Views;
using PROJET_C__GESTIONRESTO.Views.MenuViews;
using PROJET_C__GESTIONRESTO.Views.ReservationView;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;

namespace PROJET_C__GESTIONRESTO
{
    public partial class Form1 : Form
    {
        OrderInterface oi;
        private Guna2Button? currentButton;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrderInterface(), sender);
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (btnSender != currentButton)
                {
                    DisableButtons();
                    currentButton = (Guna2Button)btnSender;
                    currentButton.ForeColor = Color.OrangeRed;
                    currentButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
                }
            }
        }

        private void DisableButtons()
        {
            foreach (Control previousBtn in pnSlidebar.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna2Button))
                {
                    previousBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
                    previousBtn.ForeColor = Color.DarkGray;
                }
            }
        }

        private void btnArticle_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCategoryView(), sender);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MenuDash(), sender);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReservationDash(), sender);

        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null) { activeForm.Close(); }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnContainer.Controls.Add(childForm);
            this.pnContainer.Tag = childForm;
            childForm.Tag = this.pnHeader.Tag;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
