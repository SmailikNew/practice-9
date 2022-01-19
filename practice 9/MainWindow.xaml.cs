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

namespace practice_9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hardware[] hardware = new Hardware[5];

        public MainWindow()
        {
            InitializeComponent();

            
            hardware[0] = new Hardware("Intel Core I5 3370k", 8, "Western Digital", "Nvidia Gforce 3080 TI");
            hardware[1] = new Hardware("Intel Core I3 10100k", 32, "Hyper X Cloud Fury", "Asus Gforce 1060 super");
            hardware[2] = new Hardware("Ryzen 3600", 8, "Dexp DL870", "AMD Radeon RX 6800");
            hardware[3] = new Hardware("Intel Xeon Silver 4316", 16, "Roadime", "NVIDIA TITAN Xp");
            hardware[4] = new Hardware("AMD EPYC 7413", 4, "Samsung", "AMD Radeon RX 580");

            for (int i = 0; i < 5; i++)
            {
                list1.Items.Add($"{hardware[i].ProcessorType} | {hardware[i].Memory} | {hardware[i].HDD} | {hardware[i].GPU}");
            }

        }

        private void info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-34, Горшков Илья, Вариант 2. Заполнить таблицу с аппаратными средствами на 5 компьютеров с полями: тип" +
                    "процессор, память, HDD, видео. Вывести результат на экран. Вывести средний" +
                    "объем памяти.");
        }

        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void calculate(object sender, RoutedEventArgs e)
        {
            int average = 0;
            for (int i = 0; i < 5; i++)
            {
                average += hardware[i].Memory;
            }
            MessageBox.Show($"Средний объем памяти на компах - {average / 5} гб.", "Объем памяти", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
