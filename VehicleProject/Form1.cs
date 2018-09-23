using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleProject
{
    public partial class Form1 : Form
    {
        private List<int> vehicleTypeIdList = new List<int>();
        private List<int> makeIdList = new List<int>();
        private List<int> modelIdList = new List<int>();

        public Form1()
        {
            InitializeComponent();

        }

        private DataTable loadTable()
        {
            DataTable carData = new DataTable();

            try
            {
                string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = "SELECT (SELECT ModelName from VehicleType WHERE VehicleType.VehicleTypeId = (SELECT VehicleTypeID FROM Model WHERE Model.ModelId = Vehicle.ModelId))AS Model, Make.makeName AS Make,modelYear AS Year,Price,SoldDate AS 'Sold Date' FROM Vehicle JOIN Model ON Model.ModelId = Vehicle.ModelId JOIN Make ON Make.MakeId = Vehicle.MakeId ORDER BY Price DESC;";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader dr = command.ExecuteReader();
                carData.Load(dr);

                connection.Close();
            }

            catch (Exception e)
            {
                Console.Write(e.GetBaseException());
            }
            return carData;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            dataGridView1.DataSource = loadTable();
            getAllMakeId();
            getAllModelId();
            getAllVehicleTypeId();
        }

        private void available_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = showAvailable();
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private DataTable showAvailable()
        {
            DataTable carData = new DataTable();

            try
            {
                string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = "SELECT (SELECT ModelName from VehicleType WHERE VehicleType.VehicleTypeId = (SELECT VehicleTypeID FROM Model WHERE Model.ModelId = Vehicle.ModelId))AS Model, Make.makeName AS Make,modelYear AS Year,Price,SoldDate AS 'Sold Date' FROM Vehicle JOIN Model ON Model.ModelId = Vehicle.ModelId JOIN Make ON Make.MakeId = Vehicle.MakeId WHERE SoldDate IS NULL;";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader dr = command.ExecuteReader();
                carData.Load(dr);

                connection.Close();
            }

            catch (Exception e)
            {
                Console.Write(e.GetBaseException());
            }
            return carData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = showSold();
            panel2.Visible = false;
            panel1.Visible = true;
        }
        private DataTable showSold()
        {
            DataTable carData = new DataTable();

            try
            {
                string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = "SELECT (SELECT ModelName from VehicleType WHERE VehicleType.VehicleTypeId = (SELECT VehicleTypeID FROM Model WHERE Model.ModelId = Vehicle.ModelId))AS Model, Make.makeName AS Make,modelYear AS Year,Price,SoldDate AS 'Sold Date' FROM Vehicle JOIN Model ON Model.ModelId = Vehicle.ModelId JOIN Make ON Make.MakeId = Vehicle.MakeId WHERE SoldDate IS NOT NULL;";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader dr = command.ExecuteReader();
                carData.Load(dr);

                connection.Close();
            }

            catch (Exception e)
            {
                Console.Write(e.GetBaseException());
            }
            return carData;
        }

        private void getVehicleSold()
        {
            string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT COUNT(VehicleId) FROM Vehicle WHERE SoldDate IS NOT NULL";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr.GetInt32(0).ToString() + " Vehicle Sold";
            }
            connection.Close();


        }

        private void getVehicleRemain()
        {
            string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT COUNT(VehicleId) FROM Vehicle WHERE SoldDate IS NULL";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text = dr.GetInt32(0).ToString() + " Vehicle Remaining";
            }
            connection.Close();
        }

        private void incomeGained()
        {
            string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT SUM(Price) FROM Vehicle WHERE SoldDate IS NOT NULL";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                textBox3.Text = "$" + dr.GetInt32(0).ToString();
            }
            connection.Close();
        }

        private void btn_Financial_Click(object sender, EventArgs e)
        {
            getVehicleSold();
            getVehicleRemain();
            incomeGained();

            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";

            saveFileDialog1.RestoreDirectory = true;

            saveFileDialog1.CheckPathExists = true;

            saveFileDialog1.Title = "Choose a file to save";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string result = "modelYear SoldDate Price MakeId ModelId makeName ModelName VehicleId - VehicleId, Make name and Model name are just for display, don't add them when add data " + Environment.NewLine;

                string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = "SELECT modelYear, SoldDate,  Price, Vehicle.MakeId, Vehicle.ModelId, makeName, ModelName, VehicleId FROM Vehicle JOIN Model on Vehicle.ModelId = Model.ModelId JOIN Make on Make.MakeId = Vehicle.MakeId";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string date = "";

                    if (!dr.IsDBNull(1))
                        date = dr.GetDateTime(1).ToString("yyyy-MM-dd");
                    else
                        date = "null";

                    result +=
                         Convert.ToInt16(dr.GetValue(0)).ToString() + " " + date + " " + dr.GetInt32(2).ToString() + " " + dr.GetInt32(3).ToString()
                        + " " + dr.GetInt32(4).ToString() + " " + dr.GetString(5) + " " + dr.GetString(6)+ " " + dr.GetInt32(7).ToString() + Environment.NewLine;
                }
                connection.Close();

                File.AppendAllText(saveFileDialog1.FileName + ".txt", result);
                MessageBox.Show("Successfully export data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";

            saveFileDialog1.RestoreDirectory = true;

            saveFileDialog1.CheckPathExists = true;

            saveFileDialog1.Title = "Choose a file to save";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string result = "ModelName EngineSize NumberOfDoors Colour VehicleTypeId  typeName ModelId - Do not include typeName and ModelId when add data" + Environment.NewLine;

                string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = "SELECT ModelName, EngineSize, NumberOfDoors, Colour, Model.VehicleTypeId, typeName, ModelId FROM Model JOIN VehicleType on Model.VehicleTypeId = VehicleType.VehicleTypeId";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    result +=
                        dr.GetString(0) + " " + dr.GetDecimal(1) + " " + dr.GetInt32(2).ToString()
                        + " " + dr.GetString(3) + " " + dr.GetInt32(4).ToString() + " " + dr.GetString(5) +" "+ dr.GetInt32(6).ToString() + Environment.NewLine;
                }
                connection.Close();

                File.AppendAllText(saveFileDialog1.FileName + ".txt", result);

                MessageBox.Show("Successfully export data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void makeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";

            saveFileDialog1.RestoreDirectory = true;

            saveFileDialog1.CheckPathExists = true;

            saveFileDialog1.Title = "Choose a file to save";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string result = "makeName MakeId - Do not include MakeId when add data" + Environment.NewLine;

                string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = "SELECT makeName, MakeId FROM Make";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    result +=
                        dr.GetString(0)+ " " + dr.GetInt32(1).ToString() + Environment.NewLine;
                }
                connection.Close();

                File.AppendAllText(saveFileDialog1.FileName + ".txt", result);
                MessageBox.Show("Successfully export data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void vehicleTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";

            saveFileDialog1.RestoreDirectory = true;

            saveFileDialog1.CheckPathExists = true;

            saveFileDialog1.Title = "Choose a file to save";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string result = "typeName VehicleTypeId - Do not include MakeId when add data" + Environment.NewLine;

                string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = "SELECT typeName, VehicleTypeId FROM VehicleType";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    result +=
                         dr.GetString(0) + " " + dr.GetInt32(1).ToString() + Environment.NewLine;
                }
                connection.Close();

                File.AppendAllText(saveFileDialog1.FileName + ".txt", result);

                MessageBox.Show("Successfully export data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void soldVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";

            saveFileDialog1.RestoreDirectory = true;

            saveFileDialog1.CheckPathExists = true;

            saveFileDialog1.Title = "Choose a file to save";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string result = "VehicleId modelYear SoldDate Price MakeId ModelId makeName ModelName" + Environment.NewLine;

                string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = "SELECT VehicleId, modelYear, SoldDate, Price,Vehicle.MakeId, Vehicle.ModelId,  makeName, ModelName  FROM Vehicle JOIN Model on Vehicle.ModelId = Model.ModelId JOIN Make on Make.MakeId = Vehicle.MakeId WHERE SoldDate IS NOT NULL";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    result +=
                        dr.GetInt32(0).ToString() + " " + Convert.ToInt16(dr.GetValue(1)).ToString() + " " + dr.GetDateTime(2).ToString("yyyy-MM-dd") + " " + dr.GetInt32(3).ToString() + " " + dr.GetInt32(4).ToString()
                        + " " + dr.GetInt32(5).ToString() + " " + dr.GetString(6) + " " + dr.GetString(7) + Environment.NewLine;
                }
                connection.Close();

                File.AppendAllText(saveFileDialog1.FileName + ".txt", result);
                MessageBox.Show("Successfully export data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void availableVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";

            saveFileDialog1.RestoreDirectory = true;

            saveFileDialog1.CheckPathExists = true;

            saveFileDialog1.Title = "Choose a file to save";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string result = "VehicleId modelYear SoldDate Price MakeId ModelId makeName ModelName" + Environment.NewLine;

                string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = "SELECT VehicleId, modelYear, SoldDate, Price,Vehicle.MakeId, Vehicle.ModelId,  makeName, ModelName  FROM Vehicle JOIN Model on Vehicle.ModelId = Model.ModelId JOIN Make on Make.MakeId = Vehicle.MakeId WHERE SoldDate IS NULL";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string date = "";

                    if (!dr.IsDBNull(2))
                        date = dr.GetDateTime(2).ToString("yyyy-MM-dd");
                    else
                        date = "null";

                    result +=
                        dr.GetInt32(0).ToString() + " " + Convert.ToInt16(dr.GetValue(1)).ToString() + " " + date + " " + dr.GetInt32(3).ToString() + " " + dr.GetInt32(4).ToString()
                        + " " + dr.GetInt32(5).ToString() + " " + dr.GetString(6) + " " + dr.GetString(7) + Environment.NewLine;
                }
                connection.Close();

                File.AppendAllText(saveFileDialog1.FileName + ".txt", result);
                MessageBox.Show("Successfully export data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void financialSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";

            saveFileDialog1.RestoreDirectory = true;

            saveFileDialog1.CheckPathExists = true;

            saveFileDialog1.Title = "Choose a file to save";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string result = "";

                string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = "SELECT SUM(Price) FROM Vehicle WHERE SoldDate IS NOT NULL";
                string query2 = "SELECT SUM(Price) FROM Vehicle WHERE SoldDate IS NULL";


                // Create the first command and execute
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result = "Total Income Gained is $" + reader.GetInt32(0).ToString() + Environment.NewLine;
                }
                reader.Close();

                // Change the SQL Command and execute
                SqlCommand command2 = new SqlCommand(query2, connection);
                SqlDataReader reader2 = command2.ExecuteReader();
                
                   
                while (reader2.Read())
                {
                            result += "Total Value of Vehicles Left is $" + reader2.GetInt32(0).ToString() ;
                }
                    
          
                 connection.Close();
                

                
                File.AppendAllText(saveFileDialog1.FileName + ".txt", result);
                MessageBox.Show("Successfully export data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void vehicleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("https://bennycar.azurewebsites.net/Vehicles/Create");
            Process.Start(info);
        }

        private void modelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("https://bennycar.azurewebsites.net/VehicleModels/Create");
            Process.Start(info);
            
        }

        private void makeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("https://bennycar.azurewebsites.net/Makes/Create");
            Process.Start(info);
        }

        private void vehicleTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("https://bennycar.azurewebsites.net/VehicleTypes/Create");
            Process.Start(info);
        }

        private void getAllModelId()
        {
            string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT ModelId FROM Model";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                modelIdList.Add(dr.GetInt32(0));
            }
            connection.Close();
        }

        private void getAllMakeId()
        {
            string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT MakeId FROM Make";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                makeIdList.Add(dr.GetInt32(0));
            }
            connection.Close();
        }

        private void getAllVehicleTypeId()
        {
            string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT VehicleTypeId FROM VehicleType";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                vehicleTypeIdList.Add(dr.GetInt32(0));
            }
            connection.Close();
        }

        private void vehicleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";

            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.Title = "Choose a file to open";

            //check file type
            openFileDialog1.Filter = "Data files |*.csv;*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog1.FileName).Where(l => !string.IsNullOrEmpty(l)).ToArray();

                for (int i=1; i<lines.Length; i++)
                {
                    try
                    {
                        string[] data = lines[i].Split(' ');

                        string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
                        SqlConnection connection = new SqlConnection(connectionString);
                        connection.Open();

                        //check for null id value
                        if ( !makeIdList.Contains(Convert.ToInt32(data[3])) || !modelIdList.Contains(Convert.ToInt32(data[4])))
                        {
                            throw new Exception("Cannot add id that does not exist in Model or Make table");
                        }
                        else
                        {
                            //INSERT
                            string query = "INSERT INTO Vehicle ( MakeId, ModelId, modelYear, Price, SoldDate) VALUES ( @MakeID, @ModelId, @Year, @Price, @SoldDate)";

                            SqlCommand command = new SqlCommand(query, connection);

                            command.Parameters.Add(new SqlParameter("Year", data[0]));
                            if (data[1] == "null")
                                command.Parameters.Add(new SqlParameter("SoldDate", DBNull.Value));
                            else
                                command.Parameters.Add(new SqlParameter("SoldDate", data[1]));
                            command.Parameters.Add(new SqlParameter("Price", data[2]));
                            command.Parameters.Add(new SqlParameter("ModelId", data[4]));
                            command.Parameters.Add(new SqlParameter("MakeId", data[3]));

                            command.ExecuteNonQuery();

                            connection.Close();
                        }
                        MessageBox.Show("Successfully insert data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }


        }

        private void modelToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";

            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.Title = "Choose a file to open";

            //check file type
            openFileDialog1.Filter = "Data files |*.csv;*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog1.FileName).Where(l => !string.IsNullOrEmpty(l)).ToArray();

                for (int i = 1; i < lines.Length; i++)
                {
                    try
                    {
                        string[] data = lines[i].Split(' ');

                        string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
                        SqlConnection connection = new SqlConnection(connectionString);
                        connection.Open();

                        //check for null id value
                        if (!vehicleTypeIdList.Contains(Convert.ToInt32(data[4])) )
                        {
                            throw new Exception("Cannot add id that does not exist in VehicleType table");
                        }
                        else
                        {
                            //INSERT
                            string query = "INSERT INTO Model (ModelName, EngineSize, NumberOfDoors, Colour, VehicleTypeId) VALUES ( @Name, @ES, @NOD, @C, @ID)";

                            SqlCommand command = new SqlCommand(query, connection);

                            command.Parameters.Add(new SqlParameter("Name", data[0]));
                            command.Parameters.Add(new SqlParameter("ES", data[1]));
                            command.Parameters.Add(new SqlParameter("NOD", data[2]));
                            command.Parameters.Add(new SqlParameter("C", data[3]));
                            command.Parameters.Add(new SqlParameter("ID", data[4]));

                            command.ExecuteNonQuery();

                            connection.Close();
                        }
                        MessageBox.Show("Successfully insert data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void makeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";

            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.Title = "Choose a file to open";

            //check file type
            openFileDialog1.Filter = "Data files |*.csv;*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog1.FileName).Where(l => !string.IsNullOrEmpty(l)).ToArray();

                for (int i = 1; i < lines.Length; i++)
                {
                    try
                    {
                        string[] data = lines[i].Split(' ');

                        string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
                        SqlConnection connection = new SqlConnection(connectionString);
                        connection.Open();

                        ////check for null id value
                        //if (!vehicleTypeIdList.Contains(Convert.ToInt32(data[])))
                        //{
                        //    throw new Exception("Cannot add id that does not exist in VehicleType table");
                        //}
                        //else
                        //{
                            //INSERT
                            string query = "INSERT INTO Make (makeName) VALUES ( @Name)";

                            SqlCommand command = new SqlCommand(query, connection);

                            command.Parameters.Add(new SqlParameter("Name", data[0]));

                            command.ExecuteNonQuery();

                            connection.Close();
                            MessageBox.Show("Successfully insert data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void vehicleTypeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";

            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.Title = "Choose a file to open";

            //check file type
            openFileDialog1.Filter = "Data files |*.csv;*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog1.FileName).Where(l => !string.IsNullOrEmpty(l)).ToArray();

                for (int i = 1; i < lines.Length; i++)
                {
                    try
                    {
                        string[] data = lines[i].Split(' ');

                        string connectionString = @"Data Source=bennycars.database.windows.net;Initial Catalog=car;User id=teck;Password=asdFGH12#;Integrated Security=True;Trusted_Connection=False;Encrypt=True;";
                        SqlConnection connection = new SqlConnection(connectionString);
                        connection.Open();

                        ////check for null id value
                        //if (!vehicleTypeIdList.Contains(Convert.ToInt32(data[])))
                        //{
                        //    throw new Exception("Cannot add id that does not exist in VehicleType table");
                        //}
                        //else
                        //{
                        //INSERT
                        string query = "INSERT INTO VehicleType (typeName) VALUES ( @Name)";

                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.Add(new SqlParameter("Name", data[0]));

                        command.ExecuteNonQuery();

                        connection.Close();
                        MessageBox.Show("Successfully insert data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            dataGridView1.DataSource = loadTable();
            getAllMakeId();
            getAllModelId();
            getAllVehicleTypeId();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            dataGridView1.DataSource = loadTable();
        }
        
    }
}
