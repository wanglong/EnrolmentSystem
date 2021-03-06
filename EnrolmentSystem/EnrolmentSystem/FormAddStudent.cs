﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnrolmentSystemModel;

namespace EnrolmentSystemUI
{
    public partial class FormAddStudent : Form
    {
        private University _university;
        private Student _student;

        public FormAddStudent(University university)
        {
            InitializeComponent();
            _university = university;            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxId.Text == "" || textBoxBirthday.Text == "" || richTextBoxAddress.Text == "")
            {
                MessageBox.Show("Error: Please fill all the blanks.");
                return;
            }

            _student = new Student(textBoxId.Text, textBoxName.Text, textBoxBirthday.Text, richTextBoxAddress.Text);
            if (_university.AddStudent(_student))
            {
                MessageBox.Show("Added");
                this.Close();
            }
            else
            {
                MessageBox.Show("Existed, fail");
            }
        }


    }
}
