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
			checker = true;

		}
		public int Count()
		{
			int num = 0;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].correct)
				{
					num++;
				}
			}
			return num;
		}

		private void openListStrip_Click(object sender, EventArgs e)
		{
			if (needUpdate() == true)
				return;
			openFileDialog.InitialDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				fileName = new DirectoryInfo(openFileDialog.FileName).Name;
				XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));
				using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
				{
					list = (List<Student>)formatter.Deserialize(fs);
				}

				checkupdate();
				tbName.Text = list[position].name;
				tbSurname.Text = list[position].surname;
				tbFack.Text = list[position].fack;
				checkupdate();
				checker = false;
			}


		}
		private void checkupdate() //вынесли все обновление в отдельный метод 
		{
			int col = 0;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].correct == false)
					col++;

			}
            if (list.Count() != 0)
            {
                btnForNext.Enabled = true;
                safeListStrip.Enabled = true;
                nextStripMenu.Enabled = true;
                addStrip.Enabled = true;
                delStrip.Enabled = true;
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
                btnForNext.Enabled    = false;
                nextStripMenu.Enabled = false;
                delStrip.Enabled      = false;
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

			tbName.Enabled = true;
			btnFind.Enabled = true;
			myTextBox.Enabled = true;
			tbSurname.Enabled = true;
			tbFack.Enabled = true;
		}



		public void Next()
		{
			position = Find(1, position);
		}
		public void Prev()
		{
			position = Find(-1, position);
		}
		public bool IsFirst()
		{
            if (position == 0) return true;
			return Find(-1, position) == -1? true : false;
		}

		public bool IsLast()
		{
            if (position == list.Count() - 1) return true;
			return Find(1, position) == -1 ? true : false;


		}


		private void saveForm()
		{

            saveFileDialog.FileName = fileName == string.Empty || fileName == null? saveFileDialog.FileName:fileName;
			if (fileName == string.Empty || fileName == null)
			{
				if (saveFileDialog.ShowDialog() == DialogResult.Cancel)

					return;
			}
            Save_File();
		}

		private void saveFast_Click(object sender, EventArgs e)
		{
            Save_File();
		}
		private void Save_File()
        {
            DirectoryInfo info = new DirectoryInfo(saveFileDialog.FileName);
            XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }

            MessageBox.Show(string.Format("Файл {0} сохранен", info.Name));
            checker = false;
        }
		private bool needUpdate()
		{
			if (checker == true && position != -1)
			{
				var result = SavingList();

				if (result == DialogResult.Yes)
				{
					saveForm();
				}
				if (result == DialogResult.Cancel)
				{
					return true;
				}
			}
			return false;
		}
		private void safeListStrip_Click(object sender, EventArgs e)
		{

			saveForm();

		}

		private void btnForPrev_Click(object sender, EventArgs e)
		{

			if ((tbName.Text == "" || tbSurname.Text == "" || tbFack.Text == "") && list.Count != 0)
			{
				MessageBox.Show("Вы ввели не все данные");
			}
			else
			{
				//position--;
				Prev();
				checkupdate();

				if (list[position].correct == true)
				{
					tbName.Text = list[position].name;
					tbSurname.Text = list[position].surname;
					tbFack.Text = list[position].fack;
				}

				//btnForNext.Enabled = true;
				//nextStripMenu.Enabled = true;
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
			checker = true;
		}
		private void delStrip_Click(object sender, EventArgs e)
		{
			list.RemoveAt(position);
			if (position != 0)
			{
				position--;
			}
			checkupdate();
			checker = true;
		}
		private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			//if (needUpdate() == true)
			//	return;

			if (checker == false) return;
            else
			{
                DialogResult result = SavingList();
                	if (result == DialogResult.Cancel)
                    	e.Cancel = true;
                	else if (result == DialogResult.Yes)
                    	saveForm();
            }
		}
		private DialogResult SavingList()
		{
			return MessageBox.Show("Сохранить изменения?", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
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
			list[position].name = tbName.Text;
			checker = true;
		}

		private void TextChangeSurname(object sender, EventArgs e)
		{
			list[position].surname = tbSurname.Text;
			checker = true;
		}

		private void TextChangeFack(object sender, EventArgs e)
		{
			list[position].fack = tbFack.Text;
			checker = true;
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
		public bool correct = true;

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

