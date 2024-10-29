using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SimpleAdd : Form
    {
        public SimpleAdd()
        {
            InitializeComponent();
        }

        public virtual void btnSave_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void SimpleAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
