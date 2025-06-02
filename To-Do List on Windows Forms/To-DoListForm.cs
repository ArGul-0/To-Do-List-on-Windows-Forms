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
            if(listTasks.SelectedIndex == -1)
            {
                MessageBox.Show("The task to delete is not selected.");
                return;
            }
            tasks.Remove(listTasks.SelectedItem as string);
        }



        //���������� ��������� ������ �����
        private void listTasks_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= tasks.Count)
            {
                e.ItemHeight = (int)listTasks.Font.GetHeight() + 2;
                return;
            }

            // �������� ����� ������
            string itemText = tasks[e.Index];

            // ������������, ������� �������� ����� ����� ��� ������ �� ������ ListBox
            // ���� �����/������ ������� (����� ���������� ���� ���������� ������)
            int maxWidth = listTasks.ClientSize.Width;

            // ���������� Graphics �� ListBox ��� MeasureString
            using (Graphics g = listTasks.CreateGraphics())
            {
                // StringFormat � ��������� �� ������
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Near,
                    FormatFlags = StringFormatFlags.LineLimit // ����� ����� �� �������
                };

                // �������������, � ������� ������
                SizeF sizeF = g.MeasureString(itemText, listTasks.Font, maxWidth, sf);

                // ������ ������ �������� � ��������� � ������� ������� � ��������� ��������� ������
                e.ItemHeight = (int)Math.Ceiling(sizeF.Height) + 4;
            }
        }
        private void listTasks_DrawItem(object sender, DrawItemEventArgs e)
        {
            // ���� ������ ������� (��������, ��� �������� ����), ������ �������
            if (e.Index < 0 || e.Index >= tasks.Count)
                return;

            // �������� ���� ����: ����������/������������ �������
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Color backColor = isSelected ? SystemColors.Highlight : listTasks.BackColor;
            Color foreColor = isSelected ? SystemColors.HighlightText : listTasks.ForeColor;

            // ����������� ��� ������ ������
            e.Graphics.FillRectangle(new SolidBrush(backColor), e.Bounds);

            // ����� ������
            string itemText = tasks[e.Index];

            // ���������� StringFormat � ��������� �� ������
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near,
                FormatFlags = StringFormatFlags.LineLimit
            };

            // �� ������ ������ ��������� �����/������ �������:
            Rectangle textRect = new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2,
                                                e.Bounds.Width - 4, e.Bounds.Height - 4);

            // ������ ������������� �����
            using (Brush textBrush = new SolidBrush(foreColor))
            {
                e.Graphics.DrawString(itemText, listTasks.Font, textBrush, textRect, sf);
            }

            // ������ ����� ������, ���� �����
            e.DrawFocusRectangle();
        }
    }
}
