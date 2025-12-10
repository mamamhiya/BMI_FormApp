namespace BMI_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string state;
        }
        static string CalculateBMI(double bmi)
        {
            if (bmi < 18.5)  return "ผอมเกินไป";
            else if (bmi < 24.0) return "น้ำหนักปกติ";
            else if (bmi < 30.0) return "อ้วน";
            else return "อ้วนมาก";
        }

        private void btn_weight_Click(object sender, EventArgs e)
        {
            double weight;
            double height;
            if (double.TryParse(tip_hight.Text, out weight) && double.TryParse(tip_weight.Text, out height))
            {
                double bmi = weight / ((height / 100) * (height / 100));
                string category = CalculateBMI(bmi);
                Result_BMI.Text = $"ค่า BMI ของคุณตือ {bmi:F2}, จัดอยู่ในหมวดหมู่: {category}";
                Result_BMI.Visible = true;

                if (category == "ผอมเกินไป") Result_BMI.BackColor = Color.LightBlue;
                else if (category == "น้ำหนักปกติ") Result_BMI.BackColor = Color.LightGreen;
                else if (category == "อ้วน") Result_BMI.BackColor = Color.Yellow;
                else Result_BMI.BackColor = Color.OrangeRed;


            }
            else
            {
                MessageBox.Show("โปรดกรอกข้อมูลที่ถูกต้อง");
            }
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ยินดีต้อนรับเข้าสู่โปรแกรมคำนวนค่า BMI!");
            Result_BMI.Visible = false;

        }
    }
}
