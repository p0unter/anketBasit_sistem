namespace yarisma_proc_dem1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int soru = 0, dogru = 0, eksi = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "Sonraki ->";
            soru++;
            button5.Visible = false;
            label6.Text = Convert.ToString(soru);
            dogru = Convert.ToInt32(label3.Text);
            eksi = Convert.ToInt32(label4.Text);
            if (soru == 1)
            {
                richTextBox1.Text = "RockStar Games' mi, Blazard, Activision' mu?";
                abt.Text = "RockStar Games";
                bbt.Text = "Blazzard";
                cbt.Text = "Activision";
                dbt.Text = "Bilmiyorum.";
                null1.Text = cbt.Text;
            }

            if (soru == 2)
            {
                richTextBox1.Text = "CS:GO' mu, Valorantmý?";
                abt.Text = "Valorant";
                bbt.Text = "CS:GO";
                cbt.Text = "Ýkiside deðil!";
                dbt.Text = "Bilmiyorum.";
                null1.Text = bbt.Text;
            }

            if (soru == 3)
            {
                richTextBox1.Text = "Steam' mý, Epic Games' mi?";
                abt.Text = "Epic Games";
                bbt.Text = "Steam";
                cbt.Text = "Ýkiside deðil!";
                dbt.Text = "Bilmiyorum.";
                button5.Text = "Sonuçlar:";
                null1.Text = cbt.Text;
            }
            if (soru == 4)
            {
                soru--;
                doint.Visible = true;
                yaint.Visible = true;
                doint.Text = label3.Text;
                yaint.Text = label6.Text;
                dotxt.Visible = true;
                yatxt.Visible = true;
                richTextBox1.Visible = false;
                button5.Visible = false;
                abt.Visible = false;
                bbt.Visible = false;
                cbt.Visible = false;
                dbt.Visible = false;
                label3.Visible = false;
                label6.Visible = false;
                sorulbl.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label2.Visible = false;
            }
            abt.Enabled = true;
            bbt.Enabled = true;
            cbt.Enabled = true;
            dbt.Enabled = true;
        }


        private void abt_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            null2.Text = abt.Text;

            if (null1.Text == null2.Text)
            {
                dogru++;
                label3.Text = dogru.ToString();
                MessageBox.Show("Doðru abm!");
            }
            else
            {
                eksi++;
                label4.Text = eksi.ToString();
                MessageBox.Show("Yanlýþ abm!");
            }
            abt.Enabled = false;
            bbt.Enabled = false;
            cbt.Enabled = false;
            dbt.Enabled = false;
        }

        private void bbt_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            null2.Text = bbt.Text;
            if (null1.Text == null2.Text)
            {
                dogru++;
                label3.Text = dogru.ToString();
                MessageBox.Show("Doðru abm!");
            }
            else
            {
                eksi++;
                label4.Text = eksi.ToString();
                MessageBox.Show("Yanlýþ abm!");
            }
            abt.Enabled = false;
            bbt.Enabled = false;
            cbt.Enabled = false;
            dbt.Enabled = false;
        }

        private void cbt_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            null2.Text = cbt.Text;
            if (null1.Text == null2.Text)
            {
                dogru++;
                label3.Text = dogru.ToString();
                MessageBox.Show("Doðru abm!");
            }
            else
            {
                eksi++;
                label4.Text = eksi.ToString();
                MessageBox.Show("Yanlýþ abm!");
            }
            abt.Enabled = false;
            bbt.Enabled = false;
            cbt.Enabled = false;
            dbt.Enabled = false;
        }

        private void dbt_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            null2.Text = dbt.Text;
            if (null1.Text == null2.Text)
            {
                dogru++;
                label3.Text = dogru.ToString();
                MessageBox.Show("Doðru abm!");
            }
            else
            {
                eksi++;
                label4.Text = eksi.ToString();
                MessageBox.Show("Yanlýþ abm!");
            }
            abt.Enabled = false;
            bbt.Enabled = false;
            cbt.Enabled = false;
            dbt.Enabled = false;
        }
    }
}