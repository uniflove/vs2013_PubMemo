using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrWebMemo01.UI
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HtmlDocument doc = webBrowser1.Document;
            doc.Body.InnerHtml = textBox1.Text;

        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
    }
}
