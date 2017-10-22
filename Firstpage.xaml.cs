using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
using System.Windows;
using Windows.ApplicationModel.DataTransfer;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Firstpage : Page
    {
        
        
        List<Credentials> l = new List<Credentials>();
        public Firstpage()
        {
            this.InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string t = "";
            int z = 0;
            try
            {
                string s = textBox.Text;
                int.TryParse(s, out z);
            }
            catch (Exception ax) { textBlock3.Text = ax.Message.ToString(); }


            if (z <= 0) { textBlock3.Text = "Enter passsword length\n(numbers between 1 to 100)"; }
            else
            {

                if (checkBox.IsChecked == true && checkBox1.IsChecked == true && checkBox2.IsChecked == true && checkBox3.IsChecked == true) { t = generatePW(65, 91) + generatePW(97, 123) + generatePW(48, 58) + generatePW(32, 48); }
                else if (checkBox1.IsChecked == true && checkBox2.IsChecked == true && checkBox3.IsChecked == true) { t = generatePW(97, 123) + generatePW(48, 58) + generatePW(32, 48); }
                else if (checkBox.IsChecked == true && checkBox2.IsChecked == true && checkBox3.IsChecked == true) { t = generatePW(65, 91) + generatePW(48, 58) + generatePW(32, 48); }
                else if (checkBox.IsChecked == true && checkBox1.IsChecked == true && checkBox3.IsChecked == true) { t = generatePW(65, 91) + generatePW(97, 123) + generatePW(32, 48); }
                else if (checkBox.IsChecked == true && checkBox1.IsChecked == true && checkBox2.IsChecked == true) { t = generatePW(65, 91) + generatePW(97, 123) + generatePW(48, 58); }
                else if (checkBox2.IsChecked == true && checkBox3.IsChecked == true) { t = generatePW(48, 58) + generatePW(32, 48); }
                else if (checkBox1.IsChecked == true && checkBox3.IsChecked == true) { t = generatePW(97, 123) + generatePW(32, 48); }
                else if (checkBox1.IsChecked == true && checkBox2.IsChecked == true) { t = generatePW(97, 123) + generatePW(48, 58); }
                else if (checkBox.IsChecked == true && checkBox3.IsChecked == true) { t = generatePW(65, 91) + generatePW(32, 48); }
                else if (checkBox.IsChecked == true && checkBox2.IsChecked == true) { t = generatePW(65, 91) + generatePW(48, 58); }
                else if (checkBox.IsChecked == true && checkBox1.IsChecked == true) { t = generatePW(65, 91) + generatePW(97, 123); } //same result when n=even
                else if (checkBox3.IsChecked == true) { t = generatePW(32, 48); }
                else if (checkBox2.IsChecked == true) { t = generatePW(48, 58); }
                else if (checkBox1.IsChecked == true) { t = generatePW(97, 123); }
                else if (checkBox.IsChecked == true) { t = generatePW(65, 91); }
                else { textBlock3.Text = "Choose at least one option"; }




                //   generatePW(x,y);



                //  if (t.Length / z==2) { for (int i = 1; i < t.Length; i += 2) { v += t[i]; } t = v; }
                string pw = shuffleString(preparePW(z, t));
                textBox1.Text = pw;
                var dt = new DataPackage();
                dt.SetText(pw);
                Clipboard.SetContent(dt);

            }
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock1_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void CL(object sender, RoutedEventArgs e)
        {


        }
        private void SL(object sender, RoutedEventArgs e)
        {

        }

        private void Num(object sender, RoutedEventArgs e)
        {
        }

        private void Sym(object sender, RoutedEventArgs e)
        {

        }

        private void flo(object sender, object e)
        {

        }

        public string generatePW(int p, int q)
        {
            textBlock3.Text = "";
            Random r = new Random();
            string a = textBox.Text;
            int n;
            string s = "";
            int.TryParse(a, out n);

            for (int i = 0; i < n; i++)
            {
                char b = (char)r.Next(p, q);
                string c = b.ToString();

                s += c;

            }
            textBlock3.Text = "Password generated and copied to clipboard!";
            /*
            MessageDialog md = new MessageDialog("Password generated and copied to clipboard!");
            md.ShowAsync();*/
           // t = "";

            return s;
        }
        public string preparePW(int a, string s)
        {
            /*  if (a == 0) { return "Enter a non zero number"; }
             else*/
            if (s.Length == a) { return s; }
            else if (s.Length / a == 2)
            {
                char[] c = s.ToCharArray();
                char[] d = new char[s.Length / 2];
                int j = 0;
                for (int i = 1; i < c.Length; i += 2)
                {

                    d[j] = c[i];
                    j++;
                }
                string o = new string(d);
                return o;


            }
            else if (s.Length / a == 3)
            {
                char[] c = s.ToCharArray();
                char[] d = new char[s.Length / 3];
                int j = 0;
                for (int i = 1; i < c.Length; i += 3)
                {

                    d[j] = c[i];
                    j++;
                }
                string o = new string(d);
                return o;
            }
            else if (s.Length / a == 4)
            {
                char[] c = s.ToCharArray();
                char[] d = new char[s.Length / 4];
                int j = 0;
                for (int i = 1; i < c.Length; i += 4)
                {

                    d[j] = c[i];
                    j++;
                }
                string o = new string(d);
                return o;
            }
            else return s;

        }
        public string shuffleString(string a)
        {

            /*  char[] c = a.ToCharArray();
              char[] d = new char[c.Length];

              d = c;
              d[0] = c[c.Length - 1];
              d[c.Length - 1] = c[c.Length / 2];
              d[c.Length / 2] = c[0];
              string s = new string(d);

              return s;*/

            //the 4 lines below are not my code
            Random num = new Random();
            string rand = new string(a.
                OrderBy(s => (num.Next(2) % 2) == 0).ToArray());
            return rand;

        }

        private void B1C(object sender, RoutedEventArgs e)
        {
            /*   string a = textBox2.Text;
               string b = textBox1.Text;
               string c = textBox3.Text;
               l.Add(new Credentials(a,b,c));
             //  textBox.Text = l[0].getUsername(); //return the username of the site*/
            textBlock3.Text = "Coming soon!";

        }

        

    }
}
