using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO; 


namespace KUTA
{
    public partial class FormMain : Form
    {

        string connstr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + Environment.CurrentDirectory + "\\kuta.mdf;Integrated Security=True;Connect Timeout=30";



        public FormMain()
        {
            InitializeComponent();
            init_text();
            //MessageBox.Show("" + Environment.CurrentDirectory);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        Boolean save_pre_condition()
        {
            int count_all = 0,count_pres=0,count_vice_pres=0,count_gen_sec=0,count_joint_sec=0,count_tres=0,count_social=0,count_pub=0,count_mem=0;
            CheckBox[] array_all = new CheckBox[] { checkBox_Ahsanuzzaman, checkBox_ashraful_alam, checkBox_sarder_safiqul, checkBox_hefzur_rahman,  checkBox_nazmus_sadath, checkBox_sarwar_jahan, checkBox_asish_kumar, checkBox_sarif_mohammad, checkBox_Eijaz, checkBox_Enamul, checkBox_sayda, checkBox_imran, checkBox_Nihar, checkBox_zahid, checkBox_Arif, checkBox_manir, checkBox_Shamim, checkBox_serajul, checkBox_mahadi, checkBox_salauddin, checkBox_Nazrul, checkBox_Shariful, checkBox_molla_shafiqur, checkBox_remme, checkBox_motasim, checkBox_tuhin };
            CheckBox[] array_pres = new CheckBox[] { checkBox_Ahsanuzzaman, checkBox_ashraful_alam };
            CheckBox[] array_vice_pres = new CheckBox[] { checkBox_sarder_safiqul, checkBox_hefzur_rahman };
            CheckBox[] array_gen_sec = new CheckBox[] { checkBox_nazmus_sadath, checkBox_sarwar_jahan };
            CheckBox[] array_joint_sec = new CheckBox[] { checkBox_asish_kumar, checkBox_sarif_mohammad };
            CheckBox[] array_tres = new CheckBox[] { checkBox_Eijaz, checkBox_Enamul };
            CheckBox[] array_social = new CheckBox[] {checkBox_sayda, checkBox_imran};
            CheckBox[] array_pub = new CheckBox[] { checkBox_Nihar, checkBox_zahid };
            CheckBox[] array_mem = new CheckBox[] { checkBox_Arif, checkBox_manir, checkBox_Shamim, checkBox_serajul, checkBox_mahadi, checkBox_salauddin, checkBox_Nazrul, checkBox_Shariful, checkBox_molla_shafiqur, checkBox_remme, checkBox_motasim, checkBox_tuhin};
            
            
            for (int i = 0; i < array_all.Length; i++)
            {
                if(array_all[i].Checked == true)
                {
                    count_all++;
                }
            }
            

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
            
            if (count_all < 1)
            {
                MessageBox.Show("Select at least one person");
                return false;
            }
            
            else if(count_pres > 1)
            {
                MessageBox.Show("Select 1 person for President Position");
                return false;
            }

            else if (count_vice_pres > 1)
            {
                MessageBox.Show("Select 1 person for Vice President Position");
                return false;
            }

            else if (count_gen_sec > 1)
            {
                MessageBox.Show("Select 1 person for General Secretary Position");
                return false;
            }
            else if (count_joint_sec > 1)
            {
                MessageBox.Show("Select 1 person for Joint Secretary Position");
                return false;
            }
            else if (count_tres > 1)
            {
                MessageBox.Show("Select 1 person for Tresurer Position");
                return false;
            }
            else if (count_social > 1)
            {
                MessageBox.Show("Select 1 person for Social Welfare Position");
                return false;
            }
            else if (count_pub > 1)
            {
                MessageBox.Show("Select 1 person for Publication Position");
                return false;
            }

            else if (count_mem > 6)
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

            cmd.CommandText = "INSERT INTO Table_kuta VALUES (' " + checkBox_Ahsanuzzaman.Checked + " ',' " + checkBox_ashraful_alam.Checked  + " ',' " + checkBox_sarder_safiqul.Checked + " ',' " + checkBox_hefzur_rahman.Checked  + " ',' " + checkBox_nazmus_sadath.Checked + " ',' " + checkBox_sarwar_jahan.Checked   + " ',' " + checkBox_asish_kumar.Checked + " ',' " + checkBox_sarif_mohammad.Checked  + " ',' " + checkBox_Eijaz.Checked + " ',' " + checkBox_Enamul.Checked  + " ',' " + checkBox_sayda.Checked + " ',' " + checkBox_imran.Checked  + " ',' " + checkBox_Nihar.Checked + " ',' " + checkBox_zahid.Checked   + " ',' " + checkBox_Arif.Checked + " ',' " + checkBox_manir.Checked + " ',' " + checkBox_Shamim.Checked + " ',' " + checkBox_serajul.Checked + " ',' " + checkBox_mahadi.Checked + " ',' " + checkBox_salauddin.Checked   + " ',' " + checkBox_Nazrul.Checked + " ',' " + checkBox_Shariful.Checked + " ',' " + checkBox_molla_shafiqur.Checked + " ',' " + checkBox_remme.Checked + " ',' " + checkBox_motasim.Checked + " ',' " + checkBox_tuhin.Checked  + " ')";
            
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;


            conn.Open();
            if (save_pre_condition())
            {
                int return_res = cmd.ExecuteNonQuery();
                if (return_res > 0)
                {

                    MessageBox.Show("Data saved successfully ");
                    diSelectAll();
                    show_count();

                }
            }
            conn.Close();


            
        }
        String[] checkboxtext = new String[52];
        void init_text()
        {
            CheckBox[] array_i = new CheckBox[] { checkBox_Ahsanuzzaman, checkBox_ashraful_alam,  checkBox_sarder_safiqul, checkBox_hefzur_rahman, checkBox_nazmus_sadath, checkBox_sarwar_jahan, checkBox_asish_kumar, checkBox_sarif_mohammad, checkBox_Eijaz, checkBox_Enamul, checkBox_sayda, checkBox_imran, checkBox_Nihar, checkBox_zahid, checkBox_Arif, checkBox_manir, checkBox_Shamim, checkBox_serajul, checkBox_mahadi, checkBox_salauddin, checkBox_Nazrul, checkBox_Shariful, checkBox_molla_shafiqur, checkBox_remme, checkBox_motasim, checkBox_tuhin};
            for (int i = 0; i < array_i.Length; i++)
            {
                checkboxtext[i] = array_i[i].Text;
                
            }
        }
        void diSelectAll()
        {
            CheckBox[] array_d = new CheckBox[] { checkBox_Ahsanuzzaman, checkBox_ashraful_alam, checkBox_sarder_safiqul, checkBox_hefzur_rahman, checkBox_nazmus_sadath, checkBox_sarwar_jahan, checkBox_asish_kumar, checkBox_sarif_mohammad, checkBox_Eijaz, checkBox_Enamul,  checkBox_sayda, checkBox_imran, checkBox_Nihar, checkBox_zahid, checkBox_Arif, checkBox_manir, checkBox_Shamim, checkBox_serajul, checkBox_mahadi, checkBox_salauddin, checkBox_Nazrul, checkBox_Shariful, checkBox_molla_shafiqur, checkBox_remme, checkBox_motasim, checkBox_tuhin};
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
          



            CheckBox[] array_s = new CheckBox[] { checkBox_Ahsanuzzaman, checkBox_ashraful_alam, checkBox_sarder_safiqul, checkBox_hefzur_rahman, checkBox_nazmus_sadath, checkBox_sarwar_jahan, checkBox_asish_kumar, checkBox_sarif_mohammad, checkBox_Eijaz, checkBox_Enamul, checkBox_sayda, checkBox_imran, checkBox_Nihar, checkBox_zahid, checkBox_Arif, checkBox_manir, checkBox_Shamim, checkBox_serajul, checkBox_mahadi, checkBox_salauddin, checkBox_Nazrul, checkBox_Shariful, checkBox_molla_shafiqur, checkBox_remme, checkBox_motasim, checkBox_tuhin};
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
            CheckBox[] array = new CheckBox[] { checkBox_Arif, checkBox_manir, checkBox_Shamim, checkBox_serajul, checkBox_mahadi, checkBox_salauddin, checkBox_Nazrul, checkBox_Shariful, checkBox_molla_shafiqur, checkBox_remme, checkBox_motasim, checkBox_tuhin };
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
                SqlConnection conn = new SqlConnection(connstr);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from Table_kuta";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;

                DataTable dt = new DataTable();

                //Add Datacolumn


                CheckBox[] array_all = new CheckBox[] { checkBox_Ahsanuzzaman, checkBox_ashraful_alam, checkBox_sarder_safiqul, checkBox_hefzur_rahman, checkBox_nazmus_sadath, checkBox_sarwar_jahan,  checkBox_asish_kumar, checkBox_sarif_mohammad, checkBox_Eijaz, checkBox_Enamul, checkBox_sayda, checkBox_imran, checkBox_Nihar, checkBox_zahid, checkBox_Arif, checkBox_manir, checkBox_Shamim, checkBox_serajul, checkBox_mahadi, checkBox_salauddin, checkBox_Nazrul, checkBox_Shariful, checkBox_molla_shafiqur, checkBox_remme, checkBox_motasim, checkBox_tuhin };

                DataColumn workCol = dt.Columns.Add("" + array_all[0].Text, typeof(String));
                for (int i = 1; i < array_all.Length; i++)
                {
                    dt.Columns.Add("" + array_all[i].Text, typeof(String));
                }

                //dt.Columns.Add("LastName", typeof(String));
                //dt.Columns.Add("Blog", typeof(String));
                //dt.Columns.Add("City", typeof(String));
                //dt.Columns.Add("Country", typeof(String));
                
                //Add in the datarow
                
                


                    conn.Open();

                    System.Data.SqlClient.SqlDataReader dreader;
                    dreader = cmd.ExecuteReader();
                    while (dreader.Read())
                    {
                        DataRow newRow = dt.NewRow();
                        for (int i = 0; i < array_all.Length; i++)
                        {


                            newRow["" + array_all[i].Text] = ""+dreader[i + 1].ToString().Trim();

                        }
                        dt.Rows.Add(newRow);
                    }
                  
                    dreader.Close();
                    conn.Close();
                    
               
                
                //newRow["firstname"] = "Arun";
                //newRow["lastname"] = "Prakash";
                //newRow["Blog"] = "http://royalarun.blogspot.com/";
                //newRow["city"] = "Coimbatore";
                //newRow["country"] = "India";

               

               
                

                try
                {
                    StreamWriter wr = new StreamWriter("" + Environment.CurrentDirectory + "\\kuta.xls");

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        wr.Write(dt.Columns[i].ToString().ToUpper() + "\t");
                    }

                    wr.WriteLine();

                    //write rows to excel file
                    for (int i = 0; i < (dt.Rows.Count); i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            if (dt.Rows[i][j] != null)
                            {
                                wr.Write(Convert.ToString(dt.Rows[i][j]) + "\t");
                            }
                            else
                            {
                                wr.Write("\t");
                            }
                        }
                        //go to next line
                        wr.WriteLine();
                    }
                    //close file
                    wr.Close();
                    MessageBox.Show("Done");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Another Program Using Excel file");
                }
            
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

        private void label_Treasurer_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_all_Click(object sender, EventArgs e)
        {

        }

        private void label_Socialwalfareandcs_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_main_Click(object sender, EventArgs e)
        {

        }

        private void label_PublicationSec_Click(object sender, EventArgs e)
        {

        }

        private void label_JointSecretary_Click(object sender, EventArgs e)
        {

        }

        private void General_Secretary_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_motasim_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_remme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_molla_shafiqur_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Shariful_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_mahadi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_serajul_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Shamim_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_manir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Arif_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label_Member_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_sarif_mohammad_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_asish_kumar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_zahid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Nihar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_sarwar_jahan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_nazmus_sadath_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_imran_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_sayda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_hefzur_rahman_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_sarder_safiqul_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Enamul_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Eijaz_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label_President_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_ashraful_alam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Ahsanuzzaman_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabControl_main_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
