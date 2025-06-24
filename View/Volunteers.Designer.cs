namespace View
{
    partial class Volunteers
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
            components = new System.ComponentModel.Container();
            boxFullName = new TextBox();
            lblBirthDate = new Label();
            boxBirth = new DateTimePicker();
            boxYearsOld = new TextBox();
            boxSkills = new TextBox();
            AddAvailability = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            btnAdd = new Button();
            AvailabilityAdded = new GroupBox();
            btnDelete = new Button();
            boxEmail = new TextBox();
            boxPhone = new TextBox();
            btnCreate = new Button();
            btnBack = new Button();
            volunteerViewModelBindingSource = new BindingSource(components);
            AddAvailability.SuspendLayout();
            AvailabilityAdded.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volunteerViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // boxFullName
            // 
            boxFullName.Location = new Point(129, 29);
            boxFullName.Name = "boxFullName";
            boxFullName.PlaceholderText = "Full Name";
            boxFullName.Size = new Size(519, 23);
            boxFullName.TabIndex = 0;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(193, 75);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(59, 15);
            lblBirthDate.TabIndex = 1;
            lblBirthDate.Text = "Birth Date";
            // 
            // boxBirth
            // 
            boxBirth.Format = DateTimePickerFormat.Short;
            boxBirth.Location = new Point(281, 69);
            boxBirth.MaxDate = new DateTime(2025, 6, 22, 0, 0, 0, 0);
            boxBirth.Name = "boxBirth";
            boxBirth.Size = new Size(110, 23);
            boxBirth.TabIndex = 2;
            boxBirth.Value = new DateTime(2025, 6, 22, 0, 0, 0, 0);
            // 
            // boxYearsOld
            // 
            boxYearsOld.Enabled = false;
            boxYearsOld.Location = new Point(434, 69);
            boxYearsOld.Name = "boxYearsOld";
            boxYearsOld.PlaceholderText = "Years Old";
            boxYearsOld.Size = new Size(100, 23);
            boxYearsOld.TabIndex = 3;
            // 
            // boxSkills
            // 
            boxSkills.Location = new Point(129, 98);
            boxSkills.Multiline = true;
            boxSkills.Name = "boxSkills";
            boxSkills.PlaceholderText = "Skills and Experience";
            boxSkills.Size = new Size(519, 84);
            boxSkills.TabIndex = 4;
            // 
            // AddAvailability
            // 
            AddAvailability.Controls.Add(label4);
            AddAvailability.Controls.Add(label3);
            AddAvailability.Controls.Add(label2);
            AddAvailability.Controls.Add(comboBox1);
            AddAvailability.Controls.Add(dateTimePicker2);
            AddAvailability.Controls.Add(dateTimePicker1);
            AddAvailability.Controls.Add(btnAdd);
            AddAvailability.Location = new Point(129, 188);
            AddAvailability.Name = "AddAvailability";
            AddAvailability.Size = new Size(268, 127);
            AddAvailability.TabIndex = 6;
            AddAvailability.TabStop = false;
            AddAvailability.Text = "Add Availability";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 19);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 19;
            label4.Text = "Day";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 91);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 18;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 91);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 17;
            label2.Text = "Start Hour";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(77, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(138, 66);
            dateTimePicker2.MaxDate = new DateTime(2025, 6, 22, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(110, 23);
            dateTimePicker2.TabIndex = 15;
            dateTimePicker2.Value = new DateTime(2025, 6, 22, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(22, 66);
            dateTimePicker1.MaxDate = new DateTime(2025, 6, 22, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(110, 23);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.Value = new DateTime(2025, 6, 22, 0, 0, 0, 0);
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(97, 95);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // AvailabilityAdded
            // 
            AvailabilityAdded.Controls.Add(btnDelete);
            AvailabilityAdded.Location = new Point(403, 188);
            AvailabilityAdded.Name = "AvailabilityAdded";
            AvailabilityAdded.Size = new Size(245, 127);
            AvailabilityAdded.TabIndex = 7;
            AvailabilityAdded.TabStop = false;
            AvailabilityAdded.Text = "Availability Added  ";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(103, 71);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // boxEmail
            // 
            boxEmail.Location = new Point(129, 321);
            boxEmail.Name = "boxEmail";
            boxEmail.PlaceholderText = "Email";
            boxEmail.Size = new Size(519, 23);
            boxEmail.TabIndex = 8;
            // 
            // boxPhone
            // 
            boxPhone.Location = new Point(129, 350);
            boxPhone.Name = "boxPhone";
            boxPhone.PlaceholderText = "Phone Number";
            boxPhone.Size = new Size(519, 23);
            boxPhone.TabIndex = 9;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(206, 403);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(506, 403);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Volunteers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnCreate);
            Controls.Add(boxPhone);
            Controls.Add(boxEmail);
            Controls.Add(AvailabilityAdded);
            Controls.Add(AddAvailability);
            Controls.Add(boxSkills);
            Controls.Add(boxYearsOld);
            Controls.Add(boxBirth);
            Controls.Add(lblBirthDate);
            Controls.Add(boxFullName);
            Name = "Volunteers";
            Text = "Volunteers";
            AddAvailability.ResumeLayout(false);
            AddAvailability.PerformLayout();
            AvailabilityAdded.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)volunteerViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox boxFullName;
        private Label lblBirthDate;
        private DateTimePicker boxBirth;
        private TextBox boxYearsOld;
        private TextBox boxSkills;
        private GroupBox AddAvailability;
        private Button btnDelete;
        private Button btnAdd;
        private GroupBox AvailabilityAdded;
        private TextBox boxEmail;
        private TextBox boxPhone;
        private Button btnCreate;
        private Button btnBack;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private BindingSource volunteerViewModelBindingSource;
    }
}
