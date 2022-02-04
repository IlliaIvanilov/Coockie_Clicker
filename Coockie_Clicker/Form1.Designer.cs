using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Coockie_Clicker
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
            coockie_click = int.Parse(File.ReadAllText("info").ToString());

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Coockie Clicker ";
            // this.Text = $"{coockie_click} cookies";

            this.FormClosing += Form2_FormClosing;
            this.BackgroundImage = Image.FromFile("background.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            button_box.BackgroundImage = Image.FromFile("img.png");
            button_box.Size = new Size(x_cookie, y_cookie);
            button_box.SizeMode = PictureBoxSizeMode.StretchImage;
            button_box.BackColor = Color.Transparent;
            button_box.Location = new Point(70, 300);
            this.button_box.Click += Button_Click;

            //normalcookie.BackgroundImage = Image.FromFile("img.png");
            //normalcookie.BackColor = Color.Transparent;
            //normalcookie.Size = new Size(x_cookie, y_cookie);
            //normalcookie.Location = new Point(65, 285);
            //normalcookie.SizeMode = PictureBoxSizeMode.Normal;

            //bigCookie.BackgroundImage = Image.FromFile("imgonline-com-ua-Resize-vFhzi5I0dmUifgY.png");
            //bigCookie.BackColor = Color.Transparent;
            //bigCookie.Size = new Size(x_cookie + 15, y_cookie + 15);
            //bigCookie.Location = new Point(65, 285);
            //bigCookie.SizeMode = PictureBoxSizeMode.Normal;

            littlecookie.BackgroundImage = Image.FromFile("imgonline-com-ua-resize-ve4lsmyqfsvk4s.png");
            littlecookie.BackColor = Color.Transparent;
            littlecookie.Size = new Size(35, 35);
            littlecookie.Location = new Point(30, 300);
            littlecookie.SizeMode = PictureBoxSizeMode.Normal;
            littlecookie.BringToFront();

            // this.Controls.Add(littlecookie);

            label_cockie.Size = new Size(300, 200);
            label_cockie.Location = new Point(45, 100);
            label_cockie.Text = $"COOKIE COUNT \n{coockie_click}";
            label_cockie.TextAlign = ContentAlignment.MiddleCenter;
            label_cockie.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            label_cockie.BackColor = Color.Transparent;
            
            this.Controls.Add(label_cockie);

            this.Controls.Add(button_box);

        }

        int x_cookie = 250;
        int y_cookie = 250;
        int coockie_click = 0;
        PictureBox button_box = new PictureBox();
        PictureBox normalcookie = new PictureBox();
        PictureBox bigCookie = new PictureBox();
        PictureBox littlecookie = new PictureBox();
        Label label_cockie = new Label();
        Label label_setNull = new Label();
        Timer timer = new Timer();
        private void Button_Click(object sender, EventArgs e)
        {
            // this.Cursor = new Cursor(Cursor.Current.Handle);
            // var rand = new Random();
            coockie_click++;
            label_cockie.Text = string.Format("COOKIE COUNT \n{0}", coockie_click.ToString());
            for(int i = 0; i < this.Controls.Count; i++)
            {
                littlecookie.Location = new Point(((System.Drawing.Size)Cursor.Position));
                this.button_box.SendToBack();
                this.littlecookie.BringToFront();
                this.littlecookie.BringToFront();
                this.Controls.Add(littlecookie);
            }



           // if (button_box.Size != new Size(265, 265))
            //{
            //    button_box.Size = new Size(265, 265);
            //    button_box.SizeMode = PictureBoxSizeMode.Zoom;
           // }
//
           // else
            //{
            //    button_box.Size = new Size(250, 250);
            //    button_box.SizeMode = PictureBoxSizeMode.Zoom;
            // }


            // this.Text = $"{coockie_click} cookies";
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("info", $"{coockie_click}");
        }

        #endregion
    }
}

