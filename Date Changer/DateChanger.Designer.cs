
namespace Date_Changer
{
    partial class DateChanger
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateChanger));
            this.selectedPathString = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.Change_button = new System.Windows.Forms.Button();
            this.info_text = new System.Windows.Forms.Label();
            this.target_comboBox = new System.Windows.Forms.ComboBox();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.file_radio = new System.Windows.Forms.RadioButton();
            this.folder_radio = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectedPathString
            // 
            this.selectedPathString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedPathString.AutoSize = true;
            this.selectedPathString.Location = new System.Drawing.Point(9, 51);
            this.selectedPathString.Name = "selectedPathString";
            this.selectedPathString.Size = new System.Drawing.Size(93, 13);
            this.selectedPathString.TabIndex = 1;
            this.selectedPathString.Text = "Select folder path:";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(12, 120);
            this.datePicker.Margin = new System.Windows.Forms.Padding(0);
            this.datePicker.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(240, 20);
            this.datePicker.TabIndex = 5;
            this.datePicker.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // Change_button
            // 
            this.Change_button.Enabled = false;
            this.Change_button.Location = new System.Drawing.Point(196, 224);
            this.Change_button.Name = "Change_button";
            this.Change_button.Size = new System.Drawing.Size(75, 25);
            this.Change_button.TabIndex = 8;
            this.Change_button.Text = "Change";
            this.Change_button.UseVisualStyleBackColor = true;
            this.Change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // info_text
            // 
            this.info_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info_text.AutoSize = true;
            this.info_text.Location = new System.Drawing.Point(318, 126);
            this.info_text.Name = "info_text";
            this.info_text.Size = new System.Drawing.Size(0, 13);
            this.info_text.TabIndex = 4;
            // 
            // target_comboBox
            // 
            this.target_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.target_comboBox.Items.AddRange(new object[] {
            "All Files & Directories & Main Directory",
            "All Files & Directories",
            "All Files ",
            "All Directories",
            "Main Directory"});
            this.target_comboBox.Location = new System.Drawing.Point(12, 180);
            this.target_comboBox.Name = "target_comboBox";
            this.target_comboBox.Size = new System.Drawing.Size(240, 21);
            this.target_comboBox.TabIndex = 7;
            this.target_comboBox.SelectedIndexChanged += new System.EventHandler(this.target_comboBox_SelectedIndexChanged);
            // 
            // pathBox
            // 
            this.pathBox.AllowDrop = true;
            this.pathBox.Location = new System.Drawing.Point(12, 67);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(359, 20);
            this.pathBox.TabIndex = 2;
            this.pathBox.TextChanged += new System.EventHandler(this.pathBox_TextChanged);
            this.pathBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.pathBox.DragOver += new System.Windows.Forms.DragEventHandler(this.textbox_DragOver);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Browse...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.browse_Button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Enabled = false;
            this.ok_button.Location = new System.Drawing.Point(321, 93);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(50, 23);
            this.ok_button.TabIndex = 4;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click_1);
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(12, 150);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(240, 20);
            this.timePicker.TabIndex = 6;
            this.timePicker.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.file_radio);
            this.panel1.Controls.Add(this.folder_radio);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 25);
            this.panel1.TabIndex = 9;
            // 
            // file_radio
            // 
            this.file_radio.AutoSize = true;
            this.file_radio.Location = new System.Drawing.Point(64, 4);
            this.file_radio.Name = "file_radio";
            this.file_radio.Size = new System.Drawing.Size(41, 17);
            this.file_radio.TabIndex = 1;
            this.file_radio.TabStop = true;
            this.file_radio.Text = "File";
            this.file_radio.UseVisualStyleBackColor = true;
            // 
            // folder_radio
            // 
            this.folder_radio.AutoSize = true;
            this.folder_radio.Location = new System.Drawing.Point(4, 4);
            this.folder_radio.Name = "folder_radio";
            this.folder_radio.Size = new System.Drawing.Size(54, 17);
            this.folder_radio.TabIndex = 0;
            this.folder_radio.TabStop = true;
            this.folder_radio.Text = "Folder";
            this.folder_radio.UseVisualStyleBackColor = true;
            this.folder_radio.CheckedChanged += new System.EventHandler(this.FolderFile_radio_CheckedChanged);
            // 
            // DateChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.target_comboBox);
            this.Controls.Add(this.info_text);
            this.Controls.Add(this.Change_button);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.selectedPathString);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 300);
            this.MinimumSize = new System.Drawing.Size(480, 300);
            this.Name = "DateChanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Changer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectedPathString;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button Change_button;
        private System.Windows.Forms.Label info_text;
        private System.Windows.Forms.ComboBox target_comboBox;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton file_radio;
        private System.Windows.Forms.RadioButton folder_radio;
    }
}

