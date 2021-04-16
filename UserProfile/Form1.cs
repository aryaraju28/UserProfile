using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserProfile
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=RAED_COMPUTER\\SQLEXPRESS;Database=StudentSystem;Trusted_Connection=True;";
        string imgLoc;
        private string gender;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
                dlg.Title = "Select Student Picture";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pictureProfile.ImageLocation = imgLoc;




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] img = null;
            FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            string name = txtName.Text;
            string Address = txtAddress.Text;
            //string gender = string.Empty;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("StudentSave", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Name", txtName.Text);
            command.Parameters.AddWithValue("Address", txtAddress.Text);
            if (radioMale.Checked == true)
            {
                command.Parameters.AddWithValue("Gender", "M");

            }
            if (radioFemale.Checked == true)
            {
                command.Parameters.AddWithValue("Gender", "F");
            }

            command.Parameters.AddWithValue("Sslc", checkBox10.Checked);
            command.Parameters.AddWithValue("PlusTwo", checkBoxPlusTwo.Checked);
            command.Parameters.AddWithValue("Ug", checkBoxUG.Checked);
            command.Parameters.AddWithValue("Pg", checkBoxPG.Checked);
            command.Parameters.AddWithValue("Image", img);
            command.ExecuteNonQuery();
            connection.Close();

            checkBox10.Checked = checkBoxPlusTwo.Checked = checkBoxUG.Checked = checkBoxPG.Checked = false;
            radioFemale.Checked = radioMale.Checked = false;
            MessageBox.Show("Saved");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand command = new SqlCommand("StudentDetails", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Name", txtName.Text);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //if (reader.Read() == true)
                    //{
                    txtAddress.Text = reader["Address"].ToString();
                    if (reader["Gender"].ToString() == "M")
                    {
                        radioMale.Checked = true;
                    }
                     if (reader["Gender"].ToString() == "F")
                    {
                        radioFemale.Checked = true;
                    }
                   if(reader["Sslc"].ToString()=="1")
                    {
                        checkBox10.Checked = true;

                    }
                   if(reader["PlusTwo"].ToString()=="1")
                    {
                        checkBoxPlusTwo.Checked = true;
                    }
                   if(reader["Ug"].ToString()=="1")
                    {
                        checkBoxUG.Checked = true;
                    }
                   if(reader["Pg"].ToString()=="1")
                    {
                        checkBoxPG.Checked = true;
                    }
                }
                //while (reader.Read())
                //{
                //    checkBox10.Checked = Convert.ToBoolean(reader.GetByte(reader.GetOrdinal("Sslc")));
                //    checkBoxPlusTwo.Checked = Convert.ToBoolean(reader.GetByte(reader.GetOrdinal("PlusTwo")));
                //    checkBoxUG.Checked = Convert.ToBoolean(reader.GetByte(reader.GetOrdinal("Ug")));
                //    checkBoxPG.Checked = Convert.ToBoolean(reader.GetByte(reader.GetOrdinal("Pg")));
                //}
                //reader.Close();

                //con.Close();
                //}
                //while (reader.Read())
                //{

                //}
                //reader.Close();
                //con.Close()









                //if (Convert.ToBoolean(reader["Sslc"]) == true) ;
                //{
                //    checkBox10.Checked = true;

                //}
                //if (Convert.ToBoolean(reader["PlusTwo"]) == true) ;
                //{
                //    checkBoxPlusTwo.Checked = true;

                //}
                //if (Convert.ToBoolean(reader["Ug"]) == true) ;
                //{
                //    checkBoxUG.Checked = true;

                //}
                //if (Convert.ToBoolean(reader["Pg"]) == true) ;
                //{
                //    checkBoxPG.Checked = true;

                //}




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

    



