namespace ChatBidireccional
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBoxForm1 = new ListBox();
            txtMensajeForm1 = new TextBox();
            btnEnviar = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            form2ToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxForm1
            // 
            listBoxForm1.FormattingEnabled = true;
            listBoxForm1.Location = new Point(24, 119);
            listBoxForm1.Name = "listBoxForm1";
            listBoxForm1.Size = new Size(463, 124);
            listBoxForm1.TabIndex = 0;
            // 
            // txtMensajeForm1
            // 
            txtMensajeForm1.Location = new Point(24, 73);
            txtMensajeForm1.Name = "txtMensajeForm1";
            txtMensajeForm1.Size = new Size(206, 27);
            txtMensajeForm1.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(263, 74);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(135, 26);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar Mensaje";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 50);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Mensaje";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { form2ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(665, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // form2ToolStripMenuItem
            // 
            form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            form2ToolStripMenuItem.Size = new Size(65, 24);
            form2ToolStripMenuItem.Text = "Form2";
            form2ToolStripMenuItem.Click += form2ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 285);
            Controls.Add(label1);
            Controls.Add(btnEnviar);
            Controls.Add(txtMensajeForm1);
            Controls.Add(listBoxForm1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxForm1;
        private TextBox txtMensajeForm1;
        private Button btnEnviar;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem form2ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}
