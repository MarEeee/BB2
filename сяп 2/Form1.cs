using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace сяп_2
{

	public partial class StudentForm : Form
	{
		public bool checker = false;

		private ValueTuple<string, string> pole_value = new ValueTuple<string, string>();
		List<Student> list;

		public int position = 0;
		string fileName;

		public StudentForm()
		{
			InitializeComponent();
			myComboBox.SelectedIndex = 0;
		}
		private void createListStrip_Click(object sender, EventArgs e)
		{
			if (needUpdate() == true)
				return;

			list = new List<Student>();
			errorMessage.Text = "Пустой список был создан";
			timer1.Enabled = true;
			addStrip.Enabled = true;

		}

		private void openListStrip_Click(object sender, EventArgs e)
		{
			if (needUpdate() == true)
				return;
			openFileDialog.InitialDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            openFileDialog.FileName = string.Empty;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				fileName = new DirectoryInfo(openFileDialog.FileName).FullName;
				XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));
				using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
				{
                    try
                    {
                        list = (List<Student>)formatter.Deserialize(fs);
                    }
					catch // open a empty file
                    {
                        list = new List<Student>();
                    }
				}
                if (list.Count != 0)
                {
                    tbName.Text = list[position].name;
                    tbSurname.Text = list[position].surname;
                    tbFack.Text = list[position].fack;
                }
				else
                {
                    tbName.Text = string.Empty;
                    tbSurname.Text = string.Empty;
                    tbFack.Text = string.Empty;
                }
				checkupdate();
				checker = false;
			}


		}
		private void checkupdate() //вынесли все обновление в отдельный метод 
		{
			if (!string.IsNullOrEmpty(fileName))
				saveFast.Enabled = true;
            if (list.Count() != 0)
            {
                btnForNext.Enabled = true;
                nextStripMenu.Enabled = true;
                delStrip.Enabled = true;
				tbName.Enabled = true;
				tbSurname.Enabled = true;
				tbFack.Enabled = true;
				if (position != -1)
                {
                    Student current_stud = list[position];
                    tbName.Text = current_stud.name;
                    tbSurname.Text = current_stud.surname;
                    tbFack.Text = current_stud.fack;
                }
            }
			else
            {
                addStrip.Enabled = true;
				tbName.Enabled = false;
				tbSurname.Enabled = false;
				tbFack.Enabled = false;
				btnForNext.Enabled    = false;
                nextStripMenu.Enabled = false;
                delStrip.Enabled      = false;
                btnForPrev.Enabled = false;
            }

			if (IsLast())
			{
				btnForNext.Enabled = false;
				nextStripMenu.Enabled = false;
			}
			else
			{
				btnForNext.Enabled = true;
				nextStripMenu.Enabled = true;
			}

			if (IsFirst())
			{
				btnForPrev.Enabled = false;
				prevStripMenu.Enabled = false;
			}
			else
			{
				btnForPrev.Enabled = true;
				prevStripMenu.Enabled = true;
			}

			
			myTextBox.Enabled = true;
			btnFind.Enabled = true;
			
		}



		public void Next()
		{
			position = Find(1, position);
		}
        public void Prev() => position = Find(-1, position);
		public bool IsFirst()
		{
            if (position == 0 || list.Count() == 0) return true;
			return Find(-1, position) == -1? true : false;
		}

		public bool IsLast()
		{

            if (position == list.Count() - 1 || list.Count() == 0) return true;
			return Find(1, position) == -1 ? true : false;


		}

		private void saveForm()
		{

			saveFileDialog.FileName = string.IsNullOrEmpty(fileName) ? saveFileDialog.FileName : new DirectoryInfo(fileName).Name;
			if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
				return;
			Save_File(new DirectoryInfo(saveFileDialog.FileName).FullName);
		}

		private void saveFast_Click(object sender, EventArgs e)
		{
            if (!string.IsNullOrEmpty(fileName))
                Save_File(fileName);
            else
                saveForm();
		}
		private void Save_File(string name) // name - полный путь до файла
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }

            MessageBox.Show(string.Format("Файл {0} сохранен", new DirectoryInfo(name).Name));
            checker = false;
        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checker == false) return;
            else
            {
                DialogResult result = SavingList();
                if (result == DialogResult.Cancel)
                    e.Cancel = true;
                else if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(fileName))
                        saveForm();
                    else
                        Save_File(fileName);
                }
            }
        }
        private DialogResult SavingList()
        {
            return MessageBox.Show("Сохранить изменения?", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }
        private bool needUpdate()
		{
			if (checker == true && position != -1)
			{
				var result = SavingList();

				if (result == DialogResult.Yes)
				{
                    if (string.IsNullOrEmpty(fileName))
                        saveForm();
                    else
                        Save_File(fileName);
				}
				if (result == DialogResult.Cancel)
				{
					return true;
				}
			}
			return false;
		}
        private void safeListStrip_Click(object sender, EventArgs e) => saveForm();

		private void btnForPrev_Click(object sender, EventArgs e)
		{

			if ((tbName.Text == "" || tbSurname.Text == "" || tbFack.Text == "") && list.Count != 0)
			{
				MessageBox.Show("Вы ввели не все данные");
			}
			else
			{
				Prev();
				checkupdate();
			}
		}

		private void btnForNext_Click(object sender, EventArgs e)
		{
			if ((tbName.Text == "" || tbSurname.Text == "" || tbFack.Text == "") && list.Count != 0)
			{
				MessageBox.Show("Вы ввели не все данные");
			}
			else
			{
				Next();
				checkupdate();
			}
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			errorMessage.Text = " ";
			timer1.Enabled = false;
		}
		private void addStrip_Click(object sender, EventArgs e)
		{
            list.Add(new Student() { name = "", surname = "", fack = "" });
			position = list.Count() - 1;
           
			checkupdate();
			addStrip.Enabled = false;
			checker = true;
			tbName.Focus();
		}
		private void delStrip_Click(object sender, EventArgs e)
		{
			list.RemoveAt(position);
			if (position != 0)
			{
				position--;
			}
            if (list.Count() == 0)
            {
                tbName.Text = string.Empty;
                tbSurname.Text = string.Empty;
                tbFack.Text = string.Empty;
				tbName.Enabled = false;
				tbSurname.Enabled = false;
				tbFack.Enabled = false;
                checker = false;
			}
			else
            {
                checker = true;
            }
			checkupdate();
			
		}

		public int Find(int side, int position) // помечаем список
		{
			if (pole_value.Item1 != null && pole_value.Item1 != string.Empty)
			{
				int position_find = position;
				if (side == -1)
					if (position_find == 0) return position_find;
					else position_find--;
				else
				{
					if (position_find == list.Count - 1) return position_find;
					else position_find++;
				}
				if (pole_value.Item1 == "Имя")
				{

					if (side == 1)
						return list.FindIndex(position_find, x => x.name.ToLower().Contains(pole_value.Item2.ToLower()));
					else
						return list.FindLastIndex(position_find, x => x.name.ToLower().Contains(pole_value.Item2.ToLower()));

				}

				if (pole_value.Item1 == "Фамилия")
				{
					if (side == 1)
						return list.FindIndex(position_find, x => x.surname.ToLower().Contains(pole_value.Item2.ToLower()));
					else
						return list.FindLastIndex(position_find, x => x.surname.ToLower().Contains(pole_value.Item2.ToLower()));

				}

				if (pole_value.Item1 == "Факультет")
				{
					if (side == 1)
						return list.FindIndex(position_find, x => x.fack.ToLower().Contains(pole_value.Item2.ToLower()));
					else
						return list.FindLastIndex(position_find, x => x.fack.ToLower().Contains(pole_value.Item2.ToLower()));
				}
			}
			else
			{
				if (side == 1)
					return position + 1;
				else
					return position - 1;
				
			}

			return -1;
		}
		private void btnFind_Click(object sender, EventArgs e)
		{
			//sort.Clear();
			pole_value.Item1 = myComboBox.SelectedItem.ToString(); // выбираем имя, фамилию или факультет студента по которым осуществляем поиск 
			pole_value.Item2 = myTextBox.Text.Trim();               // значение по которому ищем

			if (Find(1, -1) == -1)
			{
				MessageBox.Show("что-то пошло не так");
				myTextBox.Text = "";
                pole_value.Item2 = string.Empty;
			}
			else
			{
				position = Find(1, -1);
				checkupdate();
			}
		}

        private void TextChangeName(object sender, EventArgs e)
        {
			if (tbName.Text != string.Empty)
				addStrip.Enabled = true;
			if (list.Count() == 0) return;
			if (tbName.Text != list[position].name)
				checker = true;
			list[position].name = tbName.Text;
        }

		private void TextChangeSurname(object sender, EventArgs e)
		{
            if (tbSurname.Text != string.Empty)
                addStrip.Enabled = true;
            if (list.Count() == 0) return;
            if (tbSurname.Text != list[position].surname)
                checker = true;
            list[position].surname = tbSurname.Text;
		}

		private void TextChangeFack(object sender, EventArgs e)
		{
            if (tbFack.Text != string.Empty)
                addStrip.Enabled = true;
            if (list.Count() == 0) return;
            if (tbFack.Text != list[position].fack)
                checker = true;
            list[position].fack = tbFack.Text;
		}

		private void StudentForm_Load(object sender, EventArgs e)
		{
		}
	}

	[Serializable]
	public class Student
	{
		public string name;
		public string surname;
		public string fack;
		public Student()
		{

		}
		public Student(string name, string surname, string fack)
		{
			this.name = name;
			this.surname = surname;
			this.fack = fack;

		}
	}
}

