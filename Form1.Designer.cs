namespace FinalAttempt
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
            this.components = new System.ComponentModel.Container();
            this.tutorialDBDataSet = new FinalAttempt.TutorialDBDataSet();
            this.tutorialDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Loc = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Mob = new System.Windows.Forms.TextBox();
            this.insert_Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.button_Excel = new System.Windows.Forms.Button();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Start = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sign_Pad = new System.Windows.Forms.Button();
            this.SignStop_Button = new System.Windows.Forms.Button();
            this.SignSave_Button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.thread_Label = new System.Windows.Forms.Label();
            this.Image_Label = new System.Windows.Forms.Label();
            this.DataTime_Label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tutorialDBDataSet
            // 
            this.tutorialDBDataSet.DataSetName = "TutorialDBDataSet";
            this.tutorialDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tutorialDBDataSetBindingSource
            // 
            this.tutorialDBDataSetBindingSource.DataSource = this.tutorialDBDataSet;
            this.tutorialDBDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "MobileNumber";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(154, 9);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(150, 20);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Loc
            // 
            this.txt_Loc.Location = new System.Drawing.Point(154, 52);
            this.txt_Loc.Name = "txt_Loc";
            this.txt_Loc.Size = new System.Drawing.Size(150, 20);
            this.txt_Loc.TabIndex = 3;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(154, 102);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(150, 20);
            this.txt_Email.TabIndex = 4;
            // 
            // txt_Mob
            // 
            this.txt_Mob.Location = new System.Drawing.Point(154, 156);
            this.txt_Mob.Name = "txt_Mob";
            this.txt_Mob.Size = new System.Drawing.Size(150, 20);
            this.txt_Mob.TabIndex = 5;
            // 
            // insert_Button
            // 
            this.insert_Button.Location = new System.Drawing.Point(44, 247);
            this.insert_Button.Name = "insert_Button";
            this.insert_Button.Size = new System.Drawing.Size(75, 23);
            this.insert_Button.TabIndex = 6;
            this.insert_Button.Text = "INSERT";
            this.insert_Button.UseVisualStyleBackColor = true;
            this.insert_Button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(271, 247);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(75, 23);
            this.button_Del.TabIndex = 8;
            this.button_Del.Text = "DELETE";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.Button_Del_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Location = new System.Drawing.Point(372, 247);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(75, 23);
            this.clear_Button.TabIndex = 9;
            this.clear_Button.Text = "CLEAR";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // button_Excel
            // 
            this.button_Excel.AutoSize = true;
            this.button_Excel.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Excel.Location = new System.Drawing.Point(92, 276);
            this.button_Excel.Name = "button_Excel";
            this.button_Excel.Size = new System.Drawing.Size(102, 43);
            this.button_Excel.TabIndex = 10;
            this.button_Excel.Text = "Export to Excel";
            this.button_Excel.UseVisualStyleBackColor = false;
            this.button_Excel.Click += new System.EventHandler(this.Button_Excel_Click);
            // 
            // txt_URL
            // 
            this.txt_URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_URL.Location = new System.Drawing.Point(154, 205);
            this.txt_URL.Multiline = true;
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(150, 20);
            this.txt_URL.TabIndex = 11;
            this.txt_URL.TextChanged += new System.EventHandler(this.Txt_URL_TextChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "URL";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFile";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "GetFilePath";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(859, 248);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(106, 39);
            this.button_Start.TabIndex = 14;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1049, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 39);
            this.button3.TabIndex = 15;
            this.button3.Text = "Take Snapshot";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HikVision",
            "Webcamera",
            "Axis",
            "Samsung"});
            this.comboBox1.Location = new System.Drawing.Point(903, 221);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(728, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Sign_Pad
            // 
            this.Sign_Pad.Location = new System.Drawing.Point(1138, 345);
            this.Sign_Pad.Name = "Sign_Pad";
            this.Sign_Pad.Size = new System.Drawing.Size(106, 39);
            this.Sign_Pad.TabIndex = 18;
            this.Sign_Pad.Text = "Start";
            this.Sign_Pad.UseVisualStyleBackColor = true;
            this.Sign_Pad.Click += new System.EventHandler(this.Sign_Pad_Click);
            // 
            // SignStop_Button
            // 
            this.SignStop_Button.Location = new System.Drawing.Point(1138, 390);
            this.SignStop_Button.Name = "SignStop_Button";
            this.SignStop_Button.Size = new System.Drawing.Size(106, 39);
            this.SignStop_Button.TabIndex = 19;
            this.SignStop_Button.Text = "Stop";
            this.SignStop_Button.UseVisualStyleBackColor = true;
            this.SignStop_Button.Click += new System.EventHandler(this.SignStop_Button_Click);
            // 
            // SignSave_Button
            // 
            this.SignSave_Button.Location = new System.Drawing.Point(1138, 435);
            this.SignSave_Button.Name = "SignSave_Button";
            this.SignSave_Button.Size = new System.Drawing.Size(106, 39);
            this.SignSave_Button.TabIndex = 20;
            this.SignSave_Button.Text = "Save";
            this.SignSave_Button.UseVisualStyleBackColor = true;
            this.SignSave_Button.Click += new System.EventHandler(this.SignSave_Button_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(655, 309);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(347, 96);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // thread_Label
            // 
            this.thread_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thread_Label.Location = new System.Drawing.Point(745, 422);
            this.thread_Label.Name = "thread_Label";
            this.thread_Label.Size = new System.Drawing.Size(114, 23);
            this.thread_Label.TabIndex = 22;
            this.thread_Label.Text = "ThreadLabel";
            this.thread_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.thread_Label.Click += new System.EventHandler(this.Thread_Label_Click);
            // 
            // Image_Label
            // 
            this.Image_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Image_Label.Location = new System.Drawing.Point(372, 33);
            this.Image_Label.Name = "Image_Label";
            this.Image_Label.Size = new System.Drawing.Size(107, 25);
            this.Image_Label.TabIndex = 23;
            this.Image_Label.Text = "Image";
            this.Image_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataTime_Label
            // 
            this.DataTime_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataTime_Label.Location = new System.Drawing.Point(372, 156);
            this.DataTime_Label.Name = "DataTime_Label";
            this.DataTime_Label.Size = new System.Drawing.Size(107, 25);
            this.DataTime_Label.TabIndex = 24;
            this.DataTime_Label.Text = "DateTime";
            this.DataTime_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(485, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(497, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 474);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DataTime_Label);
            this.Controls.Add(this.Image_Label);
            this.Controls.Add(this.thread_Label);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SignSave_Button);
            this.Controls.Add(this.SignStop_Button);
            this.Controls.Add(this.Sign_Pad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_URL);
            this.Controls.Add(this.button_Excel);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.insert_Button);
            this.Controls.Add(this.txt_Mob);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Loc);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "DataIntegration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.polo);
            ((System.ComponentModel.ISupportInitialize)(this.tutorialDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tutorialDBDataSetBindingSource;
        private TutorialDBDataSet tutorialDBDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Loc;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Mob;
        private System.Windows.Forms.Button insert_Button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button button_Excel;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Sign_Pad;
        private System.Windows.Forms.Button SignStop_Button;
        private System.Windows.Forms.Button SignSave_Button;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label thread_Label;
        private System.Windows.Forms.Label Image_Label;
        private System.Windows.Forms.Label DataTime_Label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

