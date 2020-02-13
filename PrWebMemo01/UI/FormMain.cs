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
using PrWebMemo01.DataWork;

namespace PrWebMemo01.UI
{
    public partial class FormMain : Form
    {
        private const string FORM_NAME = "FormMain";
        private const string HTML_FONT_SIZE = "{ font-size : 32px; }";

		private FormLogin formLogin;
		enum CloseEvent { CLOSE, LOGOUT }
		private CloseEvent closeEvent;
		private LoginInfomation loginInfo;
		private DBService dbService = new DBService();

        // 메모/전체 검색 선택
        // false = 전체 검색 <- default, true = 메모에서만 검색
        private bool searchAll = true;

        public FormMain(FormLogin formLogin, LoginInfomation loginInfo)
        {
            InitializeComponent();
            this.Load += (s, e) => Form_Restore.LoadPosSize(this, FORM_NAME);
            this.FormClosed += (s, e) => Form_Restore.SavePosSize(this, FORM_NAME);

            //this.Load += FormMain_Load;
            //this.FormClosed += FormMain_FormClosed;

            this.formLogin = formLogin;
            this.loginInfo = loginInfo;

            menuLogout.Click += menuLogout_Click;
            menuExit.Click += menuExit_Click;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            showAllRecord();
            //webBrowser1.GoHome();
            webBrowser1.Navigate("https://search.naver.com/search.naver?sm=tab_sly.hst&where=nexearch&query=&oquery=sfe&tqi=UmbCisp0Jy0ssZARz6RsssssskK-101439");
            //webBrowser1.Navigate("https://m.naver.com");
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            switch (closeEvent)
            {
                case CloseEvent.LOGOUT:
                    formLogin.onFormMainLogout();
                    break;
                case CloseEvent.CLOSE:
                    formLogin.onFormMainClose();
                    break;
            }
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            closeEvent = CloseEvent.CLOSE;
            this.Close();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            closeEvent = CloseEvent.LOGOUT;
            this.Close();
        }

        private void menuInsert_Click(object sender, EventArgs e)
        {
            FormRecordDetail formRecord = new FormRecordDetail(FormRecordDetail.Mode.INSERT, null);
            formRecord.ShowDialog();
            if (formRecord.formResult == true)
            {
                dbService.insert(loginInfo, loginInfo.password, formRecord.srcItem);
                showAllRecord();
            }
        }

        private void showAllRecord()
        {
            List<PubMemo> list = dbService.getAll(loginInfo, loginInfo.password);
            if (list != null)
            {
                dataGridView1.DataSource = list;
            }
            else
            {
                closeEvent = CloseEvent.LOGOUT;
                this.Close();
            }
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem != null)
            {
                PubMemo srcItem = dataGridView1.CurrentRow.DataBoundItem as PubMemo;
                FormRecordDetail formRecord = new FormRecordDetail(FormRecordDetail.Mode.EDIT, srcItem);
                formRecord.ShowDialog();
                if (formRecord.formResult == true)
                {
                    dbService.update(loginInfo, loginInfo.password, formRecord.srcItem);
                    showAllRecord();
                }
            }
            else
            {
                MessageBox.Show("수정할 항목을 먼저 선택해야 합니다.");
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem != null)
            {
                PubMemo item = dataGridView1.CurrentRow.DataBoundItem as PubMemo;
                string msg = "데이타를 삭제할까요?";
                DialogResult result = MessageBox.Show(msg, "삭제", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    dbService.delete(loginInfo, item);
                    showAllRecord();
                }
            }
            else
            {
                MessageBox.Show("삭제할 항목을 먼저 선택해야 합니다.");
            }
        }

        private void menuSearch_Click(object sender, EventArgs e)
        {
            tool_tbMemoAll.Focus();
        }

        private void tool_btnSearch_Click(object sender, EventArgs e)
        {
            Dictionary<DBIndex.PubMemo, string> keyword = new Dictionary<DBIndex.PubMemo, string>();
            if (searchAll)
            {
                if (tool_tbMemoAll.Text.Length <= 0)
                {
                    return;
                }
                tool_tbMemoAll.SelectAll();
                keyword.Add(DBIndex.PubMemo.title, tool_tbMemoAll.Text);
                keyword.Add(DBIndex.PubMemo.category1, tool_tbMemoAll.Text);
                keyword.Add(DBIndex.PubMemo.category2, tool_tbMemoAll.Text);
                keyword.Add(DBIndex.PubMemo.category3, tool_tbMemoAll.Text);
                keyword.Add(DBIndex.PubMemo.memo, tool_tbMemoAll.Text);
                dataGridView1.DataSource = dbService.search(loginInfo, loginInfo.password, keyword);
            }
            else
            {
                if (tool_tbTitle.Text.Length > 0)
                {
                    tool_tbTitle.SelectAll();
                    keyword.Add(DBIndex.PubMemo.title, tool_tbTitle.Text);
                }
                if (tool_tbCate1.Text.Length > 0)
                {
                    tool_tbCate1.SelectAll();
                    keyword.Add(DBIndex.PubMemo.category1, tool_tbCate1.Text);
                }
                if (tool_tbCate2.Text.Length > 0)
                {
                    tool_tbCate2.SelectAll();
                    keyword.Add(DBIndex.PubMemo.category2, tool_tbCate2.Text);
                }
                if (tool_tbCate3.Text.Length > 0)
                {
                    tool_tbCate3.SelectAll();
                    keyword.Add(DBIndex.PubMemo.category3, tool_tbCate3.Text);
                }
                if (tool_tbMemoAll.Text.Length > 0)
                {
                    tool_tbMemoAll.SelectAll();
                    keyword.Add(DBIndex.PubMemo.memo, tool_tbMemoAll.Text);
                }
                if (keyword.Count > 0)
                {
                    dataGridView1.DataSource = dbService.search(loginInfo, loginInfo.password, keyword);
                }
            }
        }

        private void menuDetail_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem != null)
            {
                PubMemo srcItem = dataGridView1.CurrentRow.DataBoundItem as PubMemo;
                displayHTML(srcItem);
            }
        }

        private void displayHTML(PubMemo item)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Properties.Settings.Default.htmlHeaderV44);
            sb.Append(item.memo);
            sb.Append(Properties.Settings.Default.htmlTailV44);

            HtmlDocument doc = webBrowser1.Document;
            doc.Body.InnerHtml = sb.ToString();
            //doc.Body.InnerHtml = string.Format(Properties.Settings.Default.htmlHeader, item.memo);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            menuDetail_Click(null, null);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //webBrowser1.Document.Body.Style = "zoom:100%";
            //webBrowser1.Document.Body.Style = "font-size:32px;";
        }

        private void tool_btnShowAll_Click(object sender, EventArgs e)
        {
            showAllRecord();
        }

        private void tool_btnMemoAll_Click(object sender, EventArgs e)
        {
            if(searchAll) {
                searchAll ^= true;
                ((ToolStripButton)sender).Image = Properties.Resources.boincmanager1;
            }
            else
            {
                searchAll ^= true;
                ((ToolStripButton)sender).Image = Properties.Resources.blueradio1;
            }
        }

        private void tool_tbSearch_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                tool_btnSearch.PerformClick();
                e.Handled = true;
            }
        }



    }
}
