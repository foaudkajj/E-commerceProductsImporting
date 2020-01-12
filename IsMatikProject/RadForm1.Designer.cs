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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.KeywordTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.N11CheckBox = new System.Windows.Forms.CheckBox();
            this.CarrefourSACheckBox = new System.Windows.Forms.CheckBox();
            this.radForm1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeywordTextBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radForm1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(127, 123);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(730, 430);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Click += new System.EventHandler(this.radGridView1_Click);
            // 
            // KeywordTextBox
            // 
            this.KeywordTextBox.Location = new System.Drawing.Point(6, 32);
            this.KeywordTextBox.Name = "KeywordTextBox";
            this.KeywordTextBox.NullText = "Aranacak Ürün";
            this.KeywordTextBox.ShowNullText = true;
            this.KeywordTextBox.Size = new System.Drawing.Size(129, 20);
            this.KeywordTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Sorgulama";
            // 
            // N11CheckBox
            // 
            this.N11CheckBox.AutoSize = true;
            this.N11CheckBox.Location = new System.Drawing.Point(22, 77);
            this.N11CheckBox.Name = "N11CheckBox";
            this.N11CheckBox.Size = new System.Drawing.Size(46, 17);
            this.N11CheckBox.TabIndex = 0;
            this.N11CheckBox.Tag = "https://www.n11.com/";
            this.N11CheckBox.Text = "N11";
            this.N11CheckBox.UseVisualStyleBackColor = true;
            // 
            // CarrefourSACheckBox
            // 
            this.CarrefourSACheckBox.AutoSize = true;
            this.CarrefourSACheckBox.Location = new System.Drawing.Point(109, 77);
            this.CarrefourSACheckBox.Name = "CarrefourSACheckBox";
            this.CarrefourSACheckBox.Size = new System.Drawing.Size(88, 17);
            this.CarrefourSACheckBox.TabIndex = 1;
            this.CarrefourSACheckBox.Tag = "https://www.carrefoursa.com/tr/";
            this.CarrefourSACheckBox.Text = "CarrefourSA";
            this.CarrefourSACheckBox.UseVisualStyleBackColor = true;
            // 
            // radForm1BindingSource
            // 
            this.radForm1BindingSource.DataSource = typeof(IsMatikProject.RadForm1);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.radForm1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource radForm1BindingSource;
        private Telerik.WinControls.UI.RadTextBox KeywordTextBox;
        private System.Windows.Forms.Button SearchButton;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CarrefourSACheckBox;
        private System.Windows.Forms.CheckBox N11CheckBox;
    }
}