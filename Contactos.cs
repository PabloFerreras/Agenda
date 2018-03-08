using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace WinAgenda
{
    public class Contactos
    {
        
        DataTable tablaContactos = new DataTable();


        public Contactos()
        {
           
            tablaContactos.Columns.Add(new DataColumn("NOMBRES"));
            tablaContactos.Columns.Add(new DataColumn("APELLIDOS"));
            tablaContactos.Columns.Add(new DataColumn("SEXO"));
            tablaContactos.Columns.Add(new DataColumn("EDAD"));
            tablaContactos.Columns.Add(new DataColumn("CORREO"));
            tablaContactos.Columns.Add(new DataColumn("TELEFONO"));
            tablaContactos.Columns.Add(new DataColumn("CELULAR"));
            tablaContactos.Columns.Add(new DataColumn("DIRECCION"));
            tablaContactos.Columns.Add(new DataColumn("PAGINAWEB"));
            tablaContactos.Columns.Add(new DataColumn("BEEPER"));
           


            if (File.Exists(@"datosAgenda.dat"))
            {
                cargarArchivo();
            }
            
        }

        public void nuevoContacto(string nombres, string apellidos, string sexo, string edad, string correo, string telefono, string celular, string direccion, string paginaweb, string beeper)
        {
            
            registrarContacto(nombres, apellidos, sexo, edad, correo, telefono, celular, direccion, paginaweb, beeper);
            guardarArchivo();
        }

        public void eliminarContacto(int index)
        {
            tablaContactos.Rows[index].Delete();
            guardarArchivo();
        }

        public DataTable mostrarContacto()
        {
            return tablaContactos;
        }

        private void registrarContacto(string nombres, string apellidos, string sexo, string edad, string correo, string telefono, string celular, string direccion, string paginaweb, string beeper)
        {
          
            DataRow fila = tablaContactos.NewRow();
            fila["NOMBRES"] = nombres;
            fila["APELLIDOS"] = apellidos;
            fila["SEXO"] = sexo;
            fila["EDAD"] = edad;
            fila["CORREO"] = correo;
            fila["TELEFONO"] = telefono;
            fila["CELULAR"] = celular;
            fila["DIRECCION"] = direccion;
            fila["PAGINAWEB"] = paginaweb;
            fila["BEEPER"] = beeper;
          
           
            tablaContactos.Rows.Add(fila);
        }

        public void guardarEnFichero()
        {
            guardarArchivo();
        }

        private void guardarArchivo()
        {
            StreamWriter escribir = new StreamWriter(@"datosAgenda.dat", false);
            for (int x = 0; x < tablaContactos.Rows.Count; x++)
            {
                string tmp = tablaContactos.Rows[x]["NOMBRES"].ToString();
                tmp += "|" + tablaContactos.Rows[x]["APELLIDOS"].ToString();
                tmp += "|" + tablaContactos.Rows[x]["SEXO"].ToString();
                tmp += "|" + tablaContactos.Rows[x]["EDAD"].ToString();
                tmp += "|" + tablaContactos.Rows[x]["CORREO"].ToString();
                tmp += "|" + tablaContactos.Rows[x]["TELEFONO"].ToString();
                tmp += "|" + tablaContactos.Rows[x]["CELULAR"].ToString();
                tmp += "|" + tablaContactos.Rows[x]["DIRECCION"].ToString();
                tmp += "|" + tablaContactos.Rows[x]["PAGINAWEB"].ToString();
                tmp += "|" + tablaContactos.Rows[x]["BEEPER"].ToString();
                
                escribir.WriteLine(tmp);
            }
            escribir.Close();
        }

        private void cargarArchivo()
        {
            StreamReader leer = new StreamReader(@"datosAgenda.dat");
            while ( !leer.EndOfStream )
            {
                string texto = leer.ReadLine();
                char[] separador = { '|' };
                string[] arregloDatos = texto.Split(separador);
                registrarContacto(arregloDatos[0], arregloDatos[1], arregloDatos[2], arregloDatos[3], arregloDatos[4], arregloDatos[5], arregloDatos[6], arregloDatos[7], arregloDatos[8], arregloDatos[9]);
            }
            leer.Close();
        } 

    }
}
