namespace appSeguradora
{
    partial class FrmCadastroFipe
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
            System.Windows.Forms.Label anoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label marcaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroFipe));
            this.seguradoraDataSet = new appSeguradora.seguradoraDataSet();
            this.tabelaFIPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaFIPETableAdapter = new appSeguradora.seguradoraDataSetTableAdapters.TabelaFIPETableAdapter();
            this.tableAdapterManager = new appSeguradora.seguradoraDataSetTableAdapters.TableAdapterManager();
            this.marcasTableAdapter = new appSeguradora.seguradoraDataSetTableAdapters.MarcasTableAdapter();
            this.modelosTableAdapter = new appSeguradora.seguradoraDataSetTableAdapters.ModelosTableAdapter();
            this.tabelaFIPEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabelaFIPEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.modelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbModelo = new System.Windows.Forms.ComboBox();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbMarca = new System.Windows.Forms.ComboBox();
            anoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingNavigator)).BeginInit();
            this.tabelaFIPEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Location = new System.Drawing.Point(19, 103);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(29, 13);
            anoLabel.TabIndex = 5;
            anoLabel.Text = "Ano:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(19, 129);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 7;
            valorLabel.Text = "Valor:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(12, 76);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 8;
            modeloLabel.Text = "Modelo:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(12, 49);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 9;
            marcaLabel.Text = "Marca:";
            // 
            // seguradoraDataSet
            // 
            this.seguradoraDataSet.DataSetName = "seguradoraDataSet";
            this.seguradoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelaFIPEBindingSource
            // 
            this.tabelaFIPEBindingSource.DataMember = "TabelaFIPE";
            this.tabelaFIPEBindingSource.DataSource = this.seguradoraDataSet;
            // 
            // tabelaFIPETableAdapter
            // 
            this.tabelaFIPETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApolicesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.MarcasTableAdapter = this.marcasTableAdapter;
            this.tableAdapterManager.ModelosTableAdapter = this.modelosTableAdapter;
            this.tableAdapterManager.TabelaFIPETableAdapter = this.tabelaFIPETableAdapter;
            this.tableAdapterManager.UpdateOrder = appSeguradora.seguradoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // modelosTableAdapter
            // 
            this.modelosTableAdapter.ClearBeforeFill = true;
            // 
            // tabelaFIPEBindingNavigator
            // 
            this.tabelaFIPEBindingNavigator.AddNewItem = null;
            this.tabelaFIPEBindingNavigator.BindingSource = this.tabelaFIPEBindingSource;
            this.tabelaFIPEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabelaFIPEBindingNavigator.DeleteItem = null;
            this.tabelaFIPEBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tabelaFIPEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tabelaFIPEBindingNavigatorSaveItem});
            this.tabelaFIPEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabelaFIPEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabelaFIPEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabelaFIPEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabelaFIPEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabelaFIPEBindingNavigator.Name = "tabelaFIPEBindingNavigator";
            this.tabelaFIPEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabelaFIPEBindingNavigator.Size = new System.Drawing.Size(301, 27);
            this.tabelaFIPEBindingNavigator.TabIndex = 0;
            this.tabelaFIPEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tabelaFIPEBindingNavigatorSaveItem
            // 
            this.tabelaFIPEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabelaFIPEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabelaFIPEBindingNavigatorSaveItem.Image")));
            this.tabelaFIPEBindingNavigatorSaveItem.Name = "tabelaFIPEBindingNavigatorSaveItem";
            this.tabelaFIPEBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tabelaFIPEBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tabelaFIPEBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabelaFIPEBindingNavigatorSaveItem_Click);
            // 
            // txtAno
            // 
            this.txtAno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaFIPEBindingSource, "Ano", true));
            this.txtAno.Location = new System.Drawing.Point(97, 100);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 6;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // txtValor
            // 
            this.txtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaFIPEBindingSource, "Valor", true));
            this.txtValor.Location = new System.Drawing.Point(97, 126);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 8;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // modelosBindingSource
            // 
            this.modelosBindingSource.DataMember = "Modelos";
            this.modelosBindingSource.DataSource = this.seguradoraDataSet;
            // 
            // cbbModelo
            // 
            this.cbbModelo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelosBindingSource, "Modelo", true));
            this.cbbModelo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabelaFIPEBindingSource, "ModeloID", true));
            this.cbbModelo.DataSource = this.modelosBindingSource;
            this.cbbModelo.DisplayMember = "Modelo";
            this.cbbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbModelo.FormattingEnabled = true;
            this.cbbModelo.Location = new System.Drawing.Point(76, 73);
            this.cbbModelo.Name = "cbbModelo";
            this.cbbModelo.Size = new System.Drawing.Size(121, 21);
            this.cbbModelo.TabIndex = 9;
            this.cbbModelo.ValueMember = "ModeloID";
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.seguradoraDataSet;
            this.marcasBindingSource.PositionChanged += new System.EventHandler(this.marcasBindingSource_PositionChanged);
            // 
            // cbbMarca
            // 
            this.cbbMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marcasBindingSource, "Marca", true));
            this.cbbMarca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabelaFIPEBindingSource, "MarcaID", true));
            this.cbbMarca.DataSource = this.marcasBindingSource;
            this.cbbMarca.DisplayMember = "Marca";
            this.cbbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMarca.FormattingEnabled = true;
            this.cbbMarca.Location = new System.Drawing.Point(76, 46);
            this.cbbMarca.Name = "cbbMarca";
            this.cbbMarca.Size = new System.Drawing.Size(121, 21);
            this.cbbMarca.TabIndex = 10;
            this.cbbMarca.ValueMember = "Id";
            // 
            // FrmCadastroFipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 189);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.cbbMarca);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.cbbModelo);
            this.Controls.Add(anoLabel);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.tabelaFIPEBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroFipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroFipe";
            this.Load += new System.EventHandler(this.FrmCadastroFipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingNavigator)).EndInit();
            this.tabelaFIPEBindingNavigator.ResumeLayout(false);
            this.tabelaFIPEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private seguradoraDataSet seguradoraDataSet;
        private System.Windows.Forms.BindingSource tabelaFIPEBindingSource;
        private seguradoraDataSetTableAdapters.TabelaFIPETableAdapter tabelaFIPETableAdapter;
        private seguradoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabelaFIPEBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tabelaFIPEBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtValor;
        private seguradoraDataSetTableAdapters.ModelosTableAdapter modelosTableAdapter;
        private System.Windows.Forms.BindingSource modelosBindingSource;
        private System.Windows.Forms.ComboBox cbbModelo;
        private seguradoraDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private System.Windows.Forms.ComboBox cbbMarca;
    }
}