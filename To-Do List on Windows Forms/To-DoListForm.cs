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



        //Корректная отрисовка списка задач
        private void listTasks_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= tasks.Count)
            {
                e.ItemHeight = (int)listTasks.Font.GetHeight() + 2;
                return;
            }

            // Получаем текст задачи
            string itemText = tasks[e.Index];

            // Рассчитываем, сколько пикселов займёт текст при обёртке по ширине ListBox
            // Учтём левую/правую границы (здесь используем весь клиентский размер)
            int maxWidth = listTasks.ClientSize.Width;

            // Используем Graphics от ListBox для MeasureString
            using (Graphics g = listTasks.CreateGraphics())
            {
                // StringFormat с переносом по словам
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Near,
                    FormatFlags = StringFormatFlags.LineLimit // рубит слова по границе
                };

                // Прямоугольник, в котором мерять
                SizeF sizeF = g.MeasureString(itemText, listTasks.Font, maxWidth, sf);

                // Высота одного элемента — округляем в большую сторону и добавляем небольшой отступ
                e.ItemHeight = (int)Math.Ceiling(sizeF.Height) + 4;
            }
        }
        private void listTasks_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Если пустой элемент (например, при удалении всех), просто выходим
            if (e.Index < 0 || e.Index >= tasks.Count)
                return;

            // Выбираем цвет фона: выделенный/невыделенный элемент
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Color backColor = isSelected ? SystemColors.Highlight : listTasks.BackColor;
            Color foreColor = isSelected ? SystemColors.HighlightText : listTasks.ForeColor;

            // Закрашиваем фон нужным цветом
            e.Graphics.FillRectangle(new SolidBrush(backColor), e.Bounds);

            // Текст задачи
            string itemText = tasks[e.Index];

            // Подготовим StringFormat с переносом по словам
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near,
                FormatFlags = StringFormatFlags.LineLimit
            };

            // На всякий случай уменьшили левый/правый отступы:
            Rectangle textRect = new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2,
                                                e.Bounds.Width - 4, e.Bounds.Height - 4);

            // Рисуем многострочный текст
            using (Brush textBrush = new SolidBrush(foreColor))
            {
                e.Graphics.DrawString(itemText, listTasks.Font, textBrush, textRect, sf);
            }

            // Рисуем рамку фокуса, если нужно
            e.DrawFocusRectangle();
        }
    }
}
