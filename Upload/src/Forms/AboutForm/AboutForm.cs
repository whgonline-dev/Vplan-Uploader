using System.Drawing;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;

namespace Upload
{
    public partial class AboutForm : Form
    {
        public AboutForm(Point parentPosition, Size parentSize)
        {
            InitializeComponent();
            Debug.WriteLine(parentPosition.X);
        }
    }
}
