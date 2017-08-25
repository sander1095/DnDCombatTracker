using CombatTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker.Views
{
    public partial class OverwriteSaveForm : Form
    {
        public OverwriteSaveForm(Character oldCharacter, Character newCharacter)
        {
            InitializeComponent();
            //TODO: 
            //Use the Stackoverflow code to determine the properties that are different
            // https://stackoverflow.com/questions/4511722/differences-between-two-objects-in-c-sharp#_=_
            //use a big rich text box or something.
            //Every line is a line with a property that is different:
            //PROPERTY NAME: <VALUE>
            //Maybe create an attribute [OverwriteFormAttribute] or something which contains the name that should be displayed in this form to make it easy to read

            
        }
    }
}
