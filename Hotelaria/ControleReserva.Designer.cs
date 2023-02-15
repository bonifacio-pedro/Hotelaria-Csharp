namespace Hotelaria
{
    partial class ControleReserva
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
            this.dataSaida = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quarto = new System.Windows.Forms.NumericUpDown();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.quartoEdit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quarto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSaida
            // 
            this.dataSaida.Enabled = false;
            this.dataSaida.Location = new System.Drawing.Point(168, 269);
            this.dataSaida.Mask = "00/00/00 ## : ##";
            this.dataSaida.Name = "dataSaida";
            this.dataSaida.Size = new System.Drawing.Size(200, 23);
            this.dataSaida.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Data de entrada:\r\n";
            // 
            // dataEntrada
            // 
            this.dataEntrada.Enabled = false;
            this.dataEntrada.Location = new System.Drawing.Point(168, 226);
            this.dataEntrada.Mask = "00/00/00 ## : ##";
            this.dataEntrada.Name = "dataEntrada";
            this.dataEntrada.Size = new System.Drawing.Size(200, 23);
            this.dataEntrada.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Data de entrada:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Digite o número do quarto para procurar a reserva:\r\n";
            // 
            // quarto
            // 
            this.quarto.Location = new System.Drawing.Point(19, 44);
            this.quarto.Name = "quarto";
            this.quarto.Size = new System.Drawing.Size(238, 23);
            this.quarto.TabIndex = 25;
            // 
            // cpf
            // 
            this.cpf.Enabled = false;
            this.cpf.Location = new System.Drawing.Point(168, 180);
            this.cpf.Mask = "000 . 000 . 000 - 00";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(200, 23);
            this.cpf.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "CPF do cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nome do cliente:";
            // 
            // cliente
            // 
            this.cliente.Enabled = false;
            this.cliente.Location = new System.Drawing.Point(168, 140);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(200, 23);
            this.cliente.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(277, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(19, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 74);
            this.button2.TabIndex = 32;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(217, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 74);
            this.button3.TabIndex = 33;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Número do quarto:";
            // 
            // quartoEdit
            // 
            this.quartoEdit.Enabled = false;
            this.quartoEdit.Location = new System.Drawing.Point(168, 100);
            this.quartoEdit.Name = "quartoEdit";
            this.quartoEdit.Size = new System.Drawing.Size(200, 23);
            this.quartoEdit.TabIndex = 35;
            // 
            // ControleReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 403);
            this.Controls.Add(this.quartoEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataSaida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quarto);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cliente);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(415, 442);
            this.MinimumSize = new System.Drawing.Size(415, 442);
            this.Name = "ControleReserva";
            this.Text = "Hotelaria";
            ((System.ComponentModel.ISupportInitialize)(this.quarto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox dataSaida;
        private Label label5;
        private MaskedTextBox dataEntrada;
        private Label label4;
        private Label label3;
        private NumericUpDown quarto;
        private MaskedTextBox cpf;
        private Label label2;
        private Label label7;
        private TextBox cliente;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private NumericUpDown quartoEdit;
    }
}