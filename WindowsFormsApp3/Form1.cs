﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
                String[] Student = {"Orxan","Turan","Resad","Nermin","Xalid",
                                    "Sakit","Huseyn","Araz","Suleyman","Cavid",
                                        "Zaur abi","Serane","Vuqar", "Xeyyam"

                                 };

                String[] Task =
                                  {
                                      "ViewResult","PartialView","ViewData",
                                        "Redirect","RedirectToRoute","ViewBag",
                                        "Content","Json","Tempdata","Javascript","File","ViewData","TempData",
                                        "Session","Passing by Typed rguments","Request Object",
                                        "Form Collections Object","Data Binding"
                                   };


            Random r = new Random();
            int select = r.Next(0, 14);
            label1.Text = Student[select];
            int tasks = r.Next(0, 16);
            label2.Text = Task[tasks];
        }

    }
}
