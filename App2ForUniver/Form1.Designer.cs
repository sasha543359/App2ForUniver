namespace App2ForUniver
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
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button2 = new Button();
            textBox2 = new TextBox();
            button3 = new Button();
            textBox3 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(520, 36);
            button1.Name = "button1";
            button1.Size = new Size(226, 40);
            button1.TabIndex = 0;
            button1.Text = "select path";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(465, 23);
            textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(21, 212);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(323, 244);
            listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(398, 212);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(359, 244);
            listBox2.TabIndex = 3;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(445, 151);
            button2.Name = "button2";
            button2.Size = new Size(240, 34);
            button2.TabIndex = 4;
            button2.Text = "get selected item";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(395, 469);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(365, 49);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(445, 545);
            button3.Name = "button3";
            button3.Size = new Size(240, 34);
            button3.TabIndex = 6;
            button3.Text = "view";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(381, 600);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(365, 49);
            textBox3.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(819, 460);
            button4.Name = "button4";
            button4.Size = new Size(201, 50);
            button4.TabIndex = 8;
            button4.Text = "update la linia selectata";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(819, 529);
            button5.Name = "button5";
            button5.Size = new Size(201, 50);
            button5.TabIndex = 9;
            button5.Text = "add";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(819, 599);
            button6.Name = "button6";
            button6.Size = new Size(201, 50);
            button6.TabIndex = 10;
            button6.Text = "delete selected line";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(819, 673);
            button7.Name = "button7";
            button7.Size = new Size(201, 50);
            button7.TabIndex = 11;
            button7.Text = "insert";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(23, 744);
            button8.Name = "button8";
            button8.Size = new Size(257, 62);
            button8.TabIndex = 12;
            button8.Text = "Save updated listbox2 in txt file";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(361, 760);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(396, 46);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 481);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 14;
            label1.Text = "nr de inregistrari in tabel";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(180, 481);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(67, 23);
            textBox4.TabIndex = 15;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 888);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button2;
        private TextBox textBox2;
        private Button button3;
        private TextBox textBox3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private RichTextBox richTextBox1;
        private Label label1;
        private TextBox textBox4;
    }
}
