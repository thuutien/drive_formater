
using drive_formater;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Windows.Forms;

class Utils 
{

    public static List<Drive> driveList = new List<Drive>();
    public static Drive selectedDrive = null;
    public static int zplPort = 9100;

    public static string SCRIPT = @"
$disks2format = (get-disk | Where-Object { $_.number -ne '0' -AND $_.number -ne '1'})
$driveletters = 'Z', 'X','Y', 'W','V', 'U','T', 'S', 'R', 'Q', 'P'
foreach ($disk in $disks2format) {  
    $model = $disk.Model -replace '[^a-zA-Z0-9]', ''
    Clear-Disk -Number $disk.Number -RemoveData -Confirm:$false
    Initialize-Disk -Number $disk.Number
    New-Partition -DiskNumber $disk.Number -UseMaximumSize -DriveLetter $driveletters[$disk.Number]
    Format-Volume -DriveLetter $driveletters[$disk.Number] -FileSystem exFAT -NewFileSystemLabel $model  
}";

    public static bool isIPAddress(string ip)
    {
        Regex regex = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
        return regex.IsMatch(ip);
    }

    public static void printLabel(Drive drive, string printerIP)
    {
        if (drive != null && Utils.isIPAddress(printerIP))
        {
            string zplFileContent = @"^XA^CI0^PW575^BY2,3,50^FT574,350^A0I,30,30^FB575,1,0^FD*manufacturer*^FS^FT574,300^A0I,30,30^FB575,1,0^FD*model* - *size*^FS^FT180,325^A0I,70,70^FB575,1,0^FD*health*^FS^FT574,250^A0I,30,30^FB575,1,0^FD*serialnumber*^FS^FT574,100^BCI,,Y,N^FD*serialnumber2*^FS^XZ";
            zplFileContent = zplFileContent.Replace("*manufacturer*", drive.Manufacturer);
            zplFileContent = zplFileContent.Replace("*model*", drive.Model);
            zplFileContent = zplFileContent.Replace("*size*", drive.Size);
            zplFileContent = zplFileContent.Replace("*health*", drive.HealthStatus);
            zplFileContent = zplFileContent.Replace("*serialnumber*", drive.SerialNum);
            zplFileContent = zplFileContent.Replace("*serialnumber2*", drive.SerialNum);

            // Open ZPL connection
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(printerIP, zplPort);
            // Send ZPL file content
            StreamWriter streamWriter = new StreamWriter(tcpClient.GetStream());
            streamWriter.Write(zplFileContent);
            streamWriter.Flush();
            // Close ZPL connection
            streamWriter.Close();
            tcpClient.Close();
        }
        else
        {
            MessageBox.Show("No drive selected or wrong printer IP");
        }
    }

    public static String BytesToString(long byteCount)
    {
        string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
        if (byteCount == 0)
            return "0" + suf[0];
        long bytes = Math.Abs(byteCount);
        int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1000)));
        double num = Math.Round(bytes / Math.Pow(1000, place), 1);

        double size = Math.Sign(byteCount) * num;

        // Below codes are ridiclious
        if (size > 490 && size < 560 && place == 3)
        {
            size = 500; 
        }
        if (size > 990 && size < 1000 && place == 3)
        {
            size = 1;
            place++;
        }
        else if (size > 1 && size < 1.1 && place == 5)
        {
            size = 1;
        }
        else if (size > 1.9 && size < 2.1 && place == 5)
        {
            size = 2;
        }
        else if (size > 2.9 && size < 3.1 && place == 5)
        {
            size = 3;
        }
        else if (size > 3.9 && size < 4.1 && place == 5)
        {
            size = 4;
        }
        else if (size > 4.9 && size < 5.1 && place == 5)
        {
            size = 5;
        }
        else if (size > 5.9 && size < 6.1 && place == 5)
        {
            size = 6;
        }
        else if (size > 6.9 && size < 7.1 && place == 5)
        {
            size = 7;
        }
        else if (size > 7.9 && size < 8.1 && place == 5)
        {
            size = 8;
        }
        else if (size > 8.9 && size < 9.1 && place == 5)
        {
            size = 9;
        }
        else if (size > 9.9 && size < 10.1 && place == 5)
        {
            size = 10;
        }
        else if (size > 10.9 && size < 11.1 && place == 5)
        {
            size = 11;
        }
        else if (size > 11.9 && size < 12.1 && place == 5)
        {
            size = 12;
        }
        else if (size > 12.9 && size < 13.1 && place == 5)
        {
            size = 13;
        }
        else if (size > 13.9 && size < 14.1 && place == 5)
        {
            size = 14;
        }
        else if (size > 14.9 && size < 15.1 && place == 5)
        {
            size = 15;
        }
        else if (size > 15.9 && size < 16.1 && place == 5)
        {
            size = 16;
        }
        else if (size > 16.9 && size < 17.1 && place == 5)
        {
            size = 17;
        }
        else if (size > 17.9 && size < 18.1 && place == 5)
        {
            size = 18;
        }
        else if (size > 18.9 && size < 19.1 && place == 5)
        {
            size = 19;
        }
        else if (size > 19.9 && size < 20.1 && place == 5)
        {
            size = 20;
        }

        return (size.ToString() + suf[place]);
    }


    public static void reloadData()
    {
        //Get data
        driveList.Clear();
        PowerShell ps = PowerShell.Create();
        ps.AddScript("get-disk | Where-Object { $_.number -ne '0' -AND $_.number -ne '1'}");
        Collection<PSObject> psOutput = ps.Invoke();

        foreach (PSObject pSObject in psOutput)
        {
            string manufacture = pSObject.Members["Manufacturer"].Value.ToString().Trim();
            string model = pSObject.Members["Model"].Value.ToString().Trim();
            string healthCode = pSObject.Members["HealthStatus"].Value.ToString();
            string health = "unknown";  
            if (healthCode == "0")
            {
                health = "Good";
            }
            else
            {
                health = "Bad";
            }
            string serialNum = pSObject.Members["SerialNumber"].Value.ToString().Trim().TrimStart('0').PadLeft(1, '0');
            long sizelong = long.Parse(pSObject.Members["Size"].Value.ToString());
            string size = BytesToString(sizelong);
            Drive drive = new Drive() { Manufacturer = manufacture, Model = model, HealthStatus = health, SerialNum = serialNum, Size = size };
            driveList.Add(drive);
        }

    }

}


