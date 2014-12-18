using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace QLDVVTHH.BLL
{
    public class ListViewNoLag: ListView
    {
        public ListViewNoLag(): base()
        {
            this.DoubleBuffered = true;
        }
    }
}
