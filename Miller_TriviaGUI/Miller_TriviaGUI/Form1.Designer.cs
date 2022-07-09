
namespace Miller_TriviaGUI
{
    partial class Form1
    {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.lblMsg = new System.Windows.Forms.Label();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picSubmit = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubmit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Wheat;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(91, 82);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(397, 126);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "The book \"The Man in the High Castle\" was written by:";
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.BackColor = System.Drawing.Color.Transparent;
            this.rbA.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbA.Location = new System.Drawing.Point(90, 230);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(174, 24);
            this.rbA.TabIndex = 3;
            this.rbA.Text = "Thomas Hardy";
            this.rbA.UseVisualStyleBackColor = false;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.BackColor = System.Drawing.Color.Transparent;
            this.rbC.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbC.Location = new System.Drawing.Point(90, 280);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(147, 24);
            this.rbC.TabIndex = 4;
            this.rbC.Text = "Issac Asimov";
            this.rbC.UseVisualStyleBackColor = false;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.BackColor = System.Drawing.Color.Transparent;
            this.rbB.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbB.Location = new System.Drawing.Point(263, 230);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(155, 24);
            this.rbB.TabIndex = 5;
            this.rbB.Text = "Philip K. Dick";
            this.rbB.UseVisualStyleBackColor = false;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.BackColor = System.Drawing.Color.Transparent;
            this.rbD.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbD.Location = new System.Drawing.Point(263, 280);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(201, 24);
            this.rbD.TabIndex = 6;
            this.rbD.Text = "Arthur C. Clarke";
            this.rbD.UseVisualStyleBackColor = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(85, 186);
            this.lblMsg.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 25);
            this.lblMsg.TabIndex = 9;
            this.lblMsg.Visible = false;
            // 
            // picNext
            // 
            this.picNext.BackColor = System.Drawing.Color.Transparent;
            this.picNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNext.Image = global::Miller_TriviaGUI.Properties.Resources.download__1_;
            this.picNext.Location = new System.Drawing.Point(288, 354);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(288, 148);
            this.picNext.TabIndex = 8;
            this.picNext.TabStop = false;
            this.picNext.Visible = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            // 
            // picSubmit
            // 
            this.picSubmit.BackColor = System.Drawing.Color.Transparent;
            this.picSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSubmit.Image = global::Miller_TriviaGUI.Properties.Resources.download;
            this.picSubmit.Location = new System.Drawing.Point(34, 340);
            this.picSubmit.Name = "picSubmit";
            this.picSubmit.Size = new System.Drawing.Size(248, 178);
            this.picSubmit.TabIndex = 7;
            this.picSubmit.TabStop = false;
            this.picSubmit.Click += new System.EventHandler(this.picSubmit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(137, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Millers Trivia GUI";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(884, 636);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.picSubmit);
            this.Controls.Add(this.rbD);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.rbA);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubmit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.MenuStrip menuStrip1;
            private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
            private System.Windows.Forms.Label lblQuestion;
            private System.Windows.Forms.RadioButton rbA;
            private System.Windows.Forms.RadioButton rbC;
            private System.Windows.Forms.RadioButton rbB;
            private System.Windows.Forms.RadioButton rbD;
            private System.Windows.Forms.Label lblMsg;
            private System.Windows.Forms.PictureBox picSubmit;
            private System.Windows.Forms.PictureBox picNext;
            private System.Windows.Forms.TextBox textBox1;
    }
    }
