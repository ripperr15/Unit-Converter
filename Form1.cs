namespace Unit_Converter
{
    public partial class Form1 : Form
    {
        double m, n;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt1.Select();
             cmb_convertfrom.Items.Clear();
            cmb_convertfrom.Items.Add("kilometer");
            cmb_convertfrom.Items.Add("meter");
            cmb_convertfrom.Items.Add("miles");
            cmb_convertto.Items.Clear();
            cmb_convertto.Items.Add("kilometer");
            cmb_convertto.Items.Add("meter");
            cmb_convertto.Items.Add("miles");


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt1.Select();
            cmb_convertfrom.Items.Clear();
            cmb_convertfrom.Items.Add("acre");
            cmb_convertfrom.Items.Add("hectare");
            cmb_convertfrom.Items.Add("squaremeter");
            cmb_convertto.Items.Clear();
            cmb_convertto.Items.Add("acre");
            cmb_convertto.Items.Add("squaremeter");
            cmb_convertto.Items.Add("hectare");

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt1.Select();
            cmb_convertfrom.Items.Clear();
            cmb_convertfrom.Items.Add("liter");
            cmb_convertfrom.Items.Add("milliliter");
            cmb_convertfrom.Items.Add("ounce");
            cmb_convertto.Items.Clear();
            cmb_convertto.Items.Add("liter");
            cmb_convertto.Items.Add("milliliter");
            cmb_convertto.Items.Add("ounce");
        }

        private void rESETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmb_convertfrom.ResetText ();
            cmb_convertto.ResetText ();
            txt1.Clear ();
            txt2.Clear ();

        }

        

        private void cmb_convertto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_convertfrom.Text == "kilometer" && cmb_convertto.Text == "kilometer")
            {
                n = double.Parse(txt1.Text);
                m = n;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "kilometer" && cmb_convertto.Text == "meter")
            {
                n = double.Parse(txt1.Text);
                m = n * 1000;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "kilometer" && cmb_convertto.Text == "miles")
            {
                n = double.Parse(txt1.Text);
                m = n * 0.621371;
                txt2.Text = Math.Round(m, 3).ToString();
            }

            if (cmb_convertfrom.Text == "meter" && cmb_convertto.Text == "meter")
            {
                n = double.Parse(txt1.Text);
                m = n;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "meter" && cmb_convertto.Text == "kilometer")
            {
                n = double.Parse(txt1.Text);
                m = n / 1000;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "meter" && cmb_convertto.Text == "miles")
            {
                n = double.Parse(txt1.Text);
                m = n * 0.000621371;
                txt2.Text = Math.Round(m, 2).ToString();
            }
            if (cmb_convertfrom.Text == "miles" && cmb_convertto.Text == "miles")
            {
                n = double.Parse(txt1.Text);
                m = n;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "miles" && cmb_convertto.Text == "kilometer")
            {
                n = double.Parse(txt1.Text);
                m = n * 1.60934;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "miles" && cmb_convertto.Text == "meter")
            {
                n = double.Parse(txt1.Text);
                m = n * 1.60934 * 1000;
                txt2.Text = Math.Round(m, 3).ToString();
            }





            if (cmb_convertfrom.Text == "acre" && cmb_convertto.Text == "acre")
            {
                n = double.Parse(txt1.Text);
                m = n;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "acre" && cmb_convertto.Text == "hectare")
            {
                n = double.Parse(txt1.Text);
                m = n / 2.471;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "acre" && cmb_convertto.Text == "squaremeter")
            {
                n = double.Parse(txt1.Text);
                m = n * 4047;
                txt2.Text = Math.Round(m, 3).ToString();
            }

            if (cmb_convertfrom.Text == "hectare" && cmb_convertto.Text == "hectare")
            {
                n = double.Parse(txt1.Text);
                m = n;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "hectare" && cmb_convertto.Text == "squaremeter")
            {
                n = double.Parse(txt1.Text);
                m = n * 10000;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "hectare" && cmb_convertto.Text == "acre")
            {
                n = double.Parse(txt1.Text);
                m = n * 2.471;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "squaremeter" && cmb_convertto.Text == "sqauremeter")
            {
                n = double.Parse(txt1.Text);
                m = n;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "sqauremeter" && cmb_convertto.Text == "hectare")
            {
                n = double.Parse(txt1.Text);
                m = n /10000;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "squaremeter" && cmb_convertto.Text == "acre")
            {
                n = double.Parse(txt1.Text);
                m = n / 4047;
                txt2.Text = Math.Round(m, 3).ToString();
            }




            if (cmb_convertfrom.Text == "liter" && cmb_convertto.Text == "liter")
            {
                n = double.Parse(txt1.Text);
                m = n;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "liter" && cmb_convertto.Text == "milliliter")
            {
                n = double.Parse(txt1.Text);
                m = n * 1000;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "liter" && cmb_convertto.Text == "ounce")
            {
                n = double.Parse(txt1.Text);
                m = n * 33.814;
                txt2.Text = Math.Round(m, 3).ToString();
            }

            if (cmb_convertfrom.Text == "milliliter" && cmb_convertto.Text == "milliliter")
            {
                n = double.Parse(txt1.Text);
                m = n;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "milliliter" && cmb_convertto.Text == "liter")
            {
                n = double.Parse(txt1.Text);
                m = n / 1000;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "milliliter" && cmb_convertto.Text == "ounce")
            {
                n = double.Parse(txt1.Text);
                m = n /29.574;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "ounce" && cmb_convertto.Text == "ounce")
            {
                n = double.Parse(txt1.Text);
                m = n;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "ounce" && cmb_convertto.Text == "liter")
            {
                n = double.Parse(txt1.Text);
                m = n /33.814;
                txt2.Text = Math.Round(m, 3).ToString();
            }
            if (cmb_convertfrom.Text == "ounce" && cmb_convertto.Text == "milliliter")
            {
                n = double.Parse(txt1.Text);
                m = n * 29.574;
                txt2.Text = Math.Round(m, 3).ToString();
            }






        }
    }
}