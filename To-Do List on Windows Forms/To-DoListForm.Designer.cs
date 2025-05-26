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
            list = new ListBox();
            checkBox1 = new CheckBox();
            addList = new Button();
            removeList = new Button();
            SuspendLayout();
            // 
            // list
            // 
            list.BackColor = Color.FromArgb(60, 60, 60);
            list.BorderStyle = BorderStyle.None;
            list.Dock = DockStyle.Left;
            list.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            list.ForeColor = Color.WhiteSmoke;
            list.FormattingEnabled = true;
            list.ItemHeight = 30;
            list.Location = new Point(0, 0);
            list.Name = "list";
            list.Size = new Size(500, 461);
            list.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(506, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // addList
            // 
            addList.BackColor = Color.FromArgb(60, 60, 60);
            addList.FlatAppearance.BorderSize = 0;
            addList.FlatStyle = FlatStyle.Flat;
            addList.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            addList.ForeColor = Color.WhiteSmoke;
            addList.Location = new Point(647, 374);
            addList.Name = "addList";
            addList.Size = new Size(125, 75);
            addList.TabIndex = 2;
            addList.Text = "+";
            addList.UseVisualStyleBackColor = false;
            // 
            // removeList
            // 
            removeList.BackColor = Color.FromArgb(60, 60, 60);
            removeList.FlatAppearance.BorderSize = 0;
            removeList.FlatStyle = FlatStyle.Flat;
            removeList.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            removeList.ForeColor = Color.WhiteSmoke;
            removeList.Location = new Point(516, 374);
            removeList.Name = "removeList";
            removeList.Size = new Size(125, 75);
            removeList.TabIndex = 3;
            removeList.Text = "-";
            removeList.UseVisualStyleBackColor = false;
            // 
            // ToDoListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(784, 461);
            Controls.Add(removeList);
            Controls.Add(addList);
            Controls.Add(checkBox1);
            Controls.Add(list);
            Name = "ToDoListForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox list;
        private CheckBox checkBox1;
        private Button addList;
        private Button removeList;
    }
}
