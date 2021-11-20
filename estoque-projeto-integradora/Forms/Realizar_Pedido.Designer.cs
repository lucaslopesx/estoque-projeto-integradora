
namespace estoque_projeto_integradora.Forms
{
    partial class Realizar_Pedido
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
            this.components = new System.ComponentModel.Container();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.cmdFinalizar = new System.Windows.Forms.Button();
            this.txtqtd = new System.Windows.Forms.NumericUpDown();
            this.verificar_preco = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecoPedido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdAddProduto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmdIniciarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtd)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(55, 36);
            this.cbFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(232, 37);
            this.cbFuncionario.TabIndex = 61;
            // 
            // cbCliente
            // 
            this.cbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(521, 36);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(243, 37);
            this.cbCliente.TabIndex = 60;
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPrecoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoProduto.Location = new System.Drawing.Point(30, 267);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(243, 31);
            this.txtPrecoProduto.TabIndex = 57;
            // 
            // cbProduto
            // 
            this.cbProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(30, 198);
            this.cbProduto.Margin = new System.Windows.Forms.Padding(2);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(243, 33);
            this.cbProduto.TabIndex = 63;
            // 
            // cmdFinalizar
            // 
            this.cmdFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmdFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdFinalizar.Location = new System.Drawing.Point(294, 488);
            this.cmdFinalizar.Name = "cmdFinalizar";
            this.cmdFinalizar.Size = new System.Drawing.Size(243, 48);
            this.cmdFinalizar.TabIndex = 64;
            this.cmdFinalizar.Text = "Finalizar Pedido ";
            this.cmdFinalizar.UseVisualStyleBackColor = true;
            this.cmdFinalizar.Click += new System.EventHandler(this.cmdConfirmar_Click);
            // 
            // txtqtd
            // 
            this.txtqtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtqtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtd.Location = new System.Drawing.Point(179, 315);
            this.txtqtd.Margin = new System.Windows.Forms.Padding(2);
            this.txtqtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(72, 29);
            this.txtqtd.TabIndex = 67;
            this.txtqtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // verificar_preco
            // 
            this.verificar_preco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.verificar_preco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verificar_preco.Location = new System.Drawing.Point(695, 477);
            this.verificar_preco.Name = "verificar_preco";
            this.verificar_preco.Size = new System.Drawing.Size(107, 24);
            this.verificar_preco.TabIndex = 68;
            this.verificar_preco.Text = "Verificar Total";
            this.verificar_preco.UseVisualStyleBackColor = true;
            this.verificar_preco.Click += new System.EventHandler(this.verificar_preco_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(225, 7);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(194, 33);
            this.comboBox4.TabIndex = 71;
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(225, 44);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(194, 37);
            this.comboBox5.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(516, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 29);
            this.label10.TabIndex = 74;
            this.label10.Text = "Nome do cliente";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 75;
            this.label1.Text = "Nome do funcionario";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 76;
            this.label2.Text = "Nome do produto";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 29);
            this.label6.TabIndex = 77;
            this.label6.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(315, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 35);
            this.dateTimePicker1.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 79;
            this.label5.Text = "Preço";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 80;
            this.label3.Text = "Quantidade:";
            // 
            // txtPrecoPedido
            // 
            this.txtPrecoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPrecoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoPedido.Location = new System.Drawing.Point(564, 269);
            this.txtPrecoPedido.Name = "txtPrecoPedido";
            this.txtPrecoPedido.Size = new System.Drawing.Size(141, 29);
            this.txtPrecoPedido.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 81;
            this.label4.Text = "Total do pedido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 25);
            this.label7.TabIndex = 82;
            this.label7.Text = "Forma de pagamento:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Location = new System.Drawing.Point(743, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 264);
            this.panel1.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(123, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 83;
            this.label8.Text = "Parcelas:";
            // 
            // cmdAddProduto
            // 
            this.cmdAddProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmdAddProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddProduto.Location = new System.Drawing.Point(19, 366);
            this.cmdAddProduto.Name = "cmdAddProduto";
            this.cmdAddProduto.Size = new System.Drawing.Size(265, 48);
            this.cmdAddProduto.TabIndex = 84;
            this.cmdAddProduto.Text = "Adicionar produto ao pedido";
            this.cmdAddProduto.UseVisualStyleBackColor = true;
            this.cmdAddProduto.Click += new System.EventHandler(this.cmdAddProduto_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(784, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "_________________________________________________________________________________" +
    "________________________________________________ ";
            // 
            // cmdIniciarPedido
            // 
            this.cmdIniciarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmdIniciarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIniciarPedido.Location = new System.Drawing.Point(308, 95);
            this.cmdIniciarPedido.Name = "cmdIniciarPedido";
            this.cmdIniciarPedido.Size = new System.Drawing.Size(208, 39);
            this.cmdIniciarPedido.TabIndex = 86;
            this.cmdIniciarPedido.Text = "Iniciar pedido";
            this.cmdIniciarPedido.UseVisualStyleBackColor = true;
            this.cmdIniciarPedido.Click += new System.EventHandler(this.cmdIniciarPedido_Click);
            // 
            // Realizar_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 548);
            this.Controls.Add(this.cmdIniciarPedido);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmdAddProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPrecoPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.verificar_preco);
            this.Controls.Add(this.txtqtd);
            this.Controls.Add(this.cmdFinalizar);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.cbFuncionario);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Realizar_Pedido";
            this.Text = "Realizar_Pedido";
            this.Load += new System.EventHandler(this.Realizar_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtqtd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.TextBox txtPrecoProduto;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Button cmdFinalizar;
        private System.Windows.Forms.NumericUpDown txtqtd;
        private System.Windows.Forms.Button verificar_preco;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecoPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdAddProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button cmdIniciarPedido;
    }
}