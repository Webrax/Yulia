namespace journal
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
            this.components = new System.ComponentModel.Container();
            this.Journal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new journal.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new journal.Database1DataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new journal.Database1DataSetTableAdapters.TableAdapterManager();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пІБDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кстьПропусківПнDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кстьПропусківВтDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кстьПропусківСрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кстьПропусківЧтDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кстьПропусківСбDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.загальнаКстьПропусківDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Journal
            // 
            this.Journal.AutoSize = true;
            this.Journal.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Journal.Location = new System.Drawing.Point(36, 18);
            this.Journal.Name = "Journal";
            this.Journal.Size = new System.Drawing.Size(258, 29);
            this.Journal.TabIndex = 0;
            this.Journal.Text = "Журнал відвідувань";
            this.Journal.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.пІБDataGridViewTextBoxColumn,
            this.кстьПропусківПнDataGridViewTextBoxColumn,
            this.кстьПропусківВтDataGridViewTextBoxColumn,
            this.кстьПропусківСрDataGridViewTextBoxColumn,
            this.кстьПропусківЧтDataGridViewTextBoxColumn,
            this.кстьПропусківСбDataGridViewTextBoxColumn,
            this.загальнаКстьПропусківDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(385, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 567);
            this.dataGridView1.TabIndex = 1;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.database1DataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = journal.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.Frozen = true;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // пІБDataGridViewTextBoxColumn
            // 
            this.пІБDataGridViewTextBoxColumn.DataPropertyName = "ПІБ";
            this.пІБDataGridViewTextBoxColumn.Frozen = true;
            this.пІБDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            this.пІБDataGridViewTextBoxColumn.Name = "пІБDataGridViewTextBoxColumn";
            // 
            // кстьПропусківПнDataGridViewTextBoxColumn
            // 
            this.кстьПропусківПнDataGridViewTextBoxColumn.DataPropertyName = "К-сть пропусків (Пн)";
            this.кстьПропусківПнDataGridViewTextBoxColumn.Frozen = true;
            this.кстьПропусківПнDataGridViewTextBoxColumn.HeaderText = "К-сть пропусків (Пн)";
            this.кстьПропусківПнDataGridViewTextBoxColumn.Name = "кстьПропусківПнDataGridViewTextBoxColumn";
            // 
            // кстьПропусківВтDataGridViewTextBoxColumn
            // 
            this.кстьПропусківВтDataGridViewTextBoxColumn.DataPropertyName = "К-сть пропусків (Вт)";
            this.кстьПропусківВтDataGridViewTextBoxColumn.Frozen = true;
            this.кстьПропусківВтDataGridViewTextBoxColumn.HeaderText = "К-сть пропусків (Вт)";
            this.кстьПропусківВтDataGridViewTextBoxColumn.Name = "кстьПропусківВтDataGridViewTextBoxColumn";
            // 
            // кстьПропусківСрDataGridViewTextBoxColumn
            // 
            this.кстьПропусківСрDataGridViewTextBoxColumn.DataPropertyName = "К-сть пропусків (Ср)";
            this.кстьПропусківСрDataGridViewTextBoxColumn.Frozen = true;
            this.кстьПропусківСрDataGridViewTextBoxColumn.HeaderText = "К-сть пропусків (Ср)";
            this.кстьПропусківСрDataGridViewTextBoxColumn.Name = "кстьПропусківСрDataGridViewTextBoxColumn";
            // 
            // кстьПропусківЧтDataGridViewTextBoxColumn
            // 
            this.кстьПропусківЧтDataGridViewTextBoxColumn.DataPropertyName = "К-сть пропусків (Чт)";
            this.кстьПропусківЧтDataGridViewTextBoxColumn.Frozen = true;
            this.кстьПропусківЧтDataGridViewTextBoxColumn.HeaderText = "К-сть пропусків (Чт)";
            this.кстьПропусківЧтDataGridViewTextBoxColumn.Name = "кстьПропусківЧтDataGridViewTextBoxColumn";
            // 
            // кстьПропусківСбDataGridViewTextBoxColumn
            // 
            this.кстьПропусківСбDataGridViewTextBoxColumn.DataPropertyName = "К-сть пропусків (Сб)";
            this.кстьПропусківСбDataGridViewTextBoxColumn.Frozen = true;
            this.кстьПропусківСбDataGridViewTextBoxColumn.HeaderText = "К-сть пропусків (Сб)";
            this.кстьПропусківСбDataGridViewTextBoxColumn.Name = "кстьПропусківСбDataGridViewTextBoxColumn";
            // 
            // загальнаКстьПропусківDataGridViewTextBoxColumn
            // 
            this.загальнаКстьПропусківDataGridViewTextBoxColumn.DataPropertyName = "Загальна к-сть пропусків";
            this.загальнаКстьПропусківDataGridViewTextBoxColumn.Frozen = true;
            this.загальнаКстьПропусківDataGridViewTextBoxColumn.HeaderText = "Загальна к-сть пропусків";
            this.загальнаКстьПропусківDataGridViewTextBoxColumn.Name = "загальнаКстьПропусківDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Location = new System.Drawing.Point(426, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 29);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(201, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(102, 23);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(299, 3);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(102, 23);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(398, 3);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(102, 23);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(497, 3);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(102, 23);
            this.textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(595, 3);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(102, 23);
            this.textBox7.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(712, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "За тиждень";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(854, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дати";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(-5, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Назва групи";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(426, 668);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 72);
            this.panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(201, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(299, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(398, 3);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(102, 23);
            this.textBox8.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(497, 3);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(102, 23);
            this.textBox9.TabIndex = 7;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.Location = new System.Drawing.Point(595, 3);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(102, 23);
            this.textBox10.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(59, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Назва предмету";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox11.Location = new System.Drawing.Point(93, 4);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(102, 23);
            this.textBox11.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 834);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Journal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Journal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database1DataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пІБDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кстьПропусківПнDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кстьПропусківВтDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кстьПропусківСрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кстьПропусківЧтDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кстьПропусківСбDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn загальнаКстьПропусківDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

