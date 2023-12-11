namespace appSeguradora
{
    partial class FrmFipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFipe));
            this.seguradoraDataSet = new appSeguradora.seguradoraDataSet();
            this.viewFipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewFipeTableAdapter = new appSeguradora.seguradoraDataSetTableAdapters.ViewFipeTableAdapter();
            this.tableAdapterManager = new appSeguradora.seguradoraDataSetTableAdapters.TableAdapterManager();
            this.viewFipeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovaFipe = new System.Windows.Forms.ToolStripButton();
            this.txtBusca = new System.Windows.Forms.ToolStripTextBox();
            this.cbbBusca = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Excluir = new System.Windows.Forms.ToolStripButton();
            this.viewFipeDataGridView = new System.Windows.Forms.DataGridView();
            this.ModeloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFipeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFipeBindingNavigator)).BeginInit();
            this.viewFipeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewFipeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // seguradoraDataSet
            // 
            this.seguradoraDataSet.DataSetName = "seguradoraDataSet";
            this.seguradoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewFipeBindingSource
            // 
            this.viewFipeBindingSource.DataMember = "ViewFipe";
            this.viewFipeBindingSource.DataSource = this.seguradoraDataSet;
            // 
            // viewFipeTableAdapter
            // 
            this.viewFipeTableAdapter.ClearBeforeFill = true;
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
            // viewFipeBindingNavigator
            // 
            this.viewFipeBindingNavigator.AddNewItem = null;
            this.viewFipeBindingNavigator.BindingSource = this.viewFipeBindingSource;
            this.viewFipeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.viewFipeBindingNavigator.DeleteItem = null;
            this.viewFipeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.viewFipeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNovaFipe,
            this.txtBusca,
            this.cbbBusca,
            this.toolStripLabel1,
            this.btn_Excluir});
            this.viewFipeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.viewFipeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.viewFipeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.viewFipeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.viewFipeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.viewFipeBindingNavigator.Name = "viewFipeBindingNavigator";
            this.viewFipeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.viewFipeBindingNavigator.Size = new System.Drawing.Size(749, 27);
            this.viewFipeBindingNavigator.TabIndex = 0;
            this.viewFipeBindingNavigator.Text = "bindingNavigator1";
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
            // btnNovaFipe
            // 
            this.btnNovaFipe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovaFipe.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaFipe.Image")));
            this.btnNovaFipe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovaFipe.Name = "btnNovaFipe";
            this.btnNovaFipe.Size = new System.Drawing.Size(24, 24);
            this.btnNovaFipe.Text = "toolStripButton1";
            this.btnNovaFipe.Click += new System.EventHandler(this.btnNovaFipe_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtBusca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(150, 27);
            this.txtBusca.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // cbbBusca
            // 
            this.cbbBusca.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cbbBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBusca.Items.AddRange(new object[] {
            "Marcas",
            "Modelos"});
            this.cbbBusca.Name = "cbbBusca";
            this.cbbBusca.Size = new System.Drawing.Size(75, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 24);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excluir.Image")));
            this.btn_Excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(24, 24);
            this.btn_Excluir.Text = "Remover";
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // viewFipeDataGridView
            // 
            this.viewFipeDataGridView.AllowUserToAddRows = false;
            this.viewFipeDataGridView.AutoGenerateColumns = false;
            this.viewFipeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewFipeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewFipeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModeloID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.Ano,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.viewFipeDataGridView.DataSource = this.viewFipeBindingSource;
            this.viewFipeDataGridView.Location = new System.Drawing.Point(12, 28);
            this.viewFipeDataGridView.Name = "viewFipeDataGridView";
            this.viewFipeDataGridView.RowHeadersWidth = 51;
            this.viewFipeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewFipeDataGridView.Size = new System.Drawing.Size(725, 400);
            this.viewFipeDataGridView.TabIndex = 1;
            this.viewFipeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewFipeDataGridView_CellDoubleClick);
            // 
            // ModeloID
            // 
            this.ModeloID.DataPropertyName = "ModeloID";
            this.ModeloID.HeaderText = "ModeloID";
            this.ModeloID.MinimumWidth = 6;
            this.ModeloID.Name = "ModeloID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn1.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Ano
            // 
            this.Ano.DataPropertyName = "Ano";
            this.Ano.HeaderText = "Ano";
            this.Ano.MinimumWidth = 6;
            this.Ano.Name = "Ano";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MarcaID";
            this.dataGridViewTextBoxColumn5.HeaderText = "MarcaID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // FrmFipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 440);
            this.Controls.Add(this.viewFipeDataGridView);
            this.Controls.Add(this.viewFipeBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFipe";
            this.Load += new System.EventHandler(this.FrmFipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFipeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFipeBindingNavigator)).EndInit();
            this.viewFipeBindingNavigator.ResumeLayout(false);
            this.viewFipeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewFipeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private seguradoraDataSet seguradoraDataSet;
        private System.Windows.Forms.BindingSource viewFipeBindingSource;
        private seguradoraDataSetTableAdapters.ViewFipeTableAdapter viewFipeTableAdapter;
        private seguradoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator viewFipeBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnNovaFipe;
        private System.Windows.Forms.DataGridView viewFipeDataGridView;
        private System.Windows.Forms.ToolStripTextBox txtBusca;
        private System.Windows.Forms.ToolStripComboBox cbbBusca;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_Excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}