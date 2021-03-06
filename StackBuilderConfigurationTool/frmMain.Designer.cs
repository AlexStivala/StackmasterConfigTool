namespace StackBuilderConfigurationTool
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteConfig = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConfigUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbConfig = new System.Windows.Forms.ComboBox();
            this.cbDevices = new System.Windows.Forms.ComboBox();
            this.dgvDevices = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEngineUpdate = new System.Windows.Forms.Button();
            this.dgvEngines = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvTabs = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddScene = new System.Windows.Forms.Button();
            this.dgvAvailableScenes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvScenes = new System.Windows.Forms.DataGridView();
            this.lblDB = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngines)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabs)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableScenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScenes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btnDeleteConfig);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnConfigUpdate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbConfig);
            this.groupBox1.Controls.Add(this.cbDevices);
            this.groupBox1.Controls.Add(this.dgvDevices);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(711, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devices";
            // 
            // btnDeleteConfig
            // 
            this.btnDeleteConfig.Location = new System.Drawing.Point(325, 369);
            this.btnDeleteConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteConfig.Name = "btnDeleteConfig";
            this.btnDeleteConfig.Size = new System.Drawing.Size(196, 32);
            this.btnDeleteConfig.TabIndex = 7;
            this.btnDeleteConfig.Text = "Delete Config";
            this.btnDeleteConfig.UseVisualStyleBackColor = true;
            this.btnDeleteConfig.Click += new System.EventHandler(this.btnDeleteConfig_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(583, 376);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 32);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConfigUpdate
            // 
            this.btnConfigUpdate.Location = new System.Drawing.Point(583, 330);
            this.btnConfigUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfigUpdate.Name = "btnConfigUpdate";
            this.btnConfigUpdate.Size = new System.Drawing.Size(96, 32);
            this.btnConfigUpdate.TabIndex = 5;
            this.btnConfigUpdate.Text = "Update";
            this.btnConfigUpdate.UseVisualStyleBackColor = true;
            this.btnConfigUpdate.Click += new System.EventHandler(this.btnConfigUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 300);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Configuration Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 300);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Target Computer";
            // 
            // cbConfig
            // 
            this.cbConfig.FormattingEnabled = true;
            this.cbConfig.Location = new System.Drawing.Point(304, 334);
            this.cbConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbConfig.Name = "cbConfig";
            this.cbConfig.Size = new System.Drawing.Size(236, 28);
            this.cbConfig.TabIndex = 2;
            this.cbConfig.SelectedIndexChanged += new System.EventHandler(this.cbConfig_SelectedIndexChanged);
            // 
            // cbDevices
            // 
            this.cbDevices.FormattingEnabled = true;
            this.cbDevices.Location = new System.Drawing.Point(13, 334);
            this.cbDevices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDevices.Name = "cbDevices";
            this.cbDevices.Size = new System.Drawing.Size(236, 28);
            this.cbDevices.TabIndex = 1;
            this.cbDevices.SelectedIndexChanged += new System.EventHandler(this.cbDevices_SelectedIndexChanged);
            // 
            // dgvDevices
            // 
            this.dgvDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevices.Location = new System.Drawing.Point(13, 40);
            this.dgvDevices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDevices.MultiSelect = false;
            this.dgvDevices.Name = "dgvDevices";
            this.dgvDevices.RowHeadersWidth = 20;
            this.dgvDevices.RowTemplate.Height = 28;
            this.dgvDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevices.Size = new System.Drawing.Size(677, 231);
            this.dgvDevices.TabIndex = 0;
            this.dgvDevices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevices_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btnEngineUpdate);
            this.groupBox2.Controls.Add(this.dgvEngines);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 466);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(1569, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Engines";
            // 
            // btnEngineUpdate
            // 
            this.btnEngineUpdate.Location = new System.Drawing.Point(741, 120);
            this.btnEngineUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEngineUpdate.Name = "btnEngineUpdate";
            this.btnEngineUpdate.Size = new System.Drawing.Size(96, 32);
            this.btnEngineUpdate.TabIndex = 7;
            this.btnEngineUpdate.Text = "Update";
            this.btnEngineUpdate.UseVisualStyleBackColor = true;
            this.btnEngineUpdate.Click += new System.EventHandler(this.btnEngineUpdate_Click);
            // 
            // dgvEngines
            // 
            this.dgvEngines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEngines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEngines.Location = new System.Drawing.Point(0, 34);
            this.dgvEngines.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEngines.Name = "dgvEngines";
            this.dgvEngines.RowHeadersVisible = false;
            this.dgvEngines.RowHeadersWidth = 100;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEngines.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEngines.RowTemplate.Height = 28;
            this.dgvEngines.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEngines.Size = new System.Drawing.Size(1551, 57);
            this.dgvEngines.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.dgvTabs);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(748, 44);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(1029, 183);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tabs";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 131);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvTabs
            // 
            this.dgvTabs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabs.Location = new System.Drawing.Point(4, 40);
            this.dgvTabs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTabs.MultiSelect = false;
            this.dgvTabs.Name = "dgvTabs";
            this.dgvTabs.RowHeadersVisible = false;
            this.dgvTabs.RowHeadersWidth = 20;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTabs.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTabs.RowTemplate.Height = 28;
            this.dgvTabs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTabs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabs.Size = new System.Drawing.Size(1021, 60);
            this.dgvTabs.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnAddScene);
            this.groupBox4.Controls.Add(this.dgvAvailableScenes);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.dgvScenes);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(30, 647);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(1743, 395);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scenes";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(985, 147);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 32);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddScene
            // 
            this.btnAddScene.Location = new System.Drawing.Point(985, 79);
            this.btnAddScene.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddScene.Name = "btnAddScene";
            this.btnAddScene.Size = new System.Drawing.Size(96, 32);
            this.btnAddScene.TabIndex = 7;
            this.btnAddScene.Text = "ADD >>";
            this.btnAddScene.UseVisualStyleBackColor = true;
            this.btnAddScene.Click += new System.EventHandler(this.btnAddScene_Click);
            // 
            // dgvAvailableScenes
            // 
            this.dgvAvailableScenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableScenes.Location = new System.Drawing.Point(15, 34);
            this.dgvAvailableScenes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAvailableScenes.MultiSelect = false;
            this.dgvAvailableScenes.Name = "dgvAvailableScenes";
            this.dgvAvailableScenes.RowHeadersWidth = 20;
            this.dgvAvailableScenes.RowTemplate.Height = 28;
            this.dgvAvailableScenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableScenes.Size = new System.Drawing.Size(947, 285);
            this.dgvAvailableScenes.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(985, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvScenes
            // 
            this.dgvScenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScenes.Location = new System.Drawing.Point(1104, 34);
            this.dgvScenes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvScenes.MultiSelect = false;
            this.dgvScenes.Name = "dgvScenes";
            this.dgvScenes.RowHeadersWidth = 20;
            this.dgvScenes.RowTemplate.Height = 28;
            this.dgvScenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScenes.Size = new System.Drawing.Size(600, 285);
            this.dgvScenes.TabIndex = 0;
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDB.Location = new System.Drawing.Point(23, 12);
            this.lblDB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(140, 20);
            this.lblDB.TabIndex = 4;
            this.lblDB.Text = "DB Connection: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(752, 290);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1023, 23);
            this.textBox1.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1794, 1012);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "Stack Builder Configuration Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngines)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabs)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableScenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDevices;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEngines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbConfig;
        private System.Windows.Forms.ComboBox cbDevices;
        private System.Windows.Forms.Button btnConfigUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTabs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEngineUpdate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvScenes;
        private System.Windows.Forms.DataGridView dgvAvailableScenes;
        private System.Windows.Forms.Button btnAddScene;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDeleteConfig;
    }
}

