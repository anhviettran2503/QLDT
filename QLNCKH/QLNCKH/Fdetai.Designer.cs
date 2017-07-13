namespace QLNCKH
{
    partial class Fdetai
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDTDataSet7 = new QLNCKH.QLDTDataSet7();
            this.detaiTableAdapter = new QLNCKH.QLDTDataSet7TableAdapters.DetaiTableAdapter();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDTDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(938, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // detaiBindingSource
            // 
            this.detaiBindingSource.DataMember = "Detai";
            this.detaiBindingSource.DataSource = this.qLDTDataSet7;
            // 
            // qLDTDataSet7
            // 
            this.qLDTDataSet7.DataSetName = "QLDTDataSet7";
            this.qLDTDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detaiTableAdapter
            // 
            this.detaiTableAdapter.ClearBeforeFill = true;
            // 
            // btncapnhat
            // 
            this.btncapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapnhat.ForeColor = System.Drawing.Color.Blue;
            this.btncapnhat.Location = new System.Drawing.Point(250, 334);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(138, 42);
            this.btncapnhat.TabIndex = 1;
            this.btncapnhat.Text = "Cập Nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.Blue;
            this.btnthoat.Location = new System.Drawing.Point(502, 334);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(138, 42);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Fdetai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 493);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Fdetai";
            this.Text = "Cập Nhật Thông Tin Đề Tài";
            this.Load += new System.EventHandler(this.Fdetai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDTDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QLDTDataSet7 qLDTDataSet7;
        private System.Windows.Forms.BindingSource detaiBindingSource;
        private QLDTDataSet7TableAdapters.DetaiTableAdapter detaiTableAdapter;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnthoat;
    }
}