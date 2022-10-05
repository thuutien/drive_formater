using QRCoder;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Management.Automation;
using System.Windows.Forms;


namespace drive_formater
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            refreshData();
            
        }

        void refreshData()
        {
            Utils.reloadData();
            dataGridView.DataSource = Utils.driveList;
        }


        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridView.DataSource = null;
            refreshData();
            Cursor.Current = Cursors.Default;

        }

        private void btn_format_Click(object sender, EventArgs e)
        {
            //Start formating
            Cursor.Current = Cursors.WaitCursor;
            dataGridView.DataSource = null;
            PowerShell ps = PowerShell.Create();
            ps.AddScript(Utils.SCRIPT);
            Collection<PSObject> psOutput = ps.Invoke();
            refreshData();
            Cursor.Current = Cursors.Default;
            MessageBox.Show("Format completed!");

        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            //open github
            Process.Start("https://github.com/thuutien");
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Need to get drive details
            if( e.RowIndex != -1)
            {
                int index = e.RowIndex;
                Utils.selectedDrive = Utils.driveList[index];
                string output = "Manufacturer: " + Utils.selectedDrive.Manufacturer + "\nModel: " + Utils.selectedDrive.Model + "\nSize: " + Utils.selectedDrive.Size + "\nS/N: " + Utils.selectedDrive.SerialNum + "\nHealth: " + Utils.selectedDrive.HealthStatus; ;
                lblQRCode.Text = output;
                // QRcoder
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(output, QRCodeGenerator.ECCLevel.L);
                QRCode code = new QRCode(data);
                picQRCode.Image = code.GetGraphic(5);
                Console.WriteLine(output);
            } 

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Utils.printLabel(Utils.selectedDrive, txtPrinterIP.Text);
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            if(Utils.driveList.Count > 0)
            {
                foreach( Drive drive in Utils.driveList)
                {
                    Utils.printLabel(drive, txtPrinterIP.Text);
                }

            }else
            {
                MessageBox.Show("");
            }
        }
    }
}




