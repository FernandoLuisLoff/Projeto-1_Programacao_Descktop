namespace appSeguradora
{
    partial class FrmModelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModelos));
            this.seguradoraDataSet = new appSeguradora.seguradoraDataSet();
            this.viewModeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewModeloTableAdapter = new appSeguradora.seguradoraDataSetTableAdapters.ViewModeloTableAdapter();
            this.tableAdapterManager = new appSeguradora.seguradoraDataSetTableAdapters.TableAdapterManager();
            this.viewModeloBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovoModelo = new System.Windows.Forms.ToolStripButton();
            this.txtBusca = new System.Windows.Forms.ToolStripTextBox();
            this.CombBusca = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.viewModeloDataGridView = new System.Windows.Forms.DataGridView();
            this.ModeloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModeloBindingNavigator)).BeginInit();
            this.viewModeloBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewModeloDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // seguradoraDataSet
            // 
            this.seguradoraDataSet.DataSetName = "seguradoraDataSet";
            this.seguradoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewModeloBindingSource
            // 
            this.viewModeloBindingSource.DataMember = "ViewModelo";
            this.viewModeloBindingSource.DataSource = this.seguradoraDataSet;
            // 
            // viewModeloTableAdapter
            // 
            this.viewModeloTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApolicesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MarcasTableAdapter = null;
            this.tableAdapterManager.ModelosTableAdapter = null;
            this.tableAdapterManager.TabelaFIPETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appSeguradora.seguradoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // viewModeloBindingNavigator
            // 
            this.viewModeloBindingNavigator.AddNewItem = null;
            this.viewModeloBindingNavigator.BindingSource = this.viewModeloBindingSource;
            this.viewModeloBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.viewModeloBindingNavigator.DeleteItem = null;
            this.viewModeloBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.viewModeloBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNovoModelo,
            this.txtBusca,
            this.CombBusca,
            this.toolStripLabel1,
            this.btnExcluir});
            this.viewModeloBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.viewModeloBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.viewModeloBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.viewModeloBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.viewModeloBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.viewModeloBindingNavigator.Name = "viewModeloBindingNavigator";
            this.viewModeloBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.viewModeloBindingNavigator.Size = new System.Drawing.Size(699, 27);
            this.viewModeloBindingNavigator.TabIndex = 0;
            this.viewModeloBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // btnNovoModelo
            // 
            this.btnNovoModelo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovoModelo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoModelo.Image")));
            this.btnNovoModelo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovoModelo.Name = "btnNovoModelo";
            this.btnNovoModelo.Size = new System.Drawing.Size(24, 24);
            this.btnNovoModelo.Text = "toolStripButton1";
            this.btnNovoModelo.Click += new System.EventHandler(this.btnNovoModelo_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtBusca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(150, 27);
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBuscaMarca_TextChanged);
            // 
            // CombBusca
            // 
            this.CombBusca.AccessibleName = "";
            this.CombBusca.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CombBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombBusca.Items.AddRange(new object[] {
            "Marca",
            "Modelo"});
            this.CombBusca.Name = "CombBusca";
            this.CombBusca.Size = new System.Drawing.Size(75, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 24);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(24, 24);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // viewModeloDataGridView
            // 
            this.viewModeloDataGridView.AllowUserToAddRows = false;
            this.viewModeloDataGridView.AutoGenerateColumns = false;
            this.viewModeloDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewModeloDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModeloID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.viewModeloDataGridView.DataSource = this.viewModeloBindingSource;
            this.viewModeloDataGridView.Location = new System.Drawing.Point(12, 28);
            this.viewModeloDataGridView.Name = "viewModeloDataGridView";
            this.viewModeloDataGridView.RowHeadersWidth = 51;
            this.viewModeloDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewModeloDataGridView.Size = new System.Drawing.Size(675, 400);
            this.viewModeloDataGridView.TabIndex = 1;
            this.viewModeloDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewModeloDataGridView_CellDoubleClick);
            // 
            // ModeloID
            // 
            this.ModeloID.DataPropertyName = "ModeloID";
            this.ModeloID.HeaderText = "ModeloID";
            this.ModeloID.MinimumWidth = 6;
            this.ModeloID.Name = "ModeloID";
            this.ModeloID.ReadOnly = true;
            this.ModeloID.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MarcaID";
            this.dataGridViewTextBoxColumn3.HeaderText = "MarcaID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Marcas";
            this.dataGridViewTextBoxColumn4.HeaderText = "Marcas";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // FrmModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 440);
            this.Controls.Add(this.viewModeloDataGridView);
            this.Controls.Add(this.viewModeloBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModelos";
            this.Load += new System.EventHandler(this.FrmModelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModeloBindingNavigator)).EndInit();
            this.viewModeloBindingNavigator.ResumeLayout(false);
            this.viewModeloBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewModeloDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private seguradoraDataSet seguradoraDataSet;
        private System.Windows.Forms.BindingSource viewModeloBindingSource;
        private seguradoraDataSetTableAdapters.ViewModeloTableAdapter viewModeloTableAdapter;
        private seguradoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator viewModeloBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnNovoModelo;
        private System.Windows.Forms.DataGridView viewModeloDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripTextBox txtBusca;
        private System.Windows.Forms.ToolStripComboBox CombBusca;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnExcluir;
    }
}