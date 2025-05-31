namespace To_Do_List_on_Windows_Forms
{
    partial class ToDoListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listTasks = new ListBox();
            addTask = new Button();
            removeTask = new Button();
            inputTask = new TextBox();
            SuspendLayout();
            // 
            // listTasks
            // 
            listTasks.BackColor = Color.FromArgb(60, 60, 60);
            listTasks.BorderStyle = BorderStyle.None;
            listTasks.Dock = DockStyle.Left;
            listTasks.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            listTasks.ForeColor = Color.WhiteSmoke;
            listTasks.FormattingEnabled = true;
            listTasks.HorizontalScrollbar = true;
            listTasks.ItemHeight = 30;
            listTasks.Location = new Point(0, 0);
            listTasks.Name = "listTasks";
            listTasks.Size = new Size(500, 461);
            listTasks.TabIndex = 0;
            listTasks.SelectedIndexChanged += listTasks_SelectedIndexChanged_1;
            // 
            // addTask
            // 
            addTask.BackColor = Color.FromArgb(60, 60, 60);
            addTask.FlatAppearance.BorderSize = 0;
            addTask.FlatStyle = FlatStyle.Flat;
            addTask.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            addTask.ForeColor = Color.WhiteSmoke;
            addTask.Location = new Point(647, 374);
            addTask.Name = "addTask";
            addTask.Size = new Size(125, 75);
            addTask.TabIndex = 2;
            addTask.Text = "+";
            addTask.UseVisualStyleBackColor = false;
            addTask.Click += addTask_Click;
            // 
            // removeTask
            // 
            removeTask.BackColor = Color.FromArgb(60, 60, 60);
            removeTask.FlatAppearance.BorderSize = 0;
            removeTask.FlatStyle = FlatStyle.Flat;
            removeTask.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            removeTask.ForeColor = Color.WhiteSmoke;
            removeTask.Location = new Point(516, 374);
            removeTask.Name = "removeTask";
            removeTask.Size = new Size(125, 75);
            removeTask.TabIndex = 3;
            removeTask.Text = "-";
            removeTask.UseVisualStyleBackColor = false;
            removeTask.Click += removeTask_Click;
            // 
            // inputTask
            // 
            inputTask.BackColor = Color.FromArgb(75, 75, 75);
            inputTask.BorderStyle = BorderStyle.None;
            inputTask.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            inputTask.ForeColor = Color.WhiteSmoke;
            inputTask.Location = new Point(516, 12);
            inputTask.Multiline = true;
            inputTask.Name = "inputTask";
            inputTask.Size = new Size(256, 347);
            inputTask.TabIndex = 4;
            inputTask.TextChanged += inputTask_TextChanged;
            // 
            // ToDoListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(784, 461);
            Controls.Add(inputTask);
            Controls.Add(removeTask);
            Controls.Add(addTask);
            Controls.Add(listTasks);
            Name = "ToDoListForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listTasks;
        private Button addTask;
        private Button removeTask;
        private TextBox inputTask;
    }
}
