using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace çalışmalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //İç içe switch kullanarak kullanıcı adını ve şifresini kontrol ediniz.eğer kullanıcı kullanıcıadını ve şifresini doğru girerse "Tebrikler, hem kullanıcı adı hemde şifreniz doğru" uyarısı
            //Kullanıcı adı doğru şifre yanlışsa "Kullanıcı adınız doğru ancak şifreniz yanlış!" uyarısı
            //kullanıcı adı yanlışsa "Kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile!" uyarusını kullanıcıya veriniz.

            //KullaniciAdi = "bilgeadam";
            //Sifre = "1234";

            string metin = txtgiris1.Text.ToLower();
            int sayi = int.Parse(txtgiris2.Text);

            switch (metin)
            {
                case "bilgeadam":
                    switch(sayi)
                    {
                        case 1234:
                            MessageBox.Show("kullanıcı adı ve şifre doğru");
                            break;
                        default:
                            MessageBox.Show("kullanıcı adı doğru ancak şifreniz hatalı");
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("kullanıcı adınız hatalıdır");
                    break;
            }

        }
    }
}
