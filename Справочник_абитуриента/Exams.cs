﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Справочник_абитуриента
{
    public partial class Exams : Form
    {
        private SqlConnection sqlConnection = null;

        public Exams()
        {
            InitializeComponent();
        }

        private void Exams_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetForExams.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.databaseDataSetForExams.Table);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);

            sqlConnection.Open();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxForExams.SelectedIndex != -1)
            {
                string combobox = comboBoxForExams.SelectedItem.ToString();

                string request = "SELECT * FROM [Table] WHERE Exams = N'" + combobox + "'";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(request,
                    sqlConnection);

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                dataGridViewForExams.DataSource = dataSet.Tables[0];
            }
            else MessageBox.Show("Выберите экзамены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSorting1_Click(object sender, EventArgs e)
        {
            if (comboBoxForExams.SelectedIndex != -1)
            {
                string combobox = comboBoxForExams.SelectedItem.ToString();

                string request = "SELECT * FROM [Table] WHERE Exams = N'" + combobox + "' ORDER BY Places DESC";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(request,
                    sqlConnection);

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                dataGridViewForExams.DataSource = dataSet.Tables[0];
            }
            else
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Table] ORDER BY Places DESC",
                    sqlConnection);

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                dataGridViewForExams.DataSource = dataSet.Tables[0];
            }
        }

        private void buttonSorting2_Click(object sender, EventArgs e)
        {
            if (comboBoxForExams.SelectedIndex != -1)
            {
                string combobox = comboBoxForExams.SelectedItem.ToString();

                string request = "SELECT * FROM [Table] WHERE Exams = N'" + combobox + "' ORDER BY Coast ASC";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(request,
                    sqlConnection);

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                dataGridViewForExams.DataSource = dataSet.Tables[0];
            }
            else
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Table] ORDER BY Coast ASC",
                    sqlConnection);

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                dataGridViewForExams.DataSource = dataSet.Tables[0];
            }
        }

        private void buttonSorting3_Click(object sender, EventArgs e)
        {
            if (comboBoxForExams.SelectedIndex != -1)
            {
                string combobox = comboBoxForExams.SelectedItem.ToString();

                string request = "SELECT * FROM [Table] WHERE Exams = N'" + combobox + "' ORDER BY Point ASC";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(request,
                    sqlConnection);

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                dataGridViewForExams.DataSource = dataSet.Tables[0];
            }
            else
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Table] ORDER BY Point ASC",
                    sqlConnection);

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                dataGridViewForExams.DataSource = dataSet.Tables[0];
            }
        }
    }
}
