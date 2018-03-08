using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinAgenda
{
    public partial class Modificar : Form
    {
        Contactos contacto_tmp;
        int index;

        public Modificar(Contactos pcontactos, int index)
        {
            InitializeComponent();
            contacto_tmp = pcontactos;
            this.index = index;

          
            txt_nombres.Text = contacto_tmp.mostrarContacto().Rows[index]["NOMBRES"].ToString();
             txt_apellidos.Text = contacto_tmp.mostrarContacto().Rows[index]["APELLIDOS"].ToString();
             cmb_Sexo.Text = contacto_tmp.mostrarContacto().Rows[index]["SEXO"].ToString();
             txt_Edad.Text = contacto_tmp.mostrarContacto().Rows[index]["EDAD"].ToString();
              txt_correo.Text = contacto_tmp.mostrarContacto().Rows[index]["CORREO"].ToString();
              txt_telefono.Text = contacto_tmp.mostrarContacto().Rows[index]["TELEFONO"].ToString();
              txt_celular.Text = contacto_tmp.mostrarContacto().Rows[index]["CELULAR"].ToString();
              txt_direccion.Text = contacto_tmp.mostrarContacto().Rows[index]["DIRECCION"].ToString();
              txt_paginaweb.Text = contacto_tmp.mostrarContacto().Rows[index]["PAGINAWEB"].ToString();
              txt_beeper.Text = contacto_tmp.mostrarContacto().Rows[index]["BEEPER"].ToString();
        
                  
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
          
            contacto_tmp.mostrarContacto().Rows[index]["NOMBRES"] = txt_nombres.Text;
            contacto_tmp.mostrarContacto().Rows[index]["APELLIDOS"] = txt_apellidos.Text;
            contacto_tmp.mostrarContacto().Rows[index]["SEXO"] = cmb_Sexo.Text;
            contacto_tmp.mostrarContacto().Rows[index]["EDAD"] = txt_Edad.Text;
            contacto_tmp.mostrarContacto().Rows[index]["CORREO"] = txt_correo.Text;
            contacto_tmp.mostrarContacto().Rows[index]["TELEFONO"] = txt_telefono.Text;
            contacto_tmp.mostrarContacto().Rows[index]["CELULAR"] = txt_celular.Text;
            contacto_tmp.mostrarContacto().Rows[index]["DIRECCION"] = txt_direccion.Text;
            contacto_tmp.mostrarContacto().Rows[index]["PAGINAWEB"] = txt_paginaweb.Text;
            contacto_tmp.mostrarContacto().Rows[index]["BEEPER"] = txt_beeper.Text;
            
            

            DialogResult result = MessageBox.Show("Los datos han sido modificados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
         
            if (result == DialogResult.OK)
            {
                contacto_tmp.guardarEnFichero();
                this.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_apellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void pict_modificar_Click(object sender, EventArgs e)
        {

        }

        private void Modificar_Load(object sender, EventArgs e)
        {

        }
    }
}
