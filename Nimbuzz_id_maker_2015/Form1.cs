using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MehdiComponent;
using MehdiComponent.MehdiXmpp.Create;
using MehdiComponent.Xml;

namespace Nimbuzz_id_maker_2015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            {
                idMaker.Created += idMaker_Created;
                idMaker.ErrorCreate += idMaker_ErrorCreate;
                idMaker.Available += idMaker_Available;
                idMaker.WrongCaptcha += idMaker_WrongCaptcha;
                idMaker.InvalidPassword += idMaker_InvalidPassword;
                idMaker.LoadChaptcha(pictureBox1);
                //idMaker.LoadChaptcha(pictureBox2);
                //idMaker.LoadChaptcha(pictureBox3);
                //idMaker.LoadChaptcha(pictureBox4);
                //idMaker.LoadChaptcha(pictureBox5);
                
            }
        }

        private IdMaker idMaker = new IdMaker();

        private void button1_Click(object sender, EventArgs e)
        {

            // For 1st id
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                lblsts.TextAlign = ContentAlignment.MiddleCenter;
                lblsts.BackColor = Color.Yellow;
                lblsts.Text = "Please Enter Your Id";
                return;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                lblsts.BackColor = Color.Yellow;
                lblsts.Text = "Please Enter Your Password";
                return;
            }
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                lblsts.BackColor = Color.Yellow;
                lblsts.Text = "Please Enter Captcha";
                return;
            }
     
            idMaker.Create(textBox1.Text, textBox6.Text, textBox7.Text);
            textBox7.Clear();
            pictureBox1.Hide();
            
            idMaker.LoadChaptcha(pictureBox2);
        }

                
        private void button2_Click(object sender, EventArgs e)
        {
            // For 2nd id
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                lblsts.TextAlign = ContentAlignment.MiddleCenter;
                lblsts.BackColor = Color.Yellow;
                lblsts.Text = "Please Enter Your Id";
                return;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                lblsts.BackColor = Color.Yellow;
                lblsts.Text = "Please Enter Your Password";
                return;
            }
            if (string.IsNullOrEmpty(textBox8.Text))
            {
                lblsts.BackColor = Color.Yellow;
                lblsts.Text = "Please Enter Captcha";
                return;
            }


            idMaker.Create(textBox2.Text, textBox6.Text, textBox8.Text);
            textBox8.Clear();
            pictureBox2.Hide();
            idMaker.LoadChaptcha(pictureBox3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // For 3rd id
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                lblsts.TextAlign = ContentAlignment.MiddleCenter;
                lblsts.BackColor = Color.Yellow;
                lblsts.Text = "Please Enter Your Id";
                return;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                lblsts.BackColor = Color.Yellow;
                lblsts.Text = "Please Enter Your Password";
                return;
            }
            if (string.IsNullOrEmpty(textBox9.Text))
            {
                lblsts.BackColor = Color.Yellow;
                lblsts.Text = "Please Enter Captcha";
                return;
            }


            idMaker.Create(textBox3.Text, textBox6.Text, textBox9.Text);
            textBox9.Clear();
            pictureBox3.Hide();
            idMaker.LoadChaptcha(pictureBox4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // For 4th id
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                lblsts.TextAlign = ContentAlignment.MiddleCenter;
                lblsts.BackColor = Color.Yellow;
                lblsts.Text = "Please Enter Your Id";
                return;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                lblsts.BackColor = Color.Yellow;
                lblsts.Text = "Please Enter Your Password";
                return;
            }
            if (string.IsNullOrEmpty(textBox10.Text))
            {
                lblsts.BackColor = Color.Yellow;
                lblsts.Text = "Please Enter Captcha";
                return;
            }


            idMaker.Create(textBox4.Text, textBox6.Text, textBox10.Text);
            textBox10.Clear();
            pictureBox4.Hide();
            idMaker.LoadChaptcha(pictureBox5);
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            // For 5th id
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                lblsts.TextAlign = ContentAlignment.MiddleCenter;
                lblsts.BackColor = Color.Yellow;
                lblsts.Text = "Please Enter Your Id";
                return;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                lblsts.BackColor = Color.Yellow;
                lblsts.Text = "Please Enter Your Password";
                return;
            }
            if (string.IsNullOrEmpty(textBox11.Text))
            {
                lblsts.BackColor = Color.Yellow;
                lblsts.Text = "Please Enter Captcha";
                return;
            }

            idMaker.Create(textBox5.Text, textBox6.Text, textBox11.Text);
            textBox11.Clear();
            pictureBox5.Hide();
        }



        private void idMaker_InvalidPassword(IdMaker idMaker, string msg)
        {
            MessageBox.Show("Invalid Password", "Error");
            return;
        }

        private void idMaker_WrongCaptcha(IdMaker idMaker, string msg)
        {
            MessageBox.Show("Wrong Captcha", "Error");
            return;
        }

        private void idMaker_Available(IdMaker idMaker, bool available)
        {
            Invoke(new Action(delegate
            {
                if (available == false)
                {
                    var msgBox = new MehdiMessageBox("\nThis Id is Already Created!", "Attention",
                    MehdiMessageBox.Type.Error);
                    //msgBox.MessageColor = Color.Red;
                    //msgBox.TitleColor = Color.Red;
                    msgBox.ShowDialog();
                }
            }));
        }

        private void idMaker_ErrorCreate(IdMaker idMaker)
        {
            lblsts.Text = "Error Create";
            MessageBox.Show("Error in Creating Id", "Attention!");
            return;
        }

        private void idMaker_Created(IdMaker idMaker, string msg, string data)
        {
            MessageBox.Show("Id Created Sucessfully!", "Attention!");     
            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        
      }
}
