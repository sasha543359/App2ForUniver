namespace App2ForUniver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Alege failul txt";
                openFileDialog.Filter = "Failuri txt (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog.FileName;
                }

                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(lines);

                    listBox2.Items.Clear();
                    listBox2.Items.AddRange(lines);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greseala in timpul citirii failului: " + ex.Message, "Greseala");
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
                textBox2.Text = listBox2.SelectedItem.ToString();
            else
                MessageBox.Show("Alege elemt din lista", "Greseala");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox2.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1) // Verificam daca elementui ales
            {
                int index = listBox2.SelectedIndex;
                listBox2.Items.Insert(index, textBox3.Text);
            }
            else
                MessageBox.Show("introduceti text in camp", "Greseala");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox3.Text))
                listBox2.Items[listBox2.SelectedIndex] = textBox3.Text;
            else
                MessageBox.Show("introduceti text in camp", "Greseala");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show(
                    "Sunteti siguri ca doriti sa stergeti inregistrarea ?",
                    "Acceptati stergerea",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Alegeti elementul pentru stergere !", "Greseala", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Alegeti locul pentru salvare";
                saveFileDialog.Filter = "Failuri TXT (*.txt)|*.txt|Toate failurile (*.*)|*.*";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllLines(saveFileDialog.FileName, listBox2.Items.Cast<string>());

                        richTextBox1.Text = saveFileDialog.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Greseala in timpul salvarii: " + ex.Message, "Greseala");
                    }
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}