namespace AdoLab
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
            IdBox = new TextBox();
            FnameBox = new TextBox();
            LnameBox = new TextBox();
            DidBox = new TextBox();
            DnameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSearch = new Button();
            btnDisplay = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnInsert = new Button();
            dataGridView = new DataGridView();
            btnConnect = new Button();
            btnDisconnect = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // IdBox
            // 
            IdBox.Location = new Point(114, 70);
            IdBox.Name = "IdBox";
            IdBox.Size = new Size(125, 27);
            IdBox.TabIndex = 0;
            // 
            // FnameBox
            // 
            FnameBox.Location = new Point(114, 120);
            FnameBox.Name = "FnameBox";
            FnameBox.Size = new Size(125, 27);
            FnameBox.TabIndex = 1;
            // 
            // LnameBox
            // 
            LnameBox.Location = new Point(114, 177);
            LnameBox.Name = "LnameBox";
            LnameBox.Size = new Size(125, 27);
            LnameBox.TabIndex = 2;
            // 
            // DidBox
            // 
            DidBox.Location = new Point(114, 233);
            DidBox.Name = "DidBox";
            DidBox.Size = new Size(125, 27);
            DidBox.TabIndex = 3;
            // 
            // DnameBox
            // 
            DnameBox.Location = new Point(114, 293);
            DnameBox.Name = "DnameBox";
            DnameBox.Size = new Size(125, 27);
            DnameBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 73);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 5;
            label1.Text = "EmpId";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 127);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 6;
            label2.Text = "Fname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 184);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 7;
            label3.Text = "Lname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 240);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 8;
            label4.Text = "DeptId";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 296);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 9;
            label5.Text = "DeptName";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightCoral;
            btnSearch.Location = new Point(300, 362);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.DarkCyan;
            btnDisplay.Location = new Point(679, 30);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(94, 29);
            btnDisplay.TabIndex = 11;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightCoral;
            btnUpdate.Location = new Point(490, 362);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Location = new Point(679, 362);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.LightCoral;
            btnInsert.Location = new Point(866, 362);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 14;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.Window;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(276, 73);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(701, 247);
            dataGridView.TabIndex = 15;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(312, 30);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 29);
            btnConnect.TabIndex = 16;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(457, 30);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(94, 29);
            btnDisconnect.TabIndex = 17;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 450);
            Controls.Add(btnDisconnect);
            Controls.Add(btnConnect);
            Controls.Add(dataGridView);
            Controls.Add(btnInsert);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnDisplay);
            Controls.Add(btnSearch);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DnameBox);
            Controls.Add(DidBox);
            Controls.Add(LnameBox);
            Controls.Add(FnameBox);
            Controls.Add(IdBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IdBox;
        private TextBox FnameBox;
        private TextBox LnameBox;
        private TextBox DidBox;
        private TextBox DnameBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSearch;
        private Button btnDisplay;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnInsert;
        private DataGridView dataGridView;
        private Button btnConnect;
        private Button btnDisconnect;
    }
}
