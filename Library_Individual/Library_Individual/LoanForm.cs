﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Individual
{
    public partial class LoanForm : Form
    {
        public LoanForm()
        {
            InitializeComponent();
        }

        private void btnSubmitLoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
            this.Close();
        }
    }
}
