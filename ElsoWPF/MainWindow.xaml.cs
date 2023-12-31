﻿using System;
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

namespace ElsoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Random rnd;

        public MainWindow()
        {
            InitializeComponent();
            rnd = new Random();
            tbxNev.Width = tbxNev.Width * 4;
            tbxNev.Height = tbxNev.Height * 3;
            tbxNev.FontSize = 16;
            tbxNev.FontWeight = FontWeights.Bold;

        }


        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            tbxNev.Text = "Üdvözlöm " + tbxNev.Text + "!";
        }

        private void btnMegse_Click(object sender, RoutedEventArgs e)
        {
            tbxNev.Text = "Adja meg a nevét";
        }

        private void btnSzinez_Click(object sender, RoutedEventArgs e)
        {
            byte[] rgb = GetRandomBytes(3);

            SolidColorBrush scbSzinez = new SolidColorBrush(Color.FromArgb(255, rgb[0], rgb[1], rgb[2]));
            tbxNev.Foreground = scbSzinez;

            rgb = GetRandomBytes(3);
            SolidColorBrush scbSzinez2 = new SolidColorBrush(Color.FromArgb(255, rgb[0], rgb[1], rgb[2]));
            tbxNev.Background = scbSzinez2;
        }


        private byte[] GetRandomBytes(int n)
        {
            byte[] randomBytes = new byte[n];
            rnd.NextBytes(randomBytes);

            return randomBytes;
        }
    }
}
