namespace Lab3_sakharov
{
    partial class ManagerForm
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
            this.Report4Btn = new System.Windows.Forms.Button();
            this.Report3Btn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.HelloLabelManage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Report4Btn
            // 
            this.Report4Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report4Btn.Location = new System.Drawing.Point(471, 182);
            this.Report4Btn.Name = "Report4Btn";
            this.Report4Btn.Size = new System.Drawing.Size(159, 59);
            this.Report4Btn.TabIndex = 9;
            this.Report4Btn.Text = "Отчет 4";
            this.Report4Btn.UseVisualStyleBackColor = true;
            // 
            // Report3Btn
            // 
            this.Report3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report3Btn.Location = new System.Drawing.Point(183, 182);
            this.Report3Btn.Name = "Report3Btn";
            this.Report3Btn.Size = new System.Drawing.Size(159, 59);
            this.Report3Btn.TabIndex = 8;
            this.Report3Btn.Text = "Отчет 3";
            this.Report3Btn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Location = new System.Drawing.Point(329, 303);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(159, 59);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // HelloLabelManage
            // 
            this.HelloLabelManage.AutoSize = true;
            this.HelloLabelManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelloLabelManage.Location = new System.Drawing.Point(275, 88);
            this.HelloLabelManage.Name = "HelloLabelManage";
            this.HelloLabelManage.Size = new System.Drawing.Size(0, 24);
            this.HelloLabelManage.TabIndex = 6;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Report4Btn);
            this.Controls.Add(this.Report3Btn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.HelloLabelManage);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Report4Btn;
        private System.Windows.Forms.Button Report3Btn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label HelloLabelManage;
    }
}