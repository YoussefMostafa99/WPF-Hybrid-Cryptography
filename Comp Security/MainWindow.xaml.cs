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
using System.Security.Cryptography;
using System.IO;
using NETCore.Encrypt;
using NETCore.Encrypt.Internal;
using Microsoft.Win32;

namespace Comp_Security
{

    public partial class MainWindow : Window
    {

        
        public  MainWindow()
        {
            InitializeComponent();

        }

         
        
        private  string EncryptMessage()
        {
            aes aes1 = new aes();
            rsa rsa1 = new rsa();
            var encrypted = EncryptProvider.AESEncrypt(textBlock2.Text, (string)aes1.key, (string)aes1.iv);
            textBlock4.Text = aes1.key;
            textBlock7.Text = EncryptAESKey();
            textBlock6.Text = Hashed();
            textBlock5.Text = rsa1.privateKey;
            return encrypted;
        }
        private string EncryptAESKey()
        {
            aes aes1 = new aes();
            rsa rsa1 = new rsa();
            //var encrypted1 = EncryptProvider.RSAEncrypt((string)rsa1.publicKey, (string)aes1.key);
            var encrypted1 = EncryptProvider.RSAEncrypt((string)rsa1.publicKey, textBlock4.Text);

            return encrypted1;
        }
        
        private string Hashed()
        {
            rsa rsa1 = new rsa();
            var hashed = EncryptProvider.Sha256((string)rsa1.privateKey);
            return hashed;
        }

        private string DecryptAESKey()
        {
            rsa rsa1 = new rsa();
            var decrypted1 = EncryptProvider.RSADecrypt((string)rsa1.privateKey, EncryptAESKey());
            
            return decrypted1;
        }

        private string DecryptMessage()
        {
            //rsa rsa1 = new rsa();
            aes aes1 = new aes();
            //var decrypted = EncryptProvider.AESDecrypt(EncryptMessage(), (string)aes1.key, (string)aes1.iv);
            var decrypted = EncryptProvider.AESDecrypt(EncryptMessage(), textBlock4.Text, (string)aes1.iv);
            return decrypted;
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock2.Text.Length == 0)
            {
                MessageBox.Show("Please Select a Text File First.","Error!");
            }
            else if (radioButton1.IsChecked == true && textBlock2.Text == null || radioButton2.IsChecked == true && textBlock2.Text == null)
            {
                MessageBox.Show("Please Select a Text File First.", "Error!");
            }
            else if (textBlock2.Text.Length != 0 && radioButton1.IsChecked == false && radioButton2.IsChecked == false)
            {
                MessageBox.Show("Please Select Either 'Encrypt' or 'Decrypt' First.", "Error!");
            }
            else if(textBlock2.Text.Length != 0 && radioButton1.IsChecked == true)
            {
                
                textBlock1.Text = EncryptMessage(); 
            }
            else if (textBlock2.Text.Length != 0 && radioButton2.IsChecked == true)
            {
                
                textBlock3.Text = DecryptMessage();
            }
            
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void normalButton2_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == true) { 
                textBlock2.Text = File.ReadAllText(fileDialog.FileName);
            }


        }
    }
}
