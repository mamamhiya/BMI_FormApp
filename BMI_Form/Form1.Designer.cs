namespace BMI_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            label1 = new Label();
            tip_hight = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tip_weight = new TextBox();
            btn_weight = new Button();
            Result_BMI = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 4, 0, 4);
            menuStrip1.Size = new Size(1475, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Location = new Point(70, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(325, 36);
            label1.TabIndex = 1;
            label1.Text = "โปรแกรมคำนวนค่าดัชนีมวลกาย - BMI";
            // 
            // tip_hight
            // 
            tip_hight.Location = new Point(186, 26);
            tip_hight.Name = "tip_hight";
            tip_hight.Size = new Size(390, 33);
            tip_hight.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 26);
            label2.Name = "label2";
            label2.Size = new Size(163, 36);
            label2.TabIndex = 4;
            label2.Text = "กรอกค่า ความสูง :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 91);
            label3.Name = "label3";
            label3.Size = new Size(156, 36);
            label3.TabIndex = 6;
            label3.Text = "กรอกค่า น้ำหนัก :";
            // 
            // tip_weight
            // 
            tip_weight.Location = new Point(186, 94);
            tip_weight.Name = "tip_weight";
            tip_weight.Size = new Size(390, 33);
            tip_weight.TabIndex = 7;
            // 
            // btn_weight
            // 
            btn_weight.Location = new Point(604, 80);
            btn_weight.Name = "btn_weight";
            btn_weight.Size = new Size(110, 47);
            btn_weight.TabIndex = 8;
            btn_weight.Text = "ok";
            btn_weight.UseVisualStyleBackColor = true;
            btn_weight.Click += btn_weight_Click;
            // 
            // Result_BMI
            // 
            Result_BMI.BackColor = Color.WhiteSmoke;
            Result_BMI.Location = new Point(17, 152);
            Result_BMI.Name = "Result_BMI";
            Result_BMI.Size = new Size(519, 47);
            Result_BMI.TabIndex = 10;
            Result_BMI.Text = "คำตอบ";
            // 
            // label4
            // 
            label4.Location = new Point(70, 97);
            label4.Name = "label4";
            label4.Size = new Size(530, 133);
            label4.TabIndex = 11;
            label4.Text = "ค่า BMI คือค่าดัชนีที่ใช้ชี้วัดความสมดุลของน้ำหนักตัว (กิโลกรัม) และส่วนสูง (เซนติเมตร) ซึ่งสามารถระบุได้ว่า ตอนนี้รูปร่างของคนคนนั้นอยู่ในระดับใด ตั้งแต่อ้วนมากไปจนถึงผอมเกินไป";
            // 
            // label5
            // 
            label5.Location = new Point(70, 307);
            label5.Name = "label5";
            label5.Size = new Size(977, 122);
            label5.TabIndex = 12;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 416);
            label6.Name = "label6";
            label6.Size = new Size(167, 36);
            label6.TabIndex = 13;
            label6.Text = "อ้วน = 25.0 - 29.9";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 261);
            label7.Name = "label7";
            label7.Size = new Size(199, 36);
            label7.TabIndex = 14;
            label7.Text = "อ้วนมาก = 30.0 ขึ้นไป ";
            // 
            // label8
            // 
            label8.Location = new Point(70, 452);
            label8.Name = "label8";
            label8.Size = new Size(971, 79);
            label8.TabIndex = 15;
            label8.Text = resources.GetString("label8.Text");
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 535);
            label9.Name = "label9";
            label9.Size = new Size(287, 36);
            label9.TabIndex = 16;
            label9.Text = "น้ำหนักปกติ เหมาะสม = 18.6 - 24";
            // 
            // label10
            // 
            label10.Location = new Point(70, 582);
            label10.Name = "label10";
            label10.Size = new Size(977, 104);
            label10.TabIndex = 17;
            label10.Text = resources.GetString("label10.Text");
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(70, 663);
            label11.Name = "label11";
            label11.Size = new Size(230, 36);
            label11.TabIndex = 18;
            label11.Text = "ผอมเกินไป = น้อยกว่า 18.5";
            // 
            // label12
            // 
            label12.Location = new Point(70, 699);
            label12.Name = "label12";
            label12.Size = new Size(971, 121);
            label12.TabIndex = 19;
            label12.Text = resources.GetString("label12.Text");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Result_BMI);
            groupBox1.Controls.Add(btn_weight);
            groupBox1.Controls.Add(tip_weight);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tip_hight);
            groupBox1.Location = new Point(606, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(835, 200);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1475, 1055);
            Controls.Add(groupBox1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Chakra Petch", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label label1;
        private TextBox tip_hight;
        private Label label2;
        private Button btn_hight;
        private Label label3;
        private TextBox tip_weight;
        private Button btn_weight;
        private Label Result_BMI;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private GroupBox groupBox1;
    }
}
