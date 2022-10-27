namespace drive_formater
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_format = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.lblQRCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtPrinterIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.driveBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.driveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driveBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrintAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(13, 13);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(123, 32);
            this.btn_refresh.TabIndex = 0;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_format
            // 
            this.btn_format.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_format.ForeColor = System.Drawing.Color.Red;
            this.btn_format.Location = new System.Drawing.Point(13, 51);
            this.btn_format.Name = "btn_format";
            this.btn_format.Size = new System.Drawing.Size(123, 32);
            this.btn_format.TabIndex = 1;
            this.btn_format.Text = "Format";
            this.btn_format.UseVisualStyleBackColor = true;
            this.btn_format.Click += new System.EventHandler(this.btn_format_Click);
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(641, 196);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(123, 32);
            this.btn_about.TabIndex = 2;
            this.btn_about.Text = "About";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manufacturerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.healthStatusDataGridViewTextBoxColumn,
            this.serialNumDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.driveBindingSource3;
            this.dataGridView.Location = new System.Drawing.Point(25, 246);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(721, 369);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick_1);
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufacturerDataGridViewTextBoxColumn.Width = 120;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 190;
            // 
            // healthStatusDataGridViewTextBoxColumn
            // 
            this.healthStatusDataGridViewTextBoxColumn.DataPropertyName = "HealthStatus";
            this.healthStatusDataGridViewTextBoxColumn.HeaderText = "HealthStatus";
            this.healthStatusDataGridViewTextBoxColumn.Name = "healthStatusDataGridViewTextBoxColumn";
            this.healthStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.healthStatusDataGridViewTextBoxColumn.Width = 80;
            // 
            // serialNumDataGridViewTextBoxColumn
            // 
            this.serialNumDataGridViewTextBoxColumn.DataPropertyName = "SerialNum";
            this.serialNumDataGridViewTextBoxColumn.HeaderText = "SerialNum";
            this.serialNumDataGridViewTextBoxColumn.Name = "serialNumDataGridViewTextBoxColumn";
            this.serialNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialNumDataGridViewTextBoxColumn.Width = 190;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driveBindingSource3
            // 
            this.driveBindingSource3.DataSource = typeof(drive_formater.Drive);
            // 
            // picQRCode
            // 
            this.picQRCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picQRCode.Location = new System.Drawing.Point(142, 12);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(229, 214);
            this.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picQRCode.TabIndex = 4;
            this.picQRCode.TabStop = false;
            // 
            // lblQRCode
            // 
            this.lblQRCode.AutoSize = true;
            this.lblQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQRCode.ForeColor = System.Drawing.Color.Firebrick;
            this.lblQRCode.Location = new System.Drawing.Point(377, 29);
            this.lblQRCode.Name = "lblQRCode";
            this.lblQRCode.Size = new System.Drawing.Size(16, 18);
            this.lblQRCode.TabIndex = 5;
            this.lblQRCode.Text = "..";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selected Drive:";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrint.Location = new System.Drawing.Point(641, 83);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(123, 32);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtPrinterIP
            // 
            this.txtPrinterIP.Location = new System.Drawing.Point(641, 47);
            this.txtPrinterIP.Name = "txtPrinterIP";
            this.txtPrinterIP.Size = new System.Drawing.Size(123, 20);
            this.txtPrinterIP.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Printer IP";
            // 
            // driveBindingSource2
            // 
            this.driveBindingSource2.DataSource = typeof(drive_formater.Drive);
            // 
            // driveBindingSource
            // 
            this.driveBindingSource.DataSource = typeof(drive_formater.Drive);
            // 
            // driveBindingSource1
            // 
            this.driveBindingSource1.DataSource = typeof(drive_formater.Drive);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrintAll.Location = new System.Drawing.Point(641, 121);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(123, 32);
            this.btnPrintAll.TabIndex = 10;
            this.btnPrintAll.Text = "Print All";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 627);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrinterIP);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQRCode);
            this.Controls.Add(this.picQRCode);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_format);
            this.Controls.Add(this.btn_refresh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Master Drives";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_format;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.BindingSource driveBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource driveBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource driveBindingSource2;
        private System.Windows.Forms.BindingSource driveBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.Label lblQRCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtPrinterIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrintAll;
    }
}

