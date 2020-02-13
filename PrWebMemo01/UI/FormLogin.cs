using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PrWebMemo01.DataSettings;

namespace PrWebMemo01.UI
{
    public partial class FormLogin : Form
    {
        private const string FORM_NAME = "FormLogin";

        public FormLogin()
        {
            InitializeComponent();
            this.Load += (s, e) => Form_Restore.LoadPosSize(this, FORM_NAME);
            this.FormClosed += (s, e) => Form_Restore.SavePosSize(this, FORM_NAME);

            //this.Load += FormLogin_Load;

            //btnLogin.Click += btnLogin_Click;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            updateUIFromData();
        }

        private void updateUIFromData()
        {
            LoginInfomation lastInfo = new LoginInfomation();
            lastInfo.load();

            tbServerName.Text = lastInfo.serverName;
            tbUserName.Text = lastInfo.userName;

            if (tbServerName.Text.Length > 0)
            {
                tbUserName.Select();
            }
            if (tbUserName.Text.Length > 0)
            {
                tbPassword.Text = "";
                tbPassword.Select();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginInfomation lastInfo = new LoginInfomation()
            {
                serverName = tbServerName.Text,
                userName = tbUserName.Text,
                password = tbPassword.Text
            };
            lastInfo.save();

            this.Hide();
            FormMain formmain = new FormMain(this, lastInfo);
            formmain.Show();

            //TestForm tf = new TestForm();
            //tf.Show();
        }

        public void onFormMainClose()
        {
            this.Close();
        }

        public void onFormMainLogout()
        {
            updateUIFromData();
            this.Show();
        
        }
        private void Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (tbServerName.Focused || tbUserName.Focused)
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
                else if (tbPassword.Focused)
                {
                    btnLogin.PerformClick();
                }
                e.Handled = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
