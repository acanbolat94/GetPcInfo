using MetroFramework.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace GetPcInfo.UI.UIforms
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            ShadowType = MetroFormShadowType.AeroShadow;
            WindowState = FormWindowState.Maximized;
        }

        #region Variables
        ArrayList hardDriveDetails = new ArrayList();
        string getValueFromPc = "";
        #endregion

        #region Methods
        void CaptureScreen()
        {
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{PRTSC}");
            Image img = Clipboard.GetImage();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG Image (.jpg) | *.jpg  ";
            sfd.FilterIndex = 1;
            sfd.ValidateNames = true;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                img.Save(sfd.FileName);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                //case (Keys.Control | Keys.P):
                //    CaptureScreen();
                //    break;
                case (Keys.Control | Keys.Enter):

                    //string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); 


                    using (StreamWriter sw = File.CreateText(@"c:\Pc Configuration.txt")) // delete and create again.
                    {

                        string caption = "Pc Configuration of "+ lblMachineName.Text;
                        string bckspc = "";

                        string machineName = string.Concat("\n", string.Format(@"Machine Name: {0}",lblMachineName.Text));
                        string userName = string.Concat("\n", string.Format(@"Username: {0}", lblUsername.Text));
                        string domainName = string.Concat("\n", string.Format(@"Domain Name: {0}", lblDomainName.Text));
                        string os = string.Concat("\n", string.Format(@"OS: {0}", lblOSInfo.Text));
                        string cpuModel = string.Concat("\n", string.Format(@"Cpu Model: {0}", lblCpuModel.Text));
                        string installedRam = string.Concat("\n", string.Format(@"Installed Ram: {0}", lblInstalledRam.Text));
                        string numberOfRamSlots = string.Concat("\n", string.Format(@"Number of Ram Slots: {0}", lblRamSlots.Text));
                        string installedHDD = string.Concat("\n", string.Format(@"Installed HDD: {0}", lblInstalledHDD.Text));
                        string hddSerialNumber = string.Concat("\n", string.Format(@" HDD Serial Number: {0}", lblHddSerialNumber.Text));
                        string ipAddress = string.Concat("\n", string.Format(@"IP Address: {0}", lblIpAddress.Text));
                        string macAddress = string.Concat("\n", string.Format(@"Mac Address: {0}", lblMacAddress.Text));
                        string biosManufacturer = string.Concat("\n", string.Format(@"BIOS Manufacturer: {0}", lblBiosMaker.Text));
                        string biosSerialNumber = string.Concat("\n", string.Format(@"BIOS Serial Number: {0}", lblBiosSerialNumber.Text));
                        string boardManufacturer = string.Concat("\n", string.Format(@"Board Manufacturer: {0}", lblBoardManufacturer.Text));
                        string boardSerialNumber = string.Concat("\n", string.Format(@"Board Serial Number: {0}", lblBoardSerialNumber.Text));


                        sw.WriteLine(caption);
                        sw.WriteLine(bckspc);
                        sw.WriteLine(machineName);
                        sw.WriteLine(userName);
                        sw.WriteLine(domainName);
                        sw.WriteLine(os);
                        sw.WriteLine(cpuModel);
                        sw.WriteLine(installedRam);
                        sw.WriteLine(numberOfRamSlots);
                        sw.WriteLine(installedHDD);
                        sw.WriteLine(hddSerialNumber);
                        sw.WriteLine(ipAddress);
                        sw.WriteLine(macAddress);
                        sw.WriteLine(biosManufacturer);
                        sw.WriteLine(biosSerialNumber);
                        sw.WriteLine(boardManufacturer);
                        sw.WriteLine(boardSerialNumber);


                        // Loop through your DataGridView.Rows or Cells and do the same.

                        sw.Flush();
                        sw.Close();
                        MessageBox.Show("The file was saved to drive c\nFile name: Pc Configuration.", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }

                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string hostName = Dns.GetHostName();
                IPHostEntry ipHostEntry = Dns.GetHostByName(hostName);
                string macAddress = HardwareInfo.GetMACAddress();
                foreach (IPAddress item in ipHostEntry.AddressList)
                {
                    lblIpAddress.Text = item.ToString();
                }
                lblMachineName.Text = HardwareInfo.GetComputerName();
                lblUsername.Text = HardwareInfo.GetAccountName();
                lblCpuModel.Text = HardwareInfo.GetProcessorInformation();
                lblMacAddress.Text = macAddress;
                lblDomainName.Text = System.Environment.UserDomainName;
                lblInstalledRam.Text = HardwareInfo.GetPhysicalMemory();
                lblOSInfo.Text = HardwareInfo.GetOSInformation();
                lblInstalledHDD.Text = HardwareInfo.GetHDDInfo();
                lblRamSlots.Text = HardwareInfo.GetNoRamSlots();
                lblHddSerialNumber.Text = HardwareInfo.GetHDDSerialNo();
                lblBiosMaker.Text = HardwareInfo.GetBIOSmaker();
                lblBiosSerialNumber.Text = HardwareInfo.GetBIOSserNo();
                lblBoardManufacturer.Text = HardwareInfo.GetBoardMaker();
                lblBoardSerialNumber.Text = HardwareInfo.GetBoardProductId();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tsMICopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(getValueFromPc);
        }

        private void lblMachineName_Click(object sender, EventArgs e)
        {
            getValueFromPc = lblMachineName.Text;
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            getValueFromPc = lblUsername.Text;
        }

        private void lblDomainName_Click(object sender, EventArgs e)
        {
            getValueFromPc = lblDomainName.Text;
        }

        private void lblOSInfo_Click(object sender, EventArgs e)
        {
            getValueFromPc = lblOSInfo.Text;
        }

        private void lblCpuModel_Click(object sender, EventArgs e)
        {
            getValueFromPc = lblCpuModel.Text;
        }

        private void lblInstalledRam_Click(object sender, EventArgs e)
        {
            getValueFromPc = lblInstalledRam.Text;
        }

        private void lblRamSlots_Click(object sender, EventArgs e)
        {
            getValueFromPc = lblRamSlots.Text;
        }

        private void lblInstalledHDD_Click(object sender, EventArgs e)
        {
            getValueFromPc = lblInstalledRam.Text;
        }

        private void lblHddSerialNumber_Click(object sender, EventArgs e)
        {
            getValueFromPc = lblInstalledHDD.Text;
        }

        private void lblIpAddress_Click(object sender, EventArgs e)
        {
            getValueFromPc = lblIpAddress.Text;
        }

        private void lblMacAddress_Click(object sender, EventArgs e)
        {
            getValueFromPc = lblMacAddress.Text;
        }

        private void lblBiosMaker_Click(object sender, EventArgs e)
        {
            getValueFromPc = lblBiosMaker.Text;
        }

        private void lblBiosSerialNumber_Click(object sender, EventArgs e)
        {
            getValueFromPc = lblBiosSerialNumber.Text;
        }

        private void lblBoardManufacturer_Click(object sender, EventArgs e)
        {
            getValueFromPc = lblBoardManufacturer.Text;
        }

        private void lblBoardSerialNumber_Click(object sender, EventArgs e)
        {
            getValueFromPc = lblBoardSerialNumber.Text;
        }
    }
}
