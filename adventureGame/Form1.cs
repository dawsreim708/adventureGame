using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace adventureGame
{
    public partial class Form1 : Form
    {
        int scene = 1;
        bool mazdaRx7;
        bool nissan240;
        bool dodgeChallenger;
        int chance;

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                if (scene == 1)
                {
                    scene = 2;
                    mazdaRx7 = true;
                    rx7Image.Visible = true;
                }
                else if (scene == 2)
                {
                    scene = 3;
                }
                else if (scene == 3)
                {
                    if (dodgeChallenger == true)
                    {
                        scene = 6;
                    }
                    else
                    {
                        scene = 5;
                    }
                }
                else if (scene == 4)
                {
                    Random randNum = new Random();
                    chance = randNum.Next(1, 101);
                    if (chance <= 90)
                    {
                        scene = 11;
                    }
                    else
                    {
                        scene = 10;
                    }
                }
                else if (scene == 5)
                {
                    scene = 8;
                }
                else if (scene == 7)
                {
                    Random randNum = new Random();
                    chance = randNum.Next(1, 101);
                    if (chance >= 90)
                    {
                        scene = 11;
                    }
                    else
                    {
                        scene = 10;
                    }
                }
                else if (scene == 9)
                {
                    scene = 12;
                }
                else if (scene == 13)
                {
                    scene = 14;
                }
                else if (scene == 15)
                {
                    scene = 16;
                }
                else if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 18)
                {
                    scene = 99;
                }
                else if (scene == 100)
                {
                    Application.Exit();
                }

            }
            if (e.KeyCode == Keys.B)
            {
                if (scene == 1)
                {
                    scene = 2;
                    nissan240 = true;
                    image240sx.Visible = true;
                }
                else if (scene == 2)
                {
                    scene = 97;
                }
                else if (scene == 3)
                {
                    scene = 4;
                }
                else if (scene == 4)
                {
                    scene = 9;
                }
                else if (scene == 5)
                {
                    scene = 7;
                }
                else if (scene == 7)
                {
                    scene = 9;
                }
                else if (scene == 9)
                {
                    scene = 13;
                }
                else if (scene == 13)
                {
                    scene = 99;
                }
                else if (scene == 15)
                {
                    scene = 97;
                }
                else if (scene == 16)
                {
                    scene = 17;
                }
                else if (scene == 18)
                {
                    scene = 99;
                }
                else if (scene == 100)
                {
                    scene = 1;
                }
            }
            if (e.KeyCode == Keys.N)
            {
                if (scene == 1)
                {
                    scene = 2;
                    dodgeChallenger = true;
                    challengerImage.Visible = true;
                }
            }

            switch (scene)
            {
                case 1:
                    textOutput.Text = "Choose your car.";

                    question1.Text = "1997 Mazda RX7";
                    question2.Text = "1994 Nissan 240SX";
                    question3.Text = "2020 Dodge Challenger";
                    question3.Visible = true;
                    nButton.Visible = true;
                    mButton.Visible = true;
                    bButton.Visible = true;
                    break;
                case 2:
                    textOutput.Text = "You are driving casually at a high speed and a police officer flashes his lights, what do you do?";

                    question1.Text = "Try and run";
                    question2.Text = "Pull over";
                    question3.Visible = false;
                    nButton.Visible = false;
                    break;
                case 3:
                    textOutput.Text = "You start accelerating away, you notice you can turn left down a road. Do you turn or go straight?";

                    question1.Text = "Turn";
                    question2.Text = "Go Straight";
                    break;
                case 4:
                    textOutput.Text = "You keep going straight but the cop is catching up, you notice a store you can hide behind, what do you do?";

                    question1.Text = "Hide behind store";
                    question2.Text = "Keep going straight";
                    break;
                case 5:
                    textOutput.Text = "you turn and start to oversteer, do you slow down to stop sliding or do you try and drift?";

                    question1.Text = "Drift";
                    question2.Text = "Slow down";
                    break;
                case 6:
                    textOutput.Text = "You tried to turn but died because your in a dodge challenger";

                    question1.Text = "";
                    question2.Text = "";
                    mButton.Visible = false;
                    bButton.Visible = false;
                    Refresh();
                    Thread.Sleep(4000);
                    scene = 98;
                    break;
                case 7:
                    textOutput.Text = "you slow down and correct your turn and the cop is getting close, you notice a store you can hide behind, what do you do?";

                    question1.Text = "Hide";
                    question2.Text = "Keep driving away";
                    break;
                case 8:
                    textOutput.Text = "You pull off a smooth drift as you see the cop slide into the building on the corner";

                    question1.Text = "";
                    question2.Text = "";
                    mButton.Visible = false;
                    bButton.Visible = false;
                    Refresh();
                    Thread.Sleep(4000);
                    scene = 99;
                    break;
                case 9:
                    textOutput.Text = "You are diving straight as the cop tries to push your back end out";

                    question1.Text = "try speeding up";
                    question2.Text = "turn around and go the other way";
                    break;
                case 10:
                    textOutput.Text = "The cop drives by and doesn't see you";

                    question1.Text = "";
                    question2.Text = "";
                    mButton.Visible = false;
                    bButton.Visible = false;
                    Refresh();
                    Thread.Sleep(4000);
                    scene = 99;
                    
                    break;
                case 11:
                    textOutput.Text = "The cop drives by and doesn't see you";

                    question1.Text = "";
                    question2.Text = "";
                    mButton.Visible = false;
                    bButton.Visible = false;
                    Refresh();
                    Thread.Sleep(4000);
                    scene = 15;
                    
                    break;
                case 12:
                    textOutput.Text = "you failed at trying to accelerate straight and you spun out and crashed";

                    question1.Text = "";
                    question2.Text = "";
                    mButton.Visible = false;
                    bButton.Visible = false;
                    Refresh();
                    Thread.Sleep(4000);
                    scene = 97;
                    break;
                case 13:
                    textOutput.Text = "you accelerate in the opposite direction and you see an unknown road you can go down";

                    question1.Text = "take unknown road";
                    question2.Text = "keep going straight";
                    break;
                case 14:
                    textOutput.Text = "The road is a dead end";

                    question1.Text = "";
                    question2.Text = "";
                    mButton.Visible = false;
                    bButton.Visible = false;
                    Refresh();
                    Thread.Sleep(4000);
                    scene = 97;
                    break;
                case 15:
                    textOutput.Text = "You Escaped";

                    question1.Text = "";
                    question2.Text = "";
                    mButton.Visible = false;
                    bButton.Visible = false;
                    Refresh();
                    Thread.Sleep(4000);
                    scene = 99;
                    break;
                case 16:
                    textOutput.Text = "You start driving away as you see another cop parked up ahead what do you do?";

                    question1.Text = "Turn around";
                    question2.Text = "Keep going";

                    break;
                case 17:
                    textOutput.Text = "The cop throws spike onto the road causing your tires to pop, you lose control and slide into a semi truck.";

                    question1.Text = "";
                    question2.Text = "";
                    mButton.Visible = false;
                    bButton.Visible = false;
                    Refresh();
                    Thread.Sleep(4000);
                    scene = 98;
                    break;
                case 18:
                    textOutput.Text = "the cop tries to hit you as you turn around but misses, you escaped";

                    question1.Text = "drift as you drive away";
                    question2.Text = "don't drift";
                    break;
                case 97:
                    textOutput.Text = "you lose";

                    question1.Text = "";
                    question2.Text = "";
                    Refresh();
                    Thread.Sleep(5000);
                    scene = 100;
                    break;
                case 98:
                    textOutput.Text = "you died";

                    question1.Text = "";
                    question2.Text = "";
                    Refresh();
                    Thread.Sleep(5000);
                    scene = 100;
                    break;
                case 99:
                    textOutput.Text = "you win";

                    question1.Text = "";
                    question2.Text = "";
                    Refresh();
                    Thread.Sleep(5000);
                    scene = 100;
                    Refresh();
                    break;
                case 100:
                    textOutput.Text = "Play again?";

                    question1.Text = "no";
                    question2.Text = "yes";
                    break;
            }
            

        }

    }
}
