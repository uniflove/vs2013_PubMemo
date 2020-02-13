namespace PrWebMemo01.UI
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pubMemoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tool_tbTitle = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tool_tbCate1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tool_tbCate2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tool_tbCate3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tool_tbMemoAll = new System.Windows.Forms.ToolStripTextBox();
            this.tool_btnSearch = new System.Windows.Forms.ToolStripButton();
            this.tool_btnShowAll = new System.Windows.Forms.ToolStripButton();
            this.tool_btnMemoAll = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubMemoBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogout,
            this.menuExit});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(144, 22);
            this.menuLogout.Text = "로그 아웃";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuExit.Size = new System.Drawing.Size(144, 22);
            this.menuExit.Text = "끝내기";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInsert,
            this.menuEdit,
            this.menuDelete,
            this.menuSearch,
            this.menuDetail});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // menuInsert
            // 
            this.menuInsert.Name = "menuInsert";
            this.menuInsert.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.menuInsert.Size = new System.Drawing.Size(134, 22);
            this.menuInsert.Text = "추가";
            this.menuInsert.Click += new System.EventHandler(this.menuInsert_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuEdit.Size = new System.Drawing.Size(134, 22);
            this.menuEdit.Text = "수정";
            this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuDelete.Size = new System.Drawing.Size(134, 22);
            this.menuDelete.Text = "삭제";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // menuSearch
            // 
            this.menuSearch.Name = "menuSearch";
            this.menuSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuSearch.Size = new System.Drawing.Size(134, 22);
            this.menuSearch.Text = "검색";
            this.menuSearch.Click += new System.EventHandler(this.menuSearch_Click);
            // 
            // menuDetail
            // 
            this.menuDetail.Name = "menuDetail";
            this.menuDetail.Size = new System.Drawing.Size(134, 22);
            this.menuDetail.Text = "자세히 보기";
            this.menuDetail.Click += new System.EventHandler(this.menuDetail_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.정보ToolStripMenuItem.Text = "정보";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.category1DataGridViewTextBoxColumn,
            this.category2DataGridViewTextBoxColumn,
            this.category3DataGridViewTextBoxColumn,
            this.memoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pubMemoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(204, 424);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // pubMemoBindingSource
            // 
            this.pubMemoBindingSource.DataSource = typeof(PrWebMemo01.DataWork.PubMemo);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(601, 424);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tool_tbTitle,
            this.toolStripLabel2,
            this.tool_tbCate1,
            this.toolStripLabel3,
            this.tool_tbCate2,
            this.toolStripLabel4,
            this.tool_tbCate3,
            this.toolStripLabel5,
            this.tool_tbMemoAll,
            this.tool_btnSearch,
            this.tool_btnShowAll,
            this.tool_btnMemoAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(809, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel1.Text = "제목";
            // 
            // tool_tbTitle
            // 
            this.tool_tbTitle.Name = "tool_tbTitle";
            this.tool_tbTitle.Size = new System.Drawing.Size(100, 25);
            this.tool_tbTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tool_tbSearch_KeyPress_1);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "분류1";
            // 
            // tool_tbCate1
            // 
            this.tool_tbCate1.Name = "tool_tbCate1";
            this.tool_tbCate1.Size = new System.Drawing.Size(100, 25);
            this.tool_tbCate1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tool_tbSearch_KeyPress_1);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "분류2";
            // 
            // tool_tbCate2
            // 
            this.tool_tbCate2.Name = "tool_tbCate2";
            this.tool_tbCate2.Size = new System.Drawing.Size(100, 25);
            this.tool_tbCate2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tool_tbSearch_KeyPress_1);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "분류3";
            // 
            // tool_tbCate3
            // 
            this.tool_tbCate3.Name = "tool_tbCate3";
            this.tool_tbCate3.Size = new System.Drawing.Size(100, 25);
            this.tool_tbCate3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tool_tbSearch_KeyPress_1);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel5.Text = "메모/전체";
            // 
            // tool_tbMemoAll
            // 
            this.tool_tbMemoAll.Name = "tool_tbMemoAll";
            this.tool_tbMemoAll.Size = new System.Drawing.Size(100, 25);
            this.tool_tbMemoAll.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tool_tbSearch_KeyPress_1);
            // 
            // tool_btnSearch
            // 
            this.tool_btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_btnSearch.Image = global::PrWebMemo01.Properties.Resources.zoom_3;
            this.tool_btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_btnSearch.Name = "tool_btnSearch";
            this.tool_btnSearch.Size = new System.Drawing.Size(23, 22);
            this.tool_btnSearch.Text = "toolStripButton1";
            this.tool_btnSearch.Click += new System.EventHandler(this.tool_btnSearch_Click);
            // 
            // tool_btnShowAll
            // 
            this.tool_btnShowAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_btnShowAll.Image = global::PrWebMemo01.Properties.Resources.abiword_4;
            this.tool_btnShowAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_btnShowAll.Name = "tool_btnShowAll";
            this.tool_btnShowAll.Size = new System.Drawing.Size(23, 22);
            this.tool_btnShowAll.Text = "toolStripButton2";
            this.tool_btnShowAll.Click += new System.EventHandler(this.tool_btnShowAll_Click);
            // 
            // tool_btnMemoAll
            // 
            this.tool_btnMemoAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_btnMemoAll.Image = global::PrWebMemo01.Properties.Resources.blueradio1;
            this.tool_btnMemoAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_btnMemoAll.Name = "tool_btnMemoAll";
            this.tool_btnMemoAll.Size = new System.Drawing.Size(23, 22);
            this.tool_btnMemoAll.Text = "toolStripButton1";
            this.tool_btnMemoAll.Click += new System.EventHandler(this.tool_btnMemoAll_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(809, 424);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 6;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "제목";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 60;
            // 
            // category1DataGridViewTextBoxColumn
            // 
            this.category1DataGridViewTextBoxColumn.DataPropertyName = "category1";
            this.category1DataGridViewTextBoxColumn.HeaderText = "분류1";
            this.category1DataGridViewTextBoxColumn.Name = "category1DataGridViewTextBoxColumn";
            this.category1DataGridViewTextBoxColumn.Width = 60;
            // 
            // category2DataGridViewTextBoxColumn
            // 
            this.category2DataGridViewTextBoxColumn.DataPropertyName = "category2";
            this.category2DataGridViewTextBoxColumn.HeaderText = "분류2";
            this.category2DataGridViewTextBoxColumn.Name = "category2DataGridViewTextBoxColumn";
            this.category2DataGridViewTextBoxColumn.Width = 60;
            // 
            // category3DataGridViewTextBoxColumn
            // 
            this.category3DataGridViewTextBoxColumn.DataPropertyName = "category3";
            this.category3DataGridViewTextBoxColumn.HeaderText = "분류3";
            this.category3DataGridViewTextBoxColumn.Name = "category3DataGridViewTextBoxColumn";
            this.category3DataGridViewTextBoxColumn.Width = 60;
            // 
            // memoDataGridViewTextBoxColumn
            // 
            this.memoDataGridViewTextBoxColumn.DataPropertyName = "memo";
            this.memoDataGridViewTextBoxColumn.HeaderText = "메모";
            this.memoDataGridViewTextBoxColumn.Name = "memoDataGridViewTextBoxColumn";
            this.memoDataGridViewTextBoxColumn.Width = 60;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 473);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubMemoBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuInsert;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripMenuItem menuSearch;
        private System.Windows.Forms.ToolStripMenuItem menuDetail;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pubMemoBindingSource;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox tool_tbTitle;
        private System.Windows.Forms.ToolStripButton tool_btnSearch;
        private System.Windows.Forms.ToolStripButton tool_btnShowAll;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripTextBox tool_tbCate1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox tool_tbCate2;
        private System.Windows.Forms.ToolStripTextBox tool_tbCate3;
        private System.Windows.Forms.ToolStripTextBox tool_tbMemoAll;
        private System.Windows.Forms.ToolStripButton tool_btnMemoAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn category1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn category2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn category3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoDataGridViewTextBoxColumn;
    }
}