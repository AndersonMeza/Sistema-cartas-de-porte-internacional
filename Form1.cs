using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Documentos
{
    public partial class Form1 : Form
    {
        public bool entra = false;
        public Form1()
        {
            InitializeComponent();
            Abrir(new Menu());

            if(!File.Exists("documentos.accdb"))
            {
                Base nueva = new Base();
                nueva.crear();
            }
            
        }

        public void Abrir(Object formulario)
        {
            //Principal principal = Application.OpenForms.OfType<Principal>().SingleOrDefault();
            //Contenedor_controles principal = (Contenedor_controles)this;

            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.RemoveAt(0);
            }

            Form actual = formulario as Form;
            actual.TopLevel = false;
            actual.Dock = DockStyle.Fill;
            panel2.Controls.Add(actual);
            panel2.Tag = actual;                                    
            actual.Show();
        }

        public void Actualizar_Cartaportes(string id)
        {
            //Principal principal = Application.OpenForms.OfType<Principal>().SingleOrDefault();
            //Contenedor_controles principal = (Contenedor_controles)this;

            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.RemoveAt(0);
            }

            Inventario_CP actual = new Inventario_CP();
            actual.id = id;
            actual.TopLevel = false;
            actual.Dock = DockStyle.Fill;
            panel2.Controls.Add(actual);
            panel2.Tag = actual;
            actual.Show();
        }

        public void Actualizar_Manifiestos(string id)
        {
            //Principal principal = Application.OpenForms.OfType<Principal>().SingleOrDefault();
            //Contenedor_controles principal = (Contenedor_controles)this;

            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.RemoveAt(0);
            }

            Documento2 actual = new Documento2();
            actual.id = id;
            actual.TopLevel = false;
            actual.Dock = DockStyle.Fill;
            panel2.Controls.Add(actual);
            panel2.Tag = actual;
            actual.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (entra)
            {
                DialogResult respuesta = new DialogResult();
                respuesta = MessageBox.Show("Se recomienda revisar si guardó el contenido de esta ventana, ¿desea continuar a una nueva carta de porte?", "Abrir Nueva Carta de Porte ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (respuesta.ToString() == "Yes")
                {
                    entra = true;
                    Abrir(new Inventario_CP());
                }
            }
            else
            {
                entra = true;
                Abrir(new Inventario_CP());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (entra)
            {
                DialogResult respuesta = new DialogResult();
                respuesta = MessageBox.Show("Se recomienda revisar si guardó el contenido de esta ventana, ¿desea continuar a un nuevo manifiesto?", "Abrir Nueva Manifiesto", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (respuesta.ToString() == "Yes")
                {
                    entra = true;
                    Abrir(new Documento2());
                }
            }
            else
            {
                entra = true;
                Abrir(new Documento2());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (entra)
            {
                DialogResult respuesta = new DialogResult();
                respuesta = MessageBox.Show("Se recomienda revisar si guardó el contenido de esta ventana, ¿desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (respuesta.ToString() == "Yes")
                {
                    entra = false;
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (entra)
            {
                DialogResult respuesta = new DialogResult();
                respuesta = MessageBox.Show("Se recomienda revisar si guardó el contenido de esta ventana, ¿desea continuar al menú?", "Abrir Menú", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (respuesta.ToString() == "Yes")
                {
                    entra = false;
                    Abrir(new Menu());
                }
            }
            else
            {
                entra = false;
                Abrir(new Menu());
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (entra)
            {
                DialogResult respuesta = new DialogResult();
                respuesta = MessageBox.Show("Se recomienda revisar si guardó el contenido de esta ventana, ¿desea ver 'Acerca De'?", "Abrir Acerca De", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (respuesta.ToString() == "Yes")
                {
                    entra = false;
                    //Abrir(new Acerca_De());
                }
            }
            else
            {
                entra = false;
                //Abrir(new Acerca_De());
            }
        }
    }
}
