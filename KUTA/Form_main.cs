using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KUTA
{
    public partial class FormMain : Form
    {
        string connstr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\kuta.mdf;Integrated Security=True;Connect Timeout=30";



        public FormMain()
        {
            InitializeComponent();
            init_text();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        Boolean save_pre_condition()
        {
            int count_all = 0,count_pres=0,count_vice_pres=0,count_gen_sec=0,count_joint_sec=0,count_tres=0,count_social=0,count_pub=0,count_mem=0;
            //CheckBox[] array_all = new CheckBox[] { checkBox_Ahsanuzzaman, checkBox_matin, checkBox_saroar, checkBox_mahmudul, checkBox_rakkibu, checkBox_rafiqul, checkBox_safiqul, checkBox_julfikar, checkBox_mostafizar, checkBox_Khashrul, checkBox_rubel, checkBox_sarwar, checkBox_nabiul, checkBox_nazrul_jointS, checkBox_Sadiqul, checkBox_Sabbir, checkBox_Asish, checkBox_Mustafizur, checkBox_Rabiul, checkBox_Sarif, checkBox_Monjur, checkBox_Atikul, checkBox_Enamul, checkBox_Shovo, checkBox_Afirul, checkBox_Hasan, checkBox_Protab, checkBox_Serajul, checkBox_Harun, checkBox_Azad, checkBox_joyanta, checkBox_anisuzzaman, checkBox_firoz, checkBox_howlader, checkBox_Maniruzzaman, checkBox_mizanur, checkBox_Nazmus, checkBox_Raihan, checkBox_rejaul, checkBox_hefzur, checkBox_mostafa, checkBox_nazrul_mem, checkBox_shafiqur, checkBox_hosna_ara, checkBox_rakib, checkBox_shajalal, checkBox_rumana, checkBox_saikat, checkBox_salma, checkBox_sayeda, checkBox_roziqul, checkBox_Rubaiot };
            CheckBox[] array_pres = new CheckBox[] { checkBox_Ahsanuzzaman, checkBox_matin, checkBox_saroar, checkBox_mahmudul };
            CheckBox[] array_vice_pres = new CheckBox[] { checkBox_rakkibu, checkBox_rafiqul, checkBox_safiqul, checkBox_julfikar };
            CheckBox[] array_gen_sec = new CheckBox[] { checkBox_mostafizar, checkBox_Khashrul, checkBox_rubel, checkBox_sarwar };
            CheckBox[] array_joint_sec = new CheckBox[] { checkBox_nabiul, checkBox_nazrul_jointS, checkBox_Sadiqul, checkBox_Sabbir };
            CheckBox[] array_tres = new CheckBox[] { checkBox_Asish, checkBox_Mustafizur, checkBox_Rabiul, checkBox_Sarif };
            CheckBox[] array_social = new CheckBox[] {checkBox_Monjur, checkBox_Atikul, checkBox_Enamul, checkBox_Shovo};
            CheckBox[] array_pub = new CheckBox[] { checkBox_Afirul, checkBox_Hasan, checkBox_Protab, checkBox_Serajul };
            CheckBox[] array_mem = new CheckBox[] { checkBox_Harun, checkBox_Azad, checkBox_joyanta, checkBox_anisuzzaman, checkBox_firoz, checkBox_howlader, checkBox_Maniruzzaman, checkBox_mizanur, checkBox_Nazmus, checkBox_Raihan, checkBox_rejaul, checkBox_hefzur, checkBox_mostafa, checkBox_nazrul_mem, checkBox_shafiqur, checkBox_hosna_ara, checkBox_rakib, checkBox_shajalal, checkBox_rumana, checkBox_saikat, checkBox_salma, checkBox_sayeda, checkBox_roziqul, checkBox_Rubaiot };
            
            /*
            for (int i = 0; i < array_all.Length; i++)
            {
                if(array_all[i].Checked == true)
                {
                    count_all++;
                }
            }
            */

            for (int i = 0; i < array_pres.Length; i++)
            {
                if (array_pres[i].Checked == true)
                {
                    count_pres++;
                }
            }

            for (int i = 0; i < array_vice_pres.Length; i++)
            {
                if (array_vice_pres[i].Checked == true)
                {
                    count_vice_pres++;
                }
            }

            for (int i = 0; i < array_gen_sec.Length; i++)
            {
                if (array_gen_sec[i].Checked == true)
                {
                    count_gen_sec++;
                }
            }

            for (int i = 0; i < array_joint_sec.Length; i++)
            {
                if (array_joint_sec[i].Checked == true)
                {
                    count_joint_sec++;
                }
            }

            for (int i = 0; i < array_tres.Length; i++)
            {
                if (array_tres[i].Checked == true)
                {
                    count_tres++;
                }
            }

            for (int i = 0; i < array_social.Length; i++)
            {
                if (array_social[i].Checked == true)
                {
                    count_social++;
                }
            }

            for (int i = 0; i < array_pub.Length; i++)
            {
                if (array_pub[i].Checked == true)
                {
                    count_pub++;
                }
            }
            for (int i = 0; i < array_mem.Length; i++)
            {
                if (array_mem[i].Checked == true)
                {
                    count_mem++;
                }
            }
            /*
            if (count_all != 13)
            {
                MessageBox.Show("Select total 13 persons");
                return false;
            }
             */
            if(count_pres != 1)
            {
                MessageBox.Show("Select 1 person for President Position");
                return false;
            }

            else if (count_vice_pres != 1)
            {
                MessageBox.Show("Select 1 person for Vice President Position");
                return false;
            }

            else if (count_gen_sec != 1)
            {
                MessageBox.Show("Select 1 person for General Secretary Position");
                return false;
            }
            else if (count_joint_sec != 1)
            {
                MessageBox.Show("Select 1 person for Joint Secretary Position");
                return false;
            }
            else if (count_tres != 1)
            {
                MessageBox.Show("Select 1 person for Tresurer Position");
                return false;
            }
            else if (count_social != 1)
            {
                MessageBox.Show("Select 1 person for Social Welfare Position");
                return false;
            }
            else if (count_pub != 1)
            {
                MessageBox.Show("Select 1 person for Publication Position");
                return false;
            }

            else if (count_mem != 6)
            {
                MessageBox.Show("Select 6 persons for Member Position");
                return false;
            }
            else
            {
                return true;
            }

        }
 
        private void button_save_Click(object sender, EventArgs e)
        {

            
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand();
            //MessageBox.Show("" + checkBox_Ahsanuzzaman.Checked);

            cmd.CommandText = "INSERT INTO Table_kuta VALUES (' " + checkBox_Ahsanuzzaman.Checked + " ',' " + checkBox_matin.Checked + " ',' " + checkBox_saroar.Checked + " ',' " + checkBox_mahmudul.Checked + " ',' " + checkBox_rakkibu.Checked + " ',' " + checkBox_rafiqul.Checked + " ',' " + checkBox_safiqul.Checked + " ',' " + checkBox_julfikar.Checked + " ',' " + checkBox_mostafizar.Checked + " ',' " + checkBox_Khashrul.Checked + " ',' " + checkBox_rubel.Checked + " ',' " + checkBox_sarwar.Checked + " ',' " + checkBox_nabiul.Checked + " ',' " + checkBox_nazrul_jointS.Checked + " ',' " + checkBox_Sadiqul.Checked + " ',' " + checkBox_Sabbir.Checked + " ',' " + checkBox_Asish.Checked + " ',' " + checkBox_Mustafizur.Checked + " ',' " + checkBox_Rabiul.Checked + " ',' " + checkBox_Sarif.Checked + " ',' " + checkBox_Monjur.Checked + " ',' " + checkBox_Atikul.Checked + " ',' " + checkBox_Enamul.Checked + " ',' " + checkBox_Shovo.Checked + " ',' " + checkBox_Afirul.Checked + " ',' " + checkBox_Hasan.Checked + " ',' " + checkBox_Protab.Checked + " ',' " + checkBox_Serajul.Checked + " ',' " + checkBox_Harun.Checked + " ',' " + checkBox_Azad.Checked + " ',' " + checkBox_joyanta.Checked + " ',' " + checkBox_anisuzzaman.Checked + " ',' " + checkBox_firoz.Checked + " ',' " + checkBox_howlader.Checked + " ',' " + checkBox_Maniruzzaman.Checked + " ',' " + checkBox_mizanur.Checked + " ',' " + checkBox_Nazmus.Checked + " ',' " + checkBox_Raihan.Checked + " ',' " + checkBox_rejaul.Checked + " ',' " + checkBox_hefzur.Checked + " ',' " + checkBox_mostafa.Checked + " ',' " + checkBox_nazrul_mem.Checked + " ',' " + checkBox_shafiqur.Checked + " ',' " + checkBox_hosna_ara.Checked + " ',' " + checkBox_rakib.Checked + " ',' " + checkBox_shajalal.Checked + " ',' " + checkBox_rumana.Checked + " ',' " + checkBox_saikat.Checked + " ',' " + checkBox_salma.Checked + " ',' " + checkBox_sayeda.Checked + " ' , '" + checkBox_roziqul.Checked + " ',' " + checkBox_Rubaiot.Checked + " ')";
            
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;


            conn.Open();
            int return_res = cmd.ExecuteNonQuery();
            if (return_res > 0 && save_pre_condition())
            {
                
                MessageBox.Show("Data saved successfully ");
                diSelectAll();
                show_count();
                
            }
            conn.Close();


            
        }
        String[] checkboxtext = new String[52];
        void init_text()
        {
            CheckBox[] array_i = new CheckBox[] { checkBox_Ahsanuzzaman, checkBox_matin, checkBox_saroar, checkBox_mahmudul, checkBox_rakkibu, checkBox_rafiqul, checkBox_safiqul, checkBox_julfikar, checkBox_mostafizar, checkBox_Khashrul, checkBox_rubel, checkBox_sarwar, checkBox_nabiul, checkBox_nazrul_jointS, checkBox_Sadiqul, checkBox_Sabbir, checkBox_Asish, checkBox_Mustafizur, checkBox_Rabiul, checkBox_Sarif, checkBox_Monjur, checkBox_Atikul, checkBox_Enamul, checkBox_Shovo, checkBox_Afirul, checkBox_Hasan, checkBox_Protab, checkBox_Serajul, checkBox_Harun, checkBox_Azad, checkBox_joyanta, checkBox_anisuzzaman, checkBox_firoz, checkBox_howlader, checkBox_Maniruzzaman, checkBox_mizanur, checkBox_Nazmus, checkBox_Raihan, checkBox_rejaul, checkBox_hefzur, checkBox_mostafa, checkBox_nazrul_mem, checkBox_shafiqur, checkBox_hosna_ara, checkBox_rakib, checkBox_shajalal, checkBox_rumana, checkBox_saikat, checkBox_salma, checkBox_sayeda, checkBox_roziqul, checkBox_Rubaiot };
            for (int i = 0; i < array_i.Length; i++)
            {
                checkboxtext[i] = array_i[i].Text;
                
            }
        }
        void diSelectAll()
        {
            CheckBox[] array_d = new CheckBox[] { checkBox_Ahsanuzzaman, checkBox_matin, checkBox_saroar, checkBox_mahmudul, checkBox_rakkibu, checkBox_rafiqul, checkBox_safiqul, checkBox_julfikar, checkBox_mostafizar, checkBox_Khashrul, checkBox_rubel, checkBox_sarwar, checkBox_nabiul, checkBox_nazrul_jointS, checkBox_Sadiqul, checkBox_Sabbir, checkBox_Asish, checkBox_Mustafizur, checkBox_Rabiul, checkBox_Sarif, checkBox_Monjur, checkBox_Atikul, checkBox_Enamul, checkBox_Shovo, checkBox_Afirul, checkBox_Hasan, checkBox_Protab, checkBox_Serajul, checkBox_Harun, checkBox_Azad, checkBox_joyanta, checkBox_anisuzzaman, checkBox_firoz, checkBox_howlader, checkBox_Maniruzzaman, checkBox_mizanur, checkBox_Nazmus, checkBox_Raihan, checkBox_rejaul, checkBox_hefzur, checkBox_mostafa, checkBox_nazrul_mem, checkBox_shafiqur, checkBox_hosna_ara, checkBox_rakib, checkBox_shajalal, checkBox_rumana, checkBox_saikat, checkBox_salma, checkBox_sayeda, checkBox_roziqul, checkBox_Rubaiot };
            for (int i = 0; i < array_d.Length; i++)
            {
                    array_d[i].Checked = false;
            }
           
        }


        void show_count()
        {

            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand();
            //MessageBox.Show("" + checkBox_Ahsanuzzaman.Checked);

            cmd.CommandText = "Select * from Table_kuta";

            //MessageBox.Show("" + checkBox_Ahsanuzzaman.Checked);

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;
          



            CheckBox[] array_s = new CheckBox[] { checkBox_Ahsanuzzaman, checkBox_matin, checkBox_saroar, checkBox_mahmudul, checkBox_rakkibu, checkBox_rafiqul, checkBox_safiqul, checkBox_julfikar, checkBox_mostafizar, checkBox_Khashrul, checkBox_rubel, checkBox_sarwar, checkBox_nabiul, checkBox_nazrul_jointS, checkBox_Sadiqul, checkBox_Sabbir, checkBox_Asish, checkBox_Mustafizur, checkBox_Rabiul, checkBox_Sarif, checkBox_Monjur, checkBox_Atikul, checkBox_Enamul, checkBox_Shovo, checkBox_Afirul, checkBox_Hasan, checkBox_Protab, checkBox_Serajul, checkBox_Harun, checkBox_Azad, checkBox_joyanta, checkBox_anisuzzaman, checkBox_firoz, checkBox_howlader, checkBox_Maniruzzaman, checkBox_mizanur, checkBox_Nazmus, checkBox_Raihan, checkBox_rejaul, checkBox_hefzur, checkBox_mostafa, checkBox_nazrul_mem, checkBox_shafiqur, checkBox_hosna_ara, checkBox_rakib, checkBox_shajalal, checkBox_rumana, checkBox_saikat, checkBox_salma, checkBox_sayeda, checkBox_roziqul, checkBox_Rubaiot };
            for (int i = 0; i < array_s.Length; i++)
            {
                int count = 0;
                conn.Open();

                System.Data.SqlClient.SqlDataReader dreader;
                dreader = cmd.ExecuteReader();
                while (dreader.Read())
                {
                   // MessageBox.Show(dreader[i + 1].ToString());
                    if ((dreader[i + 1].ToString().Trim()).Equals("True")) 
                    {
                       // MessageBox.Show("inside");
                        count++ ;
                    }

                }
                array_s[i].Text = checkboxtext[i] + "-" + count;
                dreader.Close();
                conn.Close();
            }


        }

        CheckBox lastChecked_pre;
        private void OnPresident(object sender, EventArgs e)
        {

            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked_pre && lastChecked_pre != null) lastChecked_pre.Checked = false;
            lastChecked_pre = activeCheckBox.Checked ? activeCheckBox : null;
        }
        CheckBox lastChecked_Vice;
        private void On_VicePresident(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked_Vice && lastChecked_Vice != null) lastChecked_Vice.Checked = false;
            lastChecked_Vice = activeCheckBox.Checked ? activeCheckBox : null;
        }

        CheckBox lastChecked_gen_sec;
        private void OnGeral_Secretary(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked_gen_sec && lastChecked_gen_sec != null) lastChecked_gen_sec.Checked = false;
            lastChecked_gen_sec = activeCheckBox.Checked ? activeCheckBox : null;
        }

        CheckBox lastChecked_joint_sec;
        private void On_Joint_Secretary(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked_joint_sec && lastChecked_joint_sec != null) lastChecked_joint_sec.Checked = false;
            lastChecked_joint_sec = activeCheckBox.Checked ? activeCheckBox : null;
        }
        CheckBox lastChecked_Treasurer;
        private void On_Treasurer(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked_Treasurer && lastChecked_Treasurer != null) lastChecked_Treasurer.Checked = false;
            lastChecked_Treasurer = activeCheckBox.Checked ? activeCheckBox : null;
        }
        CheckBox lastChecked_On_Social_wal;
        private void On_Social_wal(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked_On_Social_wal && lastChecked_On_Social_wal != null) lastChecked_On_Social_wal.Checked = false;
            lastChecked_On_Social_wal = activeCheckBox.Checked ? activeCheckBox : null;
        }
        CheckBox lastChecked_publication;
        private void on_publicatio(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked_publication && lastChecked_publication != null) lastChecked_publication.Checked = false;
            lastChecked_publication = activeCheckBox.Checked ? activeCheckBox : null;
        }

       
        private void on_member(object sender, EventArgs e)
        {
            int numberChecked = 0;
            CheckBox[] array = new CheckBox[] { checkBox_Harun, checkBox_Azad, checkBox_joyanta, checkBox_anisuzzaman, checkBox_firoz, checkBox_howlader, checkBox_Maniruzzaman, checkBox_mizanur, checkBox_Nazmus, checkBox_Raihan, checkBox_rejaul, checkBox_hefzur, checkBox_mostafa, checkBox_nazrul_mem, checkBox_shafiqur, checkBox_hosna_ara, checkBox_rakib, checkBox_shajalal, checkBox_rumana, checkBox_saikat, checkBox_salma, checkBox_sayeda, checkBox_roziqul, checkBox_Rubaiot };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Checked)
                    numberChecked++;
            }

            if (numberChecked > 6)
            {
                CheckBox activeCheckBox = sender as CheckBox;             
                activeCheckBox.Checked = false;
                MessageBox.Show("You have checked " + numberChecked.ToString() + " checkBoxes in member section. No More Than Six is allowed.");
            }
            else
            {
                // ALL OK!
            }
        }

        private void checkBox_howlader_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Nazmus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_nazrul_mem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_shafiqur_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_export_Click(object sender, EventArgs e)
        {


        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete all saved data ?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(connstr);
                SqlCommand cmd = new SqlCommand();


                cmd.CommandText = "TRUNCATE TABLE Table_kuta";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;


                conn.Open();
                int return_res = cmd.ExecuteNonQuery();
                if (return_res < 0)
                {

                    diSelectAll();
                    show_count();
                    MessageBox.Show("deleted");

                }
                conn.Close();
               
            } 
        }

        private void button_count_Click(object sender, EventArgs e)
        {
            diSelectAll();
            show_count();
            MessageBox.Show("Done");
        }


    }
}
