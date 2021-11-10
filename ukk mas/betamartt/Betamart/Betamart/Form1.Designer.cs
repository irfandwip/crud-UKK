namespace Betamart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.autoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbbetamartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new Betamart.AppData();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbox_stok = new System.Windows.Forms.TextBox();
            this.txtbox_harga = new System.Windows.Forms.TextBox();
            this.txtbox_nama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_input = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_betamartTableAdapter = new Betamart.AppDataTableAdapters.tb_betamartTableAdapter();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbetamartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoidDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.hargabarangDataGridViewTextBoxColumn,
            this.stokbarangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbbetamartBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(90, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // autoidDataGridViewTextBoxColumn
            // 
            this.autoidDataGridViewTextBoxColumn.DataPropertyName = "auto_id";
            this.autoidDataGridViewTextBoxColumn.HeaderText = "auto_id";
            this.autoidDataGridViewTextBoxColumn.Name = "autoidDataGridViewTextBoxColumn";
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            this.namabarangDataGridViewTextBoxColumn.Width = 180;
            // 
            // hargabarangDataGridViewTextBoxColumn
            // 
            this.hargabarangDataGridViewTextBoxColumn.DataPropertyName = "harga_barang";
            this.hargabarangDataGridViewTextBoxColumn.HeaderText = "harga_barang";
            this.hargabarangDataGridViewTextBoxColumn.Name = "hargabarangDataGridViewTextBoxColumn";
            this.hargabarangDataGridViewTextBoxColumn.Width = 180;
            // 
            // stokbarangDataGridViewTextBoxColumn
            // 
            this.stokbarangDataGridViewTextBoxColumn.DataPropertyName = "stok_barang";
            this.stokbarangDataGridViewTextBoxColumn.HeaderText = "stok_barang";
            this.stokbarangDataGridViewTextBoxColumn.Name = "stokbarangDataGridViewTextBoxColumn";
            this.stokbarangDataGridViewTextBoxColumn.Width = 120;
            // 
            // tbbetamartBindingSource
            // 
            this.tbbetamartBindingSource.DataMember = "tb_betamart";
            this.tbbetamartBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtbox_stok);
            this.panel1.Controls.Add(this.txtbox_harga);
            this.panel1.Controls.Add(this.txtbox_nama);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 170);
            this.panel1.TabIndex = 1;
            // 
            // txtbox_stok
            // 
            this.txtbox_stok.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbbetamartBindingSource, "stok_barang", true));
            this.txtbox_stok.Location = new System.Drawing.Point(111, 133);
            this.txtbox_stok.Name = "txtbox_stok";
            this.txtbox_stok.Size = new System.Drawing.Size(276, 20);
            this.txtbox_stok.TabIndex = 6;
            // 
            // txtbox_harga
            // 
            this.txtbox_harga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbbetamartBindingSource, "harga_barang", true));
            this.txtbox_harga.Location = new System.Drawing.Point(111, 89);
            this.txtbox_harga.Name = "txtbox_harga";
            this.txtbox_harga.Size = new System.Drawing.Size(276, 20);
            this.txtbox_harga.TabIndex = 4;
            // 
            // txtbox_nama
            // 
            this.txtbox_nama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbbetamartBindingSource, "nama_barang", true));
            this.txtbox_nama.Location = new System.Drawing.Point(111, 45);
            this.txtbox_nama.Name = "txtbox_nama";
            this.txtbox_nama.Size = new System.Drawing.Size(276, 20);
            this.txtbox_nama.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stok Barang :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Harga Barang :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(499, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "BETAMART";
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(111, 193);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(125, 26);
            this.btn_input.TabIndex = 0;
            this.btn_input.Text = "Masukkan Barang";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(263, 193);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(125, 26);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit Barang";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(416, 193);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(125, 26);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Hapus";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(572, 193);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 26);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Tampilkan";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_betamartTableAdapter
            // 
            this.tb_betamartTableAdapter.ClearBeforeFill = true;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbbetamartBindingSource, "stok_barang", true));
            this.txtID.Location = new System.Drawing.Point(579, 129);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(122, 20);
            this.txtID.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Betamart Nggih";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbetamartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_stok;
        private System.Windows.Forms.TextBox txtbox_harga;
        private System.Windows.Forms.TextBox txtbox_nama;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private AppData appData;
        private System.Windows.Forms.BindingSource tbbetamartBindingSource;
        private AppDataTableAdapters.tb_betamartTableAdapter tb_betamartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
    }
}

