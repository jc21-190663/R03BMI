using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A19 佐藤将";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var height = heighit.Text;
            var weight = weighit.Text;

            try
            {
                double h = Double.Parse(height);
                double w = Double.Parse(weight);

                //BMI計算
                double bmi = w / ((h / 100) * (h / 100));

                //BMIを四捨五入
                double bmi2 = Math.Round(bmi, 1, MidpointRounding.AwayFromZero);

                /*//BMIのランク付け
                String rank = null;*/

                if (bmi >= 30.0)
                {
                    result.Text = "あなたのBMIは"+bmi2+"で、高肥満です。";
                }
                else if (bmi >= 25.0)
                {
                    result.Text = "あなたのBMIは" + bmi2 + "で、肥満です。";
                }
                else if (bmi >= 18.5)
                {
                    result.Text = "あなたのBMIは" + bmi2 + "で、標準です。";
                }
                else
                {
                    result.Text = "あなたのBMIは" + bmi2 + "で、やせです。";
                }

                /* String rank = rank; */

                /*肥満度の計算
                double dev = ((bmi - 22) / 22) * 100;*/
            }
            catch(FormatException ex) 
            {
                Console.WriteLine(ex);
                result.Text = "!!!!!";
            }
        }
    }
}
