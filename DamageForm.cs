using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitiativeTracker
{
    public partial class DamageForm : Form
    {
        private AddForm form;

        public DamageForm(AddForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dmg;

            if (!int.TryParse(dmg_input.Text.Trim(), out dmg))
            {
                Input_warning_label.Text = "Must be an integer";
                Input_warning_label.Visible = true;
            }
            else if (dmg < 0)
            {
                Input_warning_label.Text = "Can't be < 0";
                Input_warning_label.Visible = true;
            }

            AddForm.Character.TempHP -= dmg;
            if (AddForm.Character.TempHP < 0)
            {
                //The tempHP has now been drained, actual HP should be damaged
                dmg = 0 - AddForm.Character.TempHP.Value;
                AddForm.Character.TempHP = 0;

                AddForm.Character.HP -= dmg;
                if (AddForm.Character.HP < 1)
                {
                    //Charachter is down
                    AddForm.Character.HP = 0; //Reset this if implementing TODO

                    //TODO: Check if character is dead(Take more damage than his remaining HP + max hp
                }
            }

            form.UpdateScreen(AddForm.Character.HP.Value, AddForm.Character.TempHP.Value);
            this.Close();
        }
    }
}
