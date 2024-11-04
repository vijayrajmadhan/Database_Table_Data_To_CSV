namespace Data_To_Csv
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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            connectionStringTextBox = new TextBox();
            delimiterTextBox = new TextBox();
            fileLocationTextBox = new TextBox();
            fileNameTextBox = new TextBox();
            queryTextBox = new TextBox();
            authenticationComboBox = new ComboBox();
            exportButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(175, 22);
            label1.Name = "label1";
            label1.Size = new Size(359, 30);
            label1.TabIndex = 0;
            label1.Text = "CONVERT SQL TABLE TO CSV FILE";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 501F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(connectionStringTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(delimiterTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(fileLocationTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(fileNameTextBox, 1, 4);
            tableLayoutPanel1.Controls.Add(queryTextBox, 1, 1);
            tableLayoutPanel1.Location = new Point(49, 99);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(693, 221);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(148, 21);
            label2.TabIndex = 0;
            label2.Text = "Connection String";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ImageAlign = ContentAlignment.TopLeft;
            label4.Location = new Point(3, 134);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 2;
            label4.Text = "Delimiter";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ImageAlign = ContentAlignment.TopLeft;
            label5.Location = new Point(3, 164);
            label5.Name = "label5";
            label5.Size = new Size(149, 21);
            label5.TabIndex = 3;
            label5.Text = "File_Path Location";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ImageAlign = ContentAlignment.TopLeft;
            label6.Location = new Point(3, 195);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 4;
            label6.Text = "File_Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ImageAlign = ContentAlignment.TopLeft;
            label3.Location = new Point(3, 69);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 1;
            label3.Text = "Export_Query";
            label3.Click += label3_Click;
            // 
            // connectionStringTextBox
            // 
            connectionStringTextBox.Location = new Point(195, 3);
            connectionStringTextBox.Name = "connectionStringTextBox";
            connectionStringTextBox.Size = new Size(495, 23);
            connectionStringTextBox.TabIndex = 5;
            connectionStringTextBox.TextChanged += connectionStringTextBox_TextChanged;
            // 
            // delimiterTextBox
            // 
            delimiterTextBox.Location = new Point(195, 133);
            delimiterTextBox.Name = "delimiterTextBox";
            delimiterTextBox.Size = new Size(495, 23);
            delimiterTextBox.TabIndex = 7;
            delimiterTextBox.TextChanged += delimiterTextBox_TextChanged;
            // 
            // fileLocationTextBox
            // 
            fileLocationTextBox.Location = new Point(195, 163);
            fileLocationTextBox.Name = "fileLocationTextBox";
            fileLocationTextBox.Size = new Size(495, 23);
            fileLocationTextBox.TabIndex = 8;
            fileLocationTextBox.TextChanged += fileLocationTextBox_TextChanged;
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Location = new Point(195, 193);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.Size = new Size(495, 23);
            fileNameTextBox.TabIndex = 9;
            fileNameTextBox.TextChanged += fileNameTextBox_TextChanged;
            // 
            // queryTextBox
            // 
            queryTextBox.Location = new Point(195, 33);
            queryTextBox.Multiline = true;
            queryTextBox.Name = "queryTextBox";
            queryTextBox.Size = new Size(495, 90);
            queryTextBox.TabIndex = 10;
            queryTextBox.TextChanged += queryTextBox_TextChanged;
            // 
            // authenticationComboBox
            // 
            authenticationComboBox.AllowDrop = true;
            authenticationComboBox.FormattingEnabled = true;
            authenticationComboBox.Location = new Point(49, 70);
            authenticationComboBox.Name = "authenticationComboBox";
            authenticationComboBox.Size = new Size(194, 23);
            authenticationComboBox.TabIndex = 2;
            authenticationComboBox.SelectedIndexChanged += authenticationComboBox_SelectedIndexChanged;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(272, 409);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(194, 50);
            exportButton.TabIndex = 3;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(773, 546);
            Controls.Add(exportButton);
            Controls.Add(authenticationComboBox);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "Form1";
            Load += Form1_Load_1;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private TextBox connectionStringTextBox;
        private TextBox delimiterTextBox;
        private TextBox fileLocationTextBox;
        private TextBox fileNameTextBox;
        private ComboBox authenticationComboBox;
        private Button exportButton;
        private TextBox queryTextBox;
    }
}
