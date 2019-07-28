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

namespace Bootloader_GUI_Windows
{

    public partial class main_page : Form
    {

        private struct port_settings_t
        {
           public uint    baudrate;                          // Current baudrate of the COM Port 
           public bool    isParityRequired;                  // Prity bit needed?
           public bool    isCloseAfterProgrammingRequested;  // Close after the programming is done requested? 
           public bool    isDTRRequested;                    // DTR requeted? 
           public bool    isRTSRequested;                    // RTS Requested? 
           public bool    isTwoStopBitsRequested;            // Two stop bits requested? 
           public String  port_name;                         // COM port name 
           public bool    port_state;                        // Status of the port ( Open or Close )
        }

        // Variable declarations
        port_settings_t current_port_configs;
        SerialPort currentport;
        String[] port_name_list = null; 

        public main_page()
        {
            InitializeComponent();

            // Initializing the port_settings_t members
            current_port_configs.baudrate                           = Convert.ToUInt32(baudrate_combobox.SelectedItem); // baudrate_combobox.SelectedItem
            current_port_configs.isParityRequired                   = parity_checkbox.Checked;
            current_port_configs.isCloseAfterProgrammingRequested   = close_com_port_after_prog.Checked;
            current_port_configs.isDTRRequested                     = dtr_checkbox.Checked;
            current_port_configs.isRTSRequested                     = rts_checkbox.Checked;
            current_port_configs.isTwoStopBitsRequested             = two_stop_bits_chekcbox.Checked;

            //Serial Port Initialization 
            currentport = new SerialPort();
            port_name_list = SerialPort.GetPortNames();
            port_selection_combobox.Items.AddRange(port_name_list);
        }

        private void Image_file_browse_button_Click(object sender, EventArgs e)
        {
            image_file_opener_object.InitialDirectory = "C:\\";
            image_file_opener_object.Title = "Seelct the File to load";
            image_file_opener_object.Filter = "Hex Files (*.hex)|*.hex|All files (*.*)|*.*";
            image_file_opener_object.ShowDialog();
            image_filepath_textbox.Text = image_file_opener_object.FileName;

            if(image_filepath_textbox.Text == "")
            {
                image_filepath_textbox.Text = "Please Select an Image File";
            }
            else
            {
                message_textbox.Text += image_filepath_textbox.Text + " file selected\n";
                message_textbox.Show();
            }

            image_filepath_textbox.Show();
        }

        private void Baudrate_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_port_configs.baudrate = Convert.ToUInt32(baudrate_combobox.SelectedItem);
            message_textbox.Text += "Baudrate is Set to " + current_port_configs.baudrate.ToString() + "bps\n";
            message_textbox.Show();
            port_open_close_button.Enabled = true;
        }

        private void Port_selection_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_port_configs.port_name = port_selection_combobox.SelectedItem.ToString();
            message_textbox.Text += current_port_configs.port_name + " Port Selected\n";
            message_textbox.Show();
            baudrate_combobox.Enabled = true;
        }

        private void Close_com_port_after_prog_CheckedChanged(object sender, EventArgs e)
        {
            current_port_configs.isCloseAfterProgrammingRequested = close_com_port_after_prog.Checked; 
        }

        private void Port_open_close_button_Click(object sender, EventArgs e)
        {
            currentport.BaudRate = Convert.ToInt32(current_port_configs.baudrate);
            currentport.PortName = current_port_configs.port_name;
        }
    }
}
