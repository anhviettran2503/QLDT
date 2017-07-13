namespace QLNCKH
{
    partial class FKhoa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttenkhoa = new System.Windows.Forms.TextBox();
            this.txttruongkhoa = new System.Windows.Forms.TextBox();
            this.txtsdtkhoa = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.txtmakhoa = new System.Windows.Forms.ComboBox();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDTDataSet = new QLNCKH.QLDTDataSet();
            this.khoaTableAdapter = new QLNCKH.QLDTDataSetTableAdapters.KhoaTableAdapter();
            this.qLNCKHDataSet = new QLNCKH.QLNCKHDataSet();
            this.khoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter1 = new QLNCKH.QLNCKHDataSetTableAdapters.KhoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNCKHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập Nhật Danh Mục Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Trưởng khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số điện thoại khoa";
            // 
            // txttenkhoa
            // 
            this.txttenkhoa.Location = new System.Drawing.Point(385, 208);
            this.txttenkhoa.Name = "txttenkhoa";
            this.txttenkhoa.Size = new System.Drawing.Size(216, 29);
            this.txttenkhoa.TabIndex = 2;
            this.txttenkhoa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txttruongkhoa
            // 
            this.txttruongkhoa.Location = new System.Drawing.Point(385, 243);
            this.txttruongkhoa.Name = "txttruongkhoa";
            this.txttruongkhoa.Size = new System.Drawing.Size(216, 29);
            this.txttruongkhoa.TabIndex = 3;
            this.txttruongkhoa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtsdtkhoa
            // 
            this.txtsdtkhoa.Location = new System.Drawing.Point(385, 278);
            this.txtsdtkhoa.Name = "txtsdtkhoa";
            this.txtsdtkhoa.Size = new System.Drawing.Size(216, 29);
            this.txtsdtkhoa.TabIndex = 4;
            this.txtsdtkhoa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(175, 349);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(97, 52);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(289, 349);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(97, 52);
            this.btnxoa.TabIndex = 6;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(405, 349);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(97, 52);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(524, 349);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(97, 52);
            this.btnhuy.TabIndex = 8;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.DataSource = this.khoaBindingSource1;
            this.txtmakhoa.DisplayMember = "makhoa";
            this.txtmakhoa.FormattingEnabled = true;
            this.txtmakhoa.Location = new System.Drawing.Point(385, 170);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(216, 32);
            this.txtmakhoa.TabIndex = 1;
            this.txtmakhoa.ValueMember = "makhoa";
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.qLDTDataSet;
            // 
            // qLDTDataSet
            // 
            this.qLDTDataSet.DataSetName = "QLDTDataSet";
            this.qLDTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // qLNCKHDataSet
            // 
            this.qLNCKHDataSet.DataSetName = "QLNCKHDataSet";
            this.qLNCKHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoaBindingSource1
            // 
            this.khoaBindingSource1.DataMember = "Khoa";
            this.khoaBindingSource1.DataSource = this.qLNCKHDataSet;
            // 
            // khoaTableAdapter1
            // 
            this.khoaTableAdapter1.ClearBeforeFill = true;
            // 
            // FKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 559);
            this.Controls.Add(this.txtmakhoa);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtsdtkhoa);
            this.Controls.Add(this.txttruongkhoa);
            this.Controls.Add(this.txttenkhoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FKhoa";
            this.Text = "Cập nhật danh mục Khoa";
            this.Load += new System.EventHandler(this.fKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNCKHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttenkhoa;
        private System.Windows.Forms.TextBox txttruongkhoa;
        private System.Windows.Forms.TextBox txtsdtkhoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.ComboBox txtmakhoa;
        private QLDTDataSet qLDTDataSet;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private QLDTDataSetTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private QLNCKHDataSet qLNCKHDataSet;
        private System.Windows.Forms.BindingSource khoaBindingSource1;
        private QLNCKHDataSetTableAdapters.KhoaTableAdapter khoaTableAdapter1;
    }
}