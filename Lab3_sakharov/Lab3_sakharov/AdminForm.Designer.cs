namespace Lab3_sakharov
{
    partial class AdminForm
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
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.AccountBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.HelloLabelAdmin = new System.Windows.Forms.Label();
            this.PasswordRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUserBtn.Location = new System.Drawing.Point(135, 234);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(263, 59);
            this.AddUserBtn.TabIndex = 13;
            this.AddUserBtn.Text = "Добавить пользователя";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            // 
            // AccountBtn
            // 
            this.AccountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountBtn.Location = new System.Drawing.Point(135, 160);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Size = new System.Drawing.Size(263, 59);
            this.AccountBtn.TabIndex = 12;
            this.AccountBtn.Text = "Все учетные записи";
            this.AccountBtn.UseVisualStyleBackColor = true;
            this.AccountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Location = new System.Drawing.Point(430, 234);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(263, 59);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // HelloLabelAdmin
            // 
            this.HelloLabelAdmin.AutoSize = true;
            this.HelloLabelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelloLabelAdmin.Location = new System.Drawing.Point(269, 88);
            this.HelloLabelAdmin.Name = "HelloLabelAdmin";
            this.HelloLabelAdmin.Size = new System.Drawing.Size(0, 24);
            this.HelloLabelAdmin.TabIndex = 10;
            // 
            // PasswordRestore
            // 
            this.PasswordRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordRestore.Location = new System.Drawing.Point(430, 160);
            this.PasswordRestore.Name = "PasswordRestore";
            this.PasswordRestore.Size = new System.Drawing.Size(263, 59);
            this.PasswordRestore.TabIndex = 12;
            this.PasswordRestore.Text = "Сбросить пароль";
            this.PasswordRestore.UseVisualStyleBackColor = true;
            this.PasswordRestore.Click += new System.EventHandler(this.PasswordRestore_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.PasswordRestore);
            this.Controls.Add(this.AccountBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.HelloLabelAdmin);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button AccountBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label HelloLabelAdmin;
        private System.Windows.Forms.Button PasswordRestore;
    }
}