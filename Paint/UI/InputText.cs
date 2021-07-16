using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI
{
    public partial class InputText : Form
    {
        internal string InputString { get; private set; }
        public InputText()
        {
            InitializeComponent();
            InputString = string.Empty;
            btnOK.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            InputString = txtInputText.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
