namespace Journal122
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.порядковийНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пІБDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кстьПропусків1ПараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кстьПропусків2ПараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кстьПропусків3ПараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кстьПропусків4ПараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кстьПропусків5ПараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кстьПропусків6ПараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кстьПропусків7ПараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.загальнаКстьПропусківDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Journal122.Database1DataSet();
            this.tableTableAdapter = new Journal122.Database1DataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Journal122.Database1DataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(545, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Журнал відвідувань";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.порядковийНомерDataGridViewTextBoxColumn,
            this.пІБDataGridViewTextBoxColumn,
            this.кстьПропусків1ПараDataGridViewTextBoxColumn,
            this.кстьПропусків2ПараDataGridViewTextBoxColumn,
            this.кстьПропусків3ПараDataGridViewTextBoxColumn,
            this.кстьПропусків4ПараDataGridViewTextBoxColumn,
            this.кстьПропусків5ПараDataGridViewTextBoxColumn,
            this.кстьПропусків6ПараDataGridViewTextBoxColumn,
            this.кстьПропусків7ПараDataGridViewTextBoxColumn,
            this.загальнаКстьПропусківDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(174, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1043, 558);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // порядковийНомерDataGridViewTextBoxColumn
            // 
            this.порядковийНомерDataGridViewTextBoxColumn.DataPropertyName = "Порядковий номер";
            this.порядковийНомерDataGridViewTextBoxColumn.HeaderText = "Порядковий номер";
            this.порядковийНомерDataGridViewTextBoxColumn.Name = "порядковийНомерDataGridViewTextBoxColumn";
            // 
            // пІБDataGridViewTextBoxColumn
            // 
            this.пІБDataGridViewTextBoxColumn.DataPropertyName = "ПІБ";
            this.пІБDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            this.пІБDataGridViewTextBoxColumn.Name = "пІБDataGridViewTextBoxColumn";
            // 
            // кстьПропусків1ПараDataGridViewTextBoxColumn
            // 
            this.кстьПропусків1ПараDataGridViewTextBoxColumn.DataPropertyName = "К-сть пропусків 1 пара";
            this.кстьПропусків1ПараDataGridViewTextBoxColumn.HeaderText = "К-сть пропусків 1 пара";
            this.кстьПропусків1ПараDataGridViewTextBoxColumn.Name = "кстьПропусків1ПараDataGridViewTextBoxColumn";
            // 
            // кстьПропусків2ПараDataGridViewTextBoxColumn
            // 
            this.кстьПропусків2ПараDataGridViewTextBoxColumn.DataPropertyName = "К-сть пропусків 2 пара";
            this.кстьПропусків2ПараDataGridViewTextBoxColumn.HeaderText = "К-сть пропусків 2 пара";
            this.кстьПропусків2ПараDataGridViewTextBoxColumn.Name = "кстьПропусків2ПараDataGridViewTextBoxColumn";
            // 
            // кстьПропусків3ПараDataGridViewTextBoxColumn
            // 
            this.кстьПропусків3ПараDataGridViewTextBoxColumn.DataPropertyName = "К-сть пропусків 3 пара";
            this.кстьПропусків3ПараDataGridViewTextBoxColumn.HeaderText = "К-сть пропусків 3 пара";
            this.кстьПропусків3ПараDataGridViewTextBoxColumn.Name = "кстьПропусків3ПараDataGridViewTextBoxColumn";
            // 
            // кстьПропусків4ПараDataGridViewTextBoxColumn
            // 
            this.кстьПропусків4ПараDataGridViewTextBoxColumn.DataPropertyName = "К-сть пропусків 4 пара";
            this.кстьПропусків4ПараDataGridViewTextBoxColumn.HeaderText = "К-сть пропусків 4 пара";
            this.кстьПропусків4ПараDataGridViewTextBoxColumn.Name = "кстьПропусків4ПараDataGridViewTextBoxColumn";
            // 
            // кстьПропусків5ПараDataGridViewTextBoxColumn
            // 
            this.кстьПропусків5ПараDataGridViewTextBoxColumn.DataPropertyName = "К-сть пропусків 5 пара";
            this.кстьПропусків5ПараDataGridViewTextBoxColumn.HeaderText = "К-сть пропусків 5 пара";
            this.кстьПропусків5ПараDataGridViewTextBoxColumn.Name = "кстьПропусків5ПараDataGridViewTextBoxColumn";
            // 
            // кстьПропусків6ПараDataGridViewTextBoxColumn
            // 
            this.кстьПропусків6ПараDataGridViewTextBoxColumn.DataPropertyName = "К-сть пропусків 6 пара";
            this.кстьПропусків6ПараDataGridViewTextBoxColumn.HeaderText = "К-сть пропусків 6 пара";
            this.кстьПропусків6ПараDataGridViewTextBoxColumn.Name = "кстьПропусків6ПараDataGridViewTextBoxColumn";
            // 
            // кстьПропусків7ПараDataGridViewTextBoxColumn
            // 
            this.кстьПропусків7ПараDataGridViewTextBoxColumn.DataPropertyName = "К-сть пропусків 7 пара";
            this.кстьПропусків7ПараDataGridViewTextBoxColumn.HeaderText = "К-сть пропусків 7 пара";
            this.кстьПропусків7ПараDataGridViewTextBoxColumn.Name = "кстьПропусків7ПараDataGridViewTextBoxColumn";
            // 
            // загальнаКстьПропусківDataGridViewTextBoxColumn
            // 
            this.загальнаКстьПропусківDataGridViewTextBoxColumn.DataPropertyName = "Загальна к-сть пропусків ";
            this.загальнаКстьПропусківDataGridViewTextBoxColumn.HeaderText = "Загальна к-сть пропусків ";
            this.загальнаКстьПропусківDataGridViewTextBoxColumn.Name = "загальнаКстьПропусківDataGridViewTextBoxColumn";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Journal122.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Location = new System.Drawing.Point(368, 651);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 85);
            this.panel1.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(41, 3);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(103, 20);
            this.textBox6.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(141, 3);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(103, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(544, 3);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(103, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(443, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(103, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(342, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(304, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Назва предмету";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(643, 3);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(107, 20);
            this.textBox7.TabIndex = 9;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1114, 48);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(103, 20);
            this.textBox8.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1055, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Дата";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1275, 832);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database1DataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn порядковийНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пІБDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кстьПропусків1ПараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кстьПропусків2ПараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кстьПропусків3ПараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кстьПропусків4ПараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кстьПропусків5ПараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кстьПропусків6ПараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кстьПропусків7ПараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn загальнаКстьПропусківDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label3;
    }
}

