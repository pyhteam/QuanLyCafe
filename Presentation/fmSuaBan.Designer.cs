
namespace QuanLyCafe.Presentation
{
    partial class fmSuaBan
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
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.btnDoiten = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(12, 36);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(265, 20);
            this.txtTenBan.TabIndex = 0;
            // 
            // btnDoiten
            // 
            this.btnDoiten.Location = new System.Drawing.Point(106, 62);
            this.btnDoiten.Name = "btnDoiten";
            this.btnDoiten.Size = new System.Drawing.Size(75, 23);
            this.btnDoiten.TabIndex = 1;
            this.btnDoiten.Text = "OK";
            this.btnDoiten.UseVisualStyleBackColor = true;
            this.btnDoiten.Click += new System.EventHandler(this.btnDoiten_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên bàn";
            // 
            // fmSuaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 109);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoiten);
            this.Controls.Add(this.txtTenBan);
            this.Name = "fmSuaBan";
            this.Text = "fmSuaBan";
            this.Load += new System.EventHandler(this.fmSuaBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Button btnDoiten;
        private System.Windows.Forms.Label label1;
    }
}