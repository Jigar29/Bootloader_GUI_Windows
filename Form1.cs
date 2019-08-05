using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using System.Threading;

namespace Bootloader_GUI_Windows
{
    public partial class MainForm : Form
    {
        //Delegate 
        public delegate void PortUpdate();

        private struct port_settings_t
        {
            public uint baudrate;                          // Current baudrate of the COM Port 
            public Parity parity;                            // Prity bit needed?
            public bool isCloseAfterProgrammingRequested;  // Close after the programming is done requested? 
            public bool isDTRRequested;                    // DTR requeted? 
            public bool isRTSRequested;                    // RTS Requested? 
            public StopBits num_of_stopbits;                   // Two stop bits requested? 
            public String port_name;                         // COM port name 
            public bool port_state;                        // Status of the port ( Open or Close )
        }

        // Variable declarations
        port_settings_t current_port_configs;
        SerialPort currentport;
        String[] port_name_list = null;
        public PortUpdate attachDelegate, dettachDelegate;

        public MainForm()
        {
            InitializeComponent();

            SerialPortWatcher wtcher = new SerialPortWatcher(this);

            // Initializing the port_settings_t members
            current_port_configs.baudrate                           = Convert.ToUInt32(baudrate_combobox.SelectedItem); // baudrate_combobox.SelectedItem
            current_port_configs.parity                             = Parity.None;
            current_port_configs.isCloseAfterProgrammingRequested   = close_com_port_after_prog.Checked;
            current_port_configs.isDTRRequested                     = dtr_checkbox.Checked;
            current_port_configs.isRTSRequested                     = rts_checkbox.Checked;
            current_port_configs.num_of_stopbits                    = StopBits.One;
            current_port_configs.port_state                         = false;

            // Delegates declaration 
            attachDelegate  = new PortUpdate(deviceAttachEvent);
            dettachDelegate = new PortUpdate(deviceDettachEvent);

            //Serial Port Initialization 
            currentport     = new SerialPort();
            port_name_list  = SerialPort.GetPortNames();
            port_selection_combobox.Items.AddRange(port_name_list);
        }

        public void deviceAttachEvent()
        {
            port_selection_combobox.Items.Clear();
            port_selection_combobox.Items.AddRange(SerialPort.GetPortNames());
            verbose.Text += "Device Attached\n";
            verbose.Show();
        }
        public void deviceDettachEvent()
        {
            port_selection_combobox.Items.Clear();
            port_selection_combobox.Items.AddRange(SerialPort.GetPortNames());
            verbose.Text += "Device Dettached\n";
            verbose.Show();
        }
        /*****************************************************************************************
         *****************************************************************************************
         ***********************************GUI Event Handlers************************************
         *****************************************************************************************
         ****************************************************************************************/

        private void Image_file_browse_button_Click(object sender, EventArgs e)
        {
            image_file_opener_object.InitialDirectory = "C:\\";
            image_file_opener_object.Title = "Seelct the File to load";
            image_file_opener_object.Filter = "Hex Files (*.hex)|*.hex|All files (*.*)|*.*";
            image_file_opener_object.ShowDialog();
            image_filepath_textbox.Text = image_file_opener_object.FileName;

            if (image_filepath_textbox.Text == "")
            {
                image_filepath_textbox.Text = "Please Select an Image File";
            }
            else
            {
                verbose.Text += image_filepath_textbox.Text + " file selected\n";
                verbose.Show();
            }

            image_filepath_textbox.Show();
        }

        private void Baudrate_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_port_configs.baudrate = Convert.ToUInt32(baudrate_combobox.SelectedItem);
            verbose.Text += "Baudrate is Set to " + current_port_configs.baudrate.ToString() + "bps\n";
            verbose.Show();
            port_open_close_button.Enabled = true;
        }

        private void Port_selection_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_port_configs.port_name = port_selection_combobox.SelectedItem.ToString();
            verbose.Text += current_port_configs.port_name + " Port Selected\n";
            verbose.Show();
            baudrate_combobox.Enabled = true;
        }

        private void Port_open_close_button_Click(object sender, EventArgs e)
        {
            // Lets determine the current state of the button 
            if (current_port_configs.port_state == false)         // Port is close at this point
            {
                // Lets update the port settings first 
                current_port_configs.port_state = true;

                //Lets update the name of the button 
                port_open_close_button.Text = "Close";

                //Lets lock all the buttons which can manipulate the settings while the port is open
                port_selection_combobox.Enabled = false;
                baudrate_combobox.Enabled = false;
                close_com_port_after_prog.Enabled = false;
                two_stop_bits_chekcbox.Enabled = false;
                dtr_checkbox.Enabled = false;
                rts_checkbox.Enabled = false;
                parity_checkbox.Enabled = false;

                //Configure the Port properties before opening the port 
                currentport.BaudRate = Convert.ToInt32(current_port_configs.baudrate);
                currentport.PortName = current_port_configs.port_name;
                currentport.Parity = current_port_configs.parity;
                currentport.StopBits = current_port_configs.num_of_stopbits;
                currentport.DtrEnable = current_port_configs.isRTSRequested;
                currentport.RtsEnable = current_port_configs.isRTSRequested;

                // Lets open the physical ports now
                currentport.Open();
                verbose.Text += currentport.PortName + " Opened\n";
            }
            else                            // Port is open already 
            {
                // Lets update the port settings first 
                current_port_configs.port_state = false;

                //Lets update the name of the button 
                port_open_close_button.Text = "Open";

                //Lets lock all the buttons which can manipulate the settings while the port is open
                port_selection_combobox.Enabled = true;
                baudrate_combobox.Enabled = true;
                close_com_port_after_prog.Enabled = true;
                two_stop_bits_chekcbox.Enabled = true;
                dtr_checkbox.Enabled = true;
                rts_checkbox.Enabled = true;
                parity_checkbox.Enabled = true;

                // Lets close the physical ports now
                currentport.Close();
                verbose.Text += current_port_configs.port_name + " Closed\n";
            }
            verbose.Show();
        }

        private void Close_com_port_after_prog_CheckedChanged(object sender, EventArgs e)
        {
            if (close_com_port_after_prog.Checked)
            {
                current_port_configs.isCloseAfterProgrammingRequested = true;
                verbose.Text += "COM Port will be closed after Programming is done\n";
            }
            else
            {
                current_port_configs.isCloseAfterProgrammingRequested = false;
                verbose.Text += "COM Port will be closed after Programming is done\n";
            }
            verbose.Show();
        }

        private void Two_stop_bits_chekcbox_CheckedChanged(object sender, EventArgs e)
        {
            if (two_stop_bits_chekcbox.Checked)
            {
                current_port_configs.num_of_stopbits = StopBits.Two;
                verbose.Text += "2 Stop Bits are requested for the transmission frame\n";
            }
            else
            {
                current_port_configs.num_of_stopbits = StopBits.One;
                verbose.Text += "1 Stop Bit is requested for the transmission frame\n";
            }
            verbose.Show();
        }

        private void Parity_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (parity_checkbox.Checked)
            {
                current_port_configs.parity = Parity.Even;
                verbose.Text += "Even Parity Selected\n";
            }
            else
            {
                current_port_configs.parity = Parity.None;
                verbose.Text += "No Parity Selected\n";
            }
            verbose.Show();
        }

        private void Dtr_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (dtr_checkbox.Checked)
            {
                current_port_configs.isDTRRequested = true;
                verbose.Text += "DTR Requested\n";
            }
            else
            {
                current_port_configs.isDTRRequested = false;
                verbose.Text += "DTR is not needed for the Transmission\n";
            }
            verbose.Show();
        }

        private void Rts_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rts_checkbox.Checked)
            {
                current_port_configs.isRTSRequested = true;
                verbose.Text += "RTS Requested\n";
            }
            else
            {
                current_port_configs.isRTSRequested = false;
                verbose.Text += "RTS is not needed for the Transmission\n";
            }
            verbose.Show();
        }
    }

    public class SerialPortWatcher
    {
        MainForm main_form_object; 

        public SerialPortWatcher( MainForm instance)
        {
            // Event Watcher for Device Attach events 
            var insertQuery = new WqlEventQuery("SELECT * FROM __InstanceCreationEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_USBHub'");
            var insertWatcher = new ManagementEventWatcher(insertQuery);
            insertWatcher.EventArrived += DeviceInsertedEvent;
            insertWatcher.Start();

            // Event Watcher for device Dettach events 
            var removeQuery = new WqlEventQuery("SELECT * FROM __InstanceDeletionEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_USBHub'");
            var removeWatcher = new ManagementEventWatcher(removeQuery);
            removeWatcher.EventArrived += DeviceRemovedEvent;
            removeWatcher.Start();

            main_form_object = instance; 
        }


        /*****************************************************************************************
         *****************************************************************************************
         ***********************************User Defined Functions********************************
         *****************************************************************************************
         ****************************************************************************************/
        private void DeviceInsertedEvent(object sender, EventArrivedEventArgs e)
        {
            main_form_object.Invoke(main_form_object.attachDelegate);
        }

        private void DeviceRemovedEvent(object sender, EventArrivedEventArgs e)
        {
            main_form_object.Invoke(main_form_object.dettachDelegate);
        }
    }
}
