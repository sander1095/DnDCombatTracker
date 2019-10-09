using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DnDCombatTracker.Core;

namespace DnDCombatTracker
{
    public partial class OverviewForm : Form
    {
        private Dictionary<CheckBox, Conditions> ConditionsDictionary;

        private CheckBox[] ListDeathSavesSuccess;
        private CheckBox[] ListDeathSavesFail;
        private CheckBox[] DetailDeathSavesSuccess;
        private CheckBox[] DetailDeathSavesFail;

        private CombatManagerService _combatManagerService { get; set; }

        public OverviewForm()
        {
            InitializeComponent();

            _combatManagerService = new CombatManagerService();

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                this.Text = string.Format("D&D 5e Combat Tracker - v{0}",
                    ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4));
            }

            InitiativeList.DataSource = _combatManagerService.Combatants;

            ListDeathSavesSuccess = new[] { Success1ListCheckbox, Success2ListCheckbox, Success3ListCheckbox };
            ListDeathSavesFail = new[] { Fail1ListCheckbox, Fail2ListCheckbox, Fail3ListCheckbox };
            DetailDeathSavesSuccess = new[] { Success1DetailCheckbox, Success2DetailCheckbox, Success3DetailCheckbox };
            DetailDeathSavesFail = new[] { Fail1DetailCheckbox, Fail2DetailCheckbox, Fail3DetailCheckbox };
            #region InitializeConditionsDictionary

            ConditionsDictionary = new Dictionary<CheckBox, Conditions>
            {
                [BlindedCheckbox] = Conditions.Blinded,
                [CharmedCheckbox] = Conditions.Charmed,
                [DeafenedCheckbox] = Conditions.Deafened,
                [FrightenedCheckbox] = Conditions.Frightened,
                [GrappledCheckbox] = Conditions.Grappled,
                [IncapacitatedCheckbox] = Conditions.Incapacitated,
                [InvisibleCheckbox] = Conditions.Invisible,
                [ParalyzedCheckbox] = Conditions.Paralyzed,
                [PetrifiedCheckbox] = Conditions.Petrified,
                [PoisonedCheckbox] = Conditions.Poisoned,
                [ProneCheckbox] = Conditions.Prone,
                [RestrainedCheckbox] = Conditions.Restrained,
                [StunnedCheckbox] = Conditions.Stunned,
                [UnconsciousCheckbox] = Conditions.Unconscious
            };

            #endregion
        }


        private void NextButton_Click(object sender, EventArgs e)
        {

            _combatManagerService.AdvanceTurn();

            UpdateDetailsTab(_combatManagerService.CurrentCharacter);

            if (_combatManagerService.Combatants.Count > 1)
            {
                UpdateNextTab(_combatManagerService.NextCharacter);
            }
            else
            {
                NextNamePlaceholderLabel.Text = string.Empty;
                NextInitiativePlaceholderLabel.Text = string.Empty;
                NextHPPlaceholderLabel.Text = string.Empty;
                NextMaxHPPlaceholderLabel.Text = string.Empty;
                NextTempHPPlaceholderLabel.Text = string.Empty;
            }



            //Change the index of the InitiativeList so that event will automatically update the Information tab and stuff
            InitiativeList.SelectedIndex = _combatManagerService.Combatants.IndexOf(_combatManagerService.CurrentCharacter);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {


            //calculate new index
            int currentIndex = InitiativeList.SelectedIndex;
            //remove selected character and update listbox
            _combatManagerService.DeleteCharacter(InitiativeList.SelectedValue as Character ?? _combatManagerService.Combatants.FirstOrDefault());
            InitiativeList.DataSource = null;
            InitiativeList.DataSource = _combatManagerService.Combatants;
            InitiativeList.SelectedItem = _combatManagerService.CurrentCharacter;

            if (_combatManagerService.Combatants.Count != 0)
            {
                Character newSelectedCharacter = InitiativeList.SelectedValue as Character;
                UpdateDetailsTab(newSelectedCharacter);
                UpdateInfoTab(newSelectedCharacter);

                UpdateNextTab(_combatManagerService.CurrentCharacter == _combatManagerService.NextCharacter ? null : _combatManagerService.NextCharacter);
            }
            else
            {
                UpdateDetailsTab(null);
                UpdateNextTab(null);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Let's reset the error messages first, because why not
            NameListLabel.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            InitiativeListLabel.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            HPMaxHPListLabel.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            TempHPListLabel.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            ReduceHPLabel.ForeColor = Color.FromKnownColor(KnownColor.ControlText);

            bool errors = false;
            bool hpErrors = false;

            #region inputChecking
            string name = NameInput.Text.Trim();
            string notes = NotesInput.Text.Trim();
            short initiative;

            short? hp = TryParseNullable(HPInput.Text.Trim());

            short? maxHP = TryParseNullable(MaxHPInput.Text.Trim());
            short? tempHP = TryParseNullable(TempHPInput.Text.Trim());
            short? reduceHP = TryParseNullable(ReduceHPInput.Text.Trim());

            if (name.Length == 0)
            {
                errors = true;
                NameListLabel.ForeColor = Color.Red;
            }

            if (!short.TryParse(InitiativeInput.Text.Trim(), out initiative))
            {
                errors = true;
                InitiativeListLabel.ForeColor = Color.Red;
            }

            short tempHPTest;
            if ((!tempHP.HasValue && TempHPInput.Text.Trim().Length > 0 && !short.TryParse(TempHPInput.Text.Trim(), out tempHPTest)))
            {
                //TempHP input doesnt have correct input, show this as an error:
                hpErrors = errors = true;
                TempHPListLabel.ForeColor = Color.Red;
            }

            //Check TEMP HP
            if (tempHP.HasValue && tempHP.Value < 0)
            {
                //temp HP cannot be below 0, show error
                hpErrors = errors = true;
                TempHPListLabel.ForeColor = Color.Red;
            }

            #endregion

            #region HPChecking
            if (hp.HasValue && maxHP.HasValue)
            {
                //All needed values have been inserted, now check if they are OK.


                if (hp.Value > maxHP.Value)
                {
                    //Not an error, just set HP equal to max HP
                    hp = maxHP;
                }

                if (hp.Value < 0 || maxHP.Value < 0)
                {
                    //HP or MAX HP cannot be below 0, show error
                    hpErrors = errors = true;
                    HPMaxHPListLabel.ForeColor = Color.Red;
                }

                //Because the user is using the HP system on this character, we can check if the user wants to reduce the HP
                if (reduceHP.HasValue && !hpErrors)
                {
                    //The user wants to reduce HP

                    //Check for an invalid value
                    if (reduceHP.Value < 0)
                    {
                        errors = true;
                        ReduceHPLabel.ForeColor = Color.Red;
                    }
                    else
                    {
                        short damageToDo = reduceHP.Value;

                        if (tempHP.HasValue)
                        {
                            tempHP -= damageToDo;
                            damageToDo = (short)(0 - tempHP.Value);

                            if (tempHP.Value < 1)
                            {
                                tempHP = null;
                            }
                        }

                        if (damageToDo > 0)
                        {
                            hp -= damageToDo;
                            damageToDo = (short)(0 - hp.Value);

                            if (hp < 1)
                            {
                                //Charachter is down

                                if (damageToDo >= maxHP)
                                {
                                    //The character is dead! Show this by setting all death fails:
                                    for (int i = 0; i < ListDeathSavesFail.Length; i++)
                                    {
                                        ListDeathSavesFail[i].Checked = true;
                                    }

                                }
                                else
                                {
                                    //The character isn't dead, but it might need a death save failure
                                    //Check if the character was already unconscious:
                                    if (UnconsciousCheckbox.Checked)
                                    {
                                        //The player was already unconscious, it took damage, thus it failed a death save:
                                        for (int i = 0; i < ListDeathSavesFail.Length; i++)
                                        {
                                            CheckBox currentCheckbox = ListDeathSavesFail[i];
                                            if (!currentCheckbox.Checked)
                                            {
                                                currentCheckbox.Checked = true;
                                                break;
                                            }
                                        }
                                    }
                                }

                                //Set status:
                                UnconsciousCheckbox.Checked = true;

                                //Reset HP
                                hp = 0;
                            }
                        }

                    }
                }
                else
                {
                    //Right now it is unclear if the user has entered wrong input (for example: "dsfsdf") or just didn't didnt enter anything into the Reduce HP range
                    //That is why we check if the input is empty or not
                    if (ReduceHPInput.Text.Trim().Length != 0)
                    {
                        //The user entered wrong input, this is an error!
                        errors = true;
                        ReduceHPLabel.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                //Either HP, MaxHP and/or temp HP has no value.
                //This should show an error ONLY if one of those has no value. If all three don't, it's fine!

                //Ugly, please forgive me:
                bool isThereAValue = hp.HasValue || maxHP.HasValue || tempHP.HasValue;
                bool isHPMaxHPCorrect = hp.HasValue && maxHP.HasValue;
                bool isTempHPCorrect = tempHP.HasValue;

                if (isThereAValue)
                {
                    if (!isHPMaxHPCorrect)
                    {
                        errors = true;
                        HPMaxHPListLabel.ForeColor = Color.Red;
                    }

                    if (isTempHPCorrect && !isHPMaxHPCorrect)
                    {
                        HPMaxHPListLabel.ForeColor = Color.Red;
                        errors = true;
                    }
                }

                //But what if there was input, but it was not correct input (for example, "f"). We still need to check this
                short hpTest;
                short maxHPTest;
                if ((!hp.HasValue && HPInput.Text.Trim().Length > 0 && !short.TryParse(HPInput.Text.Trim(), out hpTest) || (!maxHP.HasValue && MaxHPInput.Text.Trim().Length > 0 && !short.TryParse(MaxHPInput.Text.Trim(), out maxHPTest))))
                {
                    errors = true;
                    HPMaxHPListLabel.ForeColor = Color.Red;
                }
            }

            #endregion

            if (!errors)
            {
                var chosenConditions = (from item in ConditionsDictionary
                                        where item.Key.Checked
                                        select item.Value).ToList();

                short fails = (short)ListDeathSavesFail.Count(x => x.Checked);
                short successes = (short)ListDeathSavesSuccess.Count(x => x.Checked);

                Character character = new Character(name, initiative, maxHP, hp, tempHP, fails, successes, chosenConditions, notes);

                //Update or insert the character
                _combatManagerService.SaveCharacter(character);

                Sort();

                ReduceHPInput.Text = string.Empty;

                UpdateInfoTab(character);

                if (NamePlaceholderLabel.Text == character.Name || NamePlaceholderLabel.Text == string.Empty)
                {
                    //We are editing the current character displayed in the details tab
                    //To make sure that information is synced, we need to update that tab!

                    UpdateDetailsTab(character);
                }

                //Now update the next info thing
                if (_combatManagerService.Combatants.Count > 1)
                {
                    //Get the index of the current detail character(It should be up to date as we just updated it if necesarry
                    Character current = _combatManagerService.Combatants.Single(x => x.Name == NamePlaceholderLabel.Text);
                    int currentIndex = _combatManagerService.Combatants.IndexOf(current);

                    int nextIndex = currentIndex + 1 == _combatManagerService.Combatants.Count ? 0 : currentIndex + 1; //Check if wrap around is needed

                    UpdateNextTab(_combatManagerService.NextCharacter);
                }
            }
        }

        private void Sort()
        {
            var currentSelected = InitiativeList.SelectedItem as Character;

            _combatManagerService.SortCombatants();

            InitiativeList.DataSource = null;
            InitiativeList.DataSource = _combatManagerService.Combatants;

            InitiativeList.SelectedItem = currentSelected ?? _combatManagerService.CurrentCharacter;

        }

        /// <summary>
        /// Gets executed when the user selects an item from the <see cref="InitiativeList"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitiativeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var character = InitiativeList.SelectedValue as Character ?? (_combatManagerService.Combatants.Count > 0 ? _combatManagerService.Combatants.First() : null);

            UpdateInfoTab(character);
        }

        private void UpdateInfoTab(Character character)
        {
            if (character == null)
            {
                NameInput.Text = string.Empty;
                InitiativeInput.Text = string.Empty;
                HPInput.Text = string.Empty;
                MaxHPInput.Text = string.Empty;
                TempHPInput.Text = string.Empty;
                NotesInput.Text = string.Empty;

                for (int i = 0; i < ListDeathSavesFail.Length; i++)
                {
                    var checkBox = ListDeathSavesFail[i];
                    checkBox.Checked = false;
                }


                for (int i = 0; i < ListDeathSavesSuccess.Length; i++)
                {
                    var checkBox = ListDeathSavesSuccess[i];
                    checkBox.Checked = false;
                }

                foreach (var item in ConditionsDictionary)
                {
                    item.Key.Checked = false;
                }

                ReduceHPInput.Text = string.Empty;

            }
            else
            {
                NameInput.Text = character.Name;
                InitiativeInput.Text = character.Initiative.ToString();
                NotesInput.Text = character.Notes;

                if (character.HP.HasValue || character.MaxHP.HasValue)
                {

                    HPInput.Text = character.HP.Value.ToString();
                    MaxHPInput.Text = character.MaxHP.Value.ToString();
                    TempHPInput.Text = character.TempHP.HasValue ? character.TempHP.ToString() : string.Empty;
                }
                else
                {
                    HPInput.Text = string.Empty;
                    MaxHPInput.Text = string.Empty;
                    TempHPInput.Text = string.Empty;
                }


                for (int i = 0; i < ListDeathSavesFail.Length; i++)
                {
                    var checkBox = ListDeathSavesFail[i];
                    checkBox.Checked = false;
                }


                for (int i = 0; i < ListDeathSavesSuccess.Length; i++)
                {
                    var checkBox = ListDeathSavesSuccess[i];
                    checkBox.Checked = false;
                }


                for (int i = 0; i < character.DeathSaves_Success; i++)
                {
                    ListDeathSavesSuccess[i].Checked = true;
                }

                for (int i = 0; i < character.DeathSaves_Fail; i++)
                {
                    ListDeathSavesFail[i].Checked = true;
                }

                //Conditions info

                //Set the conditions
                foreach (var item in ConditionsDictionary)
                {
                    item.Key.Checked = character.Conditions.Contains(item.Value);
                }
            }
        }

        private void UpdateDetailsTab(Character character)
        {
            if (character == null)
            {
                NamePlaceholderLabel.Text = string.Empty;
                InitiativePlaceholderLabel.Text = string.Empty;
                HPPlaceholderLabel.Text = string.Empty;
                MaxHPPlaceholderLabel.Text = string.Empty;
                TempHPPlaceholderLabel.Text = string.Empty;
                NotesDisplay.Text = string.Empty;

                //Checkboxes
                for (int i = 0; i < DetailDeathSavesFail.Length; i++)
                {
                    var checkBox = DetailDeathSavesFail[i];
                    checkBox.Checked = false;
                }

                for (int i = 0; i < DetailDeathSavesSuccess.Length; i++)
                {
                    var checkBox = DetailDeathSavesSuccess[i];
                    checkBox.Checked = false;
                }
                ConditionsPlaceholderList.Items.Clear();

            }
            else
            {
                NamePlaceholderLabel.Text = character.Name;
                InitiativePlaceholderLabel.Text = character.Initiative.ToString();
                NotesDisplay.Text = character.Notes;

                if (character.HP.HasValue || character.MaxHP.HasValue)
                {
                    HPPlaceholderLabel.Text = character.HP.Value.ToString();
                    MaxHPPlaceholderLabel.Text = character.MaxHP.Value.ToString();
                    TempHPPlaceholderLabel.Text = character.TempHP.HasValue ? character.TempHP.ToString() : string.Empty;
                }
                else
                {
                    HPPlaceholderLabel.Text = string.Empty;
                    MaxHPPlaceholderLabel.Text = string.Empty;
                    TempHPPlaceholderLabel.Text = string.Empty;
                }

                //Checkboxes
                for (int i = 0; i < DetailDeathSavesFail.Length; i++)
                {
                    var checkBox = DetailDeathSavesFail[i];
                    checkBox.Checked = false;
                }

                for (int i = 0; i < DetailDeathSavesSuccess.Length; i++)
                {
                    var checkBox = DetailDeathSavesSuccess[i];
                    checkBox.Checked = false;
                }


                for (int i = 0; i < character.DeathSaves_Success; i++)
                {
                    DetailDeathSavesSuccess[i].Checked = true;
                }

                for (int i = 0; i < character.DeathSaves_Fail; i++)
                {
                    DetailDeathSavesFail[i].Checked = true;
                }

                //Conditions

                //Clear the list first
                ConditionsPlaceholderList.Items.Clear();

                //Set the conditions
                foreach (Conditions condition in character.Conditions)
                {
                    ConditionsPlaceholderList.Items.Add(Enum.GetName(typeof(Conditions), condition));
                }
            }
        }

        private void UpdateNextTab(Character character)
        {
            if (character == null)
            {
                NextNamePlaceholderLabel.Text = string.Empty;
                NextInitiativePlaceholderLabel.Text = string.Empty;
                NextHPPlaceholderLabel.Text = string.Empty;
                NextMaxHPPlaceholderLabel.Text = string.Empty;
                NextTempHPPlaceholderLabel.Text = string.Empty;
            }
            else
            {
                NextNamePlaceholderLabel.Text = character.Name;
                NextInitiativePlaceholderLabel.Text = character.Initiative.ToString();

                if (character.HP.HasValue || character.MaxHP.HasValue)
                {
                    NextHPPlaceholderLabel.Text = character.HP.Value.ToString();
                    NextMaxHPPlaceholderLabel.Text = character.MaxHP.Value.ToString();
                    NextTempHPPlaceholderLabel.Text = character.TempHP.HasValue ? character.TempHP.ToString() : string.Empty;

                }
                else
                {
                    NextHPPlaceholderLabel.Text = string.Empty;
                    NextMaxHPPlaceholderLabel.Text = string.Empty;
                    NextTempHPPlaceholderLabel.Text = string.Empty;
                }
            }
        }

        private short? TryParseNullable(string val)
        {
            short outValue;
            return short.TryParse(val, out outValue) ? (short?)outValue : null;
        }
    }
}
