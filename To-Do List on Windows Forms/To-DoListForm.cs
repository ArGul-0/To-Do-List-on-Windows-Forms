using System.ComponentModel;

namespace To_Do_List_on_Windows_Forms
{
    public partial class ToDoListForm : Form
    {
        BindingList<string> tasks = new BindingList<string>();

        public ToDoListForm()
        {
            InitializeComponent();
            listTasks.DataSource = tasks;
        }
        private void listTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inputTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void addTask_Click(object sender, EventArgs e)
        {

        }

        private void removeTask_Click(object sender, EventArgs e)
        {

        }
    }
}
