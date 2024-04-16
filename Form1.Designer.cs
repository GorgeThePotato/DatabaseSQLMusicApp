namespace DatabaseSQLMusicApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            checkBox1 = new CheckBox();
            Add = new Button();
            txt_description = new TextBox();
            txt_imageurl = new TextBox();
            txt_year = new TextBox();
            txt_artist = new TextBox();
            txt_album = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            label7 = new Label();
            button3 = new Button();
            button4 = new Button();
            label9 = new Label();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            label10 = new Label();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            checkBox2 = new CheckBox();
            button5 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(397, 22);
            button1.Name = "button1";
            button1.Size = new Size(112, 28);
            button1.TabIndex = 0;
            button1.Text = "Load Albums";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(397, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(685, 267);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(774, 21);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(515, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 27);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1101, 170);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(Add);
            groupBox1.Controls.Add(txt_description);
            groupBox1.Controls.Add(txt_imageurl);
            groupBox1.Controls.Add(txt_year);
            groupBox1.Controls.Add(txt_artist);
            groupBox1.Controls.Add(txt_album);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 348);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Album";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(267, 250);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 12;
            label8.Text = "albumID";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(200, 248);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(57, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Edit";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            Add.Location = new Point(22, 294);
            Add.Name = "Add";
            Add.Size = new Size(117, 29);
            Add.TabIndex = 10;
            Add.Text = "Add / Update";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(200, 203);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(125, 27);
            txt_description.TabIndex = 9;
            // 
            // txt_imageurl
            // 
            txt_imageurl.Location = new Point(200, 168);
            txt_imageurl.Name = "txt_imageurl";
            txt_imageurl.Size = new Size(125, 27);
            txt_imageurl.TabIndex = 8;
            // 
            // txt_year
            // 
            txt_year.Location = new Point(200, 133);
            txt_year.Name = "txt_year";
            txt_year.Size = new Size(125, 27);
            txt_year.TabIndex = 7;
            // 
            // txt_artist
            // 
            txt_artist.Location = new Point(200, 98);
            txt_artist.Name = "txt_artist";
            txt_artist.Size = new Size(125, 27);
            txt_artist.TabIndex = 6;
            // 
            // txt_album
            // 
            txt_album.Location = new Point(200, 63);
            txt_album.Name = "txt_album";
            txt_album.Size = new Size(125, 27);
            txt_album.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 199);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 165);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 3;
            label4.Text = "Album Cover";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 131);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 2;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 97);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Artist";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 63);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Album Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 397);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 6;
            label6.Text = "Tracks";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(408, 425);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(528, 250);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(397, 70);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 8;
            label7.Text = "Albums";
            // 
            // button3
            // 
            button3.Location = new Point(408, 695);
            button3.Name = "button3";
            button3.Size = new Size(109, 31);
            button3.TabIndex = 9;
            button3.Text = "Delete Track";
            button3.UseVisualStyleBackColor = true;
            button3.Click += deleteTrack;
            // 
            // button4
            // 
            button4.Location = new Point(874, 21);
            button4.Name = "button4";
            button4.Size = new Size(158, 29);
            button4.TabIndex = 10;
            button4.Text = "Edit Selected Album";
            button4.UseVisualStyleBackColor = true;
            button4.Click += updateAlbum;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1101, 143);
            label9.Name = "label9";
            label9.Size = new Size(95, 20);
            label9.TabIndex = 11;
            label9.Text = "Album Cover";
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Location = new Point(953, 454);
            webView.Name = "webView";
            webView.Size = new Size(512, 366);
            webView.Source = new Uri("https://www.youtube.com/", UriKind.Absolute);
            webView.TabIndex = 12;
            webView.ZoomFactor = 1D;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(942, 425);
            label10.Name = "label10";
            label10.Size = new Size(110, 20);
            label10.TabIndex = 13;
            label10.Text = "YouTube Player";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Location = new Point(12, 378);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 361);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Track";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(199, 204);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 28);
            comboBox1.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(54, 212);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 13;
            label12.Text = "Album ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(263, 248);
            label11.Name = "label11";
            label11.Size = new Size(56, 20);
            label11.TabIndex = 12;
            label11.Text = "trackID";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(200, 248);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(57, 24);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "Edit";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(54, 268);
            button5.Name = "button5";
            button5.Size = new Size(117, 29);
            button5.TabIndex = 10;
            button5.Text = "Add / Update";
            button5.UseVisualStyleBackColor = true;
            button5.Click += addTrack;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(200, 168);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(200, 133);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(200, 98);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(200, 63);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(54, 165);
            label13.Name = "label13";
            label13.Size = new Size(44, 20);
            label13.TabIndex = 3;
            label13.Text = "Lyrics";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(54, 131);
            label14.Name = "label14";
            label14.Size = new Size(78, 20);
            label14.TabIndex = 2;
            label14.Text = "Video URL";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(54, 97);
            label15.Name = "label15";
            label15.Size = new Size(63, 20);
            label15.TabIndex = 1;
            label15.Text = "Number";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(54, 63);
            label16.Name = "label16";
            label16.Size = new Size(76, 20);
            label16.TabIndex = 0;
            label16.Text = "Track Title";
            // 
            // button6
            // 
            button6.Location = new Point(523, 695);
            button6.Name = "button6";
            button6.Size = new Size(147, 29);
            button6.TabIndex = 15;
            button6.Text = "Edit Selected Track";
            button6.UseVisualStyleBackColor = true;
            button6.Click += updateTrack;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 832);
            Controls.Add(button6);
            Controls.Add(groupBox2);
            Controls.Add(label10);
            Controls.Add(webView);
            Controls.Add(label9);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox txt_description;
        private TextBox txt_imageurl;
        private TextBox txt_year;
        private TextBox txt_artist;
        private TextBox txt_album;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Add;
        private Label label6;
        private DataGridView dataGridView2;
        private Label label7;
        private Button button3;
        private Label label8;
        private CheckBox checkBox1;
        private Button button4;
        private Label label9;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private Label label10;
        private GroupBox groupBox2;
        private Label label11;
        private CheckBox checkBox2;
        private Button button5;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button button6;
        private ComboBox comboBox1;
        private Label label12;
    }
}
