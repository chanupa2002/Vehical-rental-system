namespace Vehicel_rent_system
{
    partial class managecar
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.managecarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicle_SystemDataSet = new Vehicel_rent_system.Vehicle_SystemDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarNum = new System.Windows.Forms.TextBox();
            this.manage_carTableAdapter = new Vehicel_rent_system.Vehicle_SystemDataSetTableAdapters.Manage_carTableAdapter();
            this.customer_DetailsTableAdapter = new Vehicel_rent_system.Vehicle_SystemDataSet1TableAdapters.Customer_DetailsTableAdapter();
            this.vehicle_SystemDataSet2 = new Vehicel_rent_system.Vehicle_SystemDataSet2();
            this.managecarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.manage_carTableAdapter1 = new Vehicel_rent_system.Vehicle_SystemDataSet2TableAdapters.Manage_carTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehicleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_ManageDataSet = new Vehicel_rent_system.V_ManageDataSet();
            this.v_DetailsTableAdapter = new Vehicel_rent_system.V_ManageDataSetTableAdapters.V_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.managecarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_SystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managecarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ManageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.Location = new System.Drawing.Point(150, 460);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 40);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Id";
            // 
            // txtCarId
            // 
            this.txtCarId.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarId.Location = new System.Drawing.Point(241, 40);
            this.txtCarId.Name = "txtCarId";
            this.txtCarId.Size = new System.Drawing.Size(220, 36);
            this.txtCarId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(38, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(36, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(38, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(36, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Type";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(241, 336);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(220, 36);
            this.txtType.TabIndex = 7;
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(241, 281);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(220, 36);
            this.txtColor.TabIndex = 8;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(241, 220);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(220, 36);
            this.txtModel.TabIndex = 9;
            // 
            // txtbrand
            // 
            this.txtbrand.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbrand.Location = new System.Drawing.Point(241, 158);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(220, 36);
            this.txtbrand.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Location = new System.Drawing.Point(380, 460);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 40);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Location = new System.Drawing.Point(267, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 40);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddCar.Location = new System.Drawing.Point(41, 404);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(141, 40);
            this.btnAddCar.TabIndex = 13;
            this.btnAddCar.Text = "Add";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnView.Location = new System.Drawing.Point(793, 44);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(216, 40);
            this.btnView.TabIndex = 14;
            this.btnView.Text = "View All";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // managecarBindingSource
            // 
            this.managecarBindingSource.DataMember = "Manage_car";
            this.managecarBindingSource.DataSource = this.vehicle_SystemDataSet;
            // 
            // vehicle_SystemDataSet
            // 
            this.vehicle_SystemDataSet.DataSetName = "Vehicle_SystemDataSet";
            this.vehicle_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(36, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Car Number";
            // 
            // txtCarNum
            // 
            this.txtCarNum.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarNum.Location = new System.Drawing.Point(241, 97);
            this.txtCarNum.Name = "txtCarNum";
            this.txtCarNum.Size = new System.Drawing.Size(220, 36);
            this.txtCarNum.TabIndex = 10;
            // 
            // manage_carTableAdapter
            // 
            this.manage_carTableAdapter.ClearBeforeFill = true;
            // 
            // customer_DetailsTableAdapter
            // 
            this.customer_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // vehicle_SystemDataSet2
            // 
            this.vehicle_SystemDataSet2.DataSetName = "Vehicle_SystemDataSet2";
            this.vehicle_SystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managecarBindingSource1
            // 
            this.managecarBindingSource1.DataMember = "Manage_car";
            this.managecarBindingSource1.DataSource = this.vehicle_SystemDataSet2;
            // 
            // manage_carTableAdapter1
            // 
            this.manage_carTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleIdDataGridViewTextBoxColumn,
            this.vehicleNumDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(493, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(625, 203);
            this.dataGridView1.TabIndex = 17;
            // 
            // vehicleIdDataGridViewTextBoxColumn
            // 
            this.vehicleIdDataGridViewTextBoxColumn.DataPropertyName = "VehicleId";
            this.vehicleIdDataGridViewTextBoxColumn.HeaderText = "VehicleId";
            this.vehicleIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vehicleIdDataGridViewTextBoxColumn.Name = "vehicleIdDataGridViewTextBoxColumn";
            this.vehicleIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // vehicleNumDataGridViewTextBoxColumn
            // 
            this.vehicleNumDataGridViewTextBoxColumn.DataPropertyName = "VehicleNum";
            this.vehicleNumDataGridViewTextBoxColumn.HeaderText = "VehicleNum";
            this.vehicleNumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vehicleNumDataGridViewTextBoxColumn.Name = "vehicleNumDataGridViewTextBoxColumn";
            this.vehicleNumDataGridViewTextBoxColumn.Width = 150;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 150;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 150;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 150;
            // 
            // vDetailsBindingSource
            // 
            this.vDetailsBindingSource.DataMember = "V_Details";
            this.vDetailsBindingSource.DataSource = this.v_ManageDataSet;
            // 
            // v_ManageDataSet
            // 
            this.v_ManageDataSet.DataSetName = "V_ManageDataSet";
            this.v_ManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DetailsTableAdapter
            // 
            this.v_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // managecar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1239, 522);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtCarNum);
            this.Controls.Add(this.txtbrand);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCarId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Name = "managecar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Car";
            this.Load += new System.EventHandler(this.managecar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managecarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_SystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managecarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ManageDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCarId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtbrand;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCarNum;
        private Vehicle_SystemDataSet vehicle_SystemDataSet;
        private System.Windows.Forms.BindingSource managecarBindingSource;
        private Vehicle_SystemDataSetTableAdapters.Manage_carTableAdapter manage_carTableAdapter;
        private Vehicle_SystemDataSet1TableAdapters.Customer_DetailsTableAdapter customer_DetailsTableAdapter;
        private Vehicle_SystemDataSet2 vehicle_SystemDataSet2;
        private System.Windows.Forms.BindingSource managecarBindingSource1;
        private Vehicle_SystemDataSet2TableAdapters.Manage_carTableAdapter manage_carTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private V_ManageDataSet v_ManageDataSet;
        private System.Windows.Forms.BindingSource vDetailsBindingSource;
        private V_ManageDataSetTableAdapters.V_DetailsTableAdapter v_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
    }
}