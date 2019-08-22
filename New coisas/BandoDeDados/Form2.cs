using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BandoDeDados
{
    public partial class Form2 : Form

    {
        byte var;
        MySqlConnection con = new MySqlConnection("server=143.106.241.1;port=3306;User ID=cl18152;database=cl18152;password=cl*07062002");
        MySqlCommand COMANDO = new MySqlCommand();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
               

               
                MySqlCommand insere = new MySqlCommand("insert into Alunos(idAlunos, nomeAlunos, turmaAlunos,Imagem)values(" + textBox1.Text + ",'" + textBox2.Text + "','" +
                comboBox1.SelectedItem.ToString() + "', @foto)", con);
                insere.Parameters.AddWithValue("foto", ConverterFotoParaByteArray());
                insere.ExecuteNonQuery();
                MessageBox.Show("Gravação realizada com sucesso");
               
               

                
                //con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        

        }

        private byte[] ConverterFotoParaByteArray()
        {
            using (var stream = new System.IO.MemoryStream())
            {
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                MessageBox.Show("Conectado");
                con.Close();
            }
            catch
            {
                MessageBox.Show("Falha na conexeção");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog carrega_foto = new OpenFileDialog();
            carrega_foto.Filter = "jpg|*.jpg";

            if (carrega_foto.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.ImageLocation = carrega_foto.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }


        }

      

       /*public static void AddEmployee(string photoFilePath, byte[] teste)
        {



            MySqlConnection conexao;
            string caminho = "server = 143.106.241.1; port = 3306; User ID = cl18152; database = cl18152; password = cl * 07062002";

            conexao = new MySqlConnection(caminho);
            conexao.Open();

            string sql = "INSERT INTO Alunos (Imagem) " + "values(pictureBox1);";
            MySqlCommand comandos = new MySqlCommand("insert into Imagem)values(" + pictureBox1 + ")"); 

            byte[] photo = teste; //GetPhoto(photoFilePath);

            comandos.Parameters.AddWithValue("pictureBox1", photo).Value = photo;
        }*/
        
        
    }
}
