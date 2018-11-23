using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Management;
using System.Media;
using System.Security.Principal;

namespace cs_procman
{
    public partial class Form1 : Form
    {
        private BindingList<Process> proc_list = new BindingList<Process>();
        private ManagementEventWatcher startProcessEW = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStartTrace");
        private ManagementEventWatcher stopProcessEW = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStopTrace");
        private SoundPlayer SP = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            initProcessEventHandler();
            initName_DGV();
            initProp_DGV();
            
            // Chart part
            //Dictionary<string,long> list_top_process = new Dictionary<string,long>();
            //list_top_process.Add(proc_list.Where(i => i.ProcessName), proc_list.Where(i => i.VirtualMemorySize64));
            double i = 0;
            ch_proc.Series.Add("Proc_Memory");

            IEnumerable<Process> test = proc_list.OrderBy(item => item.PrivateMemorySize64);
            foreach (var item in test)
            {
                if (i > 10) break;
                Console.WriteLine("Process :"+item.ProcessName);
                ch_proc.Series["Proc_Memory"].Points.AddXY(item.ProcessName, (double)item.PrivateMemorySize64);
                ch_proc.Series["Proc_Memory"].LabelToolTip = "Coucou";
            }

            //ch_proc.Series["Proc_Memory"].Points.AddXY((double)test.First().VirtualMemorySize64, i++);
            
        }

        private void initName_DGV()
        {
            foreach (Process proc in Process.GetProcesses())
            {
                proc_list.Add(proc);
            }
            name_dgv.AutoGenerateColumns = false;
            name_dgv.Columns.Clear();
            name_dgv.ColumnCount = 2;
            name_dgv.Columns[0].Name = "Process ID";
            name_dgv.Columns[0].DataPropertyName = "Id";
            name_dgv.Columns[1].Name = "Process Name";
            name_dgv.Columns[1].DataPropertyName = "ProcessName";
            name_dgv.DataSource = proc_list;
        }
        private void initProp_DGV()
        {
            prop_dgv.Hide();
            prop_dgv.AutoGenerateColumns = false;
            prop_dgv.ColumnCount = 2;
            prop_dgv.Columns[0].Name = "Properties";
            prop_dgv.Columns[1].Name = "Values";
            prop_dgv.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (var prop in typeof(Process).GetProperties())
            {
                prop_dgv.Rows.Add(prop.Name, "");
            }
        }
        private void initProcessEventHandler()
        {
            startProcessEW.EventArrived += new EventArrivedEventHandler(onStartProcessEvent);
            startProcessEW.Start();
            stopProcessEW.EventArrived += new EventArrivedEventHandler(onStopProcessEvent);
            stopProcessEW.Start();
        }
        private void onStartProcessEvent(object sender, EventArrivedEventArgs e)
        {
            Console.WriteLine(e.NewEvent.Properties["ProcessName"].Value.ToString() + " has started");
            logEvent(e.NewEvent.Properties["ProcessName"].Value.ToString() + "with id : " + e.NewEvent.Properties["ProcessId"].Value.ToString() + " has started");
            addProcessToDGV(Convert.ToInt32(e.NewEvent.Properties["ProcessId"].Value));
            SP.SoundLocation = "../../mp3/light.wav";
            SP.Play();
        }
        private void onStopProcessEvent(object sender, EventArrivedEventArgs e)
        {
            Console.WriteLine(e.NewEvent.Properties["ProcessName"].Value.ToString() + " has terminated");
            logEvent(e.NewEvent.Properties["ProcessName"].Value.ToString() + "with id : " + e.NewEvent.Properties["ProcessId"].Value.ToString() + " has terminated");
            removeProcessToDGV(Convert.ToInt32(e.NewEvent.Properties["ProcessId"].Value));
            SP.SoundLocation = "../../mp3/long-expected.wav";
            SP.Play();
        }
        private void addProcessToDGV(int id)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(addProcessToDGV), new object[] { id });
                return;
            }
            //if (Process.GetProcessById(id) == null)
            try
            {
                proc_list.Add(Process.GetProcessById(id));
            }
            catch (Exception)
            {
                Console.WriteLine(id +": This Process exited when you entered the program");
            }   
        }
        private void removeProcessToDGV(int id)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(removeProcessToDGV), new object[] { id });
                return;
            }

            proc_list.Remove(proc_list.Where(i => i.Id == id).FirstOrDefault());
        }
        private int findIndexByName(string str)
        {
            List<string> tmp = new List<string>();
            foreach(DataGridViewRow row in name_dgv.Rows)
            {
                tmp.Add(row.Cells[0].Value.ToString());
            }
            return tmp.IndexOf(str);
        }
        private void listDetails(object sender, EventArgs e)
        {
            // Datagrid_view details -> update
            if (!prop_dgv.Visible) prop_dgv.Show();
            Process curr_proc = proc_list.Where(i => i.Id == Convert.ToInt32(name_dgv.CurrentRow.Cells[0].Value)).FirstOrDefault();
            var props = typeof(Process).GetProperties();
            for (int i = 0; i < props.Length; i++)
            {
                try
                {
                    prop_dgv.Rows[i].Cells[1].Value = props[i].GetValue(curr_proc);
                }
                catch (Exception)
                {
                    prop_dgv.Rows[i].Cells[1].Value = "Undefined";
                }
            }
        }
        private void logEvent(string str)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(logEvent), new object[] { str });
                return;
            }
            log_textbox.Text += "[" + DateTime.Now + "] : " + str + "\r\n";
        }
    }
}