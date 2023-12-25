namespace ExpensesApp
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameOp = new System.Windows.Forms.TextBox();
            this.textBoxSumOp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxCommentOp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddOperation = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сумма";
            // 
            // textBoxNameOp
            // 
            this.textBoxNameOp.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameOp.Location = new System.Drawing.Point(16, 49);
            this.textBoxNameOp.Multiline = true;
            this.textBoxNameOp.Name = "textBoxNameOp";
            this.textBoxNameOp.Size = new System.Drawing.Size(404, 25);
            this.textBoxNameOp.TabIndex = 3;
            this.textBoxNameOp.TextChanged += new System.EventHandler(this.textBoxNameOp_TextChanged);
            // 
            // textBoxSumOp
            // 
            this.textBoxSumOp.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSumOp.Location = new System.Drawing.Point(16, 100);
            this.textBoxSumOp.Multiline = true;
            this.textBoxSumOp.Name = "textBoxSumOp";
            this.textBoxSumOp.Size = new System.Drawing.Size(404, 25);
            this.textBoxSumOp.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Жилье",
            "Еда",
            "Коммунальные услуги",
            "Развлечения",
            "Образование",
            "Другое"});
            this.comboBox1.Location = new System.Drawing.Point(16, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 25);
            this.comboBox1.TabIndex = 10;
            // 
            // textBoxCommentOp
            // 
            this.textBoxCommentOp.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommentOp.Location = new System.Drawing.Point(16, 281);
            this.textBoxCommentOp.Multiline = true;
            this.textBoxCommentOp.Name = "textBoxCommentOp";
            this.textBoxCommentOp.Size = new System.Drawing.Size(404, 56);
            this.textBoxCommentOp.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Комментарий";
            // 
            // buttonAddOperation
            // 
            this.buttonAddOperation.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOperation.Location = new System.Drawing.Point(79, 362);
            this.buttonAddOperation.Name = "buttonAddOperation";
            this.buttonAddOperation.Size = new System.Drawing.Size(303, 34);
            this.buttonAddOperation.TabIndex = 13;
            this.buttonAddOperation.Text = "Добавить";
            this.buttonAddOperation.UseVisualStyleBackColor = true;
            this.buttonAddOperation.Click += new System.EventHandler(this.buttonClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 421);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonAddOperation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCommentOp);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSumOp);
            this.Controls.Add(this.textBoxNameOp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Добавления записи";
            this.Load += new System.EventHandler(this.AddOperationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameOp;
        private System.Windows.Forms.TextBox textBoxSumOp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxCommentOp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddOperation;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}