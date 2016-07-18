using Smobiler.Core;

namespace SmobilerApplication79
{
    partial class SmobilerForm1 : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        public SmobilerForm1()
            : base()
        {
            //This call is required by the SmobilerForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridView1 = new Smobiler.Core.Controls.GridView();
            this.tblDealerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smobilerDemoDealerDataSet = new SmobilerApplication79.SmobilerDemoDealerDataSet();
            this.ShowPicked = new Smobiler.Core.Controls.ToolbarItem();
            this.tblDealerTableAdapter = new SmobilerApplication79.SmobilerDemoDealerDataSetTableAdapters.tblDealerTableAdapter();
            this.gps1 = new Smobiler.Core.Controls.GPS();
            this.gps2 = new Smobiler.Core.Controls.GPS();
            ((System.ComponentModel.ISupportInitialize)(this.tblDealerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smobilerDemoDealerDataSet)).BeginInit();
            // 
            // gridView1
            // 
            this.gridView1.DataSource = this.tblDealerBindingSource;
            this.gridView1.Layout = "SmobilerForm2";
            this.gridView1.Name = "gridView1";
            this.gridView1.Size = new System.Drawing.SizeF(120F, 200F);
            this.gridView1.TabIndex = 2;
            this.gridView1.ItemClick += new Smobiler.Core.Controls.GridViewItemClickEventHandler(this.gridView1_ItemClick);
            // 
            // tblDealerBindingSource
            // 
            this.tblDealerBindingSource.DataMember = "tblDealer";
            this.tblDealerBindingSource.DataSource = this.smobilerDemoDealerDataSet;
            // 
            // smobilerDemoDealerDataSet
            // 
            this.smobilerDemoDealerDataSet.DataSetName = "SmobilerDemoDealerDataSet";
            this.smobilerDemoDealerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ShowPicked
            // 
            this.ShowPicked.IconID = "ShowPicked";
            this.ShowPicked.Name = "ShowPicked";
            this.ShowPicked.Text = "�鿴����";
            // 
            // tblDealerTableAdapter
            // 
            this.tblDealerTableAdapter.ClearBeforeFill = true;
            // 
            // gps1
            // 
            this.gps1.Name = "gps1";
            // 
            // gps2
            // 
            this.gps2.Name = "gps2";
            // 
            // SmobilerForm1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(93)))));
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.gps1,
            this.gps2});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridView1});
            this.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(93)))));
            this.TitleText = "������";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.ShowPicked});
            this.Load += new System.EventHandler(this.SmobilerForm1_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.SmobilerForm1_ToolbarItemClick);
            ((System.ComponentModel.ISupportInitialize)(this.tblDealerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smobilerDemoDealerDataSet)).EndInit();

        }
        #endregion

        private Smobiler.Core.Controls.GridView gridView1;
        private Smobiler.Core.Controls.ToolbarItem ShowPicked;
        private System.Windows.Forms.BindingSource tblDealerBindingSource;
        private System.ComponentModel.IContainer components;
        private SmobilerDemoDealerDataSet smobilerDemoDealerDataSet;
        private SmobilerDemoDealerDataSetTableAdapters.tblDealerTableAdapter tblDealerTableAdapter;
        private Smobiler.Core.Controls.GPS gps1;
        private Smobiler.Core.Controls.GPS gps2;
    }
}