namespace appSeguradora
{
    partial class FrmCadastroUsuario
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
            System.Windows.Forms.Label clienteIDLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label uFLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label orgaoEmissorLabel;
            System.Windows.Forms.Label cartMotoristaLabel;
            System.Windows.Forms.Label emissaoCartMotLabel;
            System.Windows.Forms.Label categoriaMotLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label emailLabel;
            this.seguradoraDataSet = new appSeguradora.seguradoraDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new appSeguradora.seguradoraDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new appSeguradora.seguradoraDataSetTableAdapters.TableAdapterManager();
            this.clienteIDTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cEPTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.uFTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.rGTextBox = new System.Windows.Forms.TextBox();
            this.orgaoEmissorTextBox = new System.Windows.Forms.TextBox();
            this.cartMotoristaTextBox = new System.Windows.Forms.TextBox();
            this.emissaoCartMotDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoriaMotTextBox = new System.Windows.Forms.TextBox();
            this.dataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clienteIDLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            uFLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            orgaoEmissorLabel = new System.Windows.Forms.Label();
            cartMotoristaLabel = new System.Windows.Forms.Label();
            emissaoCartMotLabel = new System.Windows.Forms.Label();
            categoriaMotLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteIDLabel
            // 
            clienteIDLabel.AutoSize = true;
            clienteIDLabel.Location = new System.Drawing.Point(30, 64);
            clienteIDLabel.Name = "clienteIDLabel";
            clienteIDLabel.Size = new System.Drawing.Size(56, 13);
            clienteIDLabel.TabIndex = 1;
            clienteIDLabel.Text = "Cliente ID:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(30, 90);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(30, 116);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 5;
            enderecoLabel.Text = "Endereco:";
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Location = new System.Drawing.Point(30, 142);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(31, 13);
            cEPLabel.TabIndex = 7;
            cEPLabel.Text = "CEP:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(30, 168);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 9;
            cidadeLabel.Text = "Cidade:";
            // 
            // uFLabel
            // 
            uFLabel.AutoSize = true;
            uFLabel.Location = new System.Drawing.Point(30, 194);
            uFLabel.Name = "uFLabel";
            uFLabel.Size = new System.Drawing.Size(24, 13);
            uFLabel.TabIndex = 11;
            uFLabel.Text = "UF:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(30, 220);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 13;
            telefoneLabel.Text = "Telefone:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(30, 246);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(42, 13);
            celularLabel.TabIndex = 15;
            celularLabel.Text = "Celular:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(30, 272);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 17;
            cPFLabel.Text = "CPF:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(30, 298);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(26, 13);
            rGLabel.TabIndex = 19;
            rGLabel.Text = "RG:";
            // 
            // orgaoEmissorLabel
            // 
            orgaoEmissorLabel.AutoSize = true;
            orgaoEmissorLabel.Location = new System.Drawing.Point(30, 324);
            orgaoEmissorLabel.Name = "orgaoEmissorLabel";
            orgaoEmissorLabel.Size = new System.Drawing.Size(78, 13);
            orgaoEmissorLabel.TabIndex = 21;
            orgaoEmissorLabel.Text = "Orgao Emissor:";
            // 
            // cartMotoristaLabel
            // 
            cartMotoristaLabel.AutoSize = true;
            cartMotoristaLabel.Location = new System.Drawing.Point(30, 350);
            cartMotoristaLabel.Name = "cartMotoristaLabel";
            cartMotoristaLabel.Size = new System.Drawing.Size(75, 13);
            cartMotoristaLabel.TabIndex = 23;
            cartMotoristaLabel.Text = "Cart Motorista:";
            // 
            // emissaoCartMotLabel
            // 
            emissaoCartMotLabel.AutoSize = true;
            emissaoCartMotLabel.Location = new System.Drawing.Point(30, 377);
            emissaoCartMotLabel.Name = "emissaoCartMotLabel";
            emissaoCartMotLabel.Size = new System.Drawing.Size(92, 13);
            emissaoCartMotLabel.TabIndex = 25;
            emissaoCartMotLabel.Text = "Emissao Cart Mot:";
            // 
            // categoriaMotLabel
            // 
            categoriaMotLabel.AutoSize = true;
            categoriaMotLabel.Location = new System.Drawing.Point(30, 402);
            categoriaMotLabel.Name = "categoriaMotLabel";
            categoriaMotLabel.Size = new System.Drawing.Size(76, 13);
            categoriaMotLabel.TabIndex = 27;
            categoriaMotLabel.Text = "Categoria Mot:";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(30, 429);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(92, 13);
            dataNascimentoLabel.TabIndex = 29;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(30, 454);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 31;
            emailLabel.Text = "Email:";
            // 
            // seguradoraDataSet
            // 
            this.seguradoraDataSet.DataSetName = "seguradoraDataSet";
            this.seguradoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.seguradoraDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApolicesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.MarcasTableAdapter = null;
            this.tableAdapterManager.ModelosTableAdapter = null;
            this.tableAdapterManager.TabelaFIPETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appSeguradora.seguradoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteIDTextBox
            // 
            this.clienteIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "ClienteID", true));
            this.clienteIDTextBox.Enabled = false;
            this.clienteIDTextBox.Location = new System.Drawing.Point(128, 61);
            this.clienteIDTextBox.Name = "clienteIDTextBox";
            this.clienteIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.clienteIDTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(128, 87);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(128, 113);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(200, 20);
            this.enderecoTextBox.TabIndex = 6;
            // 
            // cEPTextBox
            // 
            this.cEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CEP", true));
            this.cEPTextBox.Location = new System.Drawing.Point(128, 139);
            this.cEPTextBox.Name = "cEPTextBox";
            this.cEPTextBox.Size = new System.Drawing.Size(200, 20);
            this.cEPTextBox.TabIndex = 8;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(128, 165);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.cidadeTextBox.TabIndex = 10;
            // 
            // uFTextBox
            // 
            this.uFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "UF", true));
            this.uFTextBox.Location = new System.Drawing.Point(128, 191);
            this.uFTextBox.Name = "uFTextBox";
            this.uFTextBox.Size = new System.Drawing.Size(200, 20);
            this.uFTextBox.TabIndex = 12;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(128, 217);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefoneTextBox.TabIndex = 14;
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Celular", true));
            this.celularTextBox.Location = new System.Drawing.Point(128, 243);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(200, 20);
            this.celularTextBox.TabIndex = 16;
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(128, 269);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(200, 20);
            this.cPFTextBox.TabIndex = 18;
            // 
            // rGTextBox
            // 
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "RG", true));
            this.rGTextBox.Location = new System.Drawing.Point(128, 295);
            this.rGTextBox.Name = "rGTextBox";
            this.rGTextBox.Size = new System.Drawing.Size(200, 20);
            this.rGTextBox.TabIndex = 20;
            // 
            // orgaoEmissorTextBox
            // 
            this.orgaoEmissorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "OrgaoEmissor", true));
            this.orgaoEmissorTextBox.Location = new System.Drawing.Point(128, 321);
            this.orgaoEmissorTextBox.Name = "orgaoEmissorTextBox";
            this.orgaoEmissorTextBox.Size = new System.Drawing.Size(200, 20);
            this.orgaoEmissorTextBox.TabIndex = 22;
            // 
            // cartMotoristaTextBox
            // 
            this.cartMotoristaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CartMotorista", true));
            this.cartMotoristaTextBox.Location = new System.Drawing.Point(128, 347);
            this.cartMotoristaTextBox.Name = "cartMotoristaTextBox";
            this.cartMotoristaTextBox.Size = new System.Drawing.Size(200, 20);
            this.cartMotoristaTextBox.TabIndex = 24;
            // 
            // emissaoCartMotDateTimePicker
            // 
            this.emissaoCartMotDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "EmissaoCartMot", true));
            this.emissaoCartMotDateTimePicker.Location = new System.Drawing.Point(128, 373);
            this.emissaoCartMotDateTimePicker.Name = "emissaoCartMotDateTimePicker";
            this.emissaoCartMotDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.emissaoCartMotDateTimePicker.TabIndex = 26;
            // 
            // categoriaMotTextBox
            // 
            this.categoriaMotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CategoriaMot", true));
            this.categoriaMotTextBox.Location = new System.Drawing.Point(128, 399);
            this.categoriaMotTextBox.Name = "categoriaMotTextBox";
            this.categoriaMotTextBox.Size = new System.Drawing.Size(200, 20);
            this.categoriaMotTextBox.TabIndex = 28;
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "DataNascimento", true));
            this.dataNascimentoDateTimePicker.Location = new System.Drawing.Point(128, 425);
            this.dataNascimentoDateTimePicker.Name = "dataNascimentoDateTimePicker";
            this.dataNascimentoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataNascimentoDateTimePicker.TabIndex = 30;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(128, 451);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Cadastro Cliente";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(499, 674);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 34;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.AutoGenerateColumns = false;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.clientesDataGridView.DataSource = this.clientesBindingSource;
            this.clientesDataGridView.Location = new System.Drawing.Point(12, 477);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.Size = new System.Drawing.Size(481, 220);
            this.clientesDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ClienteID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ClienteID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Endereco";
            this.dataGridViewTextBoxColumn3.HeaderText = "Endereco";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CEP";
            this.dataGridViewTextBoxColumn4.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cidade";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UF";
            this.dataGridViewTextBoxColumn6.HeaderText = "UF";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn7.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Celular";
            this.dataGridViewTextBoxColumn8.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn9.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "RG";
            this.dataGridViewTextBoxColumn10.HeaderText = "RG";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "OrgaoEmissor";
            this.dataGridViewTextBoxColumn11.HeaderText = "OrgaoEmissor";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CartMotorista";
            this.dataGridViewTextBoxColumn12.HeaderText = "CartMotorista";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "EmissaoCartMot";
            this.dataGridViewTextBoxColumn13.HeaderText = "EmissaoCartMot";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "CategoriaMot";
            this.dataGridViewTextBoxColumn14.HeaderText = "CategoriaMot";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "DataNascimento";
            this.dataGridViewTextBoxColumn15.HeaderText = "DataNascimento";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn16.HeaderText = "Email";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // FrmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 716);
            this.Controls.Add(this.clientesDataGridView);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(clienteIDLabel);
            this.Controls.Add(this.clienteIDTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(cEPLabel);
            this.Controls.Add(this.cEPTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(uFLabel);
            this.Controls.Add(this.uFTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.rGTextBox);
            this.Controls.Add(orgaoEmissorLabel);
            this.Controls.Add(this.orgaoEmissorTextBox);
            this.Controls.Add(cartMotoristaLabel);
            this.Controls.Add(this.cartMotoristaTextBox);
            this.Controls.Add(emissaoCartMotLabel);
            this.Controls.Add(this.emissaoCartMotDateTimePicker);
            this.Controls.Add(categoriaMotLabel);
            this.Controls.Add(this.categoriaMotTextBox);
            this.Controls.Add(dataNascimentoLabel);
            this.Controls.Add(this.dataNascimentoDateTimePicker);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCadastroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private seguradoraDataSet seguradoraDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private seguradoraDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private seguradoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox clienteIDTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox cEPTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox uFTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox rGTextBox;
        private System.Windows.Forms.TextBox orgaoEmissorTextBox;
        private System.Windows.Forms.TextBox cartMotoristaTextBox;
        private System.Windows.Forms.DateTimePicker emissaoCartMotDateTimePicker;
        private System.Windows.Forms.TextBox categoriaMotTextBox;
        private System.Windows.Forms.DateTimePicker dataNascimentoDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}