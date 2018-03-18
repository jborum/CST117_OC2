using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_2
{
    public partial class frmProgrammingProject2 : Form
    {
        public frmProgrammingProject2()
        {
            InitializeComponent();
            string imagePath = txtImagePath.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmProgrammingProject2.ActiveForm.Close();
        }

        private void radioHam_CheckedChanged(object sender, EventArgs e)
        {
            picMeat.Image = Image.FromFile(txtImagePath.Text + "ham.png");
            picMeat.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioTurkey_CheckedChanged(object sender, EventArgs e)
        {
            picMeat.Image = Image.FromFile(txtImagePath.Text + "turkey.png");
            picMeat.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioRoastBeef_CheckedChanged(object sender, EventArgs e)
        {
            picMeat.Image = Image.FromFile(txtImagePath.Text + "roastbeef.png");
            picMeat.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void checkLettuce_CheckedChanged(object sender, EventArgs e)
        {
            picLettuce.Image = Image.FromFile(txtImagePath.Text + "lettuce.png");
            picLettuce.SizeMode = PictureBoxSizeMode.StretchImage;
            if (checkLettuce.Checked)
                {
                    picLettuce.Visible = true;
                }
                else
                {
                    picLettuce.Visible = false;
                }
        }

        private void checkTomato_CheckedChanged(object sender, EventArgs e)
        {
            picTomato.Image = Image.FromFile(txtImagePath.Text + "tomato.png");
            picTomato.SizeMode = PictureBoxSizeMode.StretchImage;
            if (checkTomato.Checked)
            {
                picTomato.Visible = true;
            }
            else
            {
                picTomato.Visible = false;
            }
        }

        private void checkCheese_CheckedChanged(object sender, EventArgs e)
        {
            picCheese.Image = Image.FromFile(txtImagePath.Text + "cheese.png");
            picCheese.SizeMode = PictureBoxSizeMode.StretchImage;
            if (checkCheese.Checked)
            {
                picCheese.Visible = true;
            }
            else
            {
                picCheese.Visible = false;
            }
        }

        private void listChips_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listChips.SelectedIndex == 0)
            {
                picChips.Image = Image.FromFile(txtImagePath.Text + "doritos.png");
                picChips.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (listChips.SelectedIndex == 1)
            {
                picChips.Image = Image.FromFile(txtImagePath.Text + "cheetos.png");
                picChips.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (listChips.SelectedIndex == 2)
            {
                picChips.Image = Image.FromFile(txtImagePath.Text + "lays.png");
                picChips.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void frmProgrammingProject2_Load(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
           int number;
           decimal mealPrice = 5.0m;
           if (int.TryParse(txtQuantity.Text, out number))
            {
                txtPrice.Text = Convert.ToString(number * mealPrice);
            }
           else if (txtQuantity.Text == "")
            {
                txtQuantity.Text = Convert.ToString(0);
            }
            else
            {
                MessageBox.Show("Please Enter an Integer");
                txtQuantity.Text = "";
                this.ActiveControl = txtQuantity;
            }
        }
    }
}
