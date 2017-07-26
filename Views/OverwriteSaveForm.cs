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
        }
    }
}
