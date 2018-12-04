using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace StackBuilderConfigurationTool
{
    public partial class frmMain : Form
    {

        public string dbConnection = string.Empty;
        public DataTable devices = new DataTable();
        public DataTable configs = new DataTable();
        public DataTable engines = new DataTable();
        public DataTable tabs = new DataTable();
        public DataTable scenes = new DataTable();
        public DataTable tabConfig = new DataTable();
        public string currentConfig = string.Empty;

        public class EngineRec
        {
            public string config { get; set; }
            public string Eng1_Name { get; set; }
            public int Eng1_Port { get; set; }
            public bool Eng1_Enable { get; set; }
            public string Eng2_Name { get; set; }
            public int Eng2_Port { get; set; }
            public bool Eng2_Enable { get; set; }
            public string Eng3_Name { get; set; }
            public int Eng3_Port { get; set; }
            public bool Eng3_Enable { get; set; }
            public string Eng4_Name { get; set; }
            public int Eng4_Port { get; set; }
            public bool Eng4_Enable { get; set; }

        }

        public class TabRec
        {
            public string config { get; set; }
            public bool Raceboards { get; set; }
            public bool VoterAnalysis { get; set; }
            public bool BOP { get; set; }
            public bool Referendums { get; set; }
            public bool SidePanel { get; set; }
            public bool Maps { get; set; }
            public bool StackBuildOnly { get; set; }
            public string Network { get; set; }

        }

        public class SceneRec
        {
            public string SceneCode { get; set; }
            public string ScenePath { get; set; }
            public string Network { get; set; }
            public int DataType { get; set; }
        }
        public class AddSceneRec
        {
            public string config { get; set; }
            public string SceneCode { get; set; }
            public int DataType { get; set; }
            public string TabName { get; set; }
            public int EngineNo { get; set; }
        }

        public class TabConfigRec
        {
            public string config { get; set; }
            public string Tabname { get; set; }
            public int EngineNo { get; set; }
            public string SceneCode { get; set; }
        }

        
        public string[] TabNames = new string[6] {"RaceBoards","VoterAnalysis","BOP","Referendums","SidePanel","Maps"};

        public EngineRec initEngine = new EngineRec();
        public TabRec initTabs = new TabRec();
        public SceneRec initScenes = new SceneRec();
        public SceneRec availScenes = new SceneRec();
        //public TabConfigRec tabConfig = new TabConfigRec();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Set version number
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = String.Format("Stack Builder Configuration Tool   Version {0}", version);
            dbConnection = Properties.Settings.Default.dbConnection;
            init();

        }

        public void init()
        {
            var builder = new SqlConnectionStringBuilder(dbConnection);
            var dataSource = builder.DataSource;
            var initCat = builder.InitialCatalog;
            var user = builder.UserID;
            var pw = builder.Password;

            lblDB.Text = $"DB Connection: {dataSource}  {initCat}";

            initEngine.config = "";
            initEngine.Eng1_Name = "";
            initEngine.Eng1_Port = 6100;
            initEngine.Eng1_Enable = false;

            initEngine.Eng2_Name = "";
            initEngine.Eng2_Port = 6100;
            initEngine.Eng2_Enable = false;

            initEngine.Eng3_Name = "";
            initEngine.Eng3_Port = 6100;
            initEngine.Eng3_Enable = false;

            initEngine.Eng4_Name = "";
            initEngine.Eng4_Port = 6100;
            initEngine.Eng4_Enable = false;


            initTabs.config = "";
            initTabs.Raceboards = false;
            initTabs.VoterAnalysis = false;
            initTabs.BOP = false;
            initTabs.Referendums = false;
            initTabs.StackBuildOnly = true;
            initTabs.Network = "FNC";




            // set up engines grid
            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.HeaderText = "Name";
            dgvEngines.Columns.Add(col0);

            DataGridViewComboBoxColumn col1 = new DataGridViewComboBoxColumn();
            col1.HeaderText = "Engine1";
            dgvEngines.Columns.Add(col1);

            DataGridViewComboBoxColumn col2 = new DataGridViewComboBoxColumn();
            col2.HeaderText = "Port1";
            dgvEngines.Columns.Add(col2);

            DataGridViewCheckBoxColumn col3 = new DataGridViewCheckBoxColumn();
            col3.HeaderText = "Enable1";
            dgvEngines.Columns.Add(col3);


            DataGridViewComboBoxColumn col4 = new DataGridViewComboBoxColumn();
            col4.HeaderText = "Engine2";
            dgvEngines.Columns.Add(col4);

            DataGridViewComboBoxColumn col5 = new DataGridViewComboBoxColumn();
            col5.HeaderText = "Port2";
            dgvEngines.Columns.Add(col5);

            DataGridViewCheckBoxColumn col6 = new DataGridViewCheckBoxColumn();
            col6.HeaderText = "Enable2";
            dgvEngines.Columns.Add(col6);


            DataGridViewComboBoxColumn col7 = new DataGridViewComboBoxColumn();
            col7.HeaderText = "Engine3";
            dgvEngines.Columns.Add(col7);

            DataGridViewComboBoxColumn col8 = new DataGridViewComboBoxColumn();
            col8.HeaderText = "Port3";
            dgvEngines.Columns.Add(col8);

            DataGridViewCheckBoxColumn col9 = new DataGridViewCheckBoxColumn();
            col9.HeaderText = "Enable3";
            dgvEngines.Columns.Add(col9);


            DataGridViewComboBoxColumn col10 = new DataGridViewComboBoxColumn();
            col10.HeaderText = "Engine4";
            dgvEngines.Columns.Add(col10);

            DataGridViewComboBoxColumn col11 = new DataGridViewComboBoxColumn();
            col11.HeaderText = "Port4";
            dgvEngines.Columns.Add(col11);

            DataGridViewCheckBoxColumn col12 = new DataGridViewCheckBoxColumn();
            col12.HeaderText = "Enable4";
            dgvEngines.Columns.Add(col12);

            col2.Items.Add("6100");
            col2.Items.Add("6707");
            col2.Items.Add("6800");

            col5.Items.Add("6100");
            col5.Items.Add("6707");
            col5.Items.Add("6800");

            col8.Items.Add("6100");
            col8.Items.Add("6707");
            col8.Items.Add("6800");

            col11.Items.Add("6100");
            col11.Items.Add("6707");
            col11.Items.Add("6800");

            dgvEngines.Rows[0].Cells[2].Value = "6100";
            dgvEngines.Rows[0].Cells[5].Value = "6100";
            dgvEngines.Rows[0].Cells[8].Value = "6100";
            dgvEngines.Rows[0].Cells[11].Value = "6100";


            dgvEngines.Columns[0].Width = 150;
            dgvEngines.Columns[1].Width = 150;
            dgvEngines.Columns[2].Width = 85;
            dgvEngines.Columns[3].Width = 105;
            dgvEngines.Columns[4].Width = 150;
            dgvEngines.Columns[5].Width = 85;
            dgvEngines.Columns[6].Width = 105;
            dgvEngines.Columns[7].Width = 150;
            dgvEngines.Columns[8].Width = 85;
            dgvEngines.Columns[9].Width = 105;
            dgvEngines.Columns[10].Width = 150;
            dgvEngines.Columns[11].Width = 85;
            dgvEngines.Columns[12].Width = 105;

            string cmd = $"SELECT Name, IP_Address, Notes, Config1 FROM FE_Devices";
            devices = GetDBData(cmd, dbConnection);
            dgvDevices.DataSource = null;
            dgvDevices.DataSource = devices;
            dgvDevices.Columns["Name"].Width = 170;
            dgvDevices.Columns["IP_Address"].Width = 125;
            dgvDevices.Columns["Notes"].Width = 140;
            dgvDevices.Columns["Config1"].Width = 180;

            // initialize engine comboboxes
            cmd = $"SELECT Name FROM FE_Devices WHERE Type = '1'";
            DataTable engs = new DataTable();
            engs = GetDBData(cmd, dbConnection);
            string engName;

            for (int i = 0; i < engs.Rows.Count; i++)
            {
                DataRow row = engs.Rows[i];
                engName = row["Name"].ToString().Trim();
                col1.Items.Add(engName);
                col4.Items.Add(engName);
                col7.Items.Add(engName);
                col10.Items.Add(engName);

            }


            cmd = $"SELECT DISTINCT Config1 FROM FE_Devices";
            configs = GetDBData(cmd, dbConnection);

            string deviceName;
            string configName;

            // initialize device name combobox
            for (int i = 0; i < devices.Rows.Count; i++)
            {
                DataRow row = devices.Rows[i];
                deviceName = row["Name"].ToString().Trim();
                cbDevices.Items.Add(deviceName);

            }

            // initialize config combobox
            for (int i = 0; i < configs.Rows.Count; i++)
            {
                DataRow row = configs.Rows[i];
                configName = row["Config1"].ToString().Trim();
                if (configName != "")
                    cbConfig.Items.Add(configName);
            }

            string config = "";
            cmd = $"SELECT * FROM FE_Tabs WHERE Config = '{config}'";
            tabs = GetDBData(cmd, dbConnection);
            if (tabs.Rows.Count > 0)
                dgvTabs.DataSource = tabs;
            else
            {
                initTabs.config = "";
                SetFE_Tabs(initTabs);
                cmd = $"SELECT * FROM FE_Tabs WHERE Config = '{config}'";
                tabs = GetDBData(cmd, dbConnection);
            }

            dgvTabs.Columns[0].Width = 150;
            dgvTabs.Columns[1].Width = 110;
            dgvTabs.Columns[2].Width = 120;
            dgvTabs.Columns[3].Width = 80;
            dgvTabs.Columns[4].Width = 120;
            dgvTabs.Columns[5].Width = 120;
            dgvTabs.Columns[6].Width = 80;
            dgvTabs.Columns[7].Width = 150;
            dgvTabs.Columns[8].Width = 110;

            dgvTabs.Columns[7].HeaderText = "Multiplay Only";


        }
        public static DataTable GetDBData(string cmdStr, string dbConnection)
        {
            DataTable dataTable = new DataTable();

            try
            {
                // Instantiate the connection
                using (SqlConnection connection = new SqlConnection(dbConnection))
                {
                    // Create the command and set its properties
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                        {
                            cmd.CommandText = cmdStr;
                            //cmd.Parameters.Add("@StackID", SqlDbType.Float).Value = stackID;
                            sqlDataAdapter.SelectCommand = cmd;
                            sqlDataAdapter.SelectCommand.Connection = connection;
                            sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;

                            // Fill the datatable from adapter
                            sqlDataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error
                //log.Error("GetDBData Exception occurred: " + ex.Message);
                //log.Debug("GetDBData Exception occurred", ex);
            }

            return dataTable;
        }

        private void cbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Index = cbDevices.SelectedIndex;
            dgvDevices.CurrentCell = dgvDevices.Rows[Index].Cells[0];
            string config = dgvDevices.Rows[Index].Cells[3].Value.ToString();
            cbConfig.Text = config;
            
            GetConfigInfo(config);

        }

        
        public void GetConfigInfo(string config)
        {
            string cmd = $"SELECT * FROM FE_EngineDefs WHERE Config = '{config}'";
            engines = GetDBData(cmd, dbConnection);
            string n;
            string e1;
            string p1;
            bool en1;

            if (engines.Rows.Count > 0)
            {
                DataRow row = engines.Rows[0];
                n = row[0].ToString().Trim();
                e1 = row[1].ToString().Trim();
                p1 = row[2].ToString().Trim() ?? "6100";
                en1 = Convert.ToBoolean(row[3]);
                dgvEngines.Rows[0].Cells[0].Value = n;
                dgvEngines.Rows[0].Cells[1].Value = e1;
                dgvEngines.Rows[0].Cells[2].Value = p1;
                dgvEngines.Rows[0].Cells[3].Value = en1;

                e1 = row[4].ToString().Trim();
                p1 = row[5].ToString().Trim() ?? "6100";
                en1 = Convert.ToBoolean(row[6]);
                dgvEngines.Rows[0].Cells[4].Value = e1;
                dgvEngines.Rows[0].Cells[5].Value = p1;
                dgvEngines.Rows[0].Cells[6].Value = en1;

                e1 = row[7].ToString().Trim();
                p1 = row[8].ToString().Trim() ?? "6100";
                en1 = Convert.ToBoolean(row[9]);
                dgvEngines.Rows[0].Cells[7].Value = e1;
                dgvEngines.Rows[0].Cells[8].Value = p1;
                dgvEngines.Rows[0].Cells[9].Value = en1;

                e1 = row[10].ToString().Trim();
                p1 = row[11].ToString().Trim() ?? "6100";
                en1 = Convert.ToBoolean(row[12] ?? false);
                dgvEngines.Rows[0].Cells[10].Value = e1;
                dgvEngines.Rows[0].Cells[11].Value = p1;
                dgvEngines.Rows[0].Cells[12].Value = en1;


            }
            else
            {
                initEngine.config = config;
                SetFE_EngineDefs(initEngine);
            }

            string Network = "FNC";

            
            cmd = $"SELECT * FROM FE_Tabs WHERE Config = '{config}'";
            tabs = GetDBData(cmd, dbConnection);

            BindingSource SBind = new BindingSource();
            SBind.DataSource = tabs;
            dgvTabs.DataSource = SBind;

            if (tabs.Rows.Count > 0)
            {
                dgvTabs.DataSource = tabs;
                Network = dgvTabs.Rows[0].Cells[8].Value.ToString();
            }
            else
            {
                initTabs.config = config;
                SetFE_Tabs(initTabs);
            }

            
            dgvTabs.Columns[0].Width = 150;
            dgvTabs.Columns[1].Width = 110;
            dgvTabs.Columns[2].Width = 120;
            dgvTabs.Columns[3].Width = 80;
            dgvTabs.Columns[4].Width = 120;
            dgvTabs.Columns[5].Width = 120;
            dgvTabs.Columns[6].Width = 80;
            dgvTabs.Columns[7].Width = 150;
            dgvTabs.Columns[8].Width = 110;

            cmd = $"SELECT Name, IP_Address, Notes, Config1 FROM FE_Devices";
            devices = GetDBData(cmd, dbConnection);
            int index = dgvDevices.CurrentCell.RowIndex;
            dgvDevices.DataSource = null;
            dgvDevices.DataSource = devices;
            dgvDevices.Columns["Name"].Width = 200;
            dgvDevices.Columns["IP_Address"].Width = 150;
            dgvDevices.Columns["Notes"].Width = 150;
            dgvDevices.Columns["Config1"].Width = 200;
            dgvDevices.CurrentCell = dgvDevices.Rows[index].Cells[0];
            cbConfig.Text = config;


            cmd = $"SELECT * FROM FE_TabConfig WHERE Config = '{config}'";
            tabConfig = GetDBData(cmd, dbConnection);

            BindingSource SBind1 = new BindingSource();
            SBind1.DataSource = tabConfig;
            dgvScenes.DataSource = SBind1;

            if (tabConfig.Rows.Count > 0)
            {
                dgvScenes.Columns[0].Width = 200;
                dgvScenes.Columns[1].Width = 120;
                dgvScenes.Columns[2].Width = 100;
                dgvScenes.Columns[3].Width = 180;

            }

            cmd = $"SELECT * FROM FE_Scenes WHERE Network = '{Network}'";
            scenes = GetDBData(cmd, dbConnection);
            if (scenes.Rows.Count > 0)
            {
                dgvAvailableScenes.DataSource = scenes;
             
                dgvAvailableScenes.Columns[0].Width = 135;
                dgvAvailableScenes.Columns[1].Width = 470;
                dgvAvailableScenes.Columns[2].Width = 75;
                dgvAvailableScenes.Columns[3].Width = 120;

            }


        }
        private void UpdateConfigName(string Name, string Config1)
        {
            string cmdStr;

            cmdStr = "setConfig @Name, @Config1";

            //Save out the top-level metadata
            try
            {
                // Instantiate the connection
                using (SqlConnection connection = new SqlConnection(dbConnection))
                {
                    connection.Open();

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {

                            SqlTransaction transaction;
                            // Start a local transaction.
                            transaction = connection.BeginTransaction("Update Config");

                            // Must assign both transaction object and connection 
                            // to Command object for a pending local transaction
                            cmd.Connection = connection;
                            cmd.Transaction = transaction;

                            try
                            {
                                //Specify base command
                                cmd.CommandText = cmdStr;

                                
                                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
                                cmd.Parameters.Add("@Config1", SqlDbType.VarChar).Value = Config1;

                                sqlDataAdapter.SelectCommand = cmd;
                                sqlDataAdapter.SelectCommand.Connection = connection;
                                sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;

                                // Execute stored proc to store top-level metadata
                                sqlDataAdapter.SelectCommand.ExecuteNonQuery();

                                //Attempt to commit the transaction
                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                //log.Error("UpdateData- SQL Command Exception occurred: " + ex.Message);
                                //log.Debug("UpdateData- SQL Command Exception occurred", ex);
                            }
                        }
                    }
                    connection.Close();
                }
                Thread.Sleep(100);
                GetConfigInfo(Config1);
            }
            catch (Exception ex)
            {
                //log.Error("UpdateData- SQL Connection Exception occurred: " + ex.Message);
                //log.Debug("UpdateData- SQL Connection Exception occurred", ex);
            }
        }
        private void UpdateFE_Tabs(DataTable tabs)
        {
            string cmdStr;

            cmdStr = "setFE_Tabs @Config, @Raceboards, @VoterAnalysis, @BOP, @Referendums, @SidePanel, @Maps, @BuilderOnly, @Network";

            //Save out the top-level metadata
            try
            {
                DataRow row = tabs.Rows[0];
                string Config = row[0].ToString().Trim();
                
                // Instantiate the connection
                using (SqlConnection connection = new SqlConnection(dbConnection))
                {
                    connection.Open();

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {

                            SqlTransaction transaction;
                            // Start a local transaction.
                            transaction = connection.BeginTransaction("Update Config");

                            // Must assign both transaction object and connection 
                            // to Command object for a pending local transaction
                            cmd.Connection = connection;
                            cmd.Transaction = transaction;

                            try
                            {
                                //Specify base command
                                cmd.CommandText = cmdStr;

                                cmd.Parameters.Add("@Config", SqlDbType.VarChar).Value = row[0].ToString().Trim();
                                cmd.Parameters.Add("@RaceBoards", SqlDbType.Bit).Value = Convert.ToBoolean(row[1]);
                                cmd.Parameters.Add("@VoterAnalysis", SqlDbType.Bit).Value = Convert.ToBoolean(row[2]);
                                cmd.Parameters.Add("@BOP", SqlDbType.Bit).Value = Convert.ToBoolean(row[3]);
                                cmd.Parameters.Add("@Referendums", SqlDbType.Bit).Value = Convert.ToBoolean(row[4]);
                                cmd.Parameters.Add("@SidePanel", SqlDbType.Bit).Value = Convert.ToBoolean(row[5]);
                                cmd.Parameters.Add("@Maps", SqlDbType.Bit).Value = Convert.ToBoolean(row[6]);
                                cmd.Parameters.Add("@BuilderOnly", SqlDbType.Bit).Value = Convert.ToBoolean(row[7]);
                                cmd.Parameters.Add("@Network", SqlDbType.VarChar).Value = row[8].ToString().Trim();

                                sqlDataAdapter.SelectCommand = cmd;
                                sqlDataAdapter.SelectCommand.Connection = connection;
                                sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;

                                // Execute stored proc to store top-level metadata
                                sqlDataAdapter.SelectCommand.ExecuteNonQuery();

                                //Attempt to commit the transaction
                                transaction.Commit();

                                
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                //log.Error("UpdateData- SQL Command Exception occurred: " + ex.Message);
                                //log.Debug("UpdateData- SQL Command Exception occurred", ex);
                            }
                        }
                    }
                    connection.Close();
                }
                GetConfigInfo(Config);
            }
            catch (Exception ex)
            {
                //log.Error("UpdateData- SQL Connection Exception occurred: " + ex.Message);
                //log.Debug("UpdateData- SQL Connection Exception occurred", ex);
            }
        }
        private void SetFE_Tabs(TabRec tabs)
        {
            string cmdStr;

            cmdStr = "setFE_Tabs @Config, @Raceboards, @VoterAnalysis, @BOP, @Referendums, @SidePanel, @Maps, @BuilderOnly, @Network";

            //Save out the top-level metadata
            try
            {
                string Config = tabs.config;

                // Instantiate the connection
                using (SqlConnection connection = new SqlConnection(dbConnection))
                {
                    connection.Open();

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {

                            SqlTransaction transaction;
                            // Start a local transaction.
                            transaction = connection.BeginTransaction("Update Config");

                            // Must assign both transaction object and connection 
                            // to Command object for a pending local transaction
                            cmd.Connection = connection;
                            cmd.Transaction = transaction;

                            try
                            {
                                //Specify base command
                                cmd.CommandText = cmdStr;

                                cmd.Parameters.Add("@Config", SqlDbType.VarChar).Value = tabs.config;
                                cmd.Parameters.Add("@RaceBoards", SqlDbType.Bit).Value = tabs.Raceboards;
                                cmd.Parameters.Add("@VoterAnalysis", SqlDbType.Bit).Value = tabs.VoterAnalysis;
                                cmd.Parameters.Add("@BOP", SqlDbType.Bit).Value = tabs.BOP;
                                cmd.Parameters.Add("@Referendums", SqlDbType.Bit).Value = tabs.Referendums;
                                cmd.Parameters.Add("@SidePanel", SqlDbType.Bit).Value = tabs.SidePanel;
                                cmd.Parameters.Add("@Maps", SqlDbType.Bit).Value = tabs.Maps;
                                cmd.Parameters.Add("@BuilderOnly", SqlDbType.Bit).Value = tabs.StackBuildOnly;
                                cmd.Parameters.Add("@Network", SqlDbType.VarChar).Value = tabs.Network;

                                sqlDataAdapter.SelectCommand = cmd;
                                sqlDataAdapter.SelectCommand.Connection = connection;
                                sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;

                                // Execute stored proc to store top-level metadata
                                sqlDataAdapter.SelectCommand.ExecuteNonQuery();

                                //Attempt to commit the transaction
                                transaction.Commit();


                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                //log.Error("UpdateData- SQL Command Exception occurred: " + ex.Message);
                                //log.Debug("UpdateData- SQL Command Exception occurred", ex);
                            }
                        }
                    }
                    connection.Close();
                }
                //GetConfigInfo(Config);
            }
            catch (Exception ex)
            {
                //log.Error("UpdateData- SQL Connection Exception occurred: " + ex.Message);
                //log.Debug("UpdateData- SQL Connection Exception occurred", ex);
            }
        }

        private void btnConfigUpdate_Click(object sender, EventArgs e)
        {
            UpdateConfigName(cbDevices.Text, cbConfig.Text);
            currentConfig = cbConfig.Text;
            int index = dgvDevices.CurrentCell.RowIndex;
            dgvDevices.DataSource = null;
            dgvDevices.DataSource = devices;
            dgvDevices.Columns["Name"].Width = 200;
            dgvDevices.Columns["IP_Address"].Width = 150;
            dgvDevices.Columns["Notes"].Width = 150;
            dgvDevices.Columns["Config1"].Width = 200;
            dgvDevices.CurrentCell = dgvDevices.Rows[index].Cells[0];

        }

        public void UpdateAllTables()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateFE_Tabs(tabs);
        }

        private void UpdateFE_EngineDefs(DataTable engines)
        {
            string cmdStr;

            cmdStr = "setFE_EnginesDefs @Config, @Eng1_Name, @Eng1_Port, @Eng1_Enable, @Eng2_Name, @Eng2_Port, @Eng2_Enable, @Eng3_Name, @Eng3_Port, @Eng3_Enable, @Eng4_Name, @Eng4_Port, @Eng4_Enable";

            //Save out the top-level metadata
            try
            {
                DataRow row = engines.Rows[0];
                string Config = row[0].ToString().Trim();

                // Instantiate the connection
                using (SqlConnection connection = new SqlConnection(dbConnection))
                {
                    connection.Open();

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {

                            SqlTransaction transaction;
                            // Start a local transaction.
                            transaction = connection.BeginTransaction("Update Config");

                            // Must assign both transaction object and connection 
                            // to Command object for a pending local transaction
                            cmd.Connection = connection;
                            cmd.Transaction = transaction;

                            try
                            {
                                //Specify base command
                                cmd.CommandText = cmdStr;

                                cmd.Parameters.Add("@Config", SqlDbType.VarChar).Value = row[0].ToString().Trim();
                                cmd.Parameters.Add("@Eng1_Name", SqlDbType.VarChar).Value = row[1].ToString().Trim();
                                cmd.Parameters.Add("@Eng1_Port", SqlDbType.Int).Value = Convert.ToInt32(row[2]);
                                cmd.Parameters.Add("@Eng1_Enable", SqlDbType.Bit).Value = Convert.ToBoolean(row[3]);

                                cmd.Parameters.Add("@Eng2_Name", SqlDbType.VarChar).Value = row[4].ToString().Trim();
                                cmd.Parameters.Add("@Eng2_Port", SqlDbType.Int).Value = Convert.ToInt32(row[5]);
                                cmd.Parameters.Add("@Eng2_Enable", SqlDbType.Bit).Value = Convert.ToBoolean(row[6]);

                                cmd.Parameters.Add("@Eng3_Name", SqlDbType.VarChar).Value = row[7].ToString().Trim();
                                cmd.Parameters.Add("@Eng3_Port", SqlDbType.Int).Value = Convert.ToInt32(row[8]);
                                cmd.Parameters.Add("@Eng3_Enable", SqlDbType.Bit).Value = Convert.ToBoolean(row[9]);

                                cmd.Parameters.Add("@Eng4_Name", SqlDbType.VarChar).Value = row[10].ToString().Trim();
                                cmd.Parameters.Add("@Eng4_Port", SqlDbType.Int).Value = Convert.ToInt32(row[11]);
                                cmd.Parameters.Add("@Eng4_Enable", SqlDbType.Bit).Value = Convert.ToBoolean(row[12]);

                                sqlDataAdapter.SelectCommand = cmd;
                                sqlDataAdapter.SelectCommand.Connection = connection;
                                sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;

                                // Execute stored proc to store top-level metadata
                                sqlDataAdapter.SelectCommand.ExecuteNonQuery();

                                //Attempt to commit the transaction
                                transaction.Commit();


                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                //log.Error("UpdateData- SQL Command Exception occurred: " + ex.Message);
                                //log.Debug("UpdateData- SQL Command Exception occurred", ex);
                            }
                        }
                    }
                    connection.Close();
                }
                GetConfigInfo(Config);
            }
            catch (Exception ex)
            {
                //log.Error("UpdateData- SQL Connection Exception occurred: " + ex.Message);
                //log.Debug("UpdateData- SQL Connection Exception occurred", ex);
            }
        }

        private void SetFE_EngineDefs(EngineRec engines)
        {
            string cmdStr;

            cmdStr = "setFE_EnginesDefs @Config, @Eng1_Name, @Eng1_Port, @Eng1_Enable, @Eng2_Name, @Eng2_Port, @Eng2_Enable, @Eng3_Name, @Eng3_Port, @Eng3_Enable, @Eng4_Name, @Eng4_Port, @Eng4_Enable";

            //Save out the top-level metadata
            try
            {
                string Config = engines.config;

                // Instantiate the connection
                using (SqlConnection connection = new SqlConnection(dbConnection))
                {
                    connection.Open();

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {

                            SqlTransaction transaction;
                            // Start a local transaction.
                            transaction = connection.BeginTransaction("Update Config");

                            // Must assign both transaction object and connection 
                            // to Command object for a pending local transaction
                            cmd.Connection = connection;
                            cmd.Transaction = transaction;

                            try
                            {
                                //Specify base command
                                cmd.CommandText = cmdStr;

                                cmd.Parameters.Add("@Config", SqlDbType.VarChar).Value = engines.config;
                                cmd.Parameters.Add("@Eng1_Name", SqlDbType.VarChar).Value = engines.Eng1_Name;
                                cmd.Parameters.Add("@Eng1_Port", SqlDbType.Int).Value = engines.Eng1_Port;
                                cmd.Parameters.Add("@Eng1_Enable", SqlDbType.Bit).Value = engines.Eng1_Enable;

                                cmd.Parameters.Add("@Eng2_Name", SqlDbType.VarChar).Value = engines.Eng2_Name;
                                cmd.Parameters.Add("@Eng2_Port", SqlDbType.Int).Value = engines.Eng2_Port;
                                cmd.Parameters.Add("@Eng2_Enable", SqlDbType.Bit).Value = engines.Eng2_Enable;

                                cmd.Parameters.Add("@Eng3_Name", SqlDbType.VarChar).Value = engines.Eng3_Name;
                                cmd.Parameters.Add("@Eng3_Port", SqlDbType.Int).Value = engines.Eng3_Port;
                                cmd.Parameters.Add("@Eng3_Enable", SqlDbType.Bit).Value = engines.Eng3_Enable;

                                cmd.Parameters.Add("@Eng4_Name", SqlDbType.VarChar).Value = engines.Eng4_Name;
                                cmd.Parameters.Add("@Eng4_Port", SqlDbType.Int).Value = engines.Eng4_Port;
                                cmd.Parameters.Add("@Eng4_Enable", SqlDbType.Bit).Value = engines.Eng4_Enable;

                                sqlDataAdapter.SelectCommand = cmd;
                                sqlDataAdapter.SelectCommand.Connection = connection;
                                sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;

                                // Execute stored proc to store top-level metadata
                                sqlDataAdapter.SelectCommand.ExecuteNonQuery();

                                //Attempt to commit the transaction
                                transaction.Commit();


                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                //log.Error("UpdateData- SQL Command Exception occurred: " + ex.Message);
                                //log.Debug("UpdateData- SQL Command Exception occurred", ex);
                            }
                        }
                    }
                    connection.Close();
                }
                GetConfigInfo(Config);
            }
            catch (Exception ex)
            {
                //log.Error("UpdateData- SQL Connection Exception occurred: " + ex.Message);
                //log.Debug("UpdateData- SQL Connection Exception occurred", ex);
            }
        }



        private void btnEngineUpdate_Click(object sender, EventArgs e)
        {
            DataRow row = engines.Rows[0];
            for (int i = 0; i < dgvEngines.Columns.Count; i++)
            {
                row[i] = dgvEngines.Rows[0].Cells[i].Value;
            }
            UpdateFE_EngineDefs(engines);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDevices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = dgvDevices.CurrentCell.RowIndex;
            if (Index > 0)
                cbDevices.SelectedIndex = Index;
            string config = dgvDevices.Rows[Index].Cells[3].Value.ToString();
            cbConfig.Text = config;

            string cmd = $"SELECT Name, IP_Address, Notes, Config1 FROM FE_Devices";
            devices = GetDBData(cmd, dbConnection);
            dgvDevices.Refresh();


            GetConfigInfo(config);

        }

        private void btnAddScene_Click(object sender, EventArgs e)
        {
            AddSceneRec scene = new AddSceneRec();
            int Index = dgvAvailableScenes.CurrentCell.RowIndex;
            scene.SceneCode = dgvAvailableScenes.Rows[Index].Cells[0].Value.ToString();
            scene.DataType = Convert.ToInt32( dgvAvailableScenes.Rows[Index].Cells[3].Value);
            scene.config = currentConfig;
            scene.EngineNo = 1;

            string description = TabNames[scene.DataType];
            scene.TabName = description;

            DialogResult dr = new DialogResult();
            frmEngineNo fEN = new frmEngineNo(currentConfig, description, scene.SceneCode, scene.EngineNo);
            
            dr = fEN.ShowDialog();

            if (dr == DialogResult.OK)
            {
                scene.EngineNo = fEN.engineNo;
                AddScene(scene);

            }

        }
        private void AddScene(AddSceneRec scene)
        {
            string cmdStr;

            cmdStr = "spAddScene @Config, @TabName, @EngineNumber, @SceneCode";

            //Save out the top-level metadata
            try
            {
                
                // Instantiate the connection
                using (SqlConnection connection = new SqlConnection(dbConnection))
                {
                    connection.Open();

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {

                            SqlTransaction transaction;
                            // Start a local transaction.
                            transaction = connection.BeginTransaction("Update Config");

                            // Must assign both transaction object and connection 
                            // to Command object for a pending local transaction
                            cmd.Connection = connection;
                            cmd.Transaction = transaction;

                            try
                            {
                                //Specify base command
                                cmd.CommandText = cmdStr;

                                cmd.Parameters.Add("@Config", SqlDbType.VarChar).Value = scene.config;
                                cmd.Parameters.Add("TabName", SqlDbType.VarChar).Value = scene.TabName;
                                cmd.Parameters.Add("@EngineNumber", SqlDbType.Int).Value = scene.EngineNo;
                                cmd.Parameters.Add("@SceneCode", SqlDbType.VarChar).Value = scene.SceneCode;
                                
                                sqlDataAdapter.SelectCommand = cmd;
                                sqlDataAdapter.SelectCommand.Connection = connection;
                                sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;

                                // Execute stored proc to store top-level metadata
                                sqlDataAdapter.SelectCommand.ExecuteNonQuery();

                                //Attempt to commit the transaction
                                transaction.Commit();


                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                //log.Error("UpdateData- SQL Command Exception occurred: " + ex.Message);
                                //log.Debug("UpdateData- SQL Command Exception occurred", ex);
                            }
                        }
                    }
                    connection.Close();
                }
                GetConfigInfo(scene.config);
            }
            catch (Exception ex)
            {
                //log.Error("UpdateData- SQL Connection Exception occurred: " + ex.Message);
                //log.Debug("UpdateData- SQL Connection Exception occurred", ex);
            }
        }

        private void UpdateScenes(AddSceneRec scene)
        {
            string cmdStr;

            cmdStr = "spUpdateScene @Config, @TabName, @EngineNumber, @SceneCode";

            //Save out the top-level metadata
            try
            {

                // Instantiate the connection
                using (SqlConnection connection = new SqlConnection(dbConnection))
                {
                    connection.Open();

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {

                            SqlTransaction transaction;
                            // Start a local transaction.
                            transaction = connection.BeginTransaction("Update Config");

                            // Must assign both transaction object and connection 
                            // to Command object for a pending local transaction
                            cmd.Connection = connection;
                            cmd.Transaction = transaction;

                            try
                            {
                                //Specify base command
                                cmd.CommandText = cmdStr;

                                cmd.Parameters.Add("@Config", SqlDbType.VarChar).Value = scene.config;
                                cmd.Parameters.Add("TabName", SqlDbType.VarChar).Value = scene.TabName;
                                cmd.Parameters.Add("@EngineNumber", SqlDbType.Int).Value = scene.EngineNo;
                                cmd.Parameters.Add("@SceneCode", SqlDbType.VarChar).Value = scene.SceneCode;

                                sqlDataAdapter.SelectCommand = cmd;
                                sqlDataAdapter.SelectCommand.Connection = connection;
                                sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;

                                // Execute stored proc to store top-level metadata
                                sqlDataAdapter.SelectCommand.ExecuteNonQuery();

                                //Attempt to commit the transaction
                                transaction.Commit();


                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                //log.Error("UpdateData- SQL Command Exception occurred: " + ex.Message);
                                //log.Debug("UpdateData- SQL Command Exception occurred", ex);
                            }
                        }
                    }
                    connection.Close();
                }
                
            }
            catch (Exception ex)
            {
                //log.Error("UpdateData- SQL Connection Exception occurred: " + ex.Message);
                //log.Debug("UpdateData- SQL Connection Exception occurred", ex);
            }
        }


        private void DeleteScene(AddSceneRec scene)
        {
            string cmdStr;

            cmdStr = "spDeleteScene @Config, @TabName, @EngineNumber";

            //Save out the top-level metadata
            try
            {

                // Instantiate the connection
                using (SqlConnection connection = new SqlConnection(dbConnection))
                {
                    connection.Open();

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {

                            SqlTransaction transaction;
                            // Start a local transaction.
                            transaction = connection.BeginTransaction("Update Config");

                            // Must assign both transaction object and connection 
                            // to Command object for a pending local transaction
                            cmd.Connection = connection;
                            cmd.Transaction = transaction;

                            try
                            {
                                //Specify base command
                                cmd.CommandText = cmdStr;

                                cmd.Parameters.Add("@Config", SqlDbType.VarChar).Value = scene.config;
                                cmd.Parameters.Add("TabName", SqlDbType.VarChar).Value = scene.TabName;
                                cmd.Parameters.Add("@EngineNumber", SqlDbType.Int).Value = scene.EngineNo;
                                
                                sqlDataAdapter.SelectCommand = cmd;
                                sqlDataAdapter.SelectCommand.Connection = connection;
                                sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;

                                // Execute stored proc to store top-level metadata
                                sqlDataAdapter.SelectCommand.ExecuteNonQuery();

                                //Attempt to commit the transaction
                                transaction.Commit();


                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                //log.Error("UpdateData- SQL Command Exception occurred: " + ex.Message);
                                //log.Debug("UpdateData- SQL Command Exception occurred", ex);
                            }
                        }
                    }
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                //log.Error("UpdateData- SQL Connection Exception occurred: " + ex.Message);
                //log.Debug("UpdateData- SQL Connection Exception occurred", ex);
            }
        }



        private void cbConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentConfig = cbConfig.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            for (int i = 0; i < tabConfig.Rows.Count; i++)
            {
                AddSceneRec scene = new AddSceneRec();
                int Index = i;
                scene.config = currentConfig;
                scene.EngineNo = Convert.ToInt32(dgvScenes.Rows[Index].Cells[2].Value);
                scene.SceneCode = dgvScenes.Rows[Index].Cells[3].Value.ToString();
                scene.TabName = dgvScenes.Rows[Index].Cells[1].Value.ToString();
                
                UpdateScenes(scene);
            }
            
            GetConfigInfo(currentConfig);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AddSceneRec scene = new AddSceneRec();
            int Index = dgvScenes.CurrentCell.RowIndex;
            foreach (DataGridViewRow item in this.dgvScenes.SelectedRows)
            {
                scene.config = currentConfig;
                scene.EngineNo = Convert.ToInt32(dgvScenes.Rows[Index].Cells[2].Value);
                scene.SceneCode = dgvScenes.Rows[Index].Cells[3].Value.ToString();
                scene.TabName = dgvScenes.Rows[Index].Cells[1].Value.ToString();
                dgvScenes.Rows.RemoveAt(item.Index);
                DeleteScene(scene);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            init();
            btnConfigUpdate_Click(sender, e);
        }
    }
}
