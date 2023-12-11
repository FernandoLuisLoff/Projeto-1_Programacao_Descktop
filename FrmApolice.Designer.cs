namespace appSeguradora
{
    partial class FrmApolice
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
            this.seguradoraDataSet = new appSeguradora.seguradoraDataSet();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter = new appSeguradora.seguradoraDataSetTableAdapters.MarcasTableAdapter();
            this.tableAdapterManager = new appSeguradora.seguradoraDataSetTableAdapters.TableAdapterManager();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            this.apolicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valorDoBemTextBox = new System.Windows.Forms.TextBox();
            this.anoModeloTextBox = new System.Windows.Forms.TextBox();
            this.anoFabricacaoTextBox = new System.Windows.Forms.TextBox();
            this.modeloComboBox1 = new System.Windows.Forms.ComboBox();
            this.modelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSair1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProximo1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtAnoHabilitacao = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbbCombustivel = new System.Windows.Forms.ComboBox();
            this.placaTextBox = new System.Windows.Forms.TextBox();
            this.chassiTextBox = new System.Windows.Forms.TextBox();
            this.btnSair2 = new System.Windows.Forms.Button();
            this.btnVoltar1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnProximo2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.franquiaRedCheckBox = new System.Windows.Forms.CheckBox();
            this.danosTerceirosCheckBox = new System.Windows.Forms.CheckBox();
            this.acidentesCheckBox = new System.Windows.Forms.CheckBox();
            this.vidrosCheckBox = new System.Windows.Forms.CheckBox();
            this.rouboCheckBox = new System.Windows.Forms.CheckBox();
            this.btnSair3 = new System.Windows.Forms.Button();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.btnProximo3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbValPremio = new System.Windows.Forms.Label();
            this.lbValApolice = new System.Windows.Forms.Label();
            this.lbValFranquia = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSair4 = new System.Windows.Forms.Button();
            this.btnVoltar3 = new System.Windows.Forms.Button();
            this.btnContratar = new System.Windows.Forms.Button();
            this.apolicesTableAdapter = new appSeguradora.seguradoraDataSetTableAdapters.ApolicesTableAdapter();
            this.modelosTableAdapter = new appSeguradora.seguradoraDataSetTableAdapters.ModelosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apolicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // seguradoraDataSet
            // 
            this.seguradoraDataSet.DataSetName = "seguradoraDataSet";
            this.seguradoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.seguradoraDataSet;
            this.marcasBindingSource.CurrentChanged += new System.EventHandler(this.marcasBindingSource_CurrentChanged);
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApolicesTableAdapter = this.apolicesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.MarcasTableAdapter = null;
            this.tableAdapterManager.ModelosTableAdapter = null;
            this.tableAdapterManager.TabelaFIPETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appSeguradora.seguradoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(300, 18);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 443);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.marcaComboBox);
            this.tabPage1.Controls.Add(this.valorDoBemTextBox);
            this.tabPage1.Controls.Add(this.anoModeloTextBox);
            this.tabPage1.Controls.Add(this.anoFabricacaoTextBox);
            this.tabPage1.Controls.Add(this.modeloComboBox1);
            this.tabPage1.Controls.Add(this.btnSair1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnProximo1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados do veiculo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marcaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.apolicesBindingSource, "Marca", true));
            this.marcaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marcasBindingSource, "Marca", true));
            this.marcaComboBox.DataSource = this.marcasBindingSource;
            this.marcaComboBox.DisplayMember = "Marca";
            this.marcaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Location = new System.Drawing.Point(227, 57);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(544, 37);
            this.marcaComboBox.TabIndex = 19;
            this.marcaComboBox.ValueMember = "Id";
            // 
            // apolicesBindingSource
            // 
            this.apolicesBindingSource.DataMember = "Apolices";
            this.apolicesBindingSource.DataSource = this.seguradoraDataSet;
            // 
            // valorDoBemTextBox
            // 
            this.valorDoBemTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorDoBemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "ValorDoBem", true));
            this.valorDoBemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorDoBemTextBox.Location = new System.Drawing.Point(227, 281);
            this.valorDoBemTextBox.Name = "valorDoBemTextBox";
            this.valorDoBemTextBox.Size = new System.Drawing.Size(544, 35);
            this.valorDoBemTextBox.TabIndex = 18;
            this.valorDoBemTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorDoBemTextBox_KeyPress);
            // 
            // anoModeloTextBox
            // 
            this.anoModeloTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.anoModeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "AnoModelo", true));
            this.anoModeloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anoModeloTextBox.Location = new System.Drawing.Point(227, 227);
            this.anoModeloTextBox.Name = "anoModeloTextBox";
            this.anoModeloTextBox.Size = new System.Drawing.Size(544, 35);
            this.anoModeloTextBox.TabIndex = 17;
            this.anoModeloTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anoModeloTextBox_KeyPress);
            // 
            // anoFabricacaoTextBox
            // 
            this.anoFabricacaoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.anoFabricacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "AnoFabricacao", true));
            this.anoFabricacaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anoFabricacaoTextBox.Location = new System.Drawing.Point(227, 176);
            this.anoFabricacaoTextBox.Name = "anoFabricacaoTextBox";
            this.anoFabricacaoTextBox.Size = new System.Drawing.Size(544, 35);
            this.anoFabricacaoTextBox.TabIndex = 16;
            this.anoFabricacaoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anoFabricacaoTextBox_KeyPress);
            // 
            // modeloComboBox1
            // 
            this.modeloComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modeloComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelosBindingSource, "Modelo", true));
            this.modeloComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.apolicesBindingSource, "Modelo", true));
            this.modeloComboBox1.DataSource = this.modelosBindingSource;
            this.modeloComboBox1.DisplayMember = "Modelo";
            this.modeloComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloComboBox1.FormattingEnabled = true;
            this.modeloComboBox1.Location = new System.Drawing.Point(227, 117);
            this.modeloComboBox1.Name = "modeloComboBox1";
            this.modeloComboBox1.Size = new System.Drawing.Size(544, 37);
            this.modeloComboBox1.TabIndex = 15;
            this.modeloComboBox1.ValueMember = "ModeloID";
            // 
            // modelosBindingSource
            // 
            this.modelosBindingSource.DataMember = "Modelos";
            this.modelosBindingSource.DataSource = this.seguradoraDataSet;
            // 
            // btnSair1
            // 
            this.btnSair1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair1.Location = new System.Drawing.Point(12, 366);
            this.btnSair1.Name = "btnSair1";
            this.btnSair1.Size = new System.Drawing.Size(120, 45);
            this.btnSair1.TabIndex = 13;
            this.btnSair1.Text = "Sair";
            this.btnSair1.UseVisualStyleBackColor = true;
            this.btnSair1.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Preencha os dados do Veículo:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor do Carro*:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ano Modelo*:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ano Fabricação*:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo*:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marca do Veiculo*:";
            // 
            // btnProximo1
            // 
            this.btnProximo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProximo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo1.Location = new System.Drawing.Point(651, 366);
            this.btnProximo1.Name = "btnProximo1";
            this.btnProximo1.Size = new System.Drawing.Size(120, 45);
            this.btnProximo1.TabIndex = 0;
            this.btnProximo1.Text = "Proximo";
            this.btnProximo1.UseVisualStyleBackColor = true;
            this.btnProximo1.Click += new System.EventHandler(this.btnProximo1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.txtAnoHabilitacao);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.cbbCombustivel);
            this.tabPage2.Controls.Add(this.placaTextBox);
            this.tabPage2.Controls.Add(this.chassiTextBox);
            this.tabPage2.Controls.Add(this.btnSair2);
            this.tabPage2.Controls.Add(this.btnVoltar1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnProximo2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados Complementares";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAnoHabilitacao
            // 
            this.txtAnoHabilitacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnoHabilitacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "Placa", true));
            this.txtAnoHabilitacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoHabilitacao.Location = new System.Drawing.Point(348, 236);
            this.txtAnoHabilitacao.Name = "txtAnoHabilitacao";
            this.txtAnoHabilitacao.Size = new System.Drawing.Size(434, 35);
            this.txtAnoHabilitacao.TabIndex = 32;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 236);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(330, 31);
            this.label21.TabIndex = 31;
            this.label21.Text = "Ano Primeira Habilitação*:";
            // 
            // cbbCombustivel
            // 
            this.cbbCombustivel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCombustivel.FormattingEnabled = true;
            this.cbbCombustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Flex",
            "Alcool",
            "Diesel"});
            this.cbbCombustivel.Location = new System.Drawing.Point(201, 167);
            this.cbbCombustivel.Name = "cbbCombustivel";
            this.cbbCombustivel.Size = new System.Drawing.Size(581, 37);
            this.cbbCombustivel.TabIndex = 30;
            // 
            // placaTextBox
            // 
            this.placaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "Placa", true));
            this.placaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placaTextBox.Location = new System.Drawing.Point(201, 113);
            this.placaTextBox.Name = "placaTextBox";
            this.placaTextBox.Size = new System.Drawing.Size(581, 35);
            this.placaTextBox.TabIndex = 29;
            // 
            // chassiTextBox
            // 
            this.chassiTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chassiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "Chassi", true));
            this.chassiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chassiTextBox.Location = new System.Drawing.Point(201, 57);
            this.chassiTextBox.Name = "chassiTextBox";
            this.chassiTextBox.Size = new System.Drawing.Size(581, 35);
            this.chassiTextBox.TabIndex = 28;
            // 
            // btnSair2
            // 
            this.btnSair2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair2.Location = new System.Drawing.Point(6, 366);
            this.btnSair2.Name = "btnSair2";
            this.btnSair2.Size = new System.Drawing.Size(120, 45);
            this.btnSair2.TabIndex = 27;
            this.btnSair2.Text = "Sair";
            this.btnSair2.UseVisualStyleBackColor = true;
            this.btnSair2.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVoltar1
            // 
            this.btnVoltar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar1.Location = new System.Drawing.Point(487, 366);
            this.btnVoltar1.Name = "btnVoltar1";
            this.btnVoltar1.Size = new System.Drawing.Size(120, 45);
            this.btnVoltar1.TabIndex = 26;
            this.btnVoltar1.Text = "Voltar";
            this.btnVoltar1.UseVisualStyleBackColor = true;
            this.btnVoltar1.Click += new System.EventHandler(this.btnVoltar1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(129, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(447, 31);
            this.label7.TabIndex = 21;
            this.label7.Text = "Dados Complementares do Veículo:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 31);
            this.label10.TabIndex = 18;
            this.label10.Text = "Combustivel*:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 31);
            this.label11.TabIndex = 17;
            this.label11.Text = "Placa*:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 31);
            this.label12.TabIndex = 16;
            this.label12.Text = "Chassi*:";
            // 
            // btnProximo2
            // 
            this.btnProximo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProximo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo2.Location = new System.Drawing.Point(662, 366);
            this.btnProximo2.Name = "btnProximo2";
            this.btnProximo2.Size = new System.Drawing.Size(120, 45);
            this.btnProximo2.TabIndex = 14;
            this.btnProximo2.Text = "Proximo";
            this.btnProximo2.UseVisualStyleBackColor = true;
            this.btnProximo2.Click += new System.EventHandler(this.btnProximo2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.franquiaRedCheckBox);
            this.tabPage3.Controls.Add(this.danosTerceirosCheckBox);
            this.tabPage3.Controls.Add(this.acidentesCheckBox);
            this.tabPage3.Controls.Add(this.vidrosCheckBox);
            this.tabPage3.Controls.Add(this.rouboCheckBox);
            this.tabPage3.Controls.Add(this.btnSair3);
            this.tabPage3.Controls.Add(this.btnVoltar2);
            this.tabPage3.Controls.Add(this.btnProximo3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(789, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cobertura";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(94, 276);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(232, 31);
            this.label20.TabIndex = 41;
            this.label20.Text = "Franquia reduzida";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(94, 220);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(288, 31);
            this.label19.TabIndex = 40;
            this.label19.Text = "Danos contra terceiros";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(94, 167);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(396, 31);
            this.label18.TabIndex = 39;
            this.label18.Text = "Acidentes de qualquer natureza";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(94, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(209, 31);
            this.label17.TabIndex = 38;
            this.label17.Text = "Vidros e granizo";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(94, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 31);
            this.label16.TabIndex = 37;
            this.label16.Text = "Roubo";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(145, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(464, 31);
            this.label8.TabIndex = 36;
            this.label8.Text = "Assinale as coberturas desejadas (*):";
            // 
            // franquiaRedCheckBox
            // 
            this.franquiaRedCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.franquiaRedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.apolicesBindingSource, "FranquiaRed", true));
            this.franquiaRedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.franquiaRedCheckBox.Location = new System.Drawing.Point(63, 275);
            this.franquiaRedCheckBox.Name = "franquiaRedCheckBox";
            this.franquiaRedCheckBox.Size = new System.Drawing.Size(25, 39);
            this.franquiaRedCheckBox.TabIndex = 35;
            this.franquiaRedCheckBox.UseVisualStyleBackColor = true;
            // 
            // danosTerceirosCheckBox
            // 
            this.danosTerceirosCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.danosTerceirosCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.apolicesBindingSource, "DanosTerceiros", true));
            this.danosTerceirosCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danosTerceirosCheckBox.Location = new System.Drawing.Point(63, 219);
            this.danosTerceirosCheckBox.Name = "danosTerceirosCheckBox";
            this.danosTerceirosCheckBox.Size = new System.Drawing.Size(25, 39);
            this.danosTerceirosCheckBox.TabIndex = 34;
            this.danosTerceirosCheckBox.UseVisualStyleBackColor = true;
            // 
            // acidentesCheckBox
            // 
            this.acidentesCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acidentesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.apolicesBindingSource, "Acidentes", true));
            this.acidentesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acidentesCheckBox.Location = new System.Drawing.Point(63, 166);
            this.acidentesCheckBox.Name = "acidentesCheckBox";
            this.acidentesCheckBox.Size = new System.Drawing.Size(25, 39);
            this.acidentesCheckBox.TabIndex = 33;
            this.acidentesCheckBox.UseVisualStyleBackColor = true;
            // 
            // vidrosCheckBox
            // 
            this.vidrosCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vidrosCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.apolicesBindingSource, "Vidros", true));
            this.vidrosCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vidrosCheckBox.Location = new System.Drawing.Point(63, 112);
            this.vidrosCheckBox.Name = "vidrosCheckBox";
            this.vidrosCheckBox.Size = new System.Drawing.Size(25, 39);
            this.vidrosCheckBox.TabIndex = 32;
            this.vidrosCheckBox.UseVisualStyleBackColor = true;
            // 
            // rouboCheckBox
            // 
            this.rouboCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rouboCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.apolicesBindingSource, "Roubo", true));
            this.rouboCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rouboCheckBox.Location = new System.Drawing.Point(63, 54);
            this.rouboCheckBox.Name = "rouboCheckBox";
            this.rouboCheckBox.Size = new System.Drawing.Size(25, 39);
            this.rouboCheckBox.TabIndex = 31;
            this.rouboCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnSair3
            // 
            this.btnSair3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair3.Location = new System.Drawing.Point(6, 366);
            this.btnSair3.Name = "btnSair3";
            this.btnSair3.Size = new System.Drawing.Size(120, 45);
            this.btnSair3.TabIndex = 30;
            this.btnSair3.Text = "Sair";
            this.btnSair3.UseVisualStyleBackColor = true;
            this.btnSair3.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar2.Location = new System.Drawing.Point(487, 366);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(120, 45);
            this.btnVoltar2.TabIndex = 29;
            this.btnVoltar2.Text = "Voltar";
            this.btnVoltar2.UseVisualStyleBackColor = true;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
            // 
            // btnProximo3
            // 
            this.btnProximo3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProximo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo3.Location = new System.Drawing.Point(662, 366);
            this.btnProximo3.Name = "btnProximo3";
            this.btnProximo3.Size = new System.Drawing.Size(120, 45);
            this.btnProximo3.TabIndex = 28;
            this.btnProximo3.Text = "Proximo";
            this.btnProximo3.UseVisualStyleBackColor = true;
            this.btnProximo3.Click += new System.EventHandler(this.btnProximo3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbValPremio);
            this.tabPage4.Controls.Add(this.lbValApolice);
            this.tabPage4.Controls.Add(this.lbValFranquia);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.btnSair4);
            this.tabPage4.Controls.Add(this.btnVoltar3);
            this.tabPage4.Controls.Add(this.btnContratar);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(789, 417);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Apolice";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // lbValPremio
            // 
            this.lbValPremio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbValPremio.AutoSize = true;
            this.lbValPremio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValPremio.Location = new System.Drawing.Point(465, 159);
            this.lbValPremio.Name = "lbValPremio";
            this.lbValPremio.Size = new System.Drawing.Size(67, 31);
            this.lbValPremio.TabIndex = 44;
            this.lbValPremio.Text = "0,00";
            // 
            // lbValApolice
            // 
            this.lbValApolice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbValApolice.AutoSize = true;
            this.lbValApolice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValApolice.Location = new System.Drawing.Point(461, 105);
            this.lbValApolice.Name = "lbValApolice";
            this.lbValApolice.Size = new System.Drawing.Size(67, 31);
            this.lbValApolice.TabIndex = 43;
            this.lbValApolice.Text = "0,00";
            // 
            // lbValFranquia
            // 
            this.lbValFranquia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbValFranquia.AutoSize = true;
            this.lbValFranquia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValFranquia.Location = new System.Drawing.Point(486, 217);
            this.lbValFranquia.Name = "lbValFranquia";
            this.lbValFranquia.Size = new System.Drawing.Size(67, 31);
            this.lbValFranquia.TabIndex = 42;
            this.lbValFranquia.Text = "0,00";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(202, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(257, 31);
            this.label15.TabIndex = 40;
            this.label15.Text = "Valor da apólice: R$";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(202, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(278, 31);
            this.label14.TabIndex = 39;
            this.label14.Text = "Valor da Franquia: R$";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(202, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(253, 31);
            this.label13.TabIndex = 38;
            this.label13.Text = "Valor do prêmio: R$";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(259, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 31);
            this.label9.TabIndex = 37;
            this.label9.Text = "Cálculo da apólice:";
            // 
            // btnSair4
            // 
            this.btnSair4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair4.Location = new System.Drawing.Point(6, 366);
            this.btnSair4.Name = "btnSair4";
            this.btnSair4.Size = new System.Drawing.Size(120, 45);
            this.btnSair4.TabIndex = 33;
            this.btnSair4.Text = "Sair";
            this.btnSair4.UseVisualStyleBackColor = true;
            this.btnSair4.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVoltar3
            // 
            this.btnVoltar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar3.Location = new System.Drawing.Point(487, 366);
            this.btnVoltar3.Name = "btnVoltar3";
            this.btnVoltar3.Size = new System.Drawing.Size(120, 45);
            this.btnVoltar3.TabIndex = 32;
            this.btnVoltar3.Text = "Voltar";
            this.btnVoltar3.UseVisualStyleBackColor = true;
            this.btnVoltar3.Click += new System.EventHandler(this.btnVoltar3_Click);
            // 
            // btnContratar
            // 
            this.btnContratar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContratar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContratar.Location = new System.Drawing.Point(662, 366);
            this.btnContratar.Name = "btnContratar";
            this.btnContratar.Size = new System.Drawing.Size(120, 45);
            this.btnContratar.TabIndex = 31;
            this.btnContratar.Text = "Contratar";
            this.btnContratar.UseVisualStyleBackColor = true;
            this.btnContratar.Click += new System.EventHandler(this.btnContratar_Click);
            // 
            // apolicesTableAdapter
            // 
            this.apolicesTableAdapter.ClearBeforeFill = true;
            // 
            // modelosTableAdapter
            // 
            this.modelosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmApolice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmApolice";
            this.Text = "FrmDadosVeiculo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDadosVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apolicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private seguradoraDataSet seguradoraDataSet;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private seguradoraDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private seguradoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnProximo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair1;
        private System.Windows.Forms.Button btnSair2;
        private System.Windows.Forms.Button btnVoltar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnProximo2;
        private System.Windows.Forms.BindingSource apolicesBindingSource;
        private seguradoraDataSetTableAdapters.ApolicesTableAdapter apolicesTableAdapter;
        private System.Windows.Forms.Button btnSair3;
        private System.Windows.Forms.Button btnVoltar2;
        private System.Windows.Forms.Button btnProximo3;
        private System.Windows.Forms.Button btnSair4;
        private System.Windows.Forms.Button btnVoltar3;
        private System.Windows.Forms.Button btnContratar;
        private System.Windows.Forms.BindingSource modelosBindingSource;
        private seguradoraDataSetTableAdapters.ModelosTableAdapter modelosTableAdapter;
        private System.Windows.Forms.TextBox valorDoBemTextBox;
        private System.Windows.Forms.TextBox anoModeloTextBox;
        private System.Windows.Forms.TextBox anoFabricacaoTextBox;
        private System.Windows.Forms.ComboBox modeloComboBox1;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.CheckBox danosTerceirosCheckBox;
        private System.Windows.Forms.CheckBox acidentesCheckBox;
        private System.Windows.Forms.CheckBox vidrosCheckBox;
        private System.Windows.Forms.CheckBox rouboCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox franquiaRedCheckBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbValApolice;
        private System.Windows.Forms.Label lbValFranquia;
        private System.Windows.Forms.TextBox chassiTextBox;
        private System.Windows.Forms.TextBox placaTextBox;
        private System.Windows.Forms.Label lbValPremio;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAnoHabilitacao;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.ComboBox cbbCombustivel;
    }
}