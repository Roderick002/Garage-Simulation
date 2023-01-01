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
                    int i = LbGarage.Items.IndexOf(TbPlateNumber.Text);
                    BtnRecentDeparted.Text = TbPlateNumber.Text;
                    BtnRecentDeparted.BackColor = LvGarage.Items[i].ForeColor;
                    LvGarage.Items.RemoveAt(i);
                    LbGarage.Items.Remove(TbPlateNumber.Text);
                    Timer.Enabled = true;
                    MessageBox.Show("Your vehicle with plate number " + TbPlateNumber.Text + " has been departed!");
                    Timer.Enabled = false;
                    TbPlateNumber.Text = null;
                    
                }
                else
                {
                    MessageBox.Show("Your vehicle is not present in the garage!");
                    TbPlateNumber.Text = null;
                }
            }
            else
            {
                MessageBox.Show("Enter your vehicle's plate number!");
            }
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (TbPlateNumber.Text != string.Empty)
            {
                if (LbGarage.Items.Contains(TbPlateNumber.Text))
                {
                    MessageBox.Show("Your vehicle is already parked!");
                    TbPlateNumber.Text = null;
                }
                else
                {
                    if (LbGarage.Items.Count != 10)
                    {
                        LbGarage.Items.Add(TbPlateNumber.Text);
                        colorDialog1.ShowDialog();
                        LvGarage.Items.Add(TbPlateNumber.Text);
                        int a = LbGarage.Items.Count - 1;
                        LvGarage.Items[a].ForeColor = colorDialog1.Color;

                        Timer.Enabled = true;
                        MessageBox.Show("Your vehicle with plate number " + TbPlateNumber.Text + " has been parked!");
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
                MessageBox.Show("Enter your vehicle's plate number!");
            }

            int Space = 10 - (LbGarage.Items.Count);
            LblGarageSpace.Text = Space.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int index = LbGarage.Items.Count;

            if (index > 0)
            {
                BtnGS1.Text = LbGarage.Items[0].ToString();
                BtnGS1.BackColor = LvGarage.Items[0].ForeColor;
            }
            else
            {
                BtnGS1.Text = "Garage Space 1";
                BtnGS1.BackColor = Color.WhiteSmoke;
            }

            if (index > 1)
            {
                BtnGS2.Text = LbGarage.Items[1].ToString();
                BtnGS2.BackColor = LvGarage.Items[1].ForeColor;
            }
            else
            {
                BtnGS2.Text = "Garage Space 2";
                BtnGS2.BackColor = Color.WhiteSmoke;
            }

            if (index > 2)
            {
                BtnGS3.Text = LbGarage.Items[2].ToString();
                BtnGS3.BackColor = LvGarage.Items[2].ForeColor;
            }
            else
            {
                BtnGS3.Text = "Garage Space 3";
                BtnGS3.BackColor = Color.WhiteSmoke;
            }

            if (index > 3)
            {
                BtnGS4.Text = LbGarage.Items[3].ToString();
                BtnGS4.BackColor = LvGarage.Items[3].ForeColor;
            }
            else
            {
                BtnGS4.Text = "Garage Space 4";
                BtnGS4.BackColor = Color.WhiteSmoke;
            }

            if (index > 4)
            {
                BtnGS5.Text = LbGarage.Items[4].ToString();
                BtnGS5.BackColor = LvGarage.Items[4].ForeColor;
            }
            else
            {
                BtnGS5.Text = "Garage Space 5";
                BtnGS5.BackColor = Color.WhiteSmoke;
            }

            if (index > 5)
            {
                BtnGS6.Text = LbGarage.Items[5].ToString();
                BtnGS6.BackColor = LvGarage.Items[5].ForeColor;
            }
            else
            {
                BtnGS6.Text = "Garage Space 6";
                BtnGS6.BackColor = Color.WhiteSmoke;
            }

            if (index > 6)
            {
                BtnGS7.Text = LbGarage.Items[6].ToString();
                BtnGS7.BackColor = LvGarage.Items[6].ForeColor;
            }
            else
            {
                BtnGS7.Text = "Garage Space 7";
                BtnGS7.BackColor = Color.WhiteSmoke;
            }

            if (index > 7)
            {
                BtnGS8.Text = LbGarage.Items[7].ToString();
                BtnGS8.BackColor = LvGarage.Items[7].ForeColor;
            }
            else
            {
                BtnGS8.Text = "Garage Space 8";
                BtnGS8.BackColor = Color.WhiteSmoke;
            }

            if (index > 8)
            {
                BtnGS9.Text = LbGarage.Items[8].ToString();
                BtnGS9.BackColor = LvGarage.Items[8].ForeColor;
            }
            else
            {
                BtnGS9.Text = "Garage Space 9";
                BtnGS9.BackColor = Color.WhiteSmoke;
            }

            if (index > 9)
            {
                BtnGS10.Text = LbGarage.Items[9].ToString();
                BtnGS10.BackColor = LvGarage.Items[9].ForeColor;
            }
            else
            {
                BtnGS10.Text = "Garage Space 10";
                BtnGS10.BackColor = Color.WhiteSmoke;
            }
        }


        private void BtnRecentDeparted_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblPlateNo_Click(object sender, EventArgs e)
        {

        }
    }
}