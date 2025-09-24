using System.Data.SqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace ChatBidireccional
{
    public partial class Form1 : Form
    {
        ChatFuncion chat;

        public Form1()
        {
            InitializeComponent();
            string cadenaConexion = "Data Source=VICTUS-TOTO\\SQLEXPRESS; Initial Catalog=ChatBidireccional; Integrated Security=True; TrustServerCertificate=True";
            chat = new ChatFuncion(cadenaConexion);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Tick += LeerMensaje;
            timer1.Start();
            listBoxForm1.Items.Add("Iniciando Conversacion:");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtMensajeForm1.Text))
            {
                string cadenaConexion = "Data Source=VICTUS-TOTO\\SQLEXPRESS; Initial Catalog=ChatBidireccional; Integrated Security=True; TrustServerCertificate=True";
                ChatFuncion chat = new ChatFuncion(cadenaConexion);
                chat.EnviarMensaje("Form1", "Form2", txtMensajeForm1.Text, DateTime.Now);
            }
            else
            {
              MessageBox.Show("Ingrese un mensaje para enviar");

            }
        }

        private void LeerMensaje(object sender, EventArgs e)
        {
            var mensajes = chat.RecibirMensaje("Form1");
            foreach(var m in mensajes)
            {
                listBoxForm1.Items.Add(m);
            }
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
