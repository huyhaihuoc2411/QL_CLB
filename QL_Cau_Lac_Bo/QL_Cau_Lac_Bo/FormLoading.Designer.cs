namespace QL_Cau_Lac_Bo
{
    partial class FormLoading
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
            this.lbl_phantram = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Myprogess = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_phantram
            // 
            this.lbl_phantram.AutoSize = true;
            this.lbl_phantram.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phantram.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_phantram.Location = new System.Drawing.Point(189, 347);
            this.lbl_phantram.Name = "lbl_phantram";
            this.lbl_phantram.Size = new System.Drawing.Size(34, 29);
            this.lbl_phantram.TabIndex = 9;
            this.lbl_phantram.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(42, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Đang tải ...";
            // 
            // Myprogess
            // 
            this.Myprogess.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.Myprogess.Location = new System.Drawing.Point(42, 379);
            this.Myprogess.Name = "Myprogess";
            this.Myprogess.Size = new System.Drawing.Size(713, 10);
            this.Myprogess.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(338, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hệ thống quản lý câu lạc bộ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 415);
            this.Controls.Add(this.lbl_phantram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Myprogess);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoading";
            this.Text = "FormLoading";
            this.Load += new System.EventHandler(this.FormLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_phantram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar Myprogess;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}