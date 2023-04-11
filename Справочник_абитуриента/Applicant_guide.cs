using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Справочник_абитуриента
{
    public partial class Applicant_guide : Form
    {
        public Applicant_guide()
        {
            InitializeComponent();
        }

        private void search_univercity_Click(object sender, EventArgs e)
        {
            University newForm = new University();
            newForm.Show();
        }

        private void search_speciality_Click(object sender, EventArgs e)
        {
            Speciality newForm = new Speciality();
            newForm.Show();
        }

        private void search_exams_Click(object sender, EventArgs e)
        {
            Exams newForm = new Exams();
            newForm.Show();
        }

        private void Applicant_guide_Load(object sender, EventArgs e)
        {

        }

        private void developersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение разработала студентка группы ИС-41 ГУМРФ имени адмирала С.О.Макарова:\n" + 
                "Иванова Валерия Александровна.", 
                "О разработчиках", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справочник абитуриента.\n" +
                "База данных содержит список ВУЗов, реализуемые программы подготовки, " + 
                "список экзаменов, необходимых для поступления, и такие данные, как " + 
                "форма обучения, количество бюджетных мест, стоимость контрактного обучения за год, " + 
                "проходной балл на бюджет прошлого года.\n" + 
                "Программа осуществляет поиск в базе данных в соответствии " + 
                "с заданными пользователем критериями, а также осуществляет сортировку данных " + 
                "по трем показателям: количество бюджетных мест (от большего к меньшему), " + 
                "стоимость обучения (от меньшей к большей) и проходной балл на бюджет (от меньшего к большему).",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
