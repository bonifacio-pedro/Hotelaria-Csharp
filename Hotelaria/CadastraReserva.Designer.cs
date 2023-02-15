namespace Hotelaria
{
    partial class CadastraReserva
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
            this.button1 = new System.Windows.Forms.Button();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.TextBox();
            this.quarto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.dataSaida = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quarto)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(39, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 68);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(39, 92);
            this.cpf.Mask = "000 . 000 . 000 - 00";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(238, 23);
            this.cpf.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "CPF do cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(39, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nome do cliente:";
            // 
            // cliente
            // 
            this.cliente.Location = new System.Drawing.Point(39, 33);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(238, 23);
            this.cliente.TabIndex = 10;
            // 
            // quarto
            // 
            this.quarto.Location = new System.Drawing.Point(39, 153);
            this.quarto.Name = "quarto";
            this.quarto.Size = new System.Drawing.Size(238, 23);
            this.quarto.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Número do quarto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Data de entrada:\r\n";
            // 
            // dataEntrada
            // 
            this.dataEntrada.Location = new System.Drawing.Point(39, 216);
            this.dataEntrada.Mask = "00/00/00 00 : 00";
            this.dataEntrada.Name = "dataEntrada";
            this.dataEntrada.Size = new System.Drawing.Size(238, 23);
            this.dataEntrada.TabIndex = 18;
            // 
            // dataSaida
            // 
            this.dataSaida.Location = new System.Drawing.Point(39, 268);
            this.dataSaida.Mask = "00/00/00 00 : 00";
            this.dataSaida.Name = "dataSaida";
            this.dataSaida.Size = new System.Drawing.Size(238, 23);
            this.dataSaida.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(39, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Data de entrada:\r\n";
            // 
            // CadastraReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 428);
            this.Controls.Add(this.dataSaida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quarto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cliente);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(333, 467);
            this.MinimumSize = new System.Drawing.Size(333, 467);
            this.Name = "CadastraReserva";
            this.Text = "Hotelaria";
            ((System.ComponentModel.ISupportInitialize)(this.quarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private MaskedTextBox cpf;
        private Label label2;
        private Label label7;
        private TextBox cliente;
        private NumericUpDown quarto;
        private Label label3;
        private Label label4;
        private MaskedTextBox dataEntrada;
        private MaskedTextBox dataSaida;
        private Label label5;
    }
}