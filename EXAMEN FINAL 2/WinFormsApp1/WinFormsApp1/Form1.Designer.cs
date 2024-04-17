namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textID = new TextBox();
            txtCantidadPersonas = new TextBox();
            txtIDCLiente = new ListBox();
            txtIDRuta = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 57);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 103);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "IDCliente:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 158);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "IDRuta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 209);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 3;
            label4.Text = "Cantida de Personas:";
            // 
            // textID
            // 
            textID.Location = new Point(225, 54);
            textID.Name = "textID";
            textID.Size = new Size(100, 23);
            textID.TabIndex = 4;
            textID.TextChanged += textBox1_TextChanged;
            // 
            // txtCantidadPersonas
            // 
            txtCantidadPersonas.Location = new Point(225, 201);
            txtCantidadPersonas.Name = "txtCantidadPersonas";
            txtCantidadPersonas.Size = new Size(100, 23);
            txtCantidadPersonas.TabIndex = 7;
            txtCantidadPersonas.TextChanged += textBox4_TextChanged;
            // 
            // txtIDCLiente
            // 
            txtIDCLiente.AccessibleName = "txtIDCliente";
            txtIDCLiente.FormattingEnabled = true;
            txtIDCLiente.ItemHeight = 15;
            txtIDCLiente.Location = new Point(225, 103);
            txtIDCLiente.Name = "txtIDCLiente";
            txtIDCLiente.Size = new Size(120, 19);
            txtIDCLiente.TabIndex = 8;
            txtIDCLiente.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtIDRuta
            // 
            txtIDRuta.AccessibleName = "txtIDRuta";
            txtIDRuta.FormattingEnabled = true;
            txtIDRuta.ItemHeight = 15;
            txtIDRuta.Location = new Point(225, 158);
            txtIDRuta.Name = "txtIDRuta";
            txtIDRuta.Size = new Size(120, 19);
            txtIDRuta.TabIndex = 9;
            txtIDRuta.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(518, 139);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "INSERTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 253);
            Controls.Add(button1);
            Controls.Add(txtIDRuta);
            Controls.Add(txtIDCLiente);
            Controls.Add(txtCantidadPersonas);
            Controls.Add(textID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textID;
        private TextBox txtCantidadPersonas;
        private ListBox txtIDCLiente;
        private ListBox txtIDRuta;
        private Button button1;
    }
}
