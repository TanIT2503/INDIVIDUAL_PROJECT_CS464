namespace INDIVIDUAL_PROJECT
{
    partial class frm_ThanhToan
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
            this.lbl_ThanhToan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_MaNV = new System.Windows.Forms.ComboBox();
            this.txt_MaTT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.txt_ThuongThem = new System.Windows.Forms.TextBox();
            this.txt_GioLV = new System.Windows.Forms.TextBox();
            this.lbl_Tim = new System.Windows.Forms.Label();
            this.lbl_ThuongThem = new System.Windows.Forms.Label();
            this.lbl_GioLV = new System.Windows.Forms.Label();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ThanhToan
            // 
            this.lbl_ThanhToan.AutoSize = true;
            this.lbl_ThanhToan.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhToan.Location = new System.Drawing.Point(415, 30);
            this.lbl_ThanhToan.Name = "lbl_ThanhToan";
            this.lbl_ThanhToan.Size = new System.Drawing.Size(380, 31);
            this.lbl_ThanhToan.TabIndex = 0;
            this.lbl_ThanhToan.Text = "THANH TOÁN LƯƠNG NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cb_MaNV);
            this.groupBox1.Controls.Add(this.txt_MaTT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Reset);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.txt_Tim);
            this.groupBox1.Controls.Add(this.txt_ThuongThem);
            this.groupBox1.Controls.Add(this.txt_GioLV);
            this.groupBox1.Controls.Add(this.lbl_Tim);
            this.groupBox1.Controls.Add(this.lbl_ThuongThem);
            this.groupBox1.Controls.Add(this.lbl_GioLV);
            this.groupBox1.Controls.Add(this.lbl_MaNV);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1192, 233);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1088, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_MaNV
            // 
            this.cb_MaNV.FormattingEnabled = true;
            this.cb_MaNV.Location = new System.Drawing.Point(529, 42);
            this.cb_MaNV.Name = "cb_MaNV";
            this.cb_MaNV.Size = new System.Drawing.Size(211, 35);
            this.cb_MaNV.TabIndex = 18;
            // 
            // txt_MaTT
            // 
            this.txt_MaTT.Location = new System.Drawing.Point(188, 39);
            this.txt_MaTT.Name = "txt_MaTT";
            this.txt_MaTT.Size = new System.Drawing.Size(169, 34);
            this.txt_MaTT.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã thanh toán:";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(1051, 165);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(118, 44);
            this.btn_Reset.TabIndex = 14;
            this.btn_Reset.Text = "Nhập lại";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(815, 165);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(99, 44);
            this.btn_Sua.TabIndex = 13;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(935, 165);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(99, 44);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(935, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 17);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(700, 165);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(99, 44);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(889, 42);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(180, 34);
            this.txt_Tim.TabIndex = 9;
            // 
            // txt_ThuongThem
            // 
            this.txt_ThuongThem.Location = new System.Drawing.Point(529, 111);
            this.txt_ThuongThem.Name = "txt_ThuongThem";
            this.txt_ThuongThem.Size = new System.Drawing.Size(211, 34);
            this.txt_ThuongThem.TabIndex = 7;
            // 
            // txt_GioLV
            // 
            this.txt_GioLV.Location = new System.Drawing.Point(188, 111);
            this.txt_GioLV.Name = "txt_GioLV";
            this.txt_GioLV.Size = new System.Drawing.Size(169, 34);
            this.txt_GioLV.TabIndex = 5;
            // 
            // lbl_Tim
            // 
            this.lbl_Tim.AutoSize = true;
            this.lbl_Tim.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tim.Location = new System.Drawing.Point(782, 45);
            this.lbl_Tim.Name = "lbl_Tim";
            this.lbl_Tim.Size = new System.Drawing.Size(101, 27);
            this.lbl_Tim.TabIndex = 4;
            this.lbl_Tim.Text = "Tìm kiếm:";
            // 
            // lbl_ThuongThem
            // 
            this.lbl_ThuongThem.AutoSize = true;
            this.lbl_ThuongThem.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThuongThem.Location = new System.Drawing.Point(377, 114);
            this.lbl_ThuongThem.Name = "lbl_ThuongThem";
            this.lbl_ThuongThem.Size = new System.Drawing.Size(139, 27);
            this.lbl_ThuongThem.TabIndex = 3;
            this.lbl_ThuongThem.Text = "Thưởng thêm:";
            // 
            // lbl_GioLV
            // 
            this.lbl_GioLV.AutoSize = true;
            this.lbl_GioLV.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioLV.Location = new System.Drawing.Point(14, 114);
            this.lbl_GioLV.Name = "lbl_GioLV";
            this.lbl_GioLV.Size = new System.Drawing.Size(128, 27);
            this.lbl_GioLV.TabIndex = 2;
            this.lbl_GioLV.Text = "Giờ làm việc:";
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNV.Location = new System.Drawing.Point(379, 42);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(140, 27);
            this.lbl_MaNV.TabIndex = 0;
            this.lbl_MaNV.Text = "Mã nhân viên: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1192, 229);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lương";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1180, 190);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frm_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_ThanhToan);
            this.Name = "frm_ThanhToan";
            this.Text = "Thanh Toán Lương Nhân Viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_ThanhToan_FormClosed);
            this.Load += new System.EventHandler(this.frm_ThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ThanhToan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.TextBox txt_ThuongThem;
        private System.Windows.Forms.TextBox txt_GioLV;
        private System.Windows.Forms.Label lbl_ThuongThem;
        private System.Windows.Forms.Label lbl_GioLV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_MaTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_MaNV;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Label lbl_Tim;
        private System.Windows.Forms.Button button1;
    }
}