
namespace ChatBidireccional
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtMensajeForm2 = new TextBox();
            listBoxForm2 = new ListBox();
            Enviarbtn = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 38);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 7;
            label1.Text = "Mensaje";
            // 
            // txtMensajeForm2
            // 
            txtMensajeForm2.Location = new Point(35, 65);
            txtMensajeForm2.Name = "txtMensajeForm2";
            txtMensajeForm2.Size = new Size(206, 27);
            txtMensajeForm2.TabIndex = 5;
            // 
            // listBoxForm2
            // 
            listBoxForm2.FormattingEnabled = true;
            listBoxForm2.Location = new Point(35, 111);
            listBoxForm2.Name = "listBoxForm2";
            listBoxForm2.Size = new Size(463, 124);
            listBoxForm2.TabIndex = 4;
            // 
            // Enviarbtn
            // 
            Enviarbtn.Location = new Point(279, 65);
            Enviarbtn.Name = "Enviarbtn";
            Enviarbtn.Size = new Size(144, 27);
            Enviarbtn.TabIndex = 8;
            Enviarbtn.Text = "Enviar Mensaje";
            Enviarbtn.UseVisualStyleBackColor = true;
            Enviarbtn.Click += Enviarbtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 254);
            Controls.Add(Enviarbtn);
            Controls.Add(label1);
            Controls.Add(txtMensajeForm2);
            Controls.Add(listBoxForm2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        // private void btnEnviar_Click(object sender, EventArgs e)
        // {
        //  throw new NotImplementedException();
        // }

        #endregion

        private Label label1;
        private TextBox txtMensajeForm2;
        private ListBox listBoxForm2;
        private Button Enviarbtn;
        private System.Windows.Forms.Timer timer2;
    }
}