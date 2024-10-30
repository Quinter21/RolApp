using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DoubleClick : Button
    {
        public DoubleClick()
        {
            SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
        }
    }
}
