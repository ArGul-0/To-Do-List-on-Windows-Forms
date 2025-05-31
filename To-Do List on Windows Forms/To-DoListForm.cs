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

        private void listTasks_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void inputTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void addTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputTask.Text))
            {
                MessageBox.Show("Please enter a task.");
                return;
            }
            tasks.Add(inputTask.Text);
            inputTask.Clear();
        }

        private void removeTask_Click(object sender, EventArgs e)
        {
            tasks.Remove(listTasks.SelectedItem as string);
        }
    }
}
