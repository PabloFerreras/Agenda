using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinAgenda
{
    public partial class Login : Form
    {
        public object Then { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "admin" && txt_pass.Text == "admin")

            {
                Form1 abrir = new Form1();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Password Incorrecta");
            } 
               
         }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (txt_pass.PasswordChar == '▀')
                {
                    txt_pass.PasswordChar = '\0';
                }

            }
            else
            {
                txt_pass.PasswordChar = '▀';
            }
           
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pict_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
   

