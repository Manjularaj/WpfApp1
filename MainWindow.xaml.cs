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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // Output
            // Label .Content
            lblPlusMinus.Content = "+";


            // Inputs
            // Textbox .Text
            string value1 = txtAddSubtractVal1.Text;
            string value2 = txtsubtractval2.Text;

           
            double valNum1, valNum2 = 0;

            bool valNum1IsANumber = double.TryParse(value1, out valNum1);
            bool valNum2IsANumber = double.TryParse(value2, out valNum2);

            //// convert into
            //int valNum1 = int.Parse(value1);
            //int valNum2 = int.Parse(value2);


            // add two to get total
            double valnum3 = valNum1 + valNum2;

            if(valNum1IsANumber && valNum2IsANumber)
            {
                double btnAdd = valNum1 + valNum2;
                txttotal.Text = (valNum1 + valNum2).ToString();
            }
            else
            {

                MessageBox.Show("Please enter the valid number");
            }


            //string value3 = txttotal.Text;

            
            
            
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            // Output
            // Label .Content
            lblPlusMinus.Content = "-";

            // Inputs
            // Textbox .Text
            string value1 = txtAddSubtractVal1.Text;
            string value2 = txtsubtractval2.Text;

            double valNum4, valNum5 = 0;

            // convert into
            bool valNum4IsANumber = double.TryParse(value1, out valNum4);
            bool valNum5IsANumber = double.TryParse(value2, out valNum5);


            // add two to get total
            double valnum6 = valNum4 - valNum5;
            

            if(valNum4IsANumber && valNum5IsANumber)
            {
                double btnSub = valNum4 - valNum5;
                txttotal.Text = (valNum4 - valNum5).ToString();

            }
            else
            {

                MessageBox.Show("Please enter the valid number");
            }
            


        }

        private void btnmulti_Click(object sender, RoutedEventArgs e)
        {
            // Output
            // Label .Content
            lbldivmulti.Content = "*";


            // Inputs
            // Textbox .Text
            string value11 = txtmultidivVal11.Text;
            string value12 = txtmultidivVal12.Text;

            // Logic

            // convert into
            int valNum11 = int.Parse(value11);
            int valNum12 = int.Parse(value12);


            // add two to get total
            int valnum13 = valNum11 * valNum12;



            //string value13 = txttotal.Text;

            txtdivmultotal.Text = valnum13.ToString();
        }

        private void btndivide_Click(object sender, RoutedEventArgs e)
        {
            // Output
            // Label .Content
            lbldivmulti.Content = "/";


            // Inputs
            // Textbox .Text
            string value11 = txtmultidivVal11.Text;
            string value12 = txtmultidivVal12.Text;

            // Logic

            // convert into
            int valNum11 = int.Parse(value11);
            int valNum12 = int.Parse(value12);


            // add two to get total
            int valnum14 = valNum11 / valNum12;



            //string value14 = txttotal.Text;

            txtdivmultotal.Text = valnum14.ToString();
        }

       
        private void btnAve_Click(object sender, RoutedEventArgs e)
        {
                // Output

                // Inputs
                // Textbox .Text
                string valueA1 = txttotal.Text;
                string valueA2 = txtdivmultotal.Text;

                //// convert into
                //int valNumA1 = int.Parse(valueA1);
                //int valNumA2 = int.Parse(valueA2);


                double valNumA1, valNumA2 = 0;

                // convert into
                bool valNumA1IsANumber = double.TryParse(valueA1, out valNumA1);
                bool valNumA2IsANumber = double.TryParse(valueA2, out valNumA2);



                // add two to get Average Result
                double valnumRslt = valNumA1 + valNumA2 / 2;


                //string value14 = txtaverage.Text;

                txtaverage.Text = valnumRslt.ToString();
            
        }
    }
}
