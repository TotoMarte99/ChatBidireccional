using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChatBidireccional
{
    public partial class Form2 : Form
    {
        ChatFuncion chat;

        public Form2()
        {
            InitializeComponent();
            string cadenaConexion = "Data Source=VICTUS-TOTO\\SQLEXPRESS; Initial Catalog=ChatBidireccional; Integrated Security=True; TrustServerCertificate=True";
            chat = new ChatFuncion(cadenaConexion);
        }

   
        private void Form2_Load(object sender, EventArgs e)
        {
            timer2.Interval = 2000;
            timer2.Tick += LeerMensaje;
            timer2.Start();
            listBoxForm2.Items.Add("Iniciando Conversacion:");

        }


        private void Enviarbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMensajeForm2.Text))
            {
                string cadenaConexion = "Data Source=VICTUS-TOTO\\SQLEXPRESS; Initial Catalog=ChatBidireccional; Integrated Security=True; TrustServerCertificate=True";
                ChatFuncion chat = new ChatFuncion(cadenaConexion);
                chat.EnviarMensaje("Form2", "Form1", txtMensajeForm2.Text,DateTime.Now);
            }
            else
            {
                MessageBox.Show("Ingrese un mensaje para enviar");

            }

        }

        private void LeerMensaje(object sender, EventArgs e)
        {
            var mensajes = chat.RecibirMensaje("Form2");
            foreach (var m in mensajes)
            {
                listBoxForm2.Items.Add(m);
            }
        }
    }
}

