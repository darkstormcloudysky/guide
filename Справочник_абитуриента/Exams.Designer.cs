
namespace Справочник_абитуриента
{
    partial class Exams
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSorting3 = new System.Windows.Forms.Button();
            this.buttonSorting2 = new System.Windows.Forms.Button();
            this.buttonSorting1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxForExams = new System.Windows.Forms.ComboBox();
            this.dataGridViewForExams = new System.Windows.Forms.DataGridView();
            this.universityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetForExams = new Справочник_абитуриента.DatabaseDataSetForExams();
            this.tableTableAdapter = new Справочник_абитуриента.DatabaseDataSetForExamsTableAdapters.TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForExams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetForExams)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(800, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Сортировать по:";
            // 
            // buttonSorting3
            // 
            this.buttonSorting3.Location = new System.Drawing.Point(800, 80);
            this.buttonSorting3.Name = "buttonSorting3";
            this.buttonSorting3.Size = new System.Drawing.Size(150, 20);
            this.buttonSorting3.TabIndex = 14;
            this.buttonSorting3.Text = "проходному баллу";
            this.buttonSorting3.UseVisualStyleBackColor = true;
            this.buttonSorting3.Click += new System.EventHandler(this.buttonSorting3_Click);
            // 
            // buttonSorting2
            // 
            this.buttonSorting2.Location = new System.Drawing.Point(800, 50);
            this.buttonSorting2.Name = "buttonSorting2";
            this.buttonSorting2.Size = new System.Drawing.Size(150, 20);
            this.buttonSorting2.TabIndex = 13;
            this.buttonSorting2.Text = "стоимости обучения";
            this.buttonSorting2.UseVisualStyleBackColor = true;
            this.buttonSorting2.Click += new System.EventHandler(this.buttonSorting2_Click);
            // 
            // buttonSorting1
            // 
            this.buttonSorting1.Location = new System.Drawing.Point(800, 20);
            this.buttonSorting1.Name = "buttonSorting1";
            this.buttonSorting1.Size = new System.Drawing.Size(150, 20);
            this.buttonSorting1.TabIndex = 12;
            this.buttonSorting1.Text = "количеству мест";
            this.buttonSorting1.UseVisualStyleBackColor = true;
            this.buttonSorting1.Click += new System.EventHandler(this.buttonSorting1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Выберите экзамены:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(675, 40);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 30);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxForExams
            // 
            this.comboBoxForExams.FormattingEnabled = true;
            this.comboBoxForExams.Items.AddRange(new object[] {
            "Русский язык, биология, химия",
            "Русский язык, математика, биология",
            "Русский язык, математика, география",
            "Русский язык, математика, иностранный язык",
            "Русский язык, математика, информатика",
            "Русский язык, математика, обществознание",
            "Русский язык, математика, физика",
            "Русский язык, математика, химия",
            "Русский язык, обществознание, иностранный язык",
            "Русский язык, обществознание, история"});
            this.comboBoxForExams.Location = new System.Drawing.Point(50, 45);
            this.comboBoxForExams.Name = "comboBoxForExams";
            this.comboBoxForExams.Size = new System.Drawing.Size(575, 21);
            this.comboBoxForExams.TabIndex = 9;
            // 
            // dataGridViewForExams
            // 
            this.dataGridViewForExams.AllowUserToAddRows = false;
            this.dataGridViewForExams.AllowUserToDeleteRows = false;
            this.dataGridViewForExams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewForExams.AutoGenerateColumns = false;
            this.dataGridViewForExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.universityDataGridViewTextBoxColumn,
            this.specialityDataGridViewTextBoxColumn,
            this.examsDataGridViewTextBoxColumn,
            this.formDataGridViewTextBoxColumn,
            this.placesDataGridViewTextBoxColumn,
            this.coastDataGridViewTextBoxColumn,
            this.pointDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridViewForExams.DataSource = this.tableBindingSource;
            this.dataGridViewForExams.Location = new System.Drawing.Point(0, 110);
            this.dataGridViewForExams.Name = "dataGridViewForExams";
            this.dataGridViewForExams.ReadOnly = true;
            this.dataGridViewForExams.Size = new System.Drawing.Size(984, 351);
            this.dataGridViewForExams.TabIndex = 8;
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
            this.tableBindingSource.DataSource = this.databaseDataSetForExams;
            // 
            // databaseDataSetForExams
            // 
            this.databaseDataSetForExams.DataSetName = "DatabaseDataSetForExams";
            this.databaseDataSetForExams.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // Exams
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
            this.Controls.Add(this.comboBoxForExams);
            this.Controls.Add(this.dataGridViewForExams);
            this.Name = "Exams";
            this.Text = "Поиск по экзаменам";
            this.Load += new System.EventHandler(this.Exams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForExams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetForExams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSorting3;
        private System.Windows.Forms.Button buttonSorting2;
        private System.Windows.Forms.Button buttonSorting1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxForExams;
        private System.Windows.Forms.DataGridView dataGridViewForExams;
        private DatabaseDataSetForExams databaseDataSetForExams;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DatabaseDataSetForExamsTableAdapters.TableTableAdapter tableTableAdapter;
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