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
    public partial class MainForm : Form
    {
        public static BindingList<Character> InitiativeList { get; set; }
        public static BindingList<Character> ResultList { get; set; }


        public MainForm()
        {
            InitializeComponent();
            InitiativeList = new BindingList<Character>();
            ResultList = new BindingList<Character>();

            Initiative_List.DataSource = InitiativeList;
            Result_List.DataSource = ResultList;

            ResultList.ListChanged += ResultList_ListChanged;

        }

        private void ResultList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (ResultList.Count == 1)
            {
                Result_List.SetSelected(0, true);
                Current_Label.Text = ((Character)Result_List.SelectedValue).Name;

            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            addForm.ShowDialog();

        }
        private void Remove_Button_Click(object sender, EventArgs e)
        {
            InitiativeList.Remove((Character)Initiative_List.SelectedItem);

            //Update the ResultList
            var list = InitiativeList.ToList();

            ResultList.Clear();
            list.Sort();

            foreach (var item in list)
            {
                MainForm.ResultList.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Character currentItem = (Character)Initiative_List.SelectedValue;

            if (currentItem != null)
            {
                new AddForm(currentItem).ShowDialog();
            }
        }

        private void Next_Button_Click(object sender, EventArgs e)
        {
            //TODO: Make sure that when an item is added (first time, that it is selected and that the text is set and stuff
            //then it is kinda done?
            if (ResultList.Count != 0)
            {
                int next = Result_List.SelectedIndex + 1;
                if (next == ResultList.Count)
                {
                    //Wrap around
                    next = 0;
                }
                Result_List.SetSelected(next, true);

                Current_Label.Text = ((Character)Result_List.SelectedValue).Name;
            }
        }
    }
}
