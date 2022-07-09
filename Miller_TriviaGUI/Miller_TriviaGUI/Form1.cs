using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miller_TriviaGUI
{
    public partial class Form1 : Form
    {


        QuestionBank qBank;
        private int q;
        private const char NO_ANSWER = 'Z';
        private int correct;




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string msg = "Let's play a game of trivia. In this game you will be shown a series of questions, " +
                        "one at a time. Each question will have four possible answers, only one " +
                        "will be the correct answer. Your job is to pick the correct answer. Good luck.";
            MessageBox.Show(msg, "Trivia Game");

            qBank = new QuestionBank();
            try
            {
                qBank.ReadQuestionFile();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.Message);
            }

            resetForm();

            //Console.WriteLine(qBank);



        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = "Name:\t\tNicholas Miller" +
                        "\nCourse:\t\tITDEV-115" +
                        "\nInstructor:\tJanese Christie" +
                        "\nAssignment:\tTrivia Game GUI" +
                        "\nDate: \t\t" + DateTime.Today.ToShortDateString();
            MessageBox.Show(info, "Extra Credit - Trivia GUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadQuestion()
        {
            lblQuestion.Text = qBank.GetQuestion(q);
            rbA.Text = qBank.GetAnswers(q)[0];
            rbB.Text = qBank.GetAnswers(q)[1];
            rbC.Text = qBank.GetAnswers(q)[2];
            rbD.Text = qBank.GetAnswers(q)[3];
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;

            setVisiblity(true);
        }

        private void picSubmit_Click(object sender, EventArgs e)
        {
            string msg;
            char ans = NO_ANSWER;
            if (rbA.Checked)
            {
                ans = 'A';
            }
            else if (rbB.Checked)
            {
                ans = 'B';
            }
            else if (rbC.Checked)
            {
                ans = 'C';
            }
            else if (rbD.Checked)
            {
                ans = 'D';
            }
            if (ans != NO_ANSWER)
            {
                setVisiblity(false);

                if (ans == qBank.GetCorrectAnswer(q))
                {
                    lblQuestion.Text = "You are correct! Good job!!!";
                    correct++;
                }
                else
                {
                    lblQuestion.Text = "The correct answer is: "
                         + qBank.GetAnswers(q)[Array.IndexOf(QuestionBank.answerChars, qBank.GetCorrectAnswer(q))];
                }
                lblMsg.Text = qBank.GetExplanation(q);
                q++;
                if (q >= QuestionBank.NO_OF_QUESTIONS)
                {
                    msg = "You had " + correct + " correct answers out of " + QuestionBank.NO_OF_QUESTIONS;
                    msg += String.Format("\nThis gives you a percentage of {0:P}", ((double)correct / QuestionBank.NO_OF_QUESTIONS));
                    msg += "\n\nWould you like to play this game again?";
                    DialogResult res = MessageBox.Show(msg, "Your Trivia Score", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        resetForm();
                    }
                    else
                    {
                        Application.Exit();
                    }

                }
            }
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            LoadQuestion();
        }

        private void setVisiblity(bool visible)
        {
            rbA.Visible = visible;
            rbB.Visible = visible;
            rbC.Visible = visible;
            rbD.Visible = visible;
            picSubmit.Visible = visible;
            picNext.Visible = !visible;
            lblMsg.Visible = !visible;
        }
        private void resetForm()
        {
            q = 0;
            correct = 0;
            LoadQuestion();
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}