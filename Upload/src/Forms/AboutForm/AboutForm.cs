using System.Drawing;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;

namespace Upload
{
    public partial class AboutForm : Form
    {
        private Point parentPos;
        private Size parentSize;

        public AboutForm(Point parentPos, Size parentSize)
        {
            InitializeComponent();
            this.parentPos = parentPos;
            this.parentSize = parentSize;
        }

        private void AboutForm_Shown(object sender, EventArgs e)
        {
            this.SetDesktopLocation(parentPos.X + (parentSize.Width / 2) - (this.Width / 2), parentPos.Y + (parentSize.Height / 2) - (this.Height / 2));
        }
    }
}
