using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Microsoft.VisualBasic.ApplicationServices;




namespace Lab1Bank
{
    public partial class Form1 : Form
    {
       
       public static List<FOP> fopList = new List<FOP>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            fopList.Add(new FOP("Гришко І.С", "16.03.1994", "+380506687708", 1, 2, "Акторська діяльність"));
            fopList.Add(new FOP("Стрижак Г.П", "02.01.2002", "+380933430501", 2, 1, "Сервісні послуги"));
            fopList.Add(new FOP("Шевченко О.М", "29.11.1971", "+380674315781", 3, 4, "Будівельні роботи"));
            fopList.Add(new FOP("Шпак М.М", "11.08.1981", "+380634445154", 4, 2, "IT"));

            DataTable table = new DataTable();
            table.Columns.Add("ПІБ", typeof(string));
            table.Columns.Add("Дата нар.", typeof(string));
            table.Columns.Add("Ном. тел", typeof(string));
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Група ФОП", typeof(int));
            table.Columns.Add("Вид діяльності", typeof(string));

            for (int i = 0; i < fopList.Count; i++)
            {
                table.Rows.Add(fopList[i].name, fopList[i].date_of_birth, fopList[i].phone_num,
                               fopList[i].bank_id, fopList[i].fop_group, fopList[i].cereer);
            }
            dataGridView1.DataSource = table;


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            InfoForm infoform = new InfoForm();
            infoform.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addform = new AddForm();
            if (addform.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(fopList[fopList.Count - 1].name, fopList[fopList.Count - 1].date_of_birth, fopList[fopList.Count - 1].phone_num, fopList[fopList.Count - 1].bank_id,
                                      fopList[fopList.Count - 1].fop_group, fopList[fopList.Count - 1].cereer);
            }
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
        public void SerializeResult() { }

        private void SerrialiseButton_Click(object sender, EventArgs e)
        {
            Helper.WritingToFile(fopList);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            List<FOP> addingList = Helper.ReadFromFile();
            for (i = 0; i < addingList.Count; i++)
            {
                fopList.Add(addingList[i]);
                dataGridView1.Rows.Add(addingList.Count, addingList[i].name, addingList[i].date_of_birth, addingList[i].phone_num,
                    addingList[i].bank_id, addingList[i].fop_group, addingList[i].cereer);
            }
        }
    }
    public class FOP
    {
        public string name;
        public string date_of_birth;
        public string phone_num;
        public int bank_id;
        public int fop_group;
        public string cereer;
        public FOP(string _name, string _date_of_birth, string _phone_num, int _bank_id, int _fop_group, string _cereer)
        {
            name = _name;
            date_of_birth = _date_of_birth;
            phone_num = _phone_num;
            bank_id = _bank_id;
            fop_group = _fop_group;
            cereer = _cereer;
        }
    }

    public class Sorting
    {
        public static List<FOP> SortId(int min_Id)
        {
            List<FOP> sort = new List<FOP>();
            IEnumerable sortList1 = from res in Form1.fopList
                                    where res.bank_id >= min_Id
                                    select res;

            foreach (FOP res in sortList1)
                sort.Add(res);
            string list = "";
            for (int i = 0; i < sort.Count; i++)
            {
                list += JsonConvert.SerializeObject(sort[i]);

            }
            MessageBox.Show(list);
            return sort;
        }

        public static List<FOP> SortOnName(string sortedName)
        {
            List<FOP> sort = new List<FOP>();
            var sortedList2 = sort.OrderByDescending(x => x.name).ToList();
            foreach (var sorted in sortedList2)
                sort.Add(sorted);
            string sortedlist = "";
            for (int i = 0; i < sort.Count; i++)
            {
                sortedlist += JsonConvert.SerializeObject(sort[i]);

            }
            MessageBox.Show(sortedlist);
            return sort;
        }

        public static List<FOP> SortOnPhoneNum(string sortedName)
        {
            List<FOP> sort = new List<FOP>();

            var sortedList3 = sort.OrderBy(x => x.fop_group)
                                  .OrderBy(x => x.phone_num)
                                  .ToList();

            foreach (var sorted in sortedList3) sort.Add(sorted);
            string sortlist = "";
            for (int i = 0; i < sort.Count; i++)
            {
                sortlist += JsonConvert.SerializeObject(sort[i]);

            }
            MessageBox.Show(sortlist);
            return sort;
        }
    }

    class Helper : Form1
    {
        public static void WritingToFile(List<FOP> FOPList)
        {
            string buf;
            StreamWriter streamWriter = new StreamWriter("C:\\Users\\egorb\\source\\repos\\Lab1Bank\\LabOutPut.txt");
            for (int i = 0; i < FOPList.Count; i++)
            {
                buf = JsonConvert.SerializeObject(FOPList[i]);
                streamWriter.WriteLine(buf);
            }
            streamWriter.Close();
        }

        public static List<FOP> ReadFromFile()
        {
            List<FOP> list = JsonConvert.DeserializeObject<List<FOP>>(File.ReadAllText("C:\\Users\\egorb\\source\\repos\\Lab1Bank\\LabInPut.txt"));
            return list;
        }

    }
}