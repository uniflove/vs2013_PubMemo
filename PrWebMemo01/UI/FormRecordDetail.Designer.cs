namespace PrWebMemo01.UI
{
    partial class FormRecordDetail
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.spMemo = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.spCate3 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCate3 = new System.Windows.Forms.TextBox();
            this.spCate2 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCate2 = new System.Windows.Forms.TextBox();
            this.spCate1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCate1 = new System.Windows.Forms.TextBox();
            this.spTitle = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spMemo)).BeginInit();
            this.spMemo.Panel1.SuspendLayout();
            this.spMemo.Panel2.SuspendLayout();
            this.spMemo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spCate3)).BeginInit();
            this.spCate3.Panel1.SuspendLayout();
            this.spCate3.Panel2.SuspendLayout();
            this.spCate3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spCate2)).BeginInit();
            this.spCate2.Panel1.SuspendLayout();
            this.spCate2.Panel2.SuspendLayout();
            this.spCate2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spCate1)).BeginInit();
            this.spCate1.Panel1.SuspendLayout();
            this.spCate1.Panel2.SuspendLayout();
            this.spCate1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spTitle)).BeginInit();
            this.spTitle.Panel1.SuspendLayout();
            this.spTitle.Panel2.SuspendLayout();
            this.spTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(190, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Location = new System.Drawing.Point(26, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(164, 30);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbMemo
            // 
            this.tbMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMemo.Location = new System.Drawing.Point(0, 0);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMemo.Size = new System.Drawing.Size(581, 360);
            this.tbMemo.TabIndex = 0;
            this.tbMemo.TextChanged += new System.EventHandler(this.tbMemo_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.spMemo);
            this.panel1.Controls.Add(this.spCate3);
            this.panel1.Controls.Add(this.spCate2);
            this.panel1.Controls.Add(this.spCate1);
            this.panel1.Controls.Add(this.spTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 514);
            this.panel1.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 484);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.btnOK);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.splitContainer1.Size = new System.Drawing.Size(581, 30);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 5;
            this.splitContainer1.TabStop = false;
            // 
            // spMemo
            // 
            this.spMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spMemo.IsSplitterFixed = true;
            this.spMemo.Location = new System.Drawing.Point(0, 120);
            this.spMemo.Name = "spMemo";
            this.spMemo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spMemo.Panel1
            // 
            this.spMemo.Panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.spMemo.Panel1.Controls.Add(this.label5);
            // 
            // spMemo.Panel2
            // 
            this.spMemo.Panel2.Controls.Add(this.tbMemo);
            this.spMemo.Size = new System.Drawing.Size(581, 394);
            this.spMemo.SplitterDistance = 30;
            this.spMemo.TabIndex = 4;
            this.spMemo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "메모";
            // 
            // spCate3
            // 
            this.spCate3.Dock = System.Windows.Forms.DockStyle.Top;
            this.spCate3.Location = new System.Drawing.Point(0, 90);
            this.spCate3.Name = "spCate3";
            // 
            // spCate3.Panel1
            // 
            this.spCate3.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.spCate3.Panel1.Controls.Add(this.label4);
            // 
            // spCate3.Panel2
            // 
            this.spCate3.Panel2.Controls.Add(this.tbCate3);
            this.spCate3.Size = new System.Drawing.Size(581, 30);
            this.spCate3.SplitterDistance = 100;
            this.spCate3.TabIndex = 3;
            this.spCate3.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "분류3";
            // 
            // tbCate3
            // 
            this.tbCate3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCate3.Location = new System.Drawing.Point(0, 0);
            this.tbCate3.Multiline = true;
            this.tbCate3.Name = "tbCate3";
            this.tbCate3.Size = new System.Drawing.Size(477, 30);
            this.tbCate3.TabIndex = 1;
            this.tbCate3.TextChanged += new System.EventHandler(this.tbCate3_TextChanged);
            // 
            // spCate2
            // 
            this.spCate2.Dock = System.Windows.Forms.DockStyle.Top;
            this.spCate2.Location = new System.Drawing.Point(0, 60);
            this.spCate2.Name = "spCate2";
            // 
            // spCate2.Panel1
            // 
            this.spCate2.Panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.spCate2.Panel1.Controls.Add(this.label3);
            // 
            // spCate2.Panel2
            // 
            this.spCate2.Panel2.Controls.Add(this.tbCate2);
            this.spCate2.Size = new System.Drawing.Size(581, 30);
            this.spCate2.SplitterDistance = 100;
            this.spCate2.TabIndex = 2;
            this.spCate2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "분류2";
            // 
            // tbCate2
            // 
            this.tbCate2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCate2.Location = new System.Drawing.Point(0, 0);
            this.tbCate2.Multiline = true;
            this.tbCate2.Name = "tbCate2";
            this.tbCate2.Size = new System.Drawing.Size(477, 30);
            this.tbCate2.TabIndex = 1;
            this.tbCate2.TextChanged += new System.EventHandler(this.tbCate2_TextChanged);
            // 
            // spCate1
            // 
            this.spCate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.spCate1.Location = new System.Drawing.Point(0, 30);
            this.spCate1.Name = "spCate1";
            // 
            // spCate1.Panel1
            // 
            this.spCate1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.spCate1.Panel1.Controls.Add(this.label2);
            // 
            // spCate1.Panel2
            // 
            this.spCate1.Panel2.Controls.Add(this.tbCate1);
            this.spCate1.Size = new System.Drawing.Size(581, 30);
            this.spCate1.SplitterDistance = 100;
            this.spCate1.TabIndex = 1;
            this.spCate1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "분류1";
            // 
            // tbCate1
            // 
            this.tbCate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCate1.Location = new System.Drawing.Point(0, 0);
            this.tbCate1.Multiline = true;
            this.tbCate1.Name = "tbCate1";
            this.tbCate1.Size = new System.Drawing.Size(477, 30);
            this.tbCate1.TabIndex = 1;
            this.tbCate1.TextChanged += new System.EventHandler(this.tbCate1_TextChanged);
            // 
            // spTitle
            // 
            this.spTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.spTitle.Location = new System.Drawing.Point(0, 0);
            this.spTitle.Name = "spTitle";
            // 
            // spTitle.Panel1
            // 
            this.spTitle.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spTitle.Panel1.Controls.Add(this.label1);
            // 
            // spTitle.Panel2
            // 
            this.spTitle.Panel2.Controls.Add(this.tbTitle);
            this.spTitle.Size = new System.Drawing.Size(581, 30);
            this.spTitle.SplitterDistance = 100;
            this.spTitle.TabIndex = 0;
            this.spTitle.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "제목";
            // 
            // tbTitle
            // 
            this.tbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTitle.Location = new System.Drawing.Point(0, 0);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(477, 30);
            this.tbTitle.TabIndex = 0;
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // FormRecordDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 514);
            this.Controls.Add(this.panel1);
            this.Name = "FormRecordDetail";
            this.Text = "FormRecordDetail";
            this.Load += new System.EventHandler(this.FormRecordDetail_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.spMemo.Panel1.ResumeLayout(false);
            this.spMemo.Panel1.PerformLayout();
            this.spMemo.Panel2.ResumeLayout(false);
            this.spMemo.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spMemo)).EndInit();
            this.spMemo.ResumeLayout(false);
            this.spCate3.Panel1.ResumeLayout(false);
            this.spCate3.Panel1.PerformLayout();
            this.spCate3.Panel2.ResumeLayout(false);
            this.spCate3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spCate3)).EndInit();
            this.spCate3.ResumeLayout(false);
            this.spCate2.Panel1.ResumeLayout(false);
            this.spCate2.Panel1.PerformLayout();
            this.spCate2.Panel2.ResumeLayout(false);
            this.spCate2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spCate2)).EndInit();
            this.spCate2.ResumeLayout(false);
            this.spCate1.Panel1.ResumeLayout(false);
            this.spCate1.Panel1.PerformLayout();
            this.spCate1.Panel2.ResumeLayout(false);
            this.spCate1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spCate1)).EndInit();
            this.spCate1.ResumeLayout(false);
            this.spTitle.Panel1.ResumeLayout(false);
            this.spTitle.Panel1.PerformLayout();
            this.spTitle.Panel2.ResumeLayout(false);
            this.spTitle.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spTitle)).EndInit();
            this.spTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer spMemo;
        private System.Windows.Forms.SplitContainer spTitle;
        private System.Windows.Forms.SplitContainer spCate3;
        private System.Windows.Forms.SplitContainer spCate2;
        private System.Windows.Forms.SplitContainer spCate1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCate3;
        private System.Windows.Forms.TextBox tbCate2;
        private System.Windows.Forms.TextBox tbCate1;
        private System.Windows.Forms.TextBox tbTitle;
    }
}