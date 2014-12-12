using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace StratusLogReader_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            //listView1.Sorting = SortOrder.Ascending;
            // Add columns to the ListView
            listView1.Columns.Add("Date Time", 125, HorizontalAlignment.Left);
            listView1.Columns.Add("Call", 240, HorizontalAlignment.Left);
            listView1.Columns.Add("Employee ID", 75, HorizontalAlignment.Left);
            listView1.Columns.Add("Machine ID", 75, HorizontalAlignment.Left);
            listView1.Columns.Add("IP Address", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Call Type", 375, HorizontalAlignment.Left);
            listView1.Columns.Add("Seconds", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Running Average", 100, HorizontalAlignment.Left);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();    
            totalCount.Text = "0";
            totalTimeAverage.Text = "0.00";
            progress.Text = "0";
            Thread BuildListView_Thread = new Thread(new ThreadStart(BuildListView));
            BuildListView_Thread.Start();
        }

        private void BuildListView()
        {
            string containsBoxText = containsBox.Text;
            string doesNotContainBoxText = doesNotContainBox.Text;
            if (doesNotContainBoxText == "") doesNotContainBoxText = "a8jd83jl";

            System.Text.RegularExpressions.Regex containsTerm =
            new System.Text.RegularExpressions.Regex(containsBoxText);

            System.Text.RegularExpressions.Regex doesNotContainTerm =
            new System.Text.RegularExpressions.Regex(doesNotContainBoxText);

            var lines = File.ReadAllLines("c:\\dev\\wrms.log")
                .Select(l => l.Trim())
                .Where(l => containsTerm.IsMatch(l) && !doesNotContainTerm.IsMatch(l));

            List<ListViewItem> lviCollection = new List<ListViewItem>();

            decimal rTotal = 0;
            decimal rAverage = 0;
            decimal count = lines.Count();
            decimal i = 1;
            int j = 0;            
            string IPAddress = "";
            string callType = "";
            string seconds = "1.000";
            System.Text.RegularExpressions.Regex ipRegex =
            new System.Text.RegularExpressions.Regex(@"\d+\.\d+\.\d+\.\d+");

            this.Invoke(new MethodInvoker(() => resetProgressBar(Convert.ToInt32(count))));

            foreach (string line in lines)
            {
                string[] parseStep1 = line.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                string dateTime = parseStep1[0];
                string[] parseStep2 = parseStep1[1].Split(new string[] { "::" }, StringSplitOptions.None);
                string[] parseStep3 = parseStep2[0].Split(new string[] { " EmployeeId:" }, StringSplitOptions.None);
                string call = parseStep3[0];
                string employeeId = parseStep3[1];
                string[] parseStep4 = parseStep2[1].Split(new string[] { "MachineId:" }, StringSplitOptions.None);
                string machineId = parseStep4[1];
                if (line.Contains(" The total "))
                {
                    string[] parseStep5 = parseStep2[2].Split(new string[] { " The total " }, StringSplitOptions.None);
                    string[] parseStep6 = parseStep5[0].Split(new string[] { "IPAddress:" }, StringSplitOptions.None);
                    IPAddress = parseStep6[1];
                    string[] parseStep7 = parseStep5[1].Split(new string[] { " performance on Server = " }, StringSplitOptions.None);
                    callType = parseStep7[0];
                    string[] parseStep8 = parseStep7[1].Split(new string[] { " " }, StringSplitOptions.None);
                    seconds = parseStep8[0];
                }
                else
                {
                    callType = parseStep2[2].Replace("IPAddress:", "");
                    var match = ipRegex.Match(callType);
                    if (match.Success) IPAddress = match.Captures[0].ToString();
                    callType = callType.Replace(IPAddress, "");
                }

                rTotal += decimal.Parse(seconds);
                rAverage = rTotal / i;

                ListViewItem lvi = new ListViewItem(dateTime);
                lvi.SubItems.Add(call);
                lvi.SubItems.Add(employeeId);
                lvi.SubItems.Add(machineId);
                lvi.SubItems.Add(IPAddress);
                lvi.SubItems.Add(callType);
                lvi.SubItems.Add(seconds);
                lvi.SubItems.Add(rAverage.ToString("0.000"));

                if (callType.Contains(highlightBox.Text) == true && highlightBox.Text != "") lvi.BackColor = Color.Yellow;

                lviCollection.Add(lvi);

                i = i + 1;
                j = j + 1;

                decimal percent = (i / count) * 100;
                int percentInt = Convert.ToInt32(percent);
                if (progressBar1.Value != percent) this.Invoke(new MethodInvoker(() => updateProgress(percentInt)));
            }
            this.Invoke(new MethodInvoker(() => finalUpdate(lviCollection.ToArray(), count.ToString(), rAverage.ToString("0.000"))));
        }

        private void resetProgressBar (int count)
        {
            progressBar1.Value = 0;
        }

        private void updateProgress (int percent)
        {
            progress.Text = percent.ToString() + "%";
            progressBar1.Value = percent;
        }

        private void finalUpdate (ListViewItem[] lviArray, string count, string rAverage)
        {
            listView1.Items.AddRange(lviArray);
            totalCount.Text = count;
            totalTimeAverage.Text = rAverage;
        }
    }
}