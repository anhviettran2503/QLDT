namespace QLNCKH
{
    partial class FLop
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
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.cbmakhoa = new System.Windows.Forms.ComboBox();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDTDataSet1 = new QLNCKH.QLDTDataSet1();
            this.lopTableAdapter = new QLNCKH.QLDTDataSet1TableAdapters.LopTableAdapter();
            this.qLNCKHDataSet1 = new QLNCKH.QLNCKHDataSet1();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new QLNCKH.QLNCKHDataSet1TableAdapters.KhoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNCKHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập Nhật Danh Mục Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên lớp";
            // 
            // txttenlop
            // 
            this.txttenlop.Location = new System.Drawing.Point(302, 240);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(204, 29);
            this.txttenlop.TabIndex = 3;
            // 
            // txtmalop
            // 
            this.txtmalop.Location = new System.Drawing.Point(302, 205);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(204, 29);
            this.txtmalop.TabIndex = 2;
            // 
            // btnthem
            // 
            this.btnthem.Image = global::QLNCKH.Properties.Resources.add_icon2;
            this.btnthem.Location = new System.Drawing.Point(171, 334);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(87, 51);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::QLNCKH.Properties.Resources.icon_autosuggest_delete;
            this.btnxoa.Location = new System.Drawing.Point(264, 334);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(92, 51);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::QLNCKH.Properties.Resources.refresh;
            this.btnsua.Location = new System.Drawing.Point(362, 334);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(92, 51);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(460, 334);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(92, 51);
            this.btnhuy.TabIndex = 7;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // cbmakhoa
            // 
            this.cbmakhoa.DataSource = this.khoaBindingSource;
            this.cbmakhoa.DisplayMember = "makhoa";
            this.cbmakhoa.FormattingEnabled = true;
            this.cbmakhoa.Location = new System.Drawing.Point(302, 167);
            this.cbmakhoa.Name = "cbmakhoa";
            this.cbmakhoa.Size = new System.Drawing.Size(204, 32);
            this.cbmakhoa.TabIndex = 1;
            this.cbmakhoa.ValueMember = "makhoa";
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.qLDTDataSet1;
            // 
            // qLDTDataSet1
            // 
            this.qLDTDataSet1.DataSetName = "QLDTDataSet1";
            this.qLDTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // qLNCKHDataSet1
            // 
            this.qLNCKHDataSet1.DataSetName = "QLNCKHDataSet1";
            this.qLNCKHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.qLNCKHDataSet1;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // FLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 500);
            this.Controls.Add(this.cbmakhoa);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtmalop);
            this.Controls.Add(this.txttenlop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FLop";
            this.Text = "Cập Nhập Danh Mục Lớp";
            this.Load += new System.EventHandler(this.FLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNCKHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.ComboBox cbmakhoa;
        private QLDTDataSet1 qLDTDataSet1;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QLDTDataSet1TableAdapters.LopTableAdapter lopTableAdapter;
        private QLNCKHDataSet1 qLNCKHDataSet1;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private QLNCKHDataSet1TableAdapters.KhoaTableAdapter khoaTableAdapter;
    }
}