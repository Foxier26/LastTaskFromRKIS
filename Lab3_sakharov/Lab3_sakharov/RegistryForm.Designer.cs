namespace Lab3_sakharov
{
    partial class RegistryForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PswTxt = new System.Windows.Forms.TextBox();
            this.LoginTxt = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PswTxt2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FioTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RolesCombo = new System.Windows.Forms.ComboBox();
            this.sampleDBSakharovDataSet1 = new Lab3_sakharov.SampleDBSakharovDataSet1();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new Lab3_sakharov.SampleDBSakharovDataSet1TableAdapters.RolesTableAdapter();
            this.sampleDBSakharovDataSet2 = new Lab3_sakharov.SampleDBSakharovDataSet2();
            this.rolesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter1 = new Lab3_sakharov.SampleDBSakharovDataSet2TableAdapters.RolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDBSakharovDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDBSakharovDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(215, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(215, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Логин";
            // 
            // PswTxt
            // 
            this.PswTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PswTxt.Location = new System.Drawing.Point(329, 122);
            this.PswTxt.Name = "PswTxt";
            this.PswTxt.PasswordChar = '*';
            this.PswTxt.Size = new System.Drawing.Size(264, 29);
            this.PswTxt.TabIndex = 11;
            // 
            // LoginTxt
            // 
            this.LoginTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTxt.Location = new System.Drawing.Point(329, 87);
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(264, 29);
            this.LoginTxt.TabIndex = 10;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.Location = new System.Drawing.Point(418, 285);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(171, 59);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterBtn.Location = new System.Drawing.Point(215, 285);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(159, 59);
            this.RegisterBtn.TabIndex = 8;
            this.RegisterBtn.Text = "Регистрация";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(332, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Регистрация пользователя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(215, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Пароль2";
            // 
            // PswTxt2
            // 
            this.PswTxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PswTxt2.Location = new System.Drawing.Point(329, 155);
            this.PswTxt2.Name = "PswTxt2";
            this.PswTxt2.PasswordChar = '*';
            this.PswTxt2.Size = new System.Drawing.Size(264, 29);
            this.PswTxt2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(215, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Роль";
            // 
            // FioTxt
            // 
            this.FioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FioTxt.Location = new System.Drawing.Point(329, 225);
            this.FioTxt.Name = "FioTxt";
            this.FioTxt.Size = new System.Drawing.Size(264, 29);
            this.FioTxt.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(215, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "ФИО";
            // 
            // RolesCombo
            // 
            this.RolesCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RolesCombo.FormattingEnabled = true;
            this.RolesCombo.Location = new System.Drawing.Point(329, 190);
            this.RolesCombo.Name = "RolesCombo";
            this.RolesCombo.Size = new System.Drawing.Size(264, 32);
            this.RolesCombo.TabIndex = 16;
            // 
            // sampleDBSakharovDataSet1
            // 
            this.sampleDBSakharovDataSet1.DataSetName = "SampleDBSakharovDataSet1";
            this.sampleDBSakharovDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.sampleDBSakharovDataSet1;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // sampleDBSakharovDataSet2
            // 
            this.sampleDBSakharovDataSet2.DataSetName = "SampleDBSakharovDataSet2";
            this.sampleDBSakharovDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesBindingSource1
            // 
            this.rolesBindingSource1.DataMember = "Roles";
            this.rolesBindingSource1.DataSource = this.sampleDBSakharovDataSet2;
            // 
            // rolesTableAdapter1
            // 
            this.rolesTableAdapter1.ClearBeforeFill = true;
            // 
            // RegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RolesCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FioTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PswTxt2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PswTxt);
            this.Controls.Add(this.LoginTxt);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.label1);
            this.Name = "RegistryForm";
            this.Text = "Регистрация новых пользователей";
            this.Load += new System.EventHandler(this.RegistryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sampleDBSakharovDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDBSakharovDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PswTxt;
        private System.Windows.Forms.TextBox LoginTxt;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PswTxt2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FioTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RolesCombo;
        private SampleDBSakharovDataSet1 sampleDBSakharovDataSet1;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private SampleDBSakharovDataSet1TableAdapters.RolesTableAdapter rolesTableAdapter;
        private SampleDBSakharovDataSet2 sampleDBSakharovDataSet2;
        private System.Windows.Forms.BindingSource rolesBindingSource1;
        private SampleDBSakharovDataSet2TableAdapters.RolesTableAdapter rolesTableAdapter1;
    }
}