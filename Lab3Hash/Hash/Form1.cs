using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Hash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)// рассчет хэша для текста из файла
        {
            using (SHA256 sha256Hash = SHA256.Create())// создаем экземпляр SHA256
            {
                var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(File.ReadAllText("C:\\Code\\Hash.txt")));// рассчитываем хэш для текста из файла в формате UTF8
                var Hash = new StringBuilder();// StringBuilder используется для формирования хэша в одну строку (есть еще вариант построкового вывода в, например, ListBox, если через .Item.Add)
                for (int i = 0; i < bytes.Length; i++)// собственно, сама запись хэша в строку
                {
                    Hash.Append(bytes[i].ToString("x2"));// x2 - спецификатор точности
                }
                HashBox.Text = Hash.ToString();// вывод полученной строки в текстовое окно HashBox
            }
        }

        private void button2_Click(object sender, EventArgs e)// рассчет псевдослучайных последовательностей
        {
            RandBox.Items.Clear();
            using (SHA256 sha256Hash = SHA256.Create())// создаем экземпляр SHA256
            {
                for (ulong i = ulong.Parse(Seed.Text); i < ulong.Parse(Seed.Text) + ulong.Parse(RandNum.Text); i++)// из Seed.Text берется сид - начальное значение параметра i, из RandNum.Text - количество случайных последовательностей
                {
                    var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(i.ToString()));// рассчитываем хэш для i в формате UTF8
                    RandBox.Items.Add(BitConverter.ToUInt64(bytes.Take(8).ToArray(), 0).ToString("x8"));// Вывод в ListBox RandBox с спецификатором точности x8
                }
            }
        }
    }
}
