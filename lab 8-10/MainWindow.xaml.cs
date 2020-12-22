using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace lab_8_10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bool isValidEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        bool isValidEmailRu(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+ru";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        bool isValidD(string num)
        {
            string pattern = @"^[-+]?[0-9]*[./^,]?[0-9]+(?:[eE][-+]?[0-9]+)?$";
            Match isMatch = Regex.Match(num, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        bool isValidV(string num)
        {
            string pattern = "[0-9],[0-9]{2}";
            Match isMatch = Regex.Match(num, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        bool isValidV2(string num)
        {
            string pattern = "[0-9]+[.,/]{1}[0-9]";
            Match isMatch = Regex.Match(num, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }
        bool isValidC(string num)
        {
            string pattern = "[0-9]+[+,-]+[0-9]+i";
            Match isMatch = Regex.Match(num, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        bool isValidPassport(string num)
        {
            string pattern = @"[0-9]{2}\s[0-9]{2}\s[0-9]{6}";
            Match isMatch = Regex.Match(num, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        bool isValidFIO(string num)
        {
            string pattern = @"[А-Яа-яЁё]+\s[А-Яа-яЁё]+\s[А-Яа-яЁё]+";
            Match isMatch = Regex.Match(num, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        bool isValidSnils(string num)
        {
            string pattern = @"[0-9]{3}-[0-9]{3}-[0-9]{3}\s[0-9]{2}";
            Match isMatch = Regex.Match(num, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        bool isValidHtml(string num)
        {
            string pattern = @"<[A-Za-z][0-9]?>";
            Match isMatch = Regex.Match(num, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        bool isValidURL(string num)
        {
            string pattern = @"(https?:\/\/|ftps?:\/\/|www\.)((?![.,?!;:()]*(\s|$))[^\s]){2,}";
            Match isMatch = Regex.Match(num, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        bool isValidTel(string num)
        {
            string pattern = @"^((8|\+7)[\- ]?)+(\(?\d{3}\)?[\- ]?)+[\d\- ]{7,10}$";
            Match isMatch = Regex.Match(num, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        bool isValidData(string num)
        {
            string pattern = @"^(0?[1-9]|[12][0-9]|3[01])[\/\-.](0?[1-9]|1[012])[\/\-.]\d{4}$";
            Match isMatch = Regex.Match(num, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        bool isValidTime(string num)
        {
            string pattern = @"^([0-1]?[0-9]|[0-2][0-3]):[0-5][0-9]";
            Match isMatch = Regex.Match(num, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        bool isValidRaz(string num)
        {
            string pattern = @"([0-9]{1}([^.,][\s]?))+";
            Match isMatch = Regex.Match(num, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }
        private void B1(object sender, RoutedEventArgs e)
        {
            string d = Convert.ToString(T1.Text);
            if (isValidD(d)) { MessageBox.Show("Верно"); }
            else { MessageBox.Show("Число не действительное "); }

        }
        private void B2(object sender, RoutedEventArgs e)
        {
            string num = Convert.ToString(T2.Text);
            if (isValidV(num)) { MessageBox.Show("Верно"); }
            else { MessageBox.Show("Число не верно "); }
        }
        private void B3(object sender, RoutedEventArgs e)
        {
            string num = Convert.ToString(T3.Text);
            if (isValidV2(num)) { MessageBox.Show("Верно"); }
            else { MessageBox.Show("Число целое (ошибка)"); }
        }
        private void B4(object sender, RoutedEventArgs e)
        {
            string num = Convert.ToString(T4.Text);
            if (isValidC(num)) { MessageBox.Show("Верно"); }
            else { MessageBox.Show("Число не комплексное"); }
        }
        private void B5(object sender, RoutedEventArgs e)
        {
            string p = Convert.ToString(T5.Text);
            if (isValidPassport(p)) { MessageBox.Show("Верно"); }
            else { MessageBox.Show("Цифры не относятся к серии или номеру паспорта"); }
        }
        private void B6(object sender, RoutedEventArgs e)
        {
            string sn = Convert.ToString(T6.Text);
            if (isValidSnils(sn)) { MessageBox.Show("Верно"); }
            else { MessageBox.Show("Цифры не относятся к номеру снилс"); }
        }
        private void B7(object sender, RoutedEventArgs e)
        {
            string h = Convert.ToString(T7.Text);
            if (isValidHtml(h)) { MessageBox.Show("Верно"); }
            else { MessageBox.Show("Это не html контейнер"); }
        }
        private void B8(object sender, RoutedEventArgs e)
        {
            string u = Convert.ToString(T8.Text);
            if (isValidURL(u)) { MessageBox.Show("Верно"); }
            else { MessageBox.Show("Не URL"); }
        }
        private void B9(object sender, RoutedEventArgs e)
        {
            string fio = Convert.ToString(T9.Text);
            if (isValidFIO(fio)) { MessageBox.Show("Верно"); }
            else { MessageBox.Show("Вы ввели не ФИО"); }
        }
        private void B10(object sender, RoutedEventArgs e)
        {
            string tel = Convert.ToString(T10.Text);
            if (isValidTel(tel)) { MessageBox.Show("Верно"); }
            else { MessageBox.Show("Не правильно набран номер"); }
        }
        private void B11(object sender, RoutedEventArgs e)
        {
            string email = Convert.ToString(T11.Text);
            if (isValidEmail(email)) { MessageBox.Show("Верно"); }
            else { MessageBox.Show("Не является адресом почты"); }
        }
        private void B12(object sender, RoutedEventArgs e)
        {
            string emailru = Convert.ToString(T12.Text);
            if (isValidEmailRu(emailru)) { MessageBox.Show("Верно"); }
            else { MessageBox.Show("Не правильно введен домен рф или не верна почта"); }
        }
        private void B13(object sender, RoutedEventArgs e)
        {
            string data = Convert.ToString(T13.Text);
            if (isValidData(data)) { MessageBox.Show("Верно"); }
            else { MessageBox.Show("Некоректная дата"); }
        }
        private void B14(object sender, RoutedEventArgs e)
        {
            string time = Convert.ToString(T14.Text);
            if (isValidTime(time)) { MessageBox.Show("Верно"); }
            else { MessageBox.Show("Некоректное время"); }
        }
        private void B15(object sender, RoutedEventArgs e)
        {
            string  r = Convert.ToString(T15.Text);
            if (isValidRaz(r)) { MessageBox.Show("Верно"); }
            else { MessageBox.Show("Не целое число с разрядом"); }
        }

        private void B16(object sender, RoutedEventArgs e)
        {
            string text = Convert.ToString(T16.Text);
            var result = Regex.Replace(text, @"(\b\w+\b)(\s\1)+", "$1");
            T17.Text = result;
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            T1.Clear();
            T2.Clear();
            T3.Clear();
            T4.Clear();
            T5.Clear();
            T6.Clear();
            T7.Clear();
            T8.Clear();
            T9.Clear();
            T10.Clear();
            T11.Clear();
            T12.Clear();
            T13.Clear();
            T14.Clear();
            T15.Clear();
            T16.Clear();
            T17.Clear();



        }

        private void Clouse(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void T10_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void T4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void T5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
