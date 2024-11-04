using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data_To_Csv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Populate AuthenticationType dropdown
            authenticationComboBox.Items.Add("Windows");
            authenticationComboBox.Items.Add("SQL Server");
            authenticationComboBox.SelectedIndex = 0; // Set default to Windows
        }

        private void authenticationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void connectionStringTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void delimiterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileLocationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            string authenticationType = authenticationComboBox.SelectedItem?.ToString() ?? string.Empty;
            string connectionString = connectionStringTextBox.Text.Trim();
            string query = queryTextBox.Text.Trim();  // New query TextBox
            string delimiter = delimiterTextBox.Text.Trim();
            string fileLocation = fileLocationTextBox.Text.Trim();
            string fileName = fileNameTextBox.Text.Trim();

            // Identify missing fields for better feedback
            StringBuilder missingFields = new StringBuilder();

            if (string.IsNullOrEmpty(connectionString)) missingFields.AppendLine("Connection String");
            if (string.IsNullOrEmpty(query)) missingFields.AppendLine("SQL Query"); // Check for query
            if (string.IsNullOrEmpty(delimiter)) missingFields.AppendLine("Delimiter");
            if (string.IsNullOrEmpty(fileLocation)) missingFields.AppendLine("File Location");
            if (string.IsNullOrEmpty(fileName)) missingFields.AppendLine("File Name");

            // Show specific error message if there are missing fields
            if (missingFields.Length > 0)
            {
                MessageBox.Show("Please fill in the following fields:\n" + missingFields.ToString());
                return;
            }

            string fullPath = Path.Combine(fileLocation, $"{fileName}.csv");

            // Establish SQL connection and export data
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Use the user-provided query instead of the table name
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Write to CSV file
                    using (StreamWriter writer = new StreamWriter(fullPath, false, Encoding.UTF8))
                    {
                        // Write headers
                        string[] columnNames = dataTable.Columns.Cast<DataColumn>()
                                                               .Select(column => column.ColumnName)
                                                               .ToArray();
                        writer.WriteLine(string.Join(delimiter, columnNames));

                        // Write data rows
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string[] fields = row.ItemArray.Select(field => field.ToString())
                                                           .ToArray();
                            writer.WriteLine(string.Join(delimiter, fields));
                        }
                    }

                    MessageBox.Show("Data exported successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message);
            }
        }

        private void queryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
