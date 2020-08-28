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
            this.scena = new System.Windows.Forms.PictureBox();
            this.num_cols = new System.Windows.Forms.NumericUpDown();
            this.num_rows = new System.Windows.Forms.NumericUpDown();
            this.btn_new_map = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_rows)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_names
            // 
            this.lst_names.FormattingEnabled = true;
            this.lst_names.Location = new System.Drawing.Point(36, 47);
            this.lst_names.Name = "lst_names";
            this.lst_names.Size = new System.Drawing.Size(139, 264);
            this.lst_names.TabIndex = 0;
            this.lst_names.SelectedIndexChanged += new System.EventHandler(this.lst_names_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(36, 327);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(117, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_street_name
            // 
            this.txt_street_name.Location = new System.Drawing.Point(223, 47);
            this.txt_street_name.Name = "txt_street_name";
            this.txt_street_name.Size = new System.Drawing.Size(185, 20);
            this.txt_street_name.TabIndex = 2;
            // 
            // scena
            // 
            this.scena.Location = new System.Drawing.Point(209, 86);
            this.scena.Name = "scena";
            this.scena.Size = new System.Drawing.Size(946, 507);
            this.scena.TabIndex = 3;
            this.scena.TabStop = false;
            this.scena.Paint += new System.Windows.Forms.PaintEventHandler(this.scena_Paint);
            // 
            // num_cols
            // 
            this.num_cols.Location = new System.Drawing.Point(459, 22);
            this.num_cols.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.num_cols.Name = "num_cols";
            this.num_cols.Size = new System.Drawing.Size(120, 20);
            this.num_cols.TabIndex = 4;
            this.num_cols.ValueChanged += new System.EventHandler(this.num_cols_ValueChanged);
            this.num_cols.MouseClick += new System.Windows.Forms.MouseEventHandler(this.num_cols_MouseClick);
            // 
            // num_rows
            // 
            this.num_rows.Location = new System.Drawing.Point(459, 48);
            this.num_rows.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.num_rows.Name = "num_rows";
            this.num_rows.Size = new System.Drawing.Size(120, 20);
            this.num_rows.TabIndex = 5;
            this.num_rows.ValueChanged += new System.EventHandler(this.num_rows_ValueChanged);
            // 
            // btn_new_map
            // 
            this.btn_new_map.Location = new System.Drawing.Point(36, 356);
            this.btn_new_map.Name = "btn_new_map";
            this.btn_new_map.Size = new System.Drawing.Size(117, 23);
            this.btn_new_map.TabIndex = 6;
            this.btn_new_map.Text = "Новая улица";
            this.btn_new_map.UseVisualStyleBackColor = true;
            this.btn_new_map.Click += new System.EventHandler(this.btn_new_map_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(36, 386);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(117, 23);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Редактирование";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Высота";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 619);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_new_map);
            this.Controls.Add(this.num_rows);
            this.Controls.Add(this.num_cols);
            this.Controls.Add(this.scena);
            this.Controls.Add(this.txt_street_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lst_names);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_rows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_names;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_street_name;
        private System.Windows.Forms.PictureBox scena;
        private System.Windows.Forms.NumericUpDown num_cols;
        private System.Windows.Forms.NumericUpDown num_rows;
        private System.Windows.Forms.Button btn_new_map;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

