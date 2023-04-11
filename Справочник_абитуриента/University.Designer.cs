
namespace Справочник_абитуриента
{
    partial class University
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
            this.dataGridViewForUniversity = new System.Windows.Forms.DataGridView();
            this.universityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetForUniversity = new Справочник_абитуриента.DatabaseDataSetForUniversity();
            this.comboBoxForUniversity = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSorting1 = new System.Windows.Forms.Button();
            this.buttonSorting2 = new System.Windows.Forms.Button();
            this.buttonSorting3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableTableAdapter = new Справочник_абитуриента.DatabaseDataSetForUniversityTableAdapters.TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForUniversity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetForUniversity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewForUniversity
            // 
            this.dataGridViewForUniversity.AllowUserToAddRows = false;
            this.dataGridViewForUniversity.AllowUserToDeleteRows = false;
            this.dataGridViewForUniversity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewForUniversity.AutoGenerateColumns = false;
            this.dataGridViewForUniversity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForUniversity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.universityDataGridViewTextBoxColumn,
            this.specialityDataGridViewTextBoxColumn,
            this.examsDataGridViewTextBoxColumn,
            this.formDataGridViewTextBoxColumn,
            this.placesDataGridViewTextBoxColumn,
            this.coastDataGridViewTextBoxColumn,
            this.pointDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridViewForUniversity.DataSource = this.tableBindingSource;
            this.dataGridViewForUniversity.Location = new System.Drawing.Point(0, 110);
            this.dataGridViewForUniversity.Name = "dataGridViewForUniversity";
            this.dataGridViewForUniversity.ReadOnly = true;
            this.dataGridViewForUniversity.Size = new System.Drawing.Size(984, 351);
            this.dataGridViewForUniversity.TabIndex = 0;
            // 
            // universityDataGridViewTextBoxColumn
            // 
            this.universityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.universityDataGridViewTextBoxColumn.DataPropertyName = "University";
            this.universityDataGridViewTextBoxColumn.HeaderText = "ВУЗ";
            this.universityDataGridViewTextBoxColumn.Name = "universityDataGridViewTextBoxColumn";
            this.universityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specialityDataGridViewTextBoxColumn
            // 
            this.specialityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.specialityDataGridViewTextBoxColumn.DataPropertyName = "Speciality";
            this.specialityDataGridViewTextBoxColumn.HeaderText = "Направление подготовки";
            this.specialityDataGridViewTextBoxColumn.Name = "specialityDataGridViewTextBoxColumn";
            this.specialityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // examsDataGridViewTextBoxColumn
            // 
            this.examsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.examsDataGridViewTextBoxColumn.DataPropertyName = "Exams";
            this.examsDataGridViewTextBoxColumn.HeaderText = "Экзамены";
            this.examsDataGridViewTextBoxColumn.Name = "examsDataGridViewTextBoxColumn";
            this.examsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formDataGridViewTextBoxColumn
            // 
            this.formDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.formDataGridViewTextBoxColumn.DataPropertyName = "Form";
            this.formDataGridViewTextBoxColumn.HeaderText = "Форма обучения";
            this.formDataGridViewTextBoxColumn.Name = "formDataGridViewTextBoxColumn";
            this.formDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placesDataGridViewTextBoxColumn
            // 
            this.placesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.placesDataGridViewTextBoxColumn.DataPropertyName = "Places";
            this.placesDataGridViewTextBoxColumn.HeaderText = "Количество бюджетных мест";
            this.placesDataGridViewTextBoxColumn.Name = "placesDataGridViewTextBoxColumn";
            this.placesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coastDataGridViewTextBoxColumn
            // 
            this.coastDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coastDataGridViewTextBoxColumn.DataPropertyName = "Coast";
            this.coastDataGridViewTextBoxColumn.HeaderText = "Стоимость обучения";
            this.coastDataGridViewTextBoxColumn.Name = "coastDataGridViewTextBoxColumn";
            this.coastDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pointDataGridViewTextBoxColumn
            // 
            this.pointDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pointDataGridViewTextBoxColumn.DataPropertyName = "Point";
            this.pointDataGridViewTextBoxColumn.HeaderText = "Проходной балл на бюджет";
            this.pointDataGridViewTextBoxColumn.Name = "pointDataGridViewTextBoxColumn";
            this.pointDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.databaseDataSetForUniversity;
            // 
            // databaseDataSetForUniversity
            // 
            this.databaseDataSetForUniversity.DataSetName = "DatabaseDataSetForUniversity";
            this.databaseDataSetForUniversity.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxForUniversity
            // 
            this.comboBoxForUniversity.FormattingEnabled = true;
            this.comboBoxForUniversity.Items.AddRange(new object[] {
            "ГУМРФ",
            "ЛЭТИ",
            "ПСПбГМУ",
            "СПбГУ",
            "СПбПУ"});
            this.comboBoxForUniversity.Location = new System.Drawing.Point(50, 45);
            this.comboBoxForUniversity.Name = "comboBoxForUniversity";
            this.comboBoxForUniversity.Size = new System.Drawing.Size(575, 21);
            this.comboBoxForUniversity.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(675, 40);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 30);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите ВУЗ:";
            // 
            // buttonSorting1
            // 
            this.buttonSorting1.Location = new System.Drawing.Point(800, 20);
            this.buttonSorting1.Name = "buttonSorting1";
            this.buttonSorting1.Size = new System.Drawing.Size(150, 20);
            this.buttonSorting1.TabIndex = 4;
            this.buttonSorting1.Text = "количеству мест";
            this.buttonSorting1.UseVisualStyleBackColor = true;
            this.buttonSorting1.Click += new System.EventHandler(this.buttonSorting1_Click);
            // 
            // buttonSorting2
            // 
            this.buttonSorting2.Location = new System.Drawing.Point(800, 50);
            this.buttonSorting2.Name = "buttonSorting2";
            this.buttonSorting2.Size = new System.Drawing.Size(150, 20);
            this.buttonSorting2.TabIndex = 5;
            this.buttonSorting2.Text = "стоимости обучения";
            this.buttonSorting2.UseVisualStyleBackColor = true;
            this.buttonSorting2.Click += new System.EventHandler(this.buttonSorting2_Click);
            // 
            // buttonSorting3
            // 
            this.buttonSorting3.Location = new System.Drawing.Point(800, 80);
            this.buttonSorting3.Name = "buttonSorting3";
            this.buttonSorting3.Size = new System.Drawing.Size(150, 20);
            this.buttonSorting3.TabIndex = 6;
            this.buttonSorting3.Text = "проходному баллу";
            this.buttonSorting3.UseVisualStyleBackColor = true;
            this.buttonSorting3.Click += new System.EventHandler(this.buttonSorting3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(800, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сортировать по:";
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // University
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSorting3);
            this.Controls.Add(this.buttonSorting2);
            this.Controls.Add(this.buttonSorting1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxForUniversity);
            this.Controls.Add(this.dataGridViewForUniversity);
            this.Name = "University";
            this.Text = "Поиск ВУЗа";
            this.Load += new System.EventHandler(this.University_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForUniversity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetForUniversity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewForUniversity;
        private System.Windows.Forms.ComboBox comboBoxForUniversity;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSorting1;
        private System.Windows.Forms.Button buttonSorting2;
        private System.Windows.Forms.Button buttonSorting3;
        private System.Windows.Forms.Label label2;
        private DatabaseDataSetForUniversity databaseDataSetForUniversity;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DatabaseDataSetForUniversityTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}