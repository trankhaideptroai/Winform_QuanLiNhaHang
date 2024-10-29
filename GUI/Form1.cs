using GUI.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private string email;
        FTableView FTableView;
        FCategoryView FCategoryView;
        FFoodView FFoodView;
        FDatBanAn FDatBan;
        FDMK FDMK;
        FNhanVienView FNhanVienView;
        FSPNhapKhoView FSPNhapKhoView;
        FThongKe FThongKe;
        FHoaDon FHoaDon;
        public static int session = 0;
        

        public Form1()
        {
            InitializeComponent();
            mdiProp();
        }

        public Form1(string user)
        {
            InitializeComponent();
            this.email = user;
        }

        public void LimitAccess()
        {
            menuContainer.Visible = false;
            button9.Visible = false;
        }

        bool menuExpand = false;

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 300)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 46)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        public void ResetUI()
        {
            lblChao.Visible = false;
            lblTime.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        public void ResetUI2()
        {
            lblChao.Visible = true;
            lblTime.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblChao.Text = "Chào " + email;
            if(session == 1)
            {
   
                FLogin frm = new FLogin();
                frm.Show();
            }
           
        }

        private void menuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        bool siderbarExpand = false;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (siderbarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 60)
                {
                    siderbarExpand = false;
                    sidebarTransition.Stop();

                    button2.Width = sidebar.Width;
                    button3.Width = sidebar.Width;
                    button3.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 269)
                {
                    siderbarExpand = true;
                    sidebarTransition.Stop();

                    button2.Width = sidebar.Width;
                    button3.Width = sidebar.Width;
                    button3.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void CloseAllChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (FFoodView == null)
            {
                FFoodView = new FFoodView();
                FFoodView.FormClosed += fFoodView_FormClosed;
                FFoodView.MdiParent = this;
                FFoodView.Dock = DockStyle.Fill;
                FFoodView.Show();
                ResetUI();
            }
            else
            {
                FFoodView.Activate();
            }
        }

        private void fFoodView_FormClosed(object sender, FormClosedEventArgs e)
        {
            FFoodView = null;
            ResetUI2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (FTableView == null)
            {
                FTableView = new FTableView();
                FTableView.FormClosed += ftableView_FormClosed;
                FTableView.MdiParent = this;
                FTableView.Dock = DockStyle.Fill;
                FTableView.Show();
                ResetUI();
            }
            else
            {
                FTableView.Activate();
            }
        }

        private void ftableView_FormClosed(object sender, FormClosedEventArgs e)
        {
            FTableView = null;
            ResetUI2();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (FCategoryView == null)
            {
                FCategoryView = new FCategoryView();
                FCategoryView.FormClosed += fcategoryView_FormClosed;
                FCategoryView.MdiParent = this;
                FCategoryView.Dock = DockStyle.Fill;
                FCategoryView.Show();
                ResetUI();
            }
            else
            {
                FCategoryView.Activate();
            }
        }

        private void fcategoryView_FormClosed(object sender, FormClosedEventArgs e)
        {
            FCategoryView = null;
            ResetUI2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (FDatBan == null)
            {
                FDatBan = new FDatBanAn();
                FDatBan.FormClosed += fDatban_FormClosed;
                FDatBan.MdiParent = this;
                FDatBan.Dock = DockStyle.Fill;
                FDatBan.Show();
                ResetUI();
            }
            else
            {
                FDatBan.Activate();
            }
        }

        private void fDatban_FormClosed(object sender, FormClosedEventArgs e)
        {
            FDatBan = null;
            ResetUI2();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (FDMK == null)
            {
                ResetUI();
                FDMK = new FDMK(email);
                FDMK.MainForm = this;  // Truyền tham chiếu đến Form1
                FDMK.FormClosed += new FormClosedEventHandler(FDoiMatKhau_FormClosed);
                FDMK.MdiParent = this;
                FDMK.Show();
            }
            else
            {
                FDMK.Activate();
            }


        }

        private void FDoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            FDMK = null;
            ResetUI2();
            
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (FNhanVienView == null)
            {
                FNhanVienView = new FNhanVienView();
                FNhanVienView.FormClosed += FNhanvienView_FormClosed;
                FNhanVienView.MdiParent = this;
                FNhanVienView.Dock = DockStyle.Fill;
                FNhanVienView.Show();
                ResetUI();
            }
            else
            {
                FNhanVienView.Activate();
            }
        }

        private void FNhanvienView_FormClosed(object sender, FormClosedEventArgs e)
        {
            FNhanVienView = null;
            ResetUI2();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (FSPNhapKhoView == null)
            {
                FSPNhapKhoView = new FSPNhapKhoView(email);
                FSPNhapKhoView.FormClosed += FSPNhapKhoView_FormClosed;
                FSPNhapKhoView.MdiParent = this;
                FSPNhapKhoView.Dock = DockStyle.Fill;
                FSPNhapKhoView.Show();
                ResetUI();
            }
            else
            {
                FSPNhapKhoView.Activate();
            }
        }

        private void FSPNhapKhoView_FormClosed(object sender, FormClosedEventArgs e)
        {
            FSPNhapKhoView = null;
            ResetUI2();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (FThongKe == null)
            {
                FThongKe = new FThongKe();
                FThongKe.FormClosed += FThongKe_FormClosed;
                FThongKe.MdiParent = this;
                FThongKe.Dock = DockStyle.Fill;
                FThongKe.Show();
                ResetUI();
            }
            else
            {
                FThongKe.Activate();
            }
        }

        private void FThongKe_FormClosed(object sender, FormClosedEventArgs e)
        {
            FThongKe = null;
            ResetUI2();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (FHoaDon == null)
            {
                FHoaDon = new FHoaDon();
                FHoaDon.FormClosed += FHoaDon_FormClosed;
                FHoaDon.MdiParent = this;
                FHoaDon.Dock = DockStyle.Fill;
                FHoaDon.Show();
                ResetUI();
            }
            else
            {
                FHoaDon.Activate();
            }
        }

        private void FHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            FHoaDon = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin loginForm = new FLogin();
            loginForm.ShowDialog();
        }
    }
}
