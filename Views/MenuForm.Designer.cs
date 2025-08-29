namespace AccSamse._1._1.Views
{
    partial class MenuForm
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
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.buttonEntrySale = new System.Windows.Forms.Button();
            this.buttonEntryInventory = new System.Windows.Forms.Button();
            this.buttonOffSytem = new System.Windows.Forms.Button();
            this.buttonEntryAdministration = new System.Windows.Forms.Button();
            this.groupBoxViewsSales = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelMenuNameUser = new System.Windows.Forms.Label();
            this.labelMenuRoleUser = new System.Windows.Forms.Label();
            this.dateTimePickerDateMenu = new System.Windows.Forms.DateTimePicker();
            this.LabelDateMenu = new System.Windows.Forms.Label();
            this.id_SaleMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateSaleMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateSaleMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSaleMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteSaleMenu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditSaleMenu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxMenu.SuspendLayout();
            this.groupBoxViewsSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.dateTimePickerDateMenu);
            this.groupBoxMenu.Controls.Add(this.LabelDateMenu);
            this.groupBoxMenu.Controls.Add(this.labelMenuRoleUser);
            this.groupBoxMenu.Controls.Add(this.labelMenuNameUser);
            this.groupBoxMenu.Controls.Add(this.groupBoxViewsSales);
            this.groupBoxMenu.Controls.Add(this.buttonEntryAdministration);
            this.groupBoxMenu.Controls.Add(this.buttonOffSytem);
            this.groupBoxMenu.Controls.Add(this.buttonEntryInventory);
            this.groupBoxMenu.Controls.Add(this.buttonEntrySale);
            this.groupBoxMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMenu.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(800, 450);
            this.groupBoxMenu.TabIndex = 0;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            // 
            // buttonEntrySale
            // 
            this.buttonEntrySale.Location = new System.Drawing.Point(25, 42);
            this.buttonEntrySale.Name = "buttonEntrySale";
            this.buttonEntrySale.Size = new System.Drawing.Size(99, 23);
            this.buttonEntrySale.TabIndex = 0;
            this.buttonEntrySale.Text = "Sale";
            this.buttonEntrySale.UseVisualStyleBackColor = true;
            // 
            // buttonEntryInventory
            // 
            this.buttonEntryInventory.Location = new System.Drawing.Point(139, 42);
            this.buttonEntryInventory.Name = "buttonEntryInventory";
            this.buttonEntryInventory.Size = new System.Drawing.Size(99, 23);
            this.buttonEntryInventory.TabIndex = 1;
            this.buttonEntryInventory.Text = "Inventory";
            this.buttonEntryInventory.UseVisualStyleBackColor = true;
            // 
            // buttonOffSytem
            // 
            this.buttonOffSytem.Location = new System.Drawing.Point(690, 413);
            this.buttonOffSytem.Name = "buttonOffSytem";
            this.buttonOffSytem.Size = new System.Drawing.Size(104, 31);
            this.buttonOffSytem.TabIndex = 2;
            this.buttonOffSytem.Text = "Off System";
            this.buttonOffSytem.UseVisualStyleBackColor = true;
            // 
            // buttonEntryAdministration
            // 
            this.buttonEntryAdministration.Location = new System.Drawing.Point(254, 42);
            this.buttonEntryAdministration.Name = "buttonEntryAdministration";
            this.buttonEntryAdministration.Size = new System.Drawing.Size(99, 23);
            this.buttonEntryAdministration.TabIndex = 3;
            this.buttonEntryAdministration.Text = "Administration";
            this.buttonEntryAdministration.UseVisualStyleBackColor = true;
            // 
            // groupBoxViewsSales
            // 
            this.groupBoxViewsSales.Controls.Add(this.dataGridView1);
            this.groupBoxViewsSales.Location = new System.Drawing.Point(12, 71);
            this.groupBoxViewsSales.Name = "groupBoxViewsSales";
            this.groupBoxViewsSales.Size = new System.Drawing.Size(776, 338);
            this.groupBoxViewsSales.TabIndex = 4;
            this.groupBoxViewsSales.TabStop = false;
            this.groupBoxViewsSales.Text = "Sales";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_SaleMenu,
            this.DateSaleMenu,
            this.StateSaleMenu,
            this.TotalSaleMenu,
            this.DeleteSaleMenu,
            this.EditSaleMenu});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 317);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelMenuNameUser
            // 
            this.labelMenuNameUser.AutoSize = true;
            this.labelMenuNameUser.Location = new System.Drawing.Point(400, 47);
            this.labelMenuNameUser.Name = "labelMenuNameUser";
            this.labelMenuNameUser.Size = new System.Drawing.Size(30, 13);
            this.labelMenuNameUser.TabIndex = 5;
            this.labelMenuNameUser.Text = "User";
            // 
            // labelMenuRoleUser
            // 
            this.labelMenuRoleUser.AutoSize = true;
            this.labelMenuRoleUser.Location = new System.Drawing.Point(400, 18);
            this.labelMenuRoleUser.Name = "labelMenuRoleUser";
            this.labelMenuRoleUser.Size = new System.Drawing.Size(30, 13);
            this.labelMenuRoleUser.TabIndex = 6;
            this.labelMenuRoleUser.Text = "Role";
            // 
            // dateTimePickerDateMenu
            // 
            this.dateTimePickerDateMenu.Enabled = false;
            this.dateTimePickerDateMenu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateMenu.Location = new System.Drawing.Point(63, 421);
            this.dateTimePickerDateMenu.Name = "dateTimePickerDateMenu";
            this.dateTimePickerDateMenu.Size = new System.Drawing.Size(109, 22);
            this.dateTimePickerDateMenu.TabIndex = 11;
            // 
            // LabelDateMenu
            // 
            this.LabelDateMenu.AutoSize = true;
            this.LabelDateMenu.Location = new System.Drawing.Point(22, 425);
            this.LabelDateMenu.Name = "LabelDateMenu";
            this.LabelDateMenu.Size = new System.Drawing.Size(31, 13);
            this.LabelDateMenu.TabIndex = 10;
            this.LabelDateMenu.Text = "Date";
            // 
            // id_SaleMenu
            // 
            this.id_SaleMenu.HeaderText = "Sale No";
            this.id_SaleMenu.Name = "id_SaleMenu";
            // 
            // DateSaleMenu
            // 
            this.DateSaleMenu.HeaderText = "Date";
            this.DateSaleMenu.Name = "DateSaleMenu";
            // 
            // StateSaleMenu
            // 
            this.StateSaleMenu.HeaderText = "State";
            this.StateSaleMenu.Name = "StateSaleMenu";
            this.StateSaleMenu.Width = 180;
            // 
            // TotalSaleMenu
            // 
            this.TotalSaleMenu.HeaderText = "Total";
            this.TotalSaleMenu.Name = "TotalSaleMenu";
            this.TotalSaleMenu.Width = 150;
            // 
            // DeleteSaleMenu
            // 
            this.DeleteSaleMenu.HeaderText = "Delete";
            this.DeleteSaleMenu.Name = "DeleteSaleMenu";
            // 
            // EditSaleMenu
            // 
            this.EditSaleMenu.HeaderText = "Edit";
            this.EditSaleMenu.Name = "EditSaleMenu";
            this.EditSaleMenu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditSaleMenu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxMenu);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxMenu.PerformLayout();
            this.groupBoxViewsSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Button buttonOffSytem;
        private System.Windows.Forms.Button buttonEntryInventory;
        private System.Windows.Forms.Button buttonEntrySale;
        private System.Windows.Forms.Button buttonEntryAdministration;
        private System.Windows.Forms.GroupBox groupBoxViewsSales;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelMenuRoleUser;
        private System.Windows.Forms.Label labelMenuNameUser;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateMenu;
        private System.Windows.Forms.Label LabelDateMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_SaleMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateSaleMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateSaleMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSaleMenu;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteSaleMenu;
        private System.Windows.Forms.DataGridViewButtonColumn EditSaleMenu;
    }
}