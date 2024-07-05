﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
using QRCoder;

namespace BarcodeWPF
{
    /// <summary>
    /// Interaction logic for TextToQR.xaml
    /// </summary>
    public partial class TextToQR : Page
    {
        public TextToQR()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (BarText.Text != "")
                {
                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(BarText.Text, QRCodeGenerator.ECCLevel.Q);
                    QRCode qrCode = new QRCode(qrCodeData);
                    Bitmap qrCodeImage = qrCode.GetGraphic(20);
                    byte[] bytes = (byte[])(new ImageConverter()).ConvertTo(qrCodeImage, typeof(byte[]));
                    BitmapImage bitmapImage = ConvertByteArrayToBitMapImage(bytes);
                    BarImage.Source = bitmapImage;
                }
            }
            catch
            {

            }
        }

        public BitmapImage ConvertByteArrayToBitMapImage(byte[] imageByteArray)
        {
            BitmapImage img = new BitmapImage();
            using (MemoryStream memStream = new MemoryStream(imageByteArray))
            {
                img.BeginInit();
                img.CacheOption = BitmapCacheOption.OnLoad;
                img.StreamSource = memStream;
                img.EndInit();
                img.Freeze();
            }
            return img;
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            /*if (imageIn != null)
            {
                using (var ms = new MemoryStream())
                {
                    imageIn.Save(ms, imageIn.RawFormat);
                    return ms.ToArray();
                }
            }
            return null;*/
            ImageConverter imgCon = new ImageConverter();
            return (byte[])imgCon.ConvertTo(imageIn, typeof(byte[]));
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = GetMainWindow();
            mainWindow.Main.Content = new TextToBarcode();
        }

        public static MainWindow GetMainWindow()
        {
            MainWindow mainWindow = null;

            foreach (Window window in Application.Current.Windows)
            {
                Type type = typeof(MainWindow);
                if (window != null && window.DependencyObjectType.Name == type.Name)
                {
                    mainWindow = (MainWindow)window;
                    if (mainWindow != null)
                    {
                        break;
                    }
                }
            }


            return mainWindow;

        }
    }
}
