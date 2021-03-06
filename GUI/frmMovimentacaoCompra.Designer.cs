﻿namespace ControleDeEstoque.GUI
{
    partial class frmMovimentacaoCompra
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
            this.pro_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_valoru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_valort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.nupParcelas = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTipoPagamento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pro_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtForCod = new System.Windows.Forms.TextBox();
            this.txtNFiscal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtVenda = new System.Windows.Forms.DateTimePicker();
            this.txtComCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pro_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnFinalizaVenda = new System.Windows.Forms.Panel();
            this.btCancelarParcela = new System.Windows.Forms.Button();
            this.btSalvarParcela = new System.Windows.Forms.Button();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.pve_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pve_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pve_datapagto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.lbParcelas = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnDados = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.dtParcela = new System.Windows.Forms.DateTimePicker();
            this.lbForNome = new System.Windows.Forms.Label();
            this.lbProNome = new System.Windows.Forms.Label();
            this.btInc = new System.Windows.Forms.Button();
            this.txtProValor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btProLoc = new System.Windows.Forms.Button();
            this.txtProCod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.btForLoc = new System.Windows.Forms.Button();
            this.nudProQtde = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupParcelas)).BeginInit();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnFinalizaVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProQtde)).BeginInit();
            this.SuspendLayout();
            // 
            // pro_nome
            // 
            this.pro_nome.HeaderText = "Nome";
            this.pro_nome.Name = "pro_nome";
            this.pro_nome.ReadOnly = true;
            this.pro_nome.Width = 275;
            // 
            // pro_valoru
            // 
            this.pro_valoru.HeaderText = "Valor unitário";
            this.pro_valoru.Name = "pro_valoru";
            this.pro_valoru.ReadOnly = true;
            // 
            // pro_valort
            // 
            this.pro_valort.HeaderText = "Valor Total";
            this.pro_valort.Name = "pro_valort";
            this.pro_valort.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(9, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(746, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // nupParcelas
            // 
            this.nupParcelas.Enabled = false;
            this.nupParcelas.Location = new System.Drawing.Point(553, 418);
            this.nupParcelas.Name = "nupParcelas";
            this.nupParcelas.Size = new System.Drawing.Size(75, 20);
            this.nupParcelas.TabIndex = 16;
            this.nupParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupParcelas.ValueChanged += new System.EventHandler(this.nupParcelas_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(550, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Parcelas";
            // 
            // cbTipoPagamento
            // 
            this.cbTipoPagamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTipoPagamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipoPagamento.FormattingEnabled = true;
            this.cbTipoPagamento.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbTipoPagamento.Location = new System.Drawing.Point(408, 418);
            this.cbTipoPagamento.Name = "cbTipoPagamento";
            this.cbTipoPagamento.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPagamento.TabIndex = 14;
            this.cbTipoPagamento.SelectedIndexChanged += new System.EventHandler(this.cbTipoPagamento_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(404, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo do Pagamento";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(634, 419);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(631, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total";
            // 
            // pro_qtde
            // 
            this.pro_qtde.HeaderText = "Quantidade";
            this.pro_qtde.Name = "pro_qtde";
            this.pro_qtde.ReadOnly = true;
            // 
            // txtForCod
            // 
            this.txtForCod.Location = new System.Drawing.Point(258, 29);
            this.txtForCod.Name = "txtForCod";
            this.txtForCod.Size = new System.Drawing.Size(77, 20);
            this.txtForCod.TabIndex = 7;
            this.txtForCod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCliCod_KeyUp);
            this.txtForCod.Leave += new System.EventHandler(this.txtCliCod_Leave);
            // 
            // txtNFiscal
            // 
            this.txtNFiscal.Location = new System.Drawing.Point(152, 29);
            this.txtNFiscal.Name = "txtNFiscal";
            this.txtNFiscal.Size = new System.Drawing.Size(100, 20);
            this.txtNFiscal.TabIndex = 5;
            this.txtNFiscal.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(147, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota Fiscal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data da Compra";
            // 
            // dtVenda
            // 
            this.dtVenda.Location = new System.Drawing.Point(12, 78);
            this.dtVenda.Name = "dtVenda";
            this.dtVenda.Size = new System.Drawing.Size(207, 20);
            this.dtVenda.TabIndex = 2;
            // 
            // txtComCod
            // 
            this.txtComCod.Enabled = false;
            this.txtComCod.Location = new System.Drawing.Point(12, 29);
            this.txtComCod.Name = "txtComCod";
            this.txtComCod.Size = new System.Drawing.Size(112, 20);
            this.txtComCod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código da Compra";
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnMenu.Controls.Add(this.pictureBox1);
            this.pnMenu.Controls.Add(this.btExcluir);
            this.pnMenu.Controls.Add(this.btSalvar);
            this.pnMenu.Controls.Add(this.btCancelar);
            this.pnMenu.Controls.Add(this.btLocalizar);
            this.pnMenu.Controls.Add(this.btInserir);
            this.pnMenu.Location = new System.Drawing.Point(5, 468);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(761, 107);
            this.pnMenu.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.money_bag;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btExcluir
            // 
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btExcluir.Location = new System.Drawing.Point(402, 15);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(76, 72);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btSalvar.Location = new System.Drawing.Point(508, 15);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(79, 72);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(614, 15);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(76, 72);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLocalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btLocalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.btLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocalizar.Location = new System.Drawing.Point(300, 15);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(79, 72);
            this.btLocalizar.TabIndex = 1;
            this.btLocalizar.Text = "Pesquisar";
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btInserir.Location = new System.Drawing.Point(197, 15);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(76, 72);
            this.btInserir.TabIndex = 0;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(254, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Código do Fornecedor";
            // 
            // pro_cod
            // 
            this.pro_cod.HeaderText = "Código";
            this.pro_cod.Name = "pro_cod";
            this.pro_cod.ReadOnly = true;
            // 
            // pnFinalizaVenda
            // 
            this.pnFinalizaVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnFinalizaVenda.Controls.Add(this.btCancelarParcela);
            this.pnFinalizaVenda.Controls.Add(this.btSalvarParcela);
            this.pnFinalizaVenda.Controls.Add(this.dgvParcelas);
            this.pnFinalizaVenda.Controls.Add(this.label14);
            this.pnFinalizaVenda.Controls.Add(this.lbParcelas);
            this.pnFinalizaVenda.Controls.Add(this.lbTotal);
            this.pnFinalizaVenda.Controls.Add(this.label5);
            this.pnFinalizaVenda.Location = new System.Drawing.Point(5, 12);
            this.pnFinalizaVenda.Name = "pnFinalizaVenda";
            this.pnFinalizaVenda.Size = new System.Drawing.Size(761, 563);
            this.pnFinalizaVenda.TabIndex = 10;
            this.pnFinalizaVenda.Visible = false;
            // 
            // btCancelarParcela
            // 
            this.btCancelarParcela.BackgroundImage = global::GUI.Properties.Resources.cancel;
            this.btCancelarParcela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCancelarParcela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btCancelarParcela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btCancelarParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarParcela.Location = new System.Drawing.Point(584, 469);
            this.btCancelarParcela.Name = "btCancelarParcela";
            this.btCancelarParcela.Size = new System.Drawing.Size(76, 72);
            this.btCancelarParcela.TabIndex = 6;
            this.btCancelarParcela.UseVisualStyleBackColor = true;
            this.btCancelarParcela.Click += new System.EventHandler(this.btCancelarParcela_Click);
            // 
            // btSalvarParcela
            // 
            this.btSalvarParcela.BackgroundImage = global::GUI.Properties.Resources.bank;
            this.btSalvarParcela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSalvarParcela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btSalvarParcela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btSalvarParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvarParcela.Location = new System.Drawing.Point(496, 469);
            this.btSalvarParcela.Name = "btSalvarParcela";
            this.btSalvarParcela.Size = new System.Drawing.Size(76, 72);
            this.btSalvarParcela.TabIndex = 5;
            this.btSalvarParcela.UseVisualStyleBackColor = true;
            this.btSalvarParcela.Click += new System.EventHandler(this.btSalvarParcela_Click);
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pve_cod,
            this.pve_valor,
            this.pve_datapagto});
            this.dgvParcelas.Location = new System.Drawing.Point(109, 109);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.Size = new System.Drawing.Size(557, 354);
            this.dgvParcelas.TabIndex = 4;
            // 
            // pve_cod
            // 
            this.pve_cod.HeaderText = "Parcela";
            this.pve_cod.Name = "pve_cod";
            this.pve_cod.ReadOnly = true;
            // 
            // pve_valor
            // 
            this.pve_valor.HeaderText = "Valor";
            this.pve_valor.Name = "pve_valor";
            this.pve_valor.ReadOnly = true;
            // 
            // pve_datapagto
            // 
            this.pve_datapagto.HeaderText = "Data do pagamento";
            this.pve_datapagto.Name = "pve_datapagto";
            this.pve_datapagto.ReadOnly = true;
            this.pve_datapagto.Width = 150;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(107, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(647, 18);
            this.label14.TabIndex = 3;
            this.label14.Text = "_______________________________________________________________________";
            // 
            // lbParcelas
            // 
            this.lbParcelas.AutoSize = true;
            this.lbParcelas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParcelas.ForeColor = System.Drawing.Color.Red;
            this.lbParcelas.Location = new System.Drawing.Point(508, 48);
            this.lbParcelas.Name = "lbParcelas";
            this.lbParcelas.Size = new System.Drawing.Size(109, 32);
            this.lbParcelas.TabIndex = 2;
            this.lbParcelas.Text = "Parcelas";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lbTotal.Location = new System.Drawing.Point(215, 44);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(76, 40);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(103, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 45);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total:";
            // 
            // pnDados
            // 
            this.pnDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnDados.Controls.Add(this.nudProQtde);
            this.pnDados.Controls.Add(this.label15);
            this.pnDados.Controls.Add(this.dtParcela);
            this.pnDados.Controls.Add(this.lbForNome);
            this.pnDados.Controls.Add(this.lbProNome);
            this.pnDados.Controls.Add(this.btInc);
            this.pnDados.Controls.Add(this.txtProValor);
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.btProLoc);
            this.pnDados.Controls.Add(this.txtProCod);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.dgvItens);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.nupParcelas);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.cbTipoPagamento);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.txtTotal);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.btForLoc);
            this.pnDados.Controls.Add(this.txtForCod);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtNFiscal);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.dtVenda);
            this.pnDados.Controls.Add(this.txtComCod);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Enabled = false;
            this.pnDados.Location = new System.Drawing.Point(6, 12);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(760, 450);
            this.pnDados.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(199, 397);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Data Inicial das parcelas";
            // 
            // dtParcela
            // 
            this.dtParcela.Location = new System.Drawing.Point(202, 418);
            this.dtParcela.Name = "dtParcela";
            this.dtParcela.Size = new System.Drawing.Size(200, 20);
            this.dtParcela.TabIndex = 30;
            // 
            // lbForNome
            // 
            this.lbForNome.AutoSize = true;
            this.lbForNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbForNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lbForNome.Location = new System.Drawing.Point(390, 31);
            this.lbForNome.Name = "lbForNome";
            this.lbForNome.Size = new System.Drawing.Size(273, 20);
            this.lbForNome.TabIndex = 29;
            this.lbForNome.Text = "Cliente: Insira o código do Fornecedor";
            // 
            // lbProNome
            // 
            this.lbProNome.AutoSize = true;
            this.lbProNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbProNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lbProNome.Location = new System.Drawing.Point(168, 148);
            this.lbProNome.Name = "lbProNome";
            this.lbProNome.Size = new System.Drawing.Size(70, 20);
            this.lbProNome.TabIndex = 28;
            this.lbProNome.Text = "Produto:";
            // 
            // btInc
            // 
            this.btInc.BackgroundImage = global::GUI.Properties.Resources.plus;
            this.btInc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btInc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btInc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInc.Location = new System.Drawing.Point(697, 135);
            this.btInc.Name = "btInc";
            this.btInc.Size = new System.Drawing.Size(37, 35);
            this.btInc.TabIndex = 26;
            this.btInc.UseVisualStyleBackColor = true;
            this.btInc.Click += new System.EventHandler(this.btInc_Click);
            // 
            // txtProValor
            // 
            this.txtProValor.Location = new System.Drawing.Point(593, 150);
            this.txtProValor.Name = "txtProValor";
            this.txtProValor.Size = new System.Drawing.Size(100, 20);
            this.txtProValor.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(590, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Valor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(481, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Quantidade";
            // 
            // btProLoc
            // 
            this.btProLoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btProLoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btProLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProLoc.Image = global::GUI.Properties.Resources.localizar_pequeno_fw;
            this.btProLoc.Location = new System.Drawing.Point(119, 147);
            this.btProLoc.Name = "btProLoc";
            this.btProLoc.Size = new System.Drawing.Size(43, 23);
            this.btProLoc.TabIndex = 21;
            this.btProLoc.UseVisualStyleBackColor = true;
            this.btProLoc.Click += new System.EventHandler(this.btProLoc_Click);
            // 
            // txtProCod
            // 
            this.txtProCod.Location = new System.Drawing.Point(12, 149);
            this.txtProCod.Name = "txtProCod";
            this.txtProCod.Size = new System.Drawing.Size(100, 20);
            this.txtProCod.TabIndex = 20;
            this.txtProCod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProCod_KeyUp);
            this.txtProCod.Leave += new System.EventHandler(this.txtProCod_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(8, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Código";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pro_cod,
            this.pro_nome,
            this.pro_qtde,
            this.pro_valoru,
            this.pro_valort});
            this.dgvItens.Location = new System.Drawing.Point(12, 175);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(722, 213);
            this.dgvItens.TabIndex = 18;
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick);
            // 
            // btForLoc
            // 
            this.btForLoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btForLoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btForLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btForLoc.Image = global::GUI.Properties.Resources.localizar_pequeno_fw;
            this.btForLoc.Location = new System.Drawing.Point(341, 30);
            this.btForLoc.Name = "btForLoc";
            this.btForLoc.Size = new System.Drawing.Size(43, 23);
            this.btForLoc.TabIndex = 10;
            this.btForLoc.UseVisualStyleBackColor = true;
            this.btForLoc.Click += new System.EventHandler(this.btForLoc_Click);
            // 
            // nudProQtde
            // 
            this.nudProQtde.Location = new System.Drawing.Point(485, 151);
            this.nudProQtde.Name = "nudProQtde";
            this.nudProQtde.Size = new System.Drawing.Size(75, 20);
            this.nudProQtde.TabIndex = 33;
            this.nudProQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudProQtde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProQtde.ValueChanged += new System.EventHandler(this.nudProQtde_ValueChanged);
            // 
            // frmMovimentacaoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(770, 587);
            this.Controls.Add(this.pnFinalizaVenda);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmMovimentacaoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação de Compra";
            this.Load += new System.EventHandler(this.frmMovimentacaoCompra_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMovimentacaoCompra_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nupParcelas)).EndInit();
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnFinalizaVenda.ResumeLayout(false);
            this.pnFinalizaVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProQtde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn pro_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_valoru;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_valort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nupParcelas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTipoPagamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btForLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_qtde;
        private System.Windows.Forms.TextBox txtForCod;
        private System.Windows.Forms.TextBox txtNFiscal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtVenda;
        private System.Windows.Forms.TextBox txtComCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnMenu;
        protected System.Windows.Forms.Button btExcluir;
        protected System.Windows.Forms.Button btSalvar;
        protected System.Windows.Forms.Button btCancelar;
        protected System.Windows.Forms.Button btLocalizar;
        protected System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_cod;
        private System.Windows.Forms.Panel pnFinalizaVenda;
        protected System.Windows.Forms.Button btCancelarParcela;
        protected System.Windows.Forms.Button btSalvarParcela;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pve_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pve_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pve_datapagto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbParcelas;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtParcela;
        private System.Windows.Forms.Label lbForNome;
        private System.Windows.Forms.Label lbProNome;
        private System.Windows.Forms.Button btInc;
        private System.Windows.Forms.TextBox txtProValor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btProLoc;
        private System.Windows.Forms.TextBox txtProCod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudProQtde;
    }
}