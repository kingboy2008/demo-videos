using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace gridview1
{
    partial class SmobilerForm1 : Smobiler.Core.MobileForm
    {
        private void SmobilerForm1_Load(object sender, EventArgs e)
        {
            tblDataTableAdapter.Fill(smobilerDemoCostDataSet.tblData);
            gridView1.DataBind();
        }
    }
}