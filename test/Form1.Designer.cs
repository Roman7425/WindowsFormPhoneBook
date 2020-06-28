namespace test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.surnameInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.empty = new System.Windows.Forms.Label();
            this.emailError = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ColumnName,
            this.Surname,
            this.Phone,
            this.Email});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(990, 400);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Surname";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(94, 10);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(137, 22);
            this.nameInput.TabIndex = 8;
            // 
            // surnameInput
            // 
            this.surnameInput.Location = new System.Drawing.Point(94, 44);
            this.surnameInput.Name = "surnameInput";
            this.surnameInput.Size = new System.Drawing.Size(137, 22);
            this.surnameInput.TabIndex = 9;
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(94, 79);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(137, 22);
            this.phoneInput.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(256, 110);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(107, 37);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailInput
            // 
            this.emailInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.emailInput.Location = new System.Drawing.Point(94, 117);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(137, 22);
            this.emailInput.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email";
            // 
            // empty
            // 
            this.empty.AutoSize = true;
            this.empty.BackColor = System.Drawing.SystemColors.Control;
            this.empty.ForeColor = System.Drawing.Color.Red;
            this.empty.Location = new System.Drawing.Point(390, 120);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(145, 17);
            this.empty.TabIndex = 14;
            this.empty.Text = "Заполните все поля!";
            this.empty.Visible = false;
            // 
            // emailError
            // 
            this.emailError.AutoSize = true;
            this.emailError.BackColor = System.Drawing.SystemColors.Control;
            this.emailError.ForeColor = System.Drawing.Color.Red;
            this.emailError.Location = new System.Drawing.Point(552, 120);
            this.emailError.Name = "emailError";
            this.emailError.Size = new System.Drawing.Size(208, 17);
            this.emailError.TabIndex = 15;
            this.emailError.Text = "Недопустимое значение email";
            this.emailError.Visible = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 125;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 577);
            this.Controls.Add(this.emailError);
            this.Controls.Add(this.empty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.surnameInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox surnameInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label empty;
        private System.Windows.Forms.Label emailError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

