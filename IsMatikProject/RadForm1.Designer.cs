namespace IsMatikProject
{
    partial class RadForm1
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
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.KeywordTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CarrefourSACheckBox = new System.Windows.Forms.CheckBox();
            this.N11CheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filterTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeywordTextBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.AutoSizeRows = true;
            this.radGridView1.EnableCustomFiltering = true;
            this.radGridView1.Font = new System.Drawing.Font("Rockwell", 8.25F);
            this.radGridView1.Location = new System.Drawing.Point(34, 12);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowDeleteRow = false;
            this.radGridView1.MasterTemplate.AllowEditRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.EnableCustomFiltering = true;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "ListingDate";
            this.radGridView1.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.Size = new System.Drawing.Size(1724, 650);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.CustomFiltering += new Telerik.WinControls.UI.GridViewCustomFilteringEventHandler(this.radGridView1_CustomFiltering);
            // 
            // KeywordTextBox
            // 
            this.KeywordTextBox.Location = new System.Drawing.Point(6, 32);
            this.KeywordTextBox.Name = "KeywordTextBox";
            this.KeywordTextBox.NullText = "Aranacak Ürün";
            this.KeywordTextBox.ShowNullText = true;
            this.KeywordTextBox.Size = new System.Drawing.Size(129, 27);
            this.KeywordTextBox.TabIndex = 1;
            this.KeywordTextBox.TextChanged += new System.EventHandler(this.KeywordTextBox_TextChanged);
            this.KeywordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeywordTextBox_KeyDown);
            // 
            // SearchButton
            // 
            this.SearchButton.Enabled = false;
            this.SearchButton.Location = new System.Drawing.Point(160, 32);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(104, 27);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CarrefourSACheckBox);
            this.groupBox1.Controls.Add(this.KeywordTextBox);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.N11CheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 712);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Sorgulama";
            // 
            // CarrefourSACheckBox
            // 
            this.CarrefourSACheckBox.AutoSize = true;
            this.CarrefourSACheckBox.Location = new System.Drawing.Point(109, 77);
            this.CarrefourSACheckBox.Name = "CarrefourSACheckBox";
            this.CarrefourSACheckBox.Size = new System.Drawing.Size(134, 24);
            this.CarrefourSACheckBox.TabIndex = 1;
            this.CarrefourSACheckBox.Tag = "https://www.carrefoursa.com/tr/";
            this.CarrefourSACheckBox.Text = "CarrefourSA";
            this.CarrefourSACheckBox.UseVisualStyleBackColor = true;
            // 
            // N11CheckBox
            // 
            this.N11CheckBox.AutoSize = true;
            this.N11CheckBox.Location = new System.Drawing.Point(22, 77);
            this.N11CheckBox.Name = "N11CheckBox";
            this.N11CheckBox.Size = new System.Drawing.Size(65, 24);
            this.N11CheckBox.TabIndex = 0;
            this.N11CheckBox.Tag = "https://www.n11.com/";
            this.N11CheckBox.Text = "N11";
            this.N11CheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filterTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(898, 712);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Listeleme";
            // 
            // filterTextBox1
            // 
            this.filterTextBox1.Font = new System.Drawing.Font("Rockwell", 15F);
            this.filterTextBox1.Location = new System.Drawing.Point(16, 32);
            this.filterTextBox1.Name = "filterTextBox1";
            this.filterTextBox1.NullText = "Ürün Filtreleme";
            this.filterTextBox1.ShowNullText = true;
            this.filterTextBox1.Size = new System.Drawing.Size(362, 29);
            this.filterTextBox1.TabIndex = 2;
            this.filterTextBox1.TextChanged += new System.EventHandler(this.radTextBox1_TextChanged);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1776, 824);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeywordTextBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadTextBox KeywordTextBox;
        private System.Windows.Forms.Button SearchButton;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CarrefourSACheckBox;
        private System.Windows.Forms.CheckBox N11CheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private Telerik.WinControls.UI.RadTextBox filterTextBox1;
    }
}