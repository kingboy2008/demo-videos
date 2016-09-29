using System;
using Smobiler.Core;
namespace gridview1
{
    partial class SmobilerLayout1 : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public SmobilerLayout1()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            // 
            // image1
            // 
            this.image1.DataMember = "Type";
            this.image1.DisplayMember = "Type";
            this.image1.Name = "image1";
            this.image1.ResourceID = "Type";
            this.image1.Size = new System.Drawing.Size(40,30);
            this.image1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.DataMember = "TypeName";
            this.label1.DisplayMember = "TypeName";
            this.label1.FontSize = 8;
            this.label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(0,30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40,10);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.FontSize = 16;
            this.label2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label2.Location = new System.Drawing.Point(50,0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10,24);
            this.label2.TabIndex = 4;
            this.label2.Text = "��";
            // 
            // label3
            // 
            this.label3.DataMember = "Money";
            this.label3.DisplayMember = "Money";
            this.label3.FontSize = 16;
            this.label3.Location = new System.Drawing.Point(60,0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40,24);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.DataMember = "Date";
            this.label4.DisplayMember = "Date";
            this.label4.FontSize = 10;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Format = "{0:d}";
            this.label4.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label4.Location = new System.Drawing.Point(50,24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50,16);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.FontSize = 8;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(110,0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20,20);
            this.label5.TabIndex = 7;
            this.label5.Text = "��ע��";
            this.label5.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // label6
            // 
            this.label6.DataMember = "Memo";
            this.label6.DisplayMember = "Memo";
            this.label6.Location = new System.Drawing.Point(136,0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104,40);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            this.label6.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // SmobilerLayout1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label1,
            this.label2,
            this.label3,
            this.label4,
            this.label5,
            this.label6});
            this.Size = new System.Drawing.Size(240,40);
            this.Name = "SmobilerLayout1";

        }
        #endregion

        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label label6;
    }
}
