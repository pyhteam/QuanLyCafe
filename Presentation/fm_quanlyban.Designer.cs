namespace QuanLyCafe.Presentation
{
    partial class fm_quanlyban
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelDanhSachBan = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThemBan = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanelDanhSachBan);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dánh sách bàn ";
            // 
            // flowLayoutPanelDanhSachBan
            // 
            this.flowLayoutPanelDanhSachBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDanhSachBan.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelDanhSachBan.Name = "flowLayoutPanelDanhSachBan";
            this.flowLayoutPanelDanhSachBan.Size = new System.Drawing.Size(550, 324);
            this.flowLayoutPanelDanhSachBan.TabIndex = 0;
            // 
            // btnThemBan
            // 
            this.btnThemBan.Location = new System.Drawing.Point(575, 23);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(90, 27);
            this.btnThemBan.TabIndex = 1;
            this.btnThemBan.Text = "Thêm bàn";
            this.btnThemBan.UseVisualStyleBackColor = true;
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(575, 56);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(90, 27);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "LoadData";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // fm_quanlyban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 376);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnThemBan);
            this.Controls.Add(this.groupBox1);
            this.Name = "fm_quanlyban";
            this.Text = "fm_quanlyban";
            this.Load += new System.EventHandler(this.fm_quanlyban_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDanhSachBan;
        private System.Windows.Forms.Button btnThemBan;
        private System.Windows.Forms.Button btnLoadData;
    }
}