using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semaforo
{
    public partial class Form1 : Form
    {

        int slow = 1, normal = 2, fast = 3, speed = 2;
        string light = "", light2 = "";
        int tick = 0, tick2=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            timer1.Enabled = true;
            timer2.Enabled = true;
            

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            reglas1();
            reglas2();
            reglas3();
            reglas4();
            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            semaforo1();
            semaforo2();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {



        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                speed = slow;
                timer2.Interval = 2000;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                speed = normal;
                timer2.Interval = 1000;
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                speed = fast;
                timer2.Interval = 500;
            }
        }

        
        private void move1()
        {
            pictureBox1.Left += speed;
            if (pictureBox1.Location.X > 819)
            {
                pictureBox1.Location = new Point(0-70, pictureBox1.Location.Y);
            }
           
        }
        private void move2()
        {
            pictureBox6.Left -= speed;
            if (pictureBox6.Right < 0)
            {
                pictureBox6.Location = new Point(819, pictureBox6.Location.Y);
            }
        }
        private void move3()
        {
            pictureBox10.Top += speed;
            if (pictureBox10.Location.Y > 450)
            {
                pictureBox10.Location = new Point(pictureBox10.Location.X, 0-70);
            }
        }
        private void move4()
        {
            pictureBox11.Top -= speed;
            if (pictureBox11.Location.Y < 0 - 70)
            {
                pictureBox11.Location = new Point(pictureBox11.Location.X, 450);
            }
        }

        

        private void semaforo1()
        {
            
            if (tick < 10)
            {
                pictureBox3.Visible = true;
                pictureBox7.Visible = true;
                pictureBox5.Visible = false;
                pictureBox9.Visible = false;
                light = "green";
            }
            else if (tick < 14)
            {
                pictureBox4.Visible = true;
                pictureBox8.Visible = true;
                pictureBox3.Visible = false;
                pictureBox7.Visible = false;
                light = "yellow";
            }
            else if (tick < 30)
            {
                pictureBox5.Visible = true;
                pictureBox9.Visible = true;
                pictureBox4.Visible = false;
                pictureBox8.Visible = false;
                light = "red";
            }

            if (tick == 30)
            {
                tick = 0;
            }
            tick++;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void semaforo2()
        {
            
            if (tick2 < 15)
            {
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                light2 = "red";
            }
            else if (tick2 < 26)
            {
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                light2 = "green";
            }
            else if (tick2 < 30)
            {
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                light2 = "yellow";
            }

            if (tick2 == 30)
            {
                tick2 = 0;
            }
            tick2++;
        }


        private void reglas1()
        {
            if (light == "green")
            {
                move1();
            }
            if (light == "yellow")
            {
                if (pictureBox1.Location.X > 150)
                {
                    move1();
                }
                if (pictureBox1.Location.X < 120)
                {
                    move1();
                }

            }
            if (light == "red")
            {
                if (pictureBox1.Location.X > 150)
                {
                    move1();
                }
                if (pictureBox1.Location.X < 120)
                {
                    move1();
                }
            }
        }
        private void reglas2()
        {
            if (light == "green")
            {
                move2();
            }
            if (light == "yellow")
            {
                if (pictureBox6.Location.X < 580)
                {
                    move2();
                }
                if (pictureBox6.Location.X > 590)
                {
                    move2();
                }

            }
            if (light == "red")
            {
                if (pictureBox6.Location.X < 580)
                {
                    move2();
                }
                if (pictureBox6.Location.X > 590)
                {
                    move2();
                }
            }
        }
        private void reglas3()
        {
            if (light2 == "green")
            {
                move3();
            }
            if (light2 == "yellow")
            {
                if (pictureBox10.Location.Y > 40)
                {
                    move3();
                }
                if (pictureBox10.Location.Y < 24)
                {
                    move3();
                }

            }
            if (light2 == "red")
            {
                if (pictureBox10.Location.Y > 40)
                {
                    move3();
                }
                if (pictureBox10.Location.Y < 24)
                {
                    move3();
                }
            }
        }
        private void reglas4()
        {
            if (light2 == "green")
            {
                move4();
            }
            if (light2 == "yellow")
            {
                if (pictureBox11.Location.Y < 360)
                {
                    move4();
                }
                if (pictureBox11.Location.Y > 370)
                {
                    move4();
                }

            }
            if (light2 == "red")
            {
                if (pictureBox11.Location.Y < 360)
                {
                    move4();
                }
                if (pictureBox11.Location.Y > 370)
                {
                    move4();
                }
            }
        }
        
    }
}
