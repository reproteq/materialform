


namespace scraperhistory
{
  
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Test",
            "8/13/19"}, -1);
            this.TabController = new MaterialSkin.Controls.MaterialTabControl();
            this.Bot = new System.Windows.Forms.TabPage();
            this.Setting = new System.Windows.Forms.TabPage();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Items = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastdatecompleted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabController.SuspendLayout();
            this.Bot.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabController
            // 
            this.TabController.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabController.Controls.Add(this.Bot);
            this.TabController.Controls.Add(this.Setting);
            this.TabController.Depth = 0;
            this.TabController.Location = new System.Drawing.Point(0, 113);
            this.TabController.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(802, 336);
            this.TabController.TabIndex = 0;
            // 
            // bot
            // 
            this.Bot.Controls.Add(this.listView1);
            this.Bot.Location = new System.Drawing.Point(4, 25);
            this.Bot.Name = "bot";
            this.Bot.Padding = new System.Windows.Forms.Padding(3);
            this.Bot.Size = new System.Drawing.Size(794, 307);
            this.Bot.TabIndex = 0;
            this.Bot.Text = "Bot";
            this.Bot.UseVisualStyleBackColor = true;
            // 
            // setting
            // 
            this.Setting.Location = new System.Drawing.Point(4, 25);
            this.Setting.Name = "setting";
            this.Setting.Padding = new System.Windows.Forms.Padding(3);
            this.Setting.Size = new System.Drawing.Size(768, 337);
            this.Setting.TabIndex = 1;
            this.Setting.Text = "Setting";
            this.Setting.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector2.BaseTabControl = this.TabController;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(0, 68);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(802, 39);
            this.materialTabSelector2.TabIndex = 1;
            this.materialTabSelector2.Text = "materialTabSelector2";
            this.materialTabSelector2.Click += new System.EventHandler(this.MaterialTabSelector2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Items,
            this.lastdatecompleted});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(79, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(610, 216);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Items
            // 
            this.Items.Text = "Items";
            // 
            // lastdatecompleted
            // 
            this.lastdatecompleted.Text = "Last Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.TabController);
            this.Name = "Form1";
            this.Text = "Bot Histry Scraper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabController.ResumeLayout(false);
            this.Bot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabController;
        private System.Windows.Forms.TabPage Bot;
        private System.Windows.Forms.TabPage Setting;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Items;
        private System.Windows.Forms.ColumnHeader lastdatecompleted;
    }
}

