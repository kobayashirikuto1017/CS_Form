﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                TestButton testButton = new TestButton(i * 50, 0, 50, 50);

                Controls.Add(testButton);
            }
            
        }
            
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}