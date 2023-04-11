
namespace Справочник_абитуриента
{
    partial class Applicant_guide
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
            this.search_exams = new System.Windows.Forms.Button();
            this.search_speciality = new System.Windows.Forms.Button();
            this.search_univercity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_exams
            // 
            this.search_exams.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_exams.Location = new System.Drawing.Point(70, 275);
            this.search_exams.Name = "search_exams";
            this.search_exams.Size = new System.Drawing.Size(150, 50);
            this.search_exams.TabIndex = 0;
            this.search_exams.Text = "Поиск по экзаменам";
            this.search_exams.UseVisualStyleBackColor = true;
            this.search_exams.Click += new System.EventHandler(this.search_exams_Click);
            // 
            // search_speciality
            // 
            this.search_speciality.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_speciality.Location = new System.Drawing.Point(70, 175);
            this.search_speciality.Name = "search_speciality";
            this.search_speciality.Size = new System.Drawing.Size(150, 50);
            this.search_speciality.TabIndex = 1;
            this.search_speciality.Text = "Поиск по направлению подготовки";
            this.search_speciality.UseVisualStyleBackColor = true;
            this.search_speciality.Click += new System.EventHandler(this.search_speciality_Click);
            // 
            // search_univercity
            // 
            this.search_univercity.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_univercity.Location = new System.Drawing.Point(70, 75);
            this.search_univercity.Name = "search_univercity";
            this.search_univercity.Size = new System.Drawing.Size(150, 50);
            this.search_univercity.TabIndex = 2;
            this.search_univercity.Text = "Поиск ВУЗа";
            this.search_univercity.UseVisualStyleBackColor = true;
            this.search_univercity.Click += new System.EventHandler(this.search_univercity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите действие";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developersToolStripMenuItem,
            this.programToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // developersToolStripMenuItem
            // 
            this.developersToolStripMenuItem.Name = "developersToolStripMenuItem";
            this.developersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.developersToolStripMenuItem.Text = "О разработчиках";
            this.developersToolStripMenuItem.Click += new System.EventHandler(this.developersToolStripMenuItem_Click);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programToolStripMenuItem.Text = "О программе";
            this.programToolStripMenuItem.Click += new System.EventHandler(this.programToolStripMenuItem_Click);
            // 
            // Applicant_guide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_univercity);
            this.Controls.Add(this.search_speciality);
            this.Controls.Add(this.search_exams);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Applicant_guide";
            this.Text = "Справочник абитуриента";
            this.Load += new System.EventHandler(this.Applicant_guide_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_exams;
        private System.Windows.Forms.Button search_speciality;
        private System.Windows.Forms.Button search_univercity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
    }
}

