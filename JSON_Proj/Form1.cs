using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.IO;
using System.Net;

namespace JSON_Proj
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            //InitializeComponent();
            openFileDialog1.Filter = "Файлы json|*.json";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);



            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(fileText[0].ToString());
            textBox1.Text = typeof(DataSet).ToString();
            

        }
        
        public class Keys
        {
            public string Key { get; set; }
            public string Value { get; set; }
            public string GroupName { get; set; }
            public string Type { get; set; }
            public string Comment { get; set; }
            public bool IsHidden { get; set; }
            public bool IsReadOnly { get; set; }
            public string Schedule { get; set; }
            public int ContextId { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {

           

            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
            textBox1.ScrollToCaret();
            textBox1.Refresh();
            textBox1.ScrollBars = ScrollBars.Vertical;

        }

    }


}
