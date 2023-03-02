using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailRoadV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private BindingSource bindingSource1;
        private Button button1;

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void InitializeData()
        {
            bindingSource1 = new System.Windows.Forms.BindingSource();

            //Handle the BindingComplete event to ensure the two forms
            // remain synchronized.
            bindingSource1.BindingComplete +=
                new BindingCompleteEventHandler(bindingSource1_BindingComplete);

            DataSet dataSet1 = new DataSet();
        }

        private void bindingSource1_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate && e.Exception == null)
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }
    }
}
