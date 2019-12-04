using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Authority.PL
{
    public partial class Document_FORM : MetroFramework.Forms.MetroForm
    {
        public Document_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
        }
    }
}
