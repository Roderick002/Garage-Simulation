namespace Garage_Data_Structure_Activity_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TbPlateNumber.Text != string.Empty)
            {
                if (LbGarage.Items.Contains(TbPlateNumber.Text))
                {
                    BtnRecentDeparted.Text = TbPlateNumber.Text;
                    LbGarage.Items.Remove(TbPlateNumber.Text);
                    Timer.Enabled = true;
                    MessageBox.Show("Your car with plate number " + TbPlateNumber.Text + " has been departed!");
                    Timer.Enabled = false;
                    TbPlateNumber.Text = null;
                }
                else
                {
                    MessageBox.Show("Your car is not present in the garage!");
                    TbPlateNumber.Text = null;
                }
            }
            else
            {
                MessageBox.Show("Enter your car's plate number!");
            }
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (TbPlateNumber.Text != string.Empty)
            {
                if (LbGarage.Items.Contains(TbPlateNumber.Text))
                {
                    MessageBox.Show("Your car is already parked!");
                    TbPlateNumber.Text = null;
                }
                else
                {
                    if (LbGarage.Items.Count != 10)
                    {
                        LbGarage.Items.Add(TbPlateNumber.Text);
                        Timer.Enabled = true;
                        MessageBox.Show("Your car with plate number " + TbPlateNumber.Text + " has been parked!");
                        Timer.Enabled = false;

                    }
                    else
                    {
                        MessageBox.Show("Garage is Full!");
                    }
                    TbPlateNumber.Text = null;
                }
            }
            else
            {
                MessageBox.Show("Enter your car's plate number!");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int index = LbGarage.Items.Count;

            if (index > 0)
            {
                BtnGS1.Text = LbGarage.Items[0].ToString();
            }
            else
            {
                BtnGS1.Text = "Garage Space 1";
            }

            if (index > 1)
            {
                BtnGS2.Text = LbGarage.Items[1].ToString();
            }
            else
            {
                BtnGS2.Text = "Garage Space 2";
            }

            if (index > 2)
            {
                BtnGS3.Text = LbGarage.Items[2].ToString();
            }
            else
            {
                BtnGS3.Text = "Garage Space 3";
            }

            if (index > 3)
            {
                BtnGS4.Text = LbGarage.Items[3].ToString();
            }
            else
            {
                BtnGS4.Text = "Garage Space 4";
            }

            if (index > 4)
            {
                BtnGS5.Text = LbGarage.Items[4].ToString();
            }
            else
            {
                BtnGS5.Text = "Garage Space 5";
            }

            if (index > 5)
            {
                BtnGS6.Text = LbGarage.Items[5].ToString();
            }
            else
            {
                BtnGS6.Text = "Garage Space 6";
            }

            if (index > 6)
            {
                BtnGS7.Text = LbGarage.Items[6].ToString();
            }
            else
            {
                BtnGS7.Text = "Garage Space 7";
            }

            if (index > 7)
            {
                BtnGS8.Text = LbGarage.Items[7].ToString();
            }
            else
            {
                BtnGS8.Text = "Garage Space 8";
            }

            if (index > 8)
            {
                BtnGS9.Text = LbGarage.Items[8].ToString();
            }
            else
            {
                BtnGS9.Text = "Garage Space 9";
            }

            if (index > 9)
            {
                BtnGS10.Text = LbGarage.Items[9].ToString();
            }
            else
            {
                BtnGS10.Text = "Garage Space 10";
            }


        }
    }
}