using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//*Используя полученные знания и класс TrueFalse в качестве шаблона, 
//    разработать собственную утилиту хранения данных (Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).
//    Черников Олег
namespace hw8ex4
{
    public partial class Form1 : Form
    {
        Words database;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Create new data base", "Message");
                return;
            }
            database.Add(rtbEnglish.Text, rtbRussian.Text);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (database.Count == 1 || database == null) return;
            database.Remove(new Dictionary(rtbEnglish.Text, rtbRussian.Text));
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("Data base wasn't created");
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new Words(sfd.FileName);
                database.Add("test", "тест");
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new Words(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                database[(int)nudNumber.Value - 1].EnglishText = rtbEnglish.Text;
                database[(int)nudNumber.Value - 1].RussianText = rtbRussian.Text;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Details: {ex.Message}", "Open or create file with words");
            }

        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                rtbEnglish.Text = database[(int)nudNumber.Value - 1].EnglishText;
                rtbRussian.Text = database[(int)nudNumber.Value - 1].RussianText;

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Details: {ex.Message}", "No such word");
            }
        }
    }
}
