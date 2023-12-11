namespace appSeguradora
{
    partial class FrmCadastroMarcas
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label marcaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroMarcas));
            this.seguradoraDataSet = new appSeguradora.seguradoraDataSet();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter = new appSeguradora.seguradoraDataSetTableAdapters.MarcasTableAdapter();
            this.tableAdapterManager = new appSeguradora.seguradoraDataSetTableAdapters.TableAdapterManager();
            this.marcasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.marcasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingNavigator)).BeginInit();
            this.marcasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(11, 44);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(11, 70);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 3;
            marcaLabel.Text = "Marca:";
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
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApolicesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.MarcasTableAdapter = this.marcasTableAdapter;
            this.tableAdapterManager.ModelosTableAdapter = null;
            this.tableAdapterManager.TabelaFIPETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appSeguradora.seguradoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // marcasBindingNavigator
            // 
            this.marcasBindingNavigator.AddNewItem = null;
            this.marcasBindingNavigator.BindingSource = this.marcasBindingSource;
            this.marcasBindingNavigator.CountItem = null;
            this.marcasBindingNavigator.DeleteItem = null;
            this.marcasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.marcasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcasBindingNavigatorSaveItem});
            this.marcasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.marcasBindingNavigator.MoveFirstItem = null;
            this.marcasBindingNavigator.MoveLastItem = null;
            this.marcasBindingNavigator.MoveNextItem = null;
            this.marcasBindingNavigator.MovePreviousItem = null;
            this.marcasBindingNavigator.Name = "marcasBindingNavigator";
            this.marcasBindingNavigator.PositionItem = null;
            this.marcasBindingNavigator.Size = new System.Drawing.Size(328, 27);
            this.marcasBindingNavigator.TabIndex = 0;
            this.marcasBindingNavigator.Text = "bindingNavigator1";
            // 
            // marcasBindingNavigatorSaveItem
            // 
            this.marcasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.marcasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("marcasBindingNavigatorSaveItem.Image")));
            this.marcasBindingNavigatorSaveItem.Name = "marcasBindingNavigatorSaveItem";
            this.marcasBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.marcasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.marcasBindingNavigatorSaveItem.Click += new System.EventHandler(this.marcasBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marcasBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(57, 41);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(259, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // txtMarca
            // 
            this.txtMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marcasBindingSource, "Marca", true));
            this.txtMarca.Location = new System.Drawing.Point(57, 67);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(259, 20);
            this.txtMarca.TabIndex = 4;
            // 
            // FrmCadastroMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 120);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.marcasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingNavigator)).EndInit();
            this.marcasBindingNavigator.ResumeLayout(false);
            this.marcasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private seguradoraDataSet seguradoraDataSet;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private seguradoraDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private seguradoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator marcasBindingNavigator;
        private System.Windows.Forms.ToolStripButton marcasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox txtMarca;
    }
}