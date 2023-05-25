namespace Lab3_sakharov
{
    partial class DirectorForm
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
            this.HelloLabelDir = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Report1Btn = new System.Windows.Forms.Button();
            this.Report2Btn = new System.Windows.Forms.Button();
            this.ComplimentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelloLabelDir
            // 
            this.HelloLabelDir.AutoSize = true;
            this.HelloLabelDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelloLabelDir.Location = new System.Drawing.Point(271, 113);
            this.HelloLabelDir.Name = "HelloLabelDir";
            this.HelloLabelDir.Size = new System.Drawing.Size(0, 24);
            this.HelloLabelDir.TabIndex = 1;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Location = new System.Drawing.Point(325, 328);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(159, 59);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // Report1Btn
            // 
            this.Report1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report1Btn.Location = new System.Drawing.Point(179, 176);
            this.Report1Btn.Name = "Report1Btn";
            this.Report1Btn.Size = new System.Drawing.Size(159, 59);
            this.Report1Btn.TabIndex = 3;
            this.Report1Btn.Text = "Отчет 1";
            this.Report1Btn.UseVisualStyleBackColor = true;
            // 
            // Report2Btn
            // 
            this.Report2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report2Btn.Location = new System.Drawing.Point(455, 176);
            this.Report2Btn.Name = "Report2Btn";
            this.Report2Btn.Size = new System.Drawing.Size(159, 59);
            this.Report2Btn.TabIndex = 4;
            this.Report2Btn.Text = "Отчет 2";
            this.Report2Btn.UseVisualStyleBackColor = true;
            // 
            // ComplimentBtn
            // 
            this.ComplimentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComplimentBtn.Location = new System.Drawing.Point(325, 263);
            this.ComplimentBtn.Name = "ComplimentBtn";
            this.ComplimentBtn.Size = new System.Drawing.Size(159, 59);
            this.ComplimentBtn.TabIndex = 5;
            this.ComplimentBtn.Text = "Комплимент дня";
            this.ComplimentBtn.UseVisualStyleBackColor = true;
            this.ComplimentBtn.Click += new System.EventHandler(this.ComplimentBtn_Click);
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComplimentBtn);
            this.Controls.Add(this.Report2Btn);
            this.Controls.Add(this.Report1Btn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.HelloLabelDir);
            this.Name = "DirectorForm";
            this.Text = "DirectorForm";
            this.Load += new System.EventHandler(this.DirectorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLabelDir;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button Report1Btn;
        private System.Windows.Forms.Button Report2Btn;
        private System.Windows.Forms.Button ComplimentBtn;
    }
}