using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _﻿prueba_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int counterInt = 0;
        private readonly string userName = "admin";
        private readonly string userPass = "pass";

        private void ValidateButton_Click(object sender, EventArgs e)
        {
             if (UserInputName.Text is null && UserInputPass is null)
            {
                MessageBox.Show("usuario y contraseña vacios");

            }
            else if (userName.Equals(UserInputName.Text.ToLowerInvariant()) && userPass.Equals(UserInputPass.Text.ToLowerInvariant()))
            {
                FormRegistro registro = new FormRegistro();
                UserInputName.Text = null; UserInputPass.Text = null;
                counter.ForeColor = Color.Black;
                counterInt = 0;
                registro.Show();
            }
            else
            {
                counterInt = counterInt+1;
                counter.ForeColor = Color.Red;
                UserInputName.Text = null; UserInputPass.Text = null;

                MessageBox.Show("usuario y contraseña invalido");
            }
            if(counterInt >= 3)
            {
                Application.Exit();
            }
            counter.Text = counterInt.ToString();
        }

        private void Counter_Click(object sender, EventArgs e)
        {

        }
    }
}
