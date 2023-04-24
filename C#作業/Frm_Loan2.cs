using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_作業
{
    public partial class Frm_Loan2 : Form
    {
        public Frm_Loan2()
        {
            InitializeComponent();
            Frm_Loan XX= new Frm_Loan ();
            Txt_Amount2.Text = XX.Txt_Amount.Text;
        }
    }
}
