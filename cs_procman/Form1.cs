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

namespace cs_procman
{
    public partial class Form1 : Form
    {   
        private Process[] list_proc;
        private PropertyInfo[] props = typeof(Process).GetProperties();
        private ManagementEventWatcher startProcessEW = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStartTrace");
        private ManagementEventWatcher stopProcessEW = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStopTrace");
        private SoundPlayer SP = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            initProcessEventHandler();
            list_proc = Process.GetProcesses();
            string str;
            for(int i = 0; i < list_proc.Length - 1; i++)
            {
                str = list_proc[i].ProcessName.Split(new string[] { "." }, StringSplitOptions.None)[0];
                name_dgv.Rows.Add(str);
            }
            initDGV();
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
            logEvent(e.NewEvent.Properties["ProcessName"].Value.ToString() + " has started");
            addProcessToDGV(e.NewEvent.Properties["ProcessName"].Value.ToString());
            Console.WriteLine(e.NewEvent.Properties["ProcessName"].Value.ToString() + " has started");
            SP.SoundLocation = "../../mp3/light.wav";
            SP.Play();
        }
        private void onStopProcessEvent(object sender, EventArrivedEventArgs e)
        {
            logEvent(e.NewEvent.Properties["ProcessName"].Value.ToString() + " has terminated");
            removeProcessToDGV(e.NewEvent.Properties["ProcessName"].Value.ToString());
            Console.WriteLine(e.NewEvent.Properties["ProcessName"].Value.ToString() + " has terminated");
            SP.SoundLocation = "../../mp3/long-expected.wav";
            SP.Play();
        }
        private void addProcessToDGV(string str)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(addProcessToDGV), new object[] { str });
                return;
            }
            str = str.Split(new string[] { "." }, StringSplitOptions.None)[0];
            name_dgv.Rows.Add(str);
        }
        private void removeProcessToDGV(string str)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(removeProcessToDGV), new object[] { str });
                return;
            }
            str = str.Split(new string[] {"."}, StringSplitOptions.None)[0];
            //if(Process.GetProcessesByName(str).Length > 0)
                name_dgv.Rows.RemoveAt(findIndexByName(str));
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
        
        private void initDGV()
        {
            dgv.Hide();
            foreach (var prop in props)
            {
                dgv.Rows.Add(prop.Name, "");
            } 
        }
        private void listDetails(object sender, EventArgs e)
        {
            if (!dgv.Visible) dgv.Show();
            Process curr_proc = list_proc[name_dgv.CurrentRow.Index];
            for(int i = 0; i < props.Length; i++)
            {
                try
                {
                    dgv.Rows[i].Cells[1].Value = props[i].GetValue(curr_proc);
                }
                catch (Exception)
                {
                    dgv.Rows[i].Cells[1].Value = "Undefined";
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