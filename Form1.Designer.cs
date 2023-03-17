namespace Phonebook
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            frstn = new TextBox();
            secn = new TextBox();
            phonen = new TextBox();
            mailtb = new TextBox();
            btnNew = new Button();
            btnLoad = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 42);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 0;
            label1.Text = "First Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 90);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 1;
            label2.Text = "Last Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(-6, 148);
            label3.Name = "label3";
            label3.Size = new Size(154, 21);
            label3.TabIndex = 2;
            label3.Text = "Phone Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(62, 201);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 3;
            label4.Text = "E-mail:";
            // 
            // frstn
            // 
            frstn.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            frstn.Location = new Point(149, 39);
            frstn.Name = "frstn";
            frstn.Size = new Size(685, 29);
            frstn.TabIndex = 4;
            // 
            // secn
            // 
            secn.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            secn.Location = new Point(149, 90);
            secn.Name = "secn";
            secn.Size = new Size(685, 29);
            secn.TabIndex = 5;
            // 
            // phonen
            // 
            phonen.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            phonen.Location = new Point(149, 148);
            phonen.Name = "phonen";
            phonen.Size = new Size(685, 29);
            phonen.TabIndex = 6;
            // 
            // mailtb
            // 
            mailtb.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            mailtb.Location = new Point(149, 198);
            mailtb.Name = "mailtb";
            mailtb.Size = new Size(685, 29);
            mailtb.TabIndex = 7;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(882, 42);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 8;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(882, 90);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(882, 148);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(882, 201);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1015, 318);
            dataGridView1.TabIndex = 12;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1029, 564);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(btnNew);
            Controls.Add(mailtb);
            Controls.Add(phonen);
            Controls.Add(secn);
            Controls.Add(frstn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhoneBook";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox frstn;
        private TextBox secn;
        private TextBox phonen;
        private TextBox mailtb;
        private Button btnNew;
        private Button btnLoad;
        private Button btnSave;
        private Button btnDelete;
        private DataGridView dataGridView1;
    }
}