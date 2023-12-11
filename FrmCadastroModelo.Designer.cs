namespace appSeguradora
{
    partial class FrmCadastroModelo
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
            System.Windows.Forms.Label modeloIDLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label marcaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroModelo));
            this.seguradoraDataSet = new appSeguradora.seguradoraDataSet();
            this.modelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelosTableAdapter = new appSeguradora.seguradoraDataSetTableAdapters.ModelosTableAdapter();
            this.tableAdapterManager = new appSeguradora.seguradoraDataSetTableAdapters.TableAdapterManager();
            this.marcasTableAdapter = new appSeguradora.seguradoraDataSetTableAdapters.MarcasTableAdapter();
            this.modelosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.modelosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeloIDTextBox = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            modeloIDLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingNavigator)).BeginInit();
            this.modelosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // modeloIDLabel
            // 
            modeloIDLabel.AutoSize = true;
            modeloIDLabel.Location = new System.Drawing.Point(14, 43);
            modeloIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            modeloIDLabel.Name = "modeloIDLabel";
            modeloIDLabel.Size = new System.Drawing.Size(59, 13);
            modeloIDLabel.TabIndex = 3;
            modeloIDLabel.Text = "Modelo ID:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(14, 67);
            modeloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 5;
            modeloLabel.Text = "Modelo:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(14, 92);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 6;
            marcaLabel.Text = "Marca:";
            // 
            // seguradoraDataSet
            // 
            this.seguradoraDataSet.DataSetName = "seguradoraDataSet";
            this.seguradoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelosBindingSource
            // 
            this.modelosBindingSource.DataMember = "Modelos";
            this.modelosBindingSource.DataSource = this.seguradoraDataSet;
            // 
            // modelosTableAdapter
            // 
            this.modelosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApolicesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.MarcasTableAdapter = this.marcasTableAdapter;
            this.tableAdapterManager.ModelosTableAdapter = this.modelosTableAdapter;
            this.tableAdapterManager.TabelaFIPETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appSeguradora.seguradoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // modelosBindingNavigator
            // 
            this.modelosBindingNavigator.AddNewItem = null;
            this.modelosBindingNavigator.BindingSource = this.modelosBindingSource;
            this.modelosBindingNavigator.CountItem = null;
            this.modelosBindingNavigator.DeleteItem = null;
            this.modelosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.modelosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelosBindingNavigatorSaveItem});
            this.modelosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.modelosBindingNavigator.MoveFirstItem = null;
            this.modelosBindingNavigator.MoveLastItem = null;
            this.modelosBindingNavigator.MoveNextItem = null;
            this.modelosBindingNavigator.MovePreviousItem = null;
            this.modelosBindingNavigator.Name = "modelosBindingNavigator";
            this.modelosBindingNavigator.PositionItem = null;
            this.modelosBindingNavigator.Size = new System.Drawing.Size(384, 27);
            this.modelosBindingNavigator.TabIndex = 0;
            this.modelosBindingNavigator.Text = "bindingNavigator1";
            // 
            // modelosBindingNavigatorSaveItem
            // 
            this.modelosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.modelosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("modelosBindingNavigatorSaveItem.Image")));
            this.modelosBindingNavigatorSaveItem.Name = "modelosBindingNavigatorSaveItem";
            this.modelosBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.modelosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.modelosBindingNavigatorSaveItem.Click += new System.EventHandler(this.modelosBindingNavigatorSaveItem_Click);
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.seguradoraDataSet;
            // 
            // modeloIDTextBox
            // 
            this.modeloIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelosBindingSource, "ModeloID", true));
            this.modeloIDTextBox.Location = new System.Drawing.Point(92, 40);
            this.modeloIDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modeloIDTextBox.Name = "modeloIDTextBox";
            this.modeloIDTextBox.ReadOnly = true;
            this.modeloIDTextBox.Size = new System.Drawing.Size(281, 20);
            this.modeloIDTextBox.TabIndex = 4;
            // 
            // txtModelo
            // 
            this.txtModelo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelosBindingSource, "Modelo", true));
            this.txtModelo.Location = new System.Drawing.Point(92, 64);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(281, 20);
            this.txtModelo.TabIndex = 6;
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marcasBindingSource, "Marca", true));
            this.marcaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.modelosBindingSource, "MarcaID", true));
            this.marcaComboBox.DataSource = this.marcasBindingSource;
            this.marcaComboBox.DisplayMember = "Marca";
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Location = new System.Drawing.Point(92, 89);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(281, 21);
            this.marcaComboBox.TabIndex = 7;
            this.marcaComboBox.ValueMember = "Id";
            // 
            // FrmCadastroModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 129);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaComboBox);
            this.Controls.Add(modeloIDLabel);
            this.Controls.Add(this.modeloIDTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.modelosBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroModelo";
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingNavigator)).EndInit();
            this.modelosBindingNavigator.ResumeLayout(false);
            this.modelosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private seguradoraDataSet seguradoraDataSet;
        private System.Windows.Forms.BindingSource modelosBindingSource;
        private seguradoraDataSetTableAdapters.ModelosTableAdapter modelosTableAdapter;
        private seguradoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator modelosBindingNavigator;
        private System.Windows.Forms.ToolStripButton modelosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox modeloIDTextBox;
        private System.Windows.Forms.TextBox txtModelo;
        private seguradoraDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private System.Windows.Forms.ComboBox marcaComboBox;
    }
}