using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    enum Shapes
    {
        None,
        Free,
        Line,
        Rectangle,
        Square,
        Elip,
        Circle,
        Triangle,
        Petagon,
        Hecxagon,
        Fill,
    }
    public partial class frmPaint : Form
    {
        public frmPaint()
        {
            InitializeComponent();
        }

    }
}
