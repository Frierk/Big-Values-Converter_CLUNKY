namespace Big_Values_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool altmode = false;
        double texbox3value;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && altmode == false)
            {
                textBox3.Text = Math.Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble(comboBox1.SelectedItem) - Convert.ToDouble(comboBox2.SelectedItem))+ " X" + textBox1.Text;
                texbox3value = Math.Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble(comboBox1.SelectedItem) - Convert.ToDouble(comboBox2.SelectedItem));
                textBox2.Text = (Convert.ToDouble(texbox3value) * Math.Pow(Convert.ToInt32(textBox1.Text), Convert.ToDouble(comboBox2.SelectedItem))).ToString();
            }
            if (textBox1.Text != "" && altmode != false)
            {
                textBox3.Text = Math.Pow(Convert.ToInt32(textBox1.Text,2), Convert.ToDouble(comboBox1.SelectedItem) - Convert.ToDouble(comboBox2.SelectedItem))+ " X" + Convert.ToInt32(textBox1.Text, 2);
                texbox3value = Math.Pow(Convert.ToInt32(textBox1.Text, 2), Convert.ToDouble(comboBox1.SelectedItem) - Convert.ToDouble(comboBox2.SelectedItem));
                textBox2.Text = (Convert.ToDouble(texbox3value) * Math.Pow(Convert.ToInt32(textBox1.Text, 2),Convert.ToDouble(comboBox2.SelectedItem))).ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            altmode = true;
            label4.Text = "Mode = Binary";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            altmode = false;
            label4.Text = "Mode = Normal";
        }
    }
}
