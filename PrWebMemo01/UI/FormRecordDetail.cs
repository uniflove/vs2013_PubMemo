using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PrWebMemo01.DataWork;

namespace PrWebMemo01.UI
{
    public partial class FormRecordDetail : Form
    {
        private const string FORM_NAME = "FormRecordDetail";

        public enum Mode { INSERT, EDIT, SHOW }
        public Mode mode { get; set; }
        public bool formResult { get; set; }
        public PubMemo srcItem;

        public FormRecordDetail(Mode mode, PubMemo srcItem)
        {
            InitializeComponent();
            this.Load += (s, e) => Form_Restore.LoadPosSize(this, FORM_NAME);
            this.FormClosed += (s, e) => Form_Restore.SavePosSize(this, FORM_NAME);

            //this.Load += FormRecordDetail_Load;

            this.mode = mode;
            this.srcItem = srcItem;
        }

        private void FormRecordDetail_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Mode.INSERT:
                    this.Text = "추가";
                    break;
                case Mode.EDIT:
                    this.Text = "수정";
                    updateUIFromData(false);
                    break;
                case Mode.SHOW:
                    this.Text = "보기";
                    updateUIFromData(true);
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Mode.INSERT:
                    srcItem = new PubMemo();
                    updateDataFromUI();
                    break;
                case Mode.EDIT:
                    updateDataFromUI();
                    break;
                case Mode.SHOW:
                    break;
            }
            formResult = true;
            this.Close();
        }

        private void updateDataFromUI()
        {
            srcItem.title = tbTitle.Text;
            srcItem.category1 = tbCate1.Text;
            srcItem.category2 = tbCate2.Text;
            srcItem.category3 = tbCate3.Text;
            srcItem.memo = tbMemo.Text;
        }

        private void updateUIFromData(bool onlyDisplay)
        {
            tbTitle.Text = srcItem.title;
            tbCate1.Text = srcItem.category1;
            tbCate2.Text = srcItem.category2;
            tbCate3.Text = srcItem.category3;
            tbMemo.Text = srcItem.memo;
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

        // 이게 대체 왜 필요한거지?? 왜 텍스트가 그냥 입력이 안되는거냐?
        private void tbMemo_TextChanged(object sender, EventArgs e)
        {
            tbMemo.Text = ((TextBox)sender).Text;
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            tbTitle.Text = ((TextBox)sender).Text;
        }

        private void tbCate1_TextChanged(object sender, EventArgs e)
        {
            tbCate1.Text = ((TextBox)sender).Text;
        }

        private void tbCate2_TextChanged(object sender, EventArgs e)
        {
            tbCate2.Text = ((TextBox)sender).Text;
        }

        private void tbCate3_TextChanged(object sender, EventArgs e)
        {
            tbCate3.Text = ((TextBox)sender).Text;
        }

    }
}
