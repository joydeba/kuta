using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KUTA
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
 
        private void button_save_Click(object sender, EventArgs e)
        {

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


    }
}
