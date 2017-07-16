namespace QLNCKH
{
    partial class FTimKiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbtruongtimkiem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trường Tìm Kiếm";
            // 
            // cbtruongtimkiem
            // 
            this.cbtruongtimkiem.FormattingEnabled = true;
            this.cbtruongtimkiem.Items.AddRange(new object[] {
            "Tên Sinh Viên",
            "Tên Giảng Viên",
            "Tên Khoa",
            "Tên Lớp",
            "Tên Đề Tài"});
            this.cbtruongtimkiem.Location = new System.Drawing.Point(229, 42);
            this.cbtruongtimkiem.Name = "cbtruongtimkiem";
            this.cbtruongtimkiem.Size = new System.Drawing.Size(203, 28);
            this.cbtruongtimkiem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ Khóa";
            // 
            // txttukhoa
            // 
            this.txttukhoa.Location = new System.Drawing.Point(229, 76);
            this.txttukhoa.Name = "txttukhoa";
            this.txttukhoa.Size = new System.Drawing.Size(203, 26);
            this.txttukhoa.TabIndex = 3;
            this.txttukhoa.TextChanged += new System.EventHandler(this.txttukhoa_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(927, 350);
            this.dataGridView1.TabIndex = 4;
            // 
            // FTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 483);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttukhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbtruongtimkiem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FTimKiem";
            this.Text = "FTimKiem";
            this.Load += new System.EventHandler(this.FTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtruongtimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}