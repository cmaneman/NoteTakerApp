namespace NoteTaker
{
    partial class Reminder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ToNotes = new Button();
            SuspendLayout();
            // 
            // ToNotes
            // 
            ToNotes.Location = new Point(60, 47);
            ToNotes.Name = "ToNotes";
            ToNotes.Size = new Size(114, 23);
            ToNotes.TabIndex = 1;
            ToNotes.Text = "Go To Notes Page";
            ToNotes.UseVisualStyleBackColor = true;
            ToNotes.Click += ToNotesForm_Click;
            // 
            // Reminder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ToNotes);
            Name = "Reminder";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion
        private Button ToNotes;
    }
}