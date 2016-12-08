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
    public partial class AddForm : Form
    {
        private Character OldCharacter { get; set; }
        public static Character Character { get; set; }

        CheckBox[] Success;
        CheckBox[] Fail;

        private bool IsEditing
        {
            get; set;
        }


        public AddForm(Character c)
        {
            InitializeComponent();

            OldCharacter = c;
            Character = c;

            Name_Input.Text = Character.Name;
            Dex_Input.Text = Character.Initiative.ToString();
            HP_Input.Text = Character.HP.ToString();
            MaxHP_Input.Text = Character.MaxHP.ToString();
            TempHP_Input.Text = Character.TempHP.ToString();


            IsEditing = true;
            CalculateHP_Button.Visible = true;

            Success = new CheckBox[] { checkBox1, checkBox2, checkBox5 };
            Fail = new CheckBox[] { checkBox6, checkBox4, checkBox3 };

            for (int i = 0; i < c.DeathSaves_Fail; i++)
            {
                Fail[i].Checked = true;
            }

            for (int i = 0; i < c.DeathSaves_Success; i++)
            {
                Success[i].Checked = true;
            }

            if (c.HP == 0)
            {
                HP_Input.BackColor = Color.Red;
            }

        }

        public AddForm()
        {
            InitializeComponent();
            Character = new Character();

            IsEditing = false;

            Success = new CheckBox[] { checkBox1, checkBox2, checkBox5 };
            Fail = new CheckBox[] { checkBox6, checkBox4, checkBox3 };
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Character.Name = Name_Input.Text.Trim();
            int dex, hp, tempHP = 0;
            int maxHP = 0;

            bool noErrors = true;

            #region errorCheck
            if (!int.TryParse(Dex_Input.Text.Trim(), out dex))
            {
                Dex_Warning_Label.Visible = true;
                noErrors = false;
            }

            if (Name_Input.Text.Trim().Length == 0)
            {
                Name_Warning_Label.Visible = true;
                noErrors = false;

            }

            if (!int.TryParse(HP_Input.Text.Trim(), out hp) || !int.TryParse(MaxHP_Input.Text.Trim(), out maxHP))
            {
                HP_Warning_Label.Text = "Must be an integer";
                HP_Warning_Label.Visible = true;
                noErrors = false;

            }
            else if (hp < 0 || maxHP < 0)
            {
                HP_Warning_Label.Text = "Can't be -1";
                HP_Warning_Label.Visible = true;
                noErrors = false;

            }

            if (hp > maxHP)
            {
                hp = maxHP;
            }

            if (!int.TryParse(TempHP_Input.Text.Trim(), out tempHP))
            {
                TempHP_Warning_Label.Text = "Must be an integer";
                HP_Warning_Label.Visible = true;
                noErrors = false;

            }
            else if (tempHP < 0)
            {
                HP_Warning_Label.Text = "Can't be -1";
                HP_Warning_Label.Visible = true;
                noErrors = false;
            }

            #endregion
            if (noErrors)
            {
                Character.Initiative = dex;
                Character.HP = hp;
                Character.MaxHP = maxHP;
                Character.TempHP = tempHP;
                Character.DeathSaves_Fail = Fail.Where(x => x.Checked).Count();
                Character.DeathSaves_Success = Success.Where(x => x.Checked).Count();

                if (IsEditing)
                {
                    MainForm.InitiativeList[MainForm.InitiativeList.IndexOf(OldCharacter)] = Character;
                }
                else
                {
                    MainForm.InitiativeList.Add(Character);
                }


                //Update the ResultList
                var list = MainForm.InitiativeList.ToList();

                MainForm.ResultList.Clear();
                list.Sort((a, b) => -1 * a.CompareTo(b));

                foreach (var item in list)
                {
                    MainForm.ResultList.Add(item);
                }

                this.Close();
            }
        }

        private void CalculateHP_Button_Click(object sender, EventArgs e)
        {
            new DamageForm(this).ShowDialog();
        }

        public void UpdateScreen(int HP, int TempHP)
        {
            this.HP_Input.Text = HP.ToString();
            this.TempHP_Input.Text = TempHP.ToString();
            //TODO: Checkboxes?

            if (HP == 0)
            {
                HP_Input.BackColor = Color.Red;
                //TODO: Add death saves
            }
        }
    }
}
