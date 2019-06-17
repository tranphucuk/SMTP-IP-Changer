namespace ssh_change_Multi_Port.HomeModule
{
    partial class Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.teImportPath = new DevExpress.XtraEditors.TextEdit();
            this.sbImportSsh = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.teTotalSsh = new DevExpress.XtraEditors.TextEdit();
            this.teSshUsed = new DevExpress.XtraEditors.TextEdit();
            this.seTimeOut = new DevExpress.XtraEditors.SpinEdit();
            this.seThread = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sbChangeSsh = new DevExpress.XtraEditors.SimpleButton();
            this.sbStop = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teImportPath.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTotalSsh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSshUsed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTimeOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seThread.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(13, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(452, 264);
            this.gridControl1.TabIndex = 18;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // teImportPath
            // 
            this.teImportPath.Location = new System.Drawing.Point(136, 284);
            this.teImportPath.Name = "teImportPath";
            this.teImportPath.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teImportPath.Properties.Appearance.Options.UseFont = true;
            this.teImportPath.Properties.ReadOnly = true;
            this.teImportPath.Size = new System.Drawing.Size(329, 26);
            this.teImportPath.TabIndex = 19;
            // 
            // sbImportSsh
            // 
            this.sbImportSsh.AllowFocus = false;
            this.sbImportSsh.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbImportSsh.Appearance.Options.UseFont = true;
            this.sbImportSsh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.sbImportSsh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbImportSsh.ImageOptions.Image")));
            this.sbImportSsh.Location = new System.Drawing.Point(13, 284);
            this.sbImportSsh.Name = "sbImportSsh";
            this.sbImportSsh.Size = new System.Drawing.Size(117, 29);
            this.sbImportSsh.TabIndex = 20;
            this.sbImportSsh.Text = "Import";
            this.sbImportSsh.Click += new System.EventHandler(this.sbImportSsh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutControl1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(475, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 190);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.teTotalSsh);
            this.layoutControl1.Controls.Add(this.teSshUsed);
            this.layoutControl1.Controls.Add(this.seTimeOut);
            this.layoutControl1.Controls.Add(this.seThread);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(3, 22);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(771, 202, 812, 500);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(189, 165);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // teTotalSsh
            // 
            this.teTotalSsh.EditValue = "0";
            this.teTotalSsh.Location = new System.Drawing.Point(81, 112);
            this.teTotalSsh.Name = "teTotalSsh";
            this.teTotalSsh.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTotalSsh.Properties.Appearance.Options.UseFont = true;
            this.teTotalSsh.Properties.Appearance.Options.UseTextOptions = true;
            this.teTotalSsh.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teTotalSsh.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.teTotalSsh.Size = new System.Drawing.Size(92, 26);
            this.teTotalSsh.StyleController = this.layoutControl1;
            this.teTotalSsh.TabIndex = 7;
            // 
            // teSshUsed
            // 
            this.teSshUsed.EditValue = "0";
            this.teSshUsed.Location = new System.Drawing.Point(81, 80);
            this.teSshUsed.Name = "teSshUsed";
            this.teSshUsed.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teSshUsed.Properties.Appearance.Options.UseFont = true;
            this.teSshUsed.Properties.Appearance.Options.UseTextOptions = true;
            this.teSshUsed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teSshUsed.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.teSshUsed.Size = new System.Drawing.Size(92, 26);
            this.teSshUsed.StyleController = this.layoutControl1;
            this.teSshUsed.TabIndex = 6;
            // 
            // seTimeOut
            // 
            this.seTimeOut.EditValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.seTimeOut.Location = new System.Drawing.Point(81, 48);
            this.seTimeOut.Name = "seTimeOut";
            this.seTimeOut.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seTimeOut.Properties.Appearance.Options.UseFont = true;
            this.seTimeOut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTimeOut.Properties.Mask.EditMask = "n0";
            this.seTimeOut.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.seTimeOut.Properties.MinValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.seTimeOut.Size = new System.Drawing.Size(92, 26);
            this.seTimeOut.StyleController = this.layoutControl1;
            this.seTimeOut.TabIndex = 5;
            // 
            // seThread
            // 
            this.seThread.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seThread.Location = new System.Drawing.Point(81, 16);
            this.seThread.Name = "seThread";
            this.seThread.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seThread.Properties.Appearance.Options.UseFont = true;
            this.seThread.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seThread.Properties.Mask.EditMask = "n0";
            this.seThread.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.seThread.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seThread.Size = new System.Drawing.Size(92, 26);
            this.seThread.StyleController = this.layoutControl1;
            this.seThread.TabIndex = 4;
            this.seThread.EditValueChanged += new System.EventHandler(this.seThread_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(189, 165);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.seThread;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(163, 32);
            this.layoutControlItem1.Text = "Thread";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(61, 20);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.seTimeOut;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(163, 32);
            this.layoutControlItem2.Text = "Time out";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(61, 20);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.teSshUsed;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 64);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(163, 32);
            this.layoutControlItem3.Text = "Used";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(61, 20);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.teTotalSsh;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(163, 43);
            this.layoutControlItem4.Text = "Total SSH";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(61, 20);
            // 
            // sbChangeSsh
            // 
            this.sbChangeSsh.AllowFocus = false;
            this.sbChangeSsh.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbChangeSsh.Appearance.Options.UseFont = true;
            this.sbChangeSsh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.sbChangeSsh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbChangeSsh.ImageOptions.Image")));
            this.sbChangeSsh.Location = new System.Drawing.Point(474, 200);
            this.sbChangeSsh.Name = "sbChangeSsh";
            this.sbChangeSsh.Size = new System.Drawing.Size(121, 36);
            this.sbChangeSsh.TabIndex = 22;
            this.sbChangeSsh.Text = "Change";
            this.sbChangeSsh.Click += new System.EventHandler(this.sbChangeSsh_Click);
            // 
            // sbStop
            // 
            this.sbStop.AllowFocus = false;
            this.sbStop.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbStop.Appearance.Options.UseFont = true;
            this.sbStop.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.sbStop.ImageOptions.Image = global::ssh_change_Multi_Port.Properties.Resources.Stop_red_icon__2_;
            this.sbStop.Location = new System.Drawing.Point(601, 200);
            this.sbStop.Name = "sbStop";
            this.sbStop.Size = new System.Drawing.Size(69, 36);
            this.sbStop.TabIndex = 22;
            this.sbStop.Text = "Stop";
            this.sbStop.Click += new System.EventHandler(this.sbStop_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sbStop);
            this.Controls.Add(this.sbChangeSsh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sbImportSsh);
            this.Controls.Add(this.teImportPath);
            this.Controls.Add(this.gridControl1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(682, 328);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teImportPath.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teTotalSsh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSshUsed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTimeOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seThread.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit teImportPath;
        private DevExpress.XtraEditors.SimpleButton sbImportSsh;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SpinEdit seTimeOut;
        private DevExpress.XtraEditors.SpinEdit seThread;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton sbChangeSsh;
        private DevExpress.XtraEditors.SimpleButton sbStop;
        private DevExpress.XtraEditors.TextEdit teTotalSsh;
        private DevExpress.XtraEditors.TextEdit teSshUsed;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
