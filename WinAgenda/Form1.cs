using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinAgenda
{
    public partial class Form1 : Form
    {

        #region "Variables y Objetos globales"

        Contactos contactos = new Contactos();
        
        #endregion

        public Form1()
        {
            InitializeComponent();
         
            panel_ingresar.Visible = false;
            panel_mostrar.Visible = false;
           
            tiempo.Interval = 1000;
            tiempo.Enabled = true;
            tiempo.Start();
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
           

            string tmp = DateTime.Now.ToString();
            char[] separador = { ' ' };
            string[] arreglo = tmp.Split(separador);
            lb_hora.Text = arreglo[1];

            

            string diaSemana = DateTime.Now.DayOfWeek.ToString();
            string diaNumero = DateTime.Now.Day.ToString();
            string mesNumero = DateTime.Now.Month.ToString();

            string diaSemanaEs = "";
            string mesNombre = "";

            switch (diaSemana)
            {
                case "Monday": diaSemanaEs = "LUNES"; break;
                case "Tuesday": diaSemanaEs = "MARTES"; break;
                case "Wednesday": diaSemanaEs = "MIERCOLES"; break;
                case "Thursday": diaSemanaEs = "JUEVES"; break;
                case "Friday": diaSemanaEs = "VIERNES"; break;
                case "Saturday": diaSemanaEs = "SABADO"; break;
                case "Sunday": diaSemanaEs = "DOMINGO"; break;
                default: diaSemanaEs = diaSemana; break;
            };

            switch (mesNumero)
            {
                case "1": mesNombre = "ENERO"; break;
                case "2": mesNombre = "FEBRERO"; break;
                case "3": mesNombre = "MARZO"; break;
                case "4": mesNombre = "ABRIL"; break;
                case "5": mesNombre = "MAYO"; break;
                case "6": mesNombre = "JUNIO"; break;
                case "7": mesNombre = "JULIO"; break;
                case "8": mesNombre = "AGOSTO"; break;
                case "9": mesNombre = "SEPTIEMBRE"; break;
                case "10": mesNombre = "OCTUBRE"; break;
                case "11": mesNombre = "NOVIEMBRE"; break;
                case "12": mesNombre = "DICIEMBRE"; break;
                default: mesNombre = mesNumero; break;
            };

            lb_fecha.Text = diaSemanaEs + ", " + diaNumero + " de " + mesNombre;

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            panel_ingresar.Visible = true;
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            panel_mostrar.Visible = true;
            pict_modificar.Visible = false;
            pict_eliminar.Visible = false;
            bt_exportar.Visible = false;

            grid_mostrar.DataSource = contactos.mostrarContacto();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Hasta la próxima...", "Esta cerrando la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pict_regresar_Click(object sender, EventArgs e)
        {
            panel_ingresar.Visible = false;
            limpiar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            contactos.nuevoContacto(txt_nombres.Text, txt_apellidos.Text, cmb_Sexo.Text, txt_edad.Text, txt_correo.Text, txt_telefono.Text, txt_celular.Text, txt_direccion.Text, txt_paginaweb.Text, txt_beeper.Text);
            limpiar();
            MessageBox.Show("Nuevo contacto fue ingresado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limpiar()
        {
            txt_nombres.Text = "";
            txt_apellidos.Text = "";
            cmb_Sexo.Text = "";
            txt_edad.Text = "";
            txt_correo.Text = "";
            txt_telefono.Text = "";
            txt_celular.Text = "";
            txt_direccion.Text = "";
            txt_paginaweb.Text = "";
            txt_beeper.Text = "";
            
        }

        private void pict_regresar2_Click(object sender, EventArgs e)
        {
            panel_mostrar.Visible = false;
        }

        private void pict_modificar_Click(object sender, EventArgs e)
        {            
            Point punto = grid_mostrar.CurrentCellAddress;
            int n_fila = punto.Y;
            int n_columna = punto.X;
            Modificar md = new Modificar(contactos, n_fila);
            md.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pict_eliminar_Click(object sender, EventArgs e)
        {
            Point punto = grid_mostrar.CurrentCellAddress;
            int n_fila = punto.Y;
            int n_columna = punto.X;
            DialogResult result = MessageBox.Show("Deseas eliminar el contacto: " + contactos.mostrarContacto().Rows[n_fila]["NOMBRES"] + "?","Eliminar un contacto"
                ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                contactos.eliminarContacto(n_fila);
            }
        }

        private void grid_mostrar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
      

            pict_modificar.Visible = true;
            pict_eliminar.Visible = true;
            bt_exportar.Visible = true;
        }

        private void grid_mostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bt_exportar.Visible = true;
            x = grid_mostrar.CurrentRow.Index;
            nombre = grid_mostrar[0, x].Value.ToString();
            apellido = grid_mostrar[1, x].Value.ToString();
            sexo = grid_mostrar[2, x].Value.ToString();
            edad = grid_mostrar[3, x].Value.ToString();
            correo = grid_mostrar[4, x].Value.ToString();
            telefono = grid_mostrar[5, x].Value.ToString();
            celular = grid_mostrar[6, x].Value.ToString();
            direccion = grid_mostrar[7, x].Value.ToString();
            paginaweb = grid_mostrar[8, x].Value.ToString();
            beeper = grid_mostrar[9, x].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel_mostrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel_ingresar_Paint(object sender, PaintEventArgs e)
        {

        }
        string nombre = "", apellido = "", sexo = "", edad = "", correo = "", telefono = "", celular = "", direccion = "", paginaweb = "", beeper = "";
        int x;

        private void bt_exportar_Click(object sender, EventArgs e)
        {
            string ruta = "C:\\AGENDA";
            if (Directory.Exists(ruta) == false)
            {
                Directory.CreateDirectory(ruta);
            }

            MessageBox.Show("Contacto fue exportado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string contenido = "<html>" +
            "<head>" +
            "</head>" +
            "<body style ='background:" + "MEDIUMSLATEBLUE" + " '>" +
            "<center><h4>Agenda Para Contactos, Mostrado En HTML. </h4></center >" +
            "<center><table border='5'><tr><th>Nombre</th><td>" + nombre +
            "</td></tr><tr><th>Apellido</th><td>" + apellido +
            "</td></tr><tr><th>Sexo</th><td>" + sexo +
            "</td></tr><tr><th>Edad</th><td>" + edad +
            "</td></tr><tr><th>Correo</th><td>" + correo +
            "</td></tr><tr><th>Telefono</th><td>" + telefono +
            "</td></tr><tr><th>Celular</th><td>" + celular +
            "</td></tr><tr><th>Direccion</th><td>" + direccion +
            "</td></tr><tr><th>Pagina Web</th><td>" + paginaweb +
            "</td></tr><tr><th>Beeper</th><td>" + beeper +
            "</td></tr></table></body>" +
            "<center><h4>Luis David Moscoso Almanzar. </h4></center >" +
            "<center><h4>Matricula: 1-15-5161. </h4></center >" +
            "</html>";

            File.WriteAllText("c:\\AGENDA\\" + nombre + ".html", contenido);
        
            
              
                
                 
            
        }
    }
}
