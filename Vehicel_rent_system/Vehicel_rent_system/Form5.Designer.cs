namespace Vehicel_rent_system
{
    partial class bookingPg
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtBooking = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateP1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateP2 = new System.Windows.Forms.DateTimePicker();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehicleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_ManageDataSet5 = new Vehicel_rent_system.V_ManageDataSet5();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bookinIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_ManageDataSet1 = new Vehicel_rent_system.V_ManageDataSet1();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.b_DetailsTableAdapter = new Vehicel_rent_system.V_ManageDataSet1TableAdapters.B_DetailsTableAdapter();
            this.v_DetailsTableAdapter = new Vehicel_rent_system.V_ManageDataSet5TableAdapters.V_DetailsTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.combB1 = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ManageDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ManageDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(12, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBooking
            // 
            this.txtBooking.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBooking.Location = new System.Drawing.Point(264, 64);
            this.txtBooking.Name = "txtBooking";
            this.txtBooking.Size = new System.Drawing.Size(209, 31);
            this.txtBooking.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Booking Id";
            // 
            // dateP1
            // 
            this.dateP1.CalendarFont = new System.Drawing.Font("Russo One", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateP1.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateP1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateP1.Location = new System.Drawing.Point(264, 214);
            this.dateP1.Name = "dateP1";
            this.dateP1.Size = new System.Drawing.Size(209, 31);
            this.dateP1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Car Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rent Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(13, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Return Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(13, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Payment Status";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(1044, 589);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(354, 601);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 42);
            this.button3.TabIndex = 9;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateP2
            // 
            this.dateP2.CalendarFont = new System.Drawing.Font("Russo One", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateP2.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateP2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateP2.Location = new System.Drawing.Point(264, 284);
            this.dateP2.Name = "dateP2";
            this.dateP2.Size = new System.Drawing.Size(209, 31);
            this.dateP2.TabIndex = 11;
            // 
            // txtcid
            // 
            this.txtcid.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcid.Location = new System.Drawing.Point(264, 119);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(209, 31);
            this.txtcid.TabIndex = 14;
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
            this.dataGridView1.Location = new System.Drawing.Point(502, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(725, 259);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.vDetailsBindingSource.DataSource = this.v_ManageDataSet5;
            // 
            // v_ManageDataSet5
            // 
            this.v_ManageDataSet5.DataSetName = "V_ManageDataSet5";
            this.v_ManageDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookinIdDataGridViewTextBoxColumn,
            this.carIdDataGridViewTextBoxColumn,
            this.rentDateDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.paymentSDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bDetailsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(502, 419);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(765, 150);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bookinIdDataGridViewTextBoxColumn
            // 
            this.bookinIdDataGridViewTextBoxColumn.DataPropertyName = "BookinId";
            this.bookinIdDataGridViewTextBoxColumn.HeaderText = "BookinId";
            this.bookinIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookinIdDataGridViewTextBoxColumn.Name = "bookinIdDataGridViewTextBoxColumn";
            this.bookinIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            this.carIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            this.carIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // rentDateDataGridViewTextBoxColumn
            // 
            this.rentDateDataGridViewTextBoxColumn.DataPropertyName = "RentDate";
            this.rentDateDataGridViewTextBoxColumn.HeaderText = "RentDate";
            this.rentDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rentDateDataGridViewTextBoxColumn.Name = "rentDateDataGridViewTextBoxColumn";
            this.rentDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            this.returnDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // paymentSDataGridViewTextBoxColumn
            // 
            this.paymentSDataGridViewTextBoxColumn.DataPropertyName = "Payment_S";
            this.paymentSDataGridViewTextBoxColumn.HeaderText = "Payment_S";
            this.paymentSDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.paymentSDataGridViewTextBoxColumn.Name = "paymentSDataGridViewTextBoxColumn";
            this.paymentSDataGridViewTextBoxColumn.Width = 150;
            // 
            // bDetailsBindingSource
            // 
            this.bDetailsBindingSource.DataMember = "B_Details";
            this.bDetailsBindingSource.DataSource = this.v_ManageDataSet1;
            // 
            // v_ManageDataSet1
            // 
            this.v_ManageDataSet1.DataSetName = "V_ManageDataSet1";
            this.v_ManageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(712, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Booked Vehicles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(712, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Available Vehicles";
            // 
            // b_DetailsTableAdapter
            // 
            this.b_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // v_DetailsTableAdapter
            // 
            this.v_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Location = new System.Drawing.Point(1108, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 42);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // combB1
            // 
            this.combB1.FormattingEnabled = true;
            this.combB1.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.combB1.Location = new System.Drawing.Point(264, 380);
            this.combB1.Name = "combB1";
            this.combB1.Size = new System.Drawing.Size(192, 26);
            this.combB1.TabIndex = 19;
            // 
            // btnView
            // 
            this.btnView.AllowDrop = true;
            this.btnView.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnView.Location = new System.Drawing.Point(888, 589);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(141, 42);
            this.btnView.TabIndex = 20;
            this.btnView.Text = "View All";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.Location = new System.Drawing.Point(176, 602);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 42);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // bookingPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1299, 702);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.combB1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(this.dateP2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateP1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBooking);
            this.Controls.Add(this.button1);
            this.Name = "bookingPg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Booking";
            this.Load += new System.EventHandler(this.bookingPg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ManageDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ManageDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateP2;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private V_ManageDataSet1 v_ManageDataSet1;
        private System.Windows.Forms.BindingSource bDetailsBindingSource;
        private V_ManageDataSet1TableAdapters.B_DetailsTableAdapter b_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookinIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentSDataGridViewTextBoxColumn;
        private V_ManageDataSet5 v_ManageDataSet5;
        private System.Windows.Forms.BindingSource vDetailsBindingSource;
        private V_ManageDataSet5TableAdapters.V_DetailsTableAdapter v_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox combB1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnUpdate;
    }
}