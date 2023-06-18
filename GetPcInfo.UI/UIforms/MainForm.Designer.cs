namespace GetPcInfo.UI.UIforms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlPcAccountInformation = new System.Windows.Forms.Panel();
            this.lblIpAddress = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblMachineName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnlDividerTopFirst = new System.Windows.Forms.Panel();
            this.pnlDividerFirst = new System.Windows.Forms.Panel();
            this.lblCpuModel = new MetroFramework.Controls.MetroLabel();
            this.lblMacAddress = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.gboxComputerConfiguration = new System.Windows.Forms.GroupBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblDomainName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.lblInstalledRam = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.lblOSInfo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.lblInstalledHDD = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.lblRamSlots = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.lblHddSerialNumber = new MetroFramework.Controls.MetroLabel();
            this.pnlNetworkConfiguration = new System.Windows.Forms.Panel();
            this.gboxNetworkConfiguration = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBiosMaker = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblBiosSerialNumber = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblBoardManufacturer = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblBoardSerialNumber = new MetroFramework.Controls.MetroLabel();
            this.cmsContentProperties = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMICopy = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPcAccountInformation.SuspendLayout();
            this.gboxComputerConfiguration.SuspendLayout();
            this.pnlNetworkConfiguration.SuspendLayout();
            this.gboxNetworkConfiguration.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cmsContentProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(23, 30);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(981, 36);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Get Pc Info";
            // 
            // pnlPcAccountInformation
            // 
            this.pnlPcAccountInformation.Controls.Add(this.gboxComputerConfiguration);
            this.pnlPcAccountInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPcAccountInformation.Location = new System.Drawing.Point(23, 66);
            this.pnlPcAccountInformation.Name = "pnlPcAccountInformation";
            this.pnlPcAccountInformation.Size = new System.Drawing.Size(981, 295);
            this.pnlPcAccountInformation.TabIndex = 0;
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.ContextMenuStrip = this.cmsContentProperties;
            this.lblIpAddress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblIpAddress.Location = new System.Drawing.Point(115, 26);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(206, 19);
            this.lblIpAddress.TabIndex = 13;
            this.lblIpAddress.Text = "getting information from the pc.";
            this.lblIpAddress.Click += new System.EventHandler(this.lblIpAddress_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(25, 26);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Ip Address:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ContextMenuStrip = this.cmsContentProperties;
            this.lblUsername.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUsername.Location = new System.Drawing.Point(111, 55);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(206, 19);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "getting information from the pc.";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(25, 55);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Username:";
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.ContextMenuStrip = this.cmsContentProperties;
            this.lblMachineName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMachineName.Location = new System.Drawing.Point(144, 26);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(206, 19);
            this.lblMachineName.TabIndex = 9;
            this.lblMachineName.Text = "getting information from the pc.";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(25, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Machine Name:";
            // 
            // pnlDividerTopFirst
            // 
            this.pnlDividerTopFirst.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDividerTopFirst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDividerTopFirst.Location = new System.Drawing.Point(23, 361);
            this.pnlDividerTopFirst.Name = "pnlDividerTopFirst";
            this.pnlDividerTopFirst.Size = new System.Drawing.Size(981, 1);
            this.pnlDividerTopFirst.TabIndex = 14;
            // 
            // pnlDividerFirst
            // 
            this.pnlDividerFirst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDividerFirst.Location = new System.Drawing.Point(23, 362);
            this.pnlDividerFirst.Name = "pnlDividerFirst";
            this.pnlDividerFirst.Size = new System.Drawing.Size(981, 5);
            this.pnlDividerFirst.TabIndex = 15;
            // 
            // lblCpuModel
            // 
            this.lblCpuModel.AutoSize = true;
            this.lblCpuModel.ContextMenuStrip = this.cmsContentProperties;
            this.lblCpuModel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCpuModel.Location = new System.Drawing.Point(119, 142);
            this.lblCpuModel.Name = "lblCpuModel";
            this.lblCpuModel.Size = new System.Drawing.Size(206, 19);
            this.lblCpuModel.TabIndex = 11;
            this.lblCpuModel.Text = "getting information from the pc.";
            this.lblCpuModel.Click += new System.EventHandler(this.lblCpuModel_Click);
            // 
            // lblMacAddress
            // 
            this.lblMacAddress.AutoSize = true;
            this.lblMacAddress.ContextMenuStrip = this.cmsContentProperties;
            this.lblMacAddress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMacAddress.Location = new System.Drawing.Point(130, 55);
            this.lblMacAddress.Name = "lblMacAddress";
            this.lblMacAddress.Size = new System.Drawing.Size(206, 19);
            this.lblMacAddress.TabIndex = 15;
            this.lblMacAddress.Text = "getting information from the pc.";
            this.lblMacAddress.Click += new System.EventHandler(this.lblMacAddress_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(25, 55);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(99, 19);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Mac Address:";
            // 
            // gboxComputerConfiguration
            // 
            this.gboxComputerConfiguration.Controls.Add(this.metroLabel16);
            this.gboxComputerConfiguration.Controls.Add(this.lblHddSerialNumber);
            this.gboxComputerConfiguration.Controls.Add(this.metroLabel15);
            this.gboxComputerConfiguration.Controls.Add(this.lblRamSlots);
            this.gboxComputerConfiguration.Controls.Add(this.metroLabel14);
            this.gboxComputerConfiguration.Controls.Add(this.lblInstalledHDD);
            this.gboxComputerConfiguration.Controls.Add(this.metroLabel13);
            this.gboxComputerConfiguration.Controls.Add(this.lblOSInfo);
            this.gboxComputerConfiguration.Controls.Add(this.metroLabel12);
            this.gboxComputerConfiguration.Controls.Add(this.lblInstalledRam);
            this.gboxComputerConfiguration.Controls.Add(this.metroLabel10);
            this.gboxComputerConfiguration.Controls.Add(this.metroLabel6);
            this.gboxComputerConfiguration.Controls.Add(this.lblDomainName);
            this.gboxComputerConfiguration.Controls.Add(this.lblCpuModel);
            this.gboxComputerConfiguration.Controls.Add(this.metroLabel1);
            this.gboxComputerConfiguration.Controls.Add(this.lblMachineName);
            this.gboxComputerConfiguration.Controls.Add(this.metroLabel3);
            this.gboxComputerConfiguration.Controls.Add(this.lblUsername);
            this.gboxComputerConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxComputerConfiguration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gboxComputerConfiguration.Location = new System.Drawing.Point(0, 0);
            this.gboxComputerConfiguration.Name = "gboxComputerConfiguration";
            this.gboxComputerConfiguration.Size = new System.Drawing.Size(981, 295);
            this.gboxComputerConfiguration.TabIndex = 0;
            this.gboxComputerConfiguration.TabStop = false;
            this.gboxComputerConfiguration.Text = "Computer Configuration";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(25, 84);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(109, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Domain Name:";
            // 
            // lblDomainName
            // 
            this.lblDomainName.AutoSize = true;
            this.lblDomainName.ContextMenuStrip = this.cmsContentProperties;
            this.lblDomainName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDomainName.Location = new System.Drawing.Point(140, 84);
            this.lblDomainName.Name = "lblDomainName";
            this.lblDomainName.Size = new System.Drawing.Size(206, 19);
            this.lblDomainName.TabIndex = 13;
            this.lblDomainName.Text = "getting information from the pc.";
            this.lblDomainName.Click += new System.EventHandler(this.lblDomainName_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(25, 142);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(88, 19);
            this.metroLabel10.TabIndex = 14;
            this.metroLabel10.Text = "CPU Model:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(25, 171);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(103, 19);
            this.metroLabel12.TabIndex = 16;
            this.metroLabel12.Text = "Installed Ram:";
            // 
            // lblInstalledRam
            // 
            this.lblInstalledRam.AutoSize = true;
            this.lblInstalledRam.ContextMenuStrip = this.cmsContentProperties;
            this.lblInstalledRam.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblInstalledRam.Location = new System.Drawing.Point(134, 171);
            this.lblInstalledRam.Name = "lblInstalledRam";
            this.lblInstalledRam.Size = new System.Drawing.Size(206, 19);
            this.lblInstalledRam.TabIndex = 15;
            this.lblInstalledRam.Text = "getting information from the pc.";
            this.lblInstalledRam.Click += new System.EventHandler(this.lblInstalledRam_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(25, 113);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(32, 19);
            this.metroLabel13.TabIndex = 18;
            this.metroLabel13.Text = "OS:";
            // 
            // lblOSInfo
            // 
            this.lblOSInfo.AutoSize = true;
            this.lblOSInfo.ContextMenuStrip = this.cmsContentProperties;
            this.lblOSInfo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblOSInfo.Location = new System.Drawing.Point(63, 113);
            this.lblOSInfo.Name = "lblOSInfo";
            this.lblOSInfo.Size = new System.Drawing.Size(206, 19);
            this.lblOSInfo.TabIndex = 17;
            this.lblOSInfo.Text = "getting information from the pc.";
            this.lblOSInfo.Click += new System.EventHandler(this.lblOSInfo_Click);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(25, 229);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(164, 19);
            this.metroLabel14.TabIndex = 20;
            this.metroLabel14.Text = "Installed HDD (master):";
            // 
            // lblInstalledHDD
            // 
            this.lblInstalledHDD.AutoSize = true;
            this.lblInstalledHDD.ContextMenuStrip = this.cmsContentProperties;
            this.lblInstalledHDD.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblInstalledHDD.Location = new System.Drawing.Point(195, 229);
            this.lblInstalledHDD.Name = "lblInstalledHDD";
            this.lblInstalledHDD.Size = new System.Drawing.Size(206, 19);
            this.lblInstalledHDD.TabIndex = 19;
            this.lblInstalledHDD.Text = "getting information from the pc.";
            this.lblInstalledHDD.Click += new System.EventHandler(this.lblInstalledHDD_Click);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(25, 200);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(156, 19);
            this.metroLabel15.TabIndex = 22;
            this.metroLabel15.Text = "Number of Ram Slots:";
            // 
            // lblRamSlots
            // 
            this.lblRamSlots.AutoSize = true;
            this.lblRamSlots.ContextMenuStrip = this.cmsContentProperties;
            this.lblRamSlots.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblRamSlots.Location = new System.Drawing.Point(187, 200);
            this.lblRamSlots.Name = "lblRamSlots";
            this.lblRamSlots.Size = new System.Drawing.Size(206, 19);
            this.lblRamSlots.TabIndex = 21;
            this.lblRamSlots.Text = "getting information from the pc.";
            this.lblRamSlots.Click += new System.EventHandler(this.lblRamSlots_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(25, 258);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(146, 19);
            this.metroLabel16.TabIndex = 24;
            this.metroLabel16.Text = "HDD Serial Number:";
            // 
            // lblHddSerialNumber
            // 
            this.lblHddSerialNumber.AutoSize = true;
            this.lblHddSerialNumber.ContextMenuStrip = this.cmsContentProperties;
            this.lblHddSerialNumber.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblHddSerialNumber.Location = new System.Drawing.Point(177, 258);
            this.lblHddSerialNumber.Name = "lblHddSerialNumber";
            this.lblHddSerialNumber.Size = new System.Drawing.Size(206, 19);
            this.lblHddSerialNumber.TabIndex = 23;
            this.lblHddSerialNumber.Text = "getting information from the pc.";
            this.lblHddSerialNumber.Click += new System.EventHandler(this.lblHddSerialNumber_Click);
            // 
            // pnlNetworkConfiguration
            // 
            this.pnlNetworkConfiguration.Controls.Add(this.gboxNetworkConfiguration);
            this.pnlNetworkConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNetworkConfiguration.Location = new System.Drawing.Point(23, 367);
            this.pnlNetworkConfiguration.Name = "pnlNetworkConfiguration";
            this.pnlNetworkConfiguration.Size = new System.Drawing.Size(981, 88);
            this.pnlNetworkConfiguration.TabIndex = 16;
            // 
            // gboxNetworkConfiguration
            // 
            this.gboxNetworkConfiguration.Controls.Add(this.lblIpAddress);
            this.gboxNetworkConfiguration.Controls.Add(this.metroLabel8);
            this.gboxNetworkConfiguration.Controls.Add(this.lblMacAddress);
            this.gboxNetworkConfiguration.Controls.Add(this.metroLabel4);
            this.gboxNetworkConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxNetworkConfiguration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gboxNetworkConfiguration.Location = new System.Drawing.Point(0, 0);
            this.gboxNetworkConfiguration.Name = "gboxNetworkConfiguration";
            this.gboxNetworkConfiguration.Size = new System.Drawing.Size(981, 88);
            this.gboxNetworkConfiguration.TabIndex = 0;
            this.gboxNetworkConfiguration.TabStop = false;
            this.gboxNetworkConfiguration.Text = "Network Configuration";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(23, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 153);
            this.panel1.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.lblBoardSerialNumber);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.lblBoardManufacturer);
            this.groupBox1.Controls.Add(this.lblBiosMaker);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.lblBiosSerialNumber);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BIOS Configuration";
            // 
            // lblBiosMaker
            // 
            this.lblBiosMaker.AutoSize = true;
            this.lblBiosMaker.ContextMenuStrip = this.cmsContentProperties;
            this.lblBiosMaker.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBiosMaker.Location = new System.Drawing.Point(171, 26);
            this.lblBiosMaker.Name = "lblBiosMaker";
            this.lblBiosMaker.Size = new System.Drawing.Size(206, 19);
            this.lblBiosMaker.TabIndex = 13;
            this.lblBiosMaker.Text = "getting information from the pc.";
            this.lblBiosMaker.Click += new System.EventHandler(this.lblBiosMaker_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(25, 55);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(147, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "BIOS Serial Number:";
            // 
            // lblBiosSerialNumber
            // 
            this.lblBiosSerialNumber.AutoSize = true;
            this.lblBiosSerialNumber.ContextMenuStrip = this.cmsContentProperties;
            this.lblBiosSerialNumber.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBiosSerialNumber.Location = new System.Drawing.Point(178, 55);
            this.lblBiosSerialNumber.Name = "lblBiosSerialNumber";
            this.lblBiosSerialNumber.Size = new System.Drawing.Size(206, 19);
            this.lblBiosSerialNumber.TabIndex = 15;
            this.lblBiosSerialNumber.Text = "getting information from the pc.";
            this.lblBiosSerialNumber.Click += new System.EventHandler(this.lblBiosSerialNumber_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(25, 26);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(140, 19);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "BIOS Manufacturer:";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(23, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 5);
            this.panel2.TabIndex = 17;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(25, 84);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(149, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Board Manufacturer:";
            // 
            // lblBoardManufacturer
            // 
            this.lblBoardManufacturer.AutoSize = true;
            this.lblBoardManufacturer.ContextMenuStrip = this.cmsContentProperties;
            this.lblBoardManufacturer.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBoardManufacturer.Location = new System.Drawing.Point(178, 84);
            this.lblBoardManufacturer.Name = "lblBoardManufacturer";
            this.lblBoardManufacturer.Size = new System.Drawing.Size(206, 19);
            this.lblBoardManufacturer.TabIndex = 17;
            this.lblBoardManufacturer.Text = "getting information from the pc.";
            this.lblBoardManufacturer.Click += new System.EventHandler(this.lblBoardManufacturer_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(25, 113);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(156, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Board Serial Number:";
            // 
            // lblBoardSerialNumber
            // 
            this.lblBoardSerialNumber.AutoSize = true;
            this.lblBoardSerialNumber.ContextMenuStrip = this.cmsContentProperties;
            this.lblBoardSerialNumber.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBoardSerialNumber.Location = new System.Drawing.Point(187, 113);
            this.lblBoardSerialNumber.Name = "lblBoardSerialNumber";
            this.lblBoardSerialNumber.Size = new System.Drawing.Size(206, 19);
            this.lblBoardSerialNumber.TabIndex = 19;
            this.lblBoardSerialNumber.Text = "getting information from the pc.";
            this.lblBoardSerialNumber.Click += new System.EventHandler(this.lblBoardSerialNumber_Click);
            // 
            // cmsContentProperties
            // 
            this.cmsContentProperties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMICopy});
            this.cmsContentProperties.Name = "cmsContentProperties";
            this.cmsContentProperties.Size = new System.Drawing.Size(103, 26);
            // 
            // tsMICopy
            // 
            this.tsMICopy.Name = "tsMICopy";
            this.tsMICopy.Size = new System.Drawing.Size(102, 22);
            this.tsMICopy.Text = "Copy";
            this.tsMICopy.Click += new System.EventHandler(this.tsMICopy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlNetworkConfiguration);
            this.Controls.Add(this.pnlDividerFirst);
            this.Controls.Add(this.pnlDividerTopFirst);
            this.Controls.Add(this.pnlPcAccountInformation);
            this.Controls.Add(this.lblHeader);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(23, 30, 23, 26);
            this.Text = "Get Pc Info";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlPcAccountInformation.ResumeLayout(false);
            this.gboxComputerConfiguration.ResumeLayout(false);
            this.gboxComputerConfiguration.PerformLayout();
            this.pnlNetworkConfiguration.ResumeLayout(false);
            this.gboxNetworkConfiguration.ResumeLayout(false);
            this.gboxNetworkConfiguration.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cmsContentProperties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlPcAccountInformation;
        private MetroFramework.Controls.MetroLabel lblIpAddress;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblMachineName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel pnlDividerTopFirst;
        private System.Windows.Forms.Panel pnlDividerFirst;
        private MetroFramework.Controls.MetroLabel lblCpuModel;
        private MetroFramework.Controls.MetroLabel lblMacAddress;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.GroupBox gboxComputerConfiguration;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblDomainName;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel lblInstalledRam;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel lblOSInfo;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel lblInstalledHDD;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel lblRamSlots;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel lblHddSerialNumber;
        private System.Windows.Forms.Panel pnlNetworkConfiguration;
        private System.Windows.Forms.GroupBox gboxNetworkConfiguration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel lblBiosMaker;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblBiosSerialNumber;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblBoardManufacturer;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblBoardSerialNumber;
        private System.Windows.Forms.ContextMenuStrip cmsContentProperties;
        private System.Windows.Forms.ToolStripMenuItem tsMICopy;
    }
}