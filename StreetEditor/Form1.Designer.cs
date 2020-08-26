namespace StreetEditor
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
            this.lst_names = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_street_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lst_names
            // 
            this.lst_names.FormattingEnabled = true;
            this.lst_names.Location = new System.Drawing.Point(36, 47);
            this.lst_names.Name = "lst_names";
            this.lst_names.Size = new System.Drawing.Size(139, 264);
            this.lst_names.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(294, 213);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "button1";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_street_name
            // 
            this.txt_street_name.Location = new System.Drawing.Point(417, 127);
            this.txt_street_name.Name = "txt_street_name";
            this.txt_street_name.Size = new System.Drawing.Size(100, 20);
            this.txt_street_name.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_street_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lst_names);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_names;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_street_name;
    }
}

