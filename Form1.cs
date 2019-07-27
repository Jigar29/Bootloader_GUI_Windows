using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bootloader_GUI_Windows
{
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Image_file_browse_button_Click(object sender, EventArgs e)
        {
            image_file_opener_object.InitialDirectory = "C:"; 
            image_file_opener_object.ShowDialog();

            image_filepath_textbox.Text = image_file_opener_object.FileName;

            if(image_filepath_textbox.Text == "")
            {
                image_filepath_textbox.Text = "Please Select an Image File";
            }

            image_filepath_textbox.Show();
        }
    }
}
