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
    public partial class OverviewForm : Form
    {
        private BindingList<Character> CharacterList { get; set; }

        public OverviewForm()
        {
            InitializeComponent();
            CharacterList = new BindingList<Character>();
            InitiativeList.DataSource = CharacterList;
        }


        private void NextButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            CharacterList.Remove((Character)InitiativeList.SelectedItem);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void Sort()
        {
            //Update the ResultList
            var list = CharacterList.ToList();
            list.Sort((a, b) => -1 * a.CompareTo(b));
        }

        /// <summary>
        /// Gets executed when the user selects an item from the <see cref="InitiativeList"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitiativeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
