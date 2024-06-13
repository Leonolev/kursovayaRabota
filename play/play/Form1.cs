using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace play
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double first_kuchka; // Создание переменной для работы с количеством фишек из кучки
        bool vkl = false; // Создание переменной для блокировки и разблокировки кнопок выбора первого хода
        bool vikl = false; // Создание переменной для блокировки и разблокировки кнопок выбора первого хода

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
         
        // Генерация фишек в кучке от 10 до 50 и блокировка и разблокировка кнопок взятия фишек и выбора первого хода
        private void button7_Click(object sender, EventArgs e)
        {
            vikl = false;
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            Random rand = new Random();
            first_kuchka = rand.Next(10, 51);
            listBox2.Items.Add(first_kuchka.ToString());
            if (vikl == true)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            vkl = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            first_kuchka -= 1; // Взятие из кучки одной фишки
            if (first_kuchka == 1 || first_kuchka == 2 || first_kuchka == 3) // Определение победителя в игре на основе количества фишек в кучке
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("0");
                MessageBox.Show("Выиграл компьютер", "Результат");
            }
            else if (first_kuchka == 0)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("0");
                MessageBox.Show("Выиграл игрок", "Результат");
            }
            double res = Comp(first_kuchka); // Запись в новую переменную количества фишек, взятые компьютером
            double first_kuchka_save = first_kuchka; // Сохранение информации о количестве фишек в кучке до взятия компьютером
            first_kuchka = res; // Присваивание информации о количестве фишек после взятия компьютером
            double giveComp = first_kuchka_save - res; // Определение того, сколько фишек взял компьютер
            listBox1.Items.Clear();
            listBox1.Items.Add(giveComp.ToString()); // Запись в listBox информации о том, сколько фишек взял компьютер
            listBox2.Items.Clear();
            listBox2.Items.Add(res.ToString()); // Запись в listBox информации о том, сколько фишек осталось в кучке
            // Блокировка определённых кнопок взятия фишек для более удобной работы 
            if (first_kuchka == 0)
                listBox2.Items.Clear();
            if (first_kuchka < 1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            if (first_kuchka == 1)
                button2.Enabled = false;
            if (first_kuchka == 2)
                button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            first_kuchka -= 2; // Взятие из кучки двух фишек
            if (first_kuchka == 1 || first_kuchka == 2 || first_kuchka == 3) // Определение победителя в игре на основе количества фишек в кучке
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("0");
                MessageBox.Show("Выиграл компьютер", "Результат");
            }
            else if (first_kuchka == 0)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("0");
                MessageBox.Show("Выиграл игрок", "Результат");
            }
            double res = Comp(first_kuchka); // Запись в новую переменную количества фишек, взятые компьютером
            double first_kuchka_save = first_kuchka; // Сохранение информации о количестве фишек в кучке до взятия компьютером
            first_kuchka = res; // Присваивание информации о количестве фишек после взятия компьютером
            double giveComp = first_kuchka_save - res; // Определение того, сколько фишек взял компьютер
            listBox1.Items.Clear();
            listBox1.Items.Add(giveComp.ToString()); // Запись в listBox информации о том, сколько фишек взял компьютер
            listBox2.Items.Clear();
            listBox2.Items.Add(res.ToString()); // Запись в listBox информации о том, сколько фишек осталось в кучке
            // Блокировка определённых кнопок взятия фишек для более удобной работы 
            if (first_kuchka == 0)
                listBox2.Items.Clear();
            if (first_kuchka < 2)
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            if (first_kuchka < 1)
                button1.Enabled = false;
            if (first_kuchka == 2)
                button3.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            first_kuchka -= 3; // Взятие из кучки трёх фишек
            if (first_kuchka == 1 || first_kuchka == 2 || first_kuchka == 3) // Определение победителя в игре на основе количества фишек в кучке
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("0");
                MessageBox.Show("Выиграл компьютер", "Результат");
            }
            else if (first_kuchka == 0)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("0");
                MessageBox.Show("Выиграл игрок", "Результат");
            }
            double res = Comp(first_kuchka); // Запись в новую переменную количества фишек, взятые компьютером
            double first_kuchka_save = first_kuchka; // Сохранение информации о количестве фишек в кучке до взятия компьютером
            first_kuchka = res; // Присваивание информации о количестве фишек после взятия компьютером
            double giveComp = first_kuchka_save - res; // Определение того, сколько фишек взял компьютер
            listBox1.Items.Clear();
            listBox1.Items.Add(giveComp.ToString()); // Запись в listBox информации о том, сколько фишек взял компьютер
            listBox2.Items.Clear();
            listBox2.Items.Add(res.ToString()); // Запись в listBox информации о том, сколько фишек осталось в кучке
            // Блокировка определённых кнопок взятия фишек для более удобной работы 
            if (first_kuchka == 0)
                listBox2.Items.Clear();
            if (first_kuchka < 3)
                button3.Enabled = false;
            if (first_kuchka < 2)
                button2.Enabled = false;
            if (first_kuchka < 1)
                button1.Enabled = false;
        }
        // Ход компьютера
        private static double Comp(double first)
        {
            if (first > 0)
            {
                if (first == 1)
                    first -= 1;
                else if (first == 2)
                    first -= 2;
                else if (first == 3)
                    first -= 3;
                else  // Взятие случайного значения в диапазоне от 1 до 3 фишек из кучки 
                {
                    if (first % 3 == 0)
                        first -= 2;
                    else
                    {
                        Random rand = new Random();
                        first -= rand.Next(1, 4);
                    }
                }
            }
            
            return first; // Возвращение информации об оставшиемся количестве фишек в кучке
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        // Определение первого хода, первый ход игрока
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            if (vkl == true) //Разблокировка кнопок взятия фишек из кучки и блокировка кнопок определения первого хода
            {
                radioButton1.Enabled = false;
                radioButton1.Checked = false;
                radioButton2.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                vkl = false;
                vikl = true;
            }
        }

        // Определение первого хода, первый ход компьютера
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            if (vkl == true) //Разблокировка кнопок взятия фишек из кучки и блокировка кнопок определения первого хода
            {
                // Генерация и взятие из кучки определенного значения фишек от 1 до 3 компьютером
                double firstStep = 0;
                Random rand = new Random();
                firstStep = rand.Next(1, 4);
                first_kuchka = first_kuchka - firstStep;
                listBox1.Items.Clear();
                listBox1.Items.Add(firstStep.ToString()); // Запись в listBox информации о том, сколько фишек взял компьютер
                listBox2.Items.Clear();
                listBox2.Items.Add(first_kuchka.ToString()); // Запись в listBox информации о том, сколько фишек осталось в кучке
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton2.Checked = false;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                vkl = false;
                vikl = true;
            }
        }
    }
}
