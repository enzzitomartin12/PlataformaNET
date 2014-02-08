namespace Formularios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label iDClienteLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label iDContactoLabel;
            System.Windows.Forms.Label calleLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label pisoLabel;
            System.Windows.Forms.Label departamentoLabel;
            System.Windows.Forms.Label cuidadLabel;
            System.Windows.Forms.Label provinciaLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label webLabel;
            this.proyectosDataSet = new Formularios.ProyectosDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new Formularios.ProyectosDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new Formularios.ProyectosDataSetTableAdapters.TableAdapterManager();
            this.clientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.clientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDClienteLabel1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.iDContactoTextBox = new System.Windows.Forms.TextBox();
            this.calleTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.pisoTextBox = new System.Windows.Forms.TextBox();
            this.departamentoTextBox = new System.Windows.Forms.TextBox();
            this.cuidadTextBox = new System.Windows.Forms.TextBox();
            this.provinciaTextBox = new System.Windows.Forms.TextBox();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.webTextBox = new System.Windows.Forms.TextBox();
            this.proyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectosTableAdapter = new Formularios.ProyectosDataSetTableAdapters.ProyectosTableAdapter();
            this.proyectosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKProyectosClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iDClienteLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            iDContactoLabel = new System.Windows.Forms.Label();
            calleLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            pisoLabel = new System.Windows.Forms.Label();
            departamentoLabel = new System.Windows.Forms.Label();
            cuidadLabel = new System.Windows.Forms.Label();
            provinciaLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            webLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).BeginInit();
            this.clientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProyectosClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // proyectosDataSet
            // 
            this.proyectosDataSet.DataSetName = "ProyectosDataSet";
            this.proyectosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.proyectosDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.ProyectosTableAdapter = this.proyectosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Formularios.ProyectosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientesBindingNavigator
            // 
            this.clientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientesBindingNavigator.BindingSource = this.clientesBindingSource;
            this.clientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clientesBindingNavigatorSaveItem});
            this.clientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientesBindingNavigator.Name = "clientesBindingNavigator";
            this.clientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientesBindingNavigator.Size = new System.Drawing.Size(752, 25);
            this.clientesBindingNavigator.TabIndex = 0;
            this.clientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // clientesBindingNavigatorSaveItem
            // 
            this.clientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesBindingNavigatorSaveItem.Image")));
            this.clientesBindingNavigatorSaveItem.Name = "clientesBindingNavigatorSaveItem";
            this.clientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.clientesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.clientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientesBindingNavigatorSaveItem_Click);
            // 
            // iDClienteLabel
            // 
            iDClienteLabel.AutoSize = true;
            iDClienteLabel.Location = new System.Drawing.Point(25, 58);
            iDClienteLabel.Name = "iDClienteLabel";
            iDClienteLabel.Size = new System.Drawing.Size(53, 13);
            iDClienteLabel.TabIndex = 1;
            iDClienteLabel.Text = "IDCliente:";
            // 
            // iDClienteLabel1
            // 
            this.iDClienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "IDCliente", true));
            this.iDClienteLabel1.Location = new System.Drawing.Point(108, 58);
            this.iDClienteLabel1.Name = "iDClienteLabel1";
            this.iDClienteLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDClienteLabel1.TabIndex = 2;
            this.iDClienteLabel1.Text = "label1";
            this.iDClienteLabel1.Click += new System.EventHandler(this.iDClienteLabel1_Click);
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(25, 87);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(108, 84);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // iDContactoLabel
            // 
            iDContactoLabel.AutoSize = true;
            iDContactoLabel.Location = new System.Drawing.Point(25, 113);
            iDContactoLabel.Name = "iDContactoLabel";
            iDContactoLabel.Size = new System.Drawing.Size(64, 13);
            iDContactoLabel.TabIndex = 5;
            iDContactoLabel.Text = "IDContacto:";
            // 
            // iDContactoTextBox
            // 
            this.iDContactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "IDContacto", true));
            this.iDContactoTextBox.Location = new System.Drawing.Point(108, 110);
            this.iDContactoTextBox.Name = "iDContactoTextBox";
            this.iDContactoTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDContactoTextBox.TabIndex = 6;
            // 
            // calleLabel
            // 
            calleLabel.AutoSize = true;
            calleLabel.Location = new System.Drawing.Point(25, 139);
            calleLabel.Name = "calleLabel";
            calleLabel.Size = new System.Drawing.Size(33, 13);
            calleLabel.TabIndex = 7;
            calleLabel.Text = "Calle:";
            // 
            // calleTextBox
            // 
            this.calleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Calle", true));
            this.calleTextBox.Location = new System.Drawing.Point(108, 136);
            this.calleTextBox.Name = "calleTextBox";
            this.calleTextBox.Size = new System.Drawing.Size(100, 20);
            this.calleTextBox.TabIndex = 8;
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(25, 165);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(47, 13);
            numeroLabel.TabIndex = 9;
            numeroLabel.Text = "Numero:";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(108, 162);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroTextBox.TabIndex = 10;
            // 
            // pisoLabel
            // 
            pisoLabel.AutoSize = true;
            pisoLabel.Location = new System.Drawing.Point(25, 191);
            pisoLabel.Name = "pisoLabel";
            pisoLabel.Size = new System.Drawing.Size(30, 13);
            pisoLabel.TabIndex = 11;
            pisoLabel.Text = "Piso:";
            // 
            // pisoTextBox
            // 
            this.pisoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Piso", true));
            this.pisoTextBox.Location = new System.Drawing.Point(108, 188);
            this.pisoTextBox.Name = "pisoTextBox";
            this.pisoTextBox.Size = new System.Drawing.Size(100, 20);
            this.pisoTextBox.TabIndex = 12;
            // 
            // departamentoLabel
            // 
            departamentoLabel.AutoSize = true;
            departamentoLabel.Location = new System.Drawing.Point(25, 217);
            departamentoLabel.Name = "departamentoLabel";
            departamentoLabel.Size = new System.Drawing.Size(77, 13);
            departamentoLabel.TabIndex = 13;
            departamentoLabel.Text = "Departamento:";
            // 
            // departamentoTextBox
            // 
            this.departamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Departamento", true));
            this.departamentoTextBox.Location = new System.Drawing.Point(108, 214);
            this.departamentoTextBox.Name = "departamentoTextBox";
            this.departamentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.departamentoTextBox.TabIndex = 14;
            // 
            // cuidadLabel
            // 
            cuidadLabel.AutoSize = true;
            cuidadLabel.Location = new System.Drawing.Point(25, 243);
            cuidadLabel.Name = "cuidadLabel";
            cuidadLabel.Size = new System.Drawing.Size(43, 13);
            cuidadLabel.TabIndex = 15;
            cuidadLabel.Text = "Cuidad:";
            // 
            // cuidadTextBox
            // 
            this.cuidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Cuidad", true));
            this.cuidadTextBox.Location = new System.Drawing.Point(108, 240);
            this.cuidadTextBox.Name = "cuidadTextBox";
            this.cuidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.cuidadTextBox.TabIndex = 16;
            // 
            // provinciaLabel
            // 
            provinciaLabel.AutoSize = true;
            provinciaLabel.Location = new System.Drawing.Point(25, 269);
            provinciaLabel.Name = "provinciaLabel";
            provinciaLabel.Size = new System.Drawing.Size(54, 13);
            provinciaLabel.TabIndex = 17;
            provinciaLabel.Text = "Provincia:";
            // 
            // provinciaTextBox
            // 
            this.provinciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Provincia", true));
            this.provinciaTextBox.Location = new System.Drawing.Point(108, 266);
            this.provinciaTextBox.Name = "provinciaTextBox";
            this.provinciaTextBox.Size = new System.Drawing.Size(100, 20);
            this.provinciaTextBox.TabIndex = 18;
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(25, 295);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(30, 13);
            paisLabel.TabIndex = 19;
            paisLabel.Text = "Pais:";
            // 
            // paisTextBox
            // 
            this.paisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Pais", true));
            this.paisTextBox.Location = new System.Drawing.Point(108, 292);
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(100, 20);
            this.paisTextBox.TabIndex = 20;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(25, 321);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 21;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(108, 318);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 22;
            // 
            // webLabel
            // 
            webLabel.AutoSize = true;
            webLabel.Location = new System.Drawing.Point(25, 347);
            webLabel.Name = "webLabel";
            webLabel.Size = new System.Drawing.Size(33, 13);
            webLabel.TabIndex = 23;
            webLabel.Text = "Web:";
            // 
            // webTextBox
            // 
            this.webTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Web", true));
            this.webTextBox.Location = new System.Drawing.Point(108, 344);
            this.webTextBox.Name = "webTextBox";
            this.webTextBox.Size = new System.Drawing.Size(100, 20);
            this.webTextBox.TabIndex = 24;
            // 
            // proyectosBindingSource
            // 
            this.proyectosBindingSource.DataMember = "Proyectos";
            this.proyectosBindingSource.DataSource = this.proyectosDataSet;
            // 
            // proyectosTableAdapter
            // 
            this.proyectosTableAdapter.ClearBeforeFill = true;
            // 
            // proyectosDataGridView
            // 
            this.proyectosDataGridView.AutoGenerateColumns = false;
            this.proyectosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proyectosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.proyectosDataGridView.DataSource = this.fKProyectosClientesBindingSource;
            this.proyectosDataGridView.Location = new System.Drawing.Point(248, 58);
            this.proyectosDataGridView.Name = "proyectosDataGridView";
            this.proyectosDataGridView.Size = new System.Drawing.Size(444, 302);
            this.proyectosDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDProyecto";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDProyecto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDCliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "IDCliente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // fKProyectosClientesBindingSource
            // 
            this.fKProyectosClientesBindingSource.DataMember = "FK_Proyectos_Clientes";
            this.fKProyectosClientesBindingSource.DataSource = this.clientesBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 396);
            this.Controls.Add(this.proyectosDataGridView);
            this.Controls.Add(iDClienteLabel);
            this.Controls.Add(this.iDClienteLabel1);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(iDContactoLabel);
            this.Controls.Add(this.iDContactoTextBox);
            this.Controls.Add(calleLabel);
            this.Controls.Add(this.calleTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(pisoLabel);
            this.Controls.Add(this.pisoTextBox);
            this.Controls.Add(departamentoLabel);
            this.Controls.Add(this.departamentoTextBox);
            this.Controls.Add(cuidadLabel);
            this.Controls.Add(this.cuidadTextBox);
            this.Controls.Add(provinciaLabel);
            this.Controls.Add(this.provinciaTextBox);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(webLabel);
            this.Controls.Add(this.webTextBox);
            this.Controls.Add(this.clientesBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proyectosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).EndInit();
            this.clientesBindingNavigator.ResumeLayout(false);
            this.clientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProyectosClientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProyectosDataSet proyectosDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ProyectosDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private ProyectosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clientesBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iDClienteLabel1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox iDContactoTextBox;
        private System.Windows.Forms.TextBox calleTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox pisoTextBox;
        private System.Windows.Forms.TextBox departamentoTextBox;
        private System.Windows.Forms.TextBox cuidadTextBox;
        private System.Windows.Forms.TextBox provinciaTextBox;
        private System.Windows.Forms.TextBox paisTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox webTextBox;
        private ProyectosDataSetTableAdapters.ProyectosTableAdapter proyectosTableAdapter;
        private System.Windows.Forms.BindingSource proyectosBindingSource;
        private System.Windows.Forms.DataGridView proyectosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource fKProyectosClientesBindingSource;
    }
}

