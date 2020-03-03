namespace Semana01
{
    partial class PjConexion3
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.neptunoDataSet2 = new Semana01.neptunoDataSet2();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Semana01.neptunoDataSet2TableAdapters.productosTableAdapter();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadPorUnidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadesEnExistenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadesEnPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelNuevoPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspendidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO DE PRODUCTOS - MEDIANTE APP.CONFIG";
            // 
            // dgProductos
            // 
            this.dgProductos.AllowUserToAddRows = false;
            this.dgProductos.AllowUserToDeleteRows = false;
            this.dgProductos.AutoGenerateColumns = false;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.idProveedorDataGridViewTextBoxColumn,
            this.idCategoriaDataGridViewTextBoxColumn,
            this.cantidadPorUnidadDataGridViewTextBoxColumn,
            this.precioUnidadDataGridViewTextBoxColumn,
            this.unidadesEnExistenciaDataGridViewTextBoxColumn,
            this.unidadesEnPedidoDataGridViewTextBoxColumn,
            this.nivelNuevoPedidoDataGridViewTextBoxColumn,
            this.suspendidoDataGridViewTextBoxColumn,
            this.categoriaProductoDataGridViewTextBoxColumn});
            this.dgProductos.DataSource = this.productosBindingSource;
            this.dgProductos.Location = new System.Drawing.Point(92, 117);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.Size = new System.Drawing.Size(625, 187);
            this.dgProductos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NUMERO DE PRODUCTOS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCantidad.Location = new System.Drawing.Point(301, 353);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(63, 15);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "                  ";
            // 
            // neptunoDataSet2
            // 
            this.neptunoDataSet2.DataSetName = "neptunoDataSet2";
            this.neptunoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.neptunoDataSet2;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "idproducto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "idproducto";
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            this.idproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "nombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "nombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            this.nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProveedorDataGridViewTextBoxColumn
            // 
            this.idProveedorDataGridViewTextBoxColumn.DataPropertyName = "idProveedor";
            this.idProveedorDataGridViewTextBoxColumn.HeaderText = "idProveedor";
            this.idProveedorDataGridViewTextBoxColumn.Name = "idProveedorDataGridViewTextBoxColumn";
            this.idProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            this.idCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadPorUnidadDataGridViewTextBoxColumn
            // 
            this.cantidadPorUnidadDataGridViewTextBoxColumn.DataPropertyName = "cantidadPorUnidad";
            this.cantidadPorUnidadDataGridViewTextBoxColumn.HeaderText = "cantidadPorUnidad";
            this.cantidadPorUnidadDataGridViewTextBoxColumn.Name = "cantidadPorUnidadDataGridViewTextBoxColumn";
            this.cantidadPorUnidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioUnidadDataGridViewTextBoxColumn
            // 
            this.precioUnidadDataGridViewTextBoxColumn.DataPropertyName = "precioUnidad";
            this.precioUnidadDataGridViewTextBoxColumn.HeaderText = "precioUnidad";
            this.precioUnidadDataGridViewTextBoxColumn.Name = "precioUnidadDataGridViewTextBoxColumn";
            this.precioUnidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadesEnExistenciaDataGridViewTextBoxColumn
            // 
            this.unidadesEnExistenciaDataGridViewTextBoxColumn.DataPropertyName = "unidadesEnExistencia";
            this.unidadesEnExistenciaDataGridViewTextBoxColumn.HeaderText = "unidadesEnExistencia";
            this.unidadesEnExistenciaDataGridViewTextBoxColumn.Name = "unidadesEnExistenciaDataGridViewTextBoxColumn";
            this.unidadesEnExistenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadesEnPedidoDataGridViewTextBoxColumn
            // 
            this.unidadesEnPedidoDataGridViewTextBoxColumn.DataPropertyName = "unidadesEnPedido";
            this.unidadesEnPedidoDataGridViewTextBoxColumn.HeaderText = "unidadesEnPedido";
            this.unidadesEnPedidoDataGridViewTextBoxColumn.Name = "unidadesEnPedidoDataGridViewTextBoxColumn";
            this.unidadesEnPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nivelNuevoPedidoDataGridViewTextBoxColumn
            // 
            this.nivelNuevoPedidoDataGridViewTextBoxColumn.DataPropertyName = "nivelNuevoPedido";
            this.nivelNuevoPedidoDataGridViewTextBoxColumn.HeaderText = "nivelNuevoPedido";
            this.nivelNuevoPedidoDataGridViewTextBoxColumn.Name = "nivelNuevoPedidoDataGridViewTextBoxColumn";
            this.nivelNuevoPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suspendidoDataGridViewTextBoxColumn
            // 
            this.suspendidoDataGridViewTextBoxColumn.DataPropertyName = "suspendido";
            this.suspendidoDataGridViewTextBoxColumn.HeaderText = "suspendido";
            this.suspendidoDataGridViewTextBoxColumn.Name = "suspendidoDataGridViewTextBoxColumn";
            this.suspendidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaProductoDataGridViewTextBoxColumn
            // 
            this.categoriaProductoDataGridViewTextBoxColumn.DataPropertyName = "categoriaProducto";
            this.categoriaProductoDataGridViewTextBoxColumn.HeaderText = "categoriaProducto";
            this.categoriaProductoDataGridViewTextBoxColumn.Name = "categoriaProductoDataGridViewTextBoxColumn";
            this.categoriaProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PjConexion3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.label1);
            this.Name = "PjConexion3";
            this.Text = "PjConexion3";
            this.Load += new System.EventHandler(this.PjConexion3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantidad;
        private neptunoDataSet2 neptunoDataSet2;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private neptunoDataSet2TableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadPorUnidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadesEnExistenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadesEnPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelNuevoPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspendidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaProductoDataGridViewTextBoxColumn;
    }
}