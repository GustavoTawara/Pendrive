using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BandoDeDados
{
    public partial class Form3 : Form
    {
        MySqlConnection con = new MySqlConnection("server=143.106.241.1;port=3306;User ID=cl18152;database=cl18152;password=cl*07062002");
        public Form3()
        {
            InitializeComponent();
            try
            {
                con.Open();
                MessageBox.Show("Conectado com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            con.Open();
            MySqlCommand insere = new MySqlCommand("insert into Palestrantes(nomePalestra,nomePalestrante,dia,hora,email)values('"+ textBox1.Text + "','" + textBox2.Text + "','" +
            textBox3.Text + "','"+textBox4.Text+"','"+textBox5.Text+"')", con);
            insere.ExecuteNonQuery();
            MessageBox.Show("Gravação realizada com sucesso");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
