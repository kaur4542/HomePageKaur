﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homepage
{
    public partial class Librarian : Form
    {
        public Librarian()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }

        private void BtnExtension_Click(object sender, EventArgs e)
        {
            Extensions extensions = new Extensions();
            extensions.Show();
        }
    }
}
