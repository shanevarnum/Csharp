namespace DemographicAnalyticalReportsVarn
{
    partial class FormReports
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
            this.buttonExitReports = new System.Windows.Forms.Button();
            this.dataGridViewReports = new System.Windows.Forms.DataGridView();
            this.businessEntityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPurchaseYTDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFirstPurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlyIncomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalChildrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberChildrenAtHomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeOwnerFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.numberCarsOwnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPersonDemographicsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorks2012_DataDataSet = new DemographicAnalyticalReportsVarn.AdventureWorks2012_DataDataSet();
            this.labelReports = new System.Windows.Forms.Label();
            this.demographicReportOptionsToolStrip = new System.Windows.Forms.ToolStrip();
            this.maritalStatusToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.maritalStatusToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.genderToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.genderToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.totalChildrenToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.totalChildrenToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.educationToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.educationToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.occupationToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.occupationToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.demographicReportOptionsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.vPersonDemographicsTableAdapter = new DemographicAnalyticalReportsVarn.AdventureWorks2012_DataDataSetTableAdapters.vPersonDemographicsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPersonDemographicsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2012_DataDataSet)).BeginInit();
            this.demographicReportOptionsToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExitReports
            // 
            this.buttonExitReports.Location = new System.Drawing.Point(461, 378);
            this.buttonExitReports.Name = "buttonExitReports";
            this.buttonExitReports.Size = new System.Drawing.Size(79, 32);
            this.buttonExitReports.TabIndex = 0;
            this.buttonExitReports.Text = "Exit Reports";
            this.buttonExitReports.UseVisualStyleBackColor = true;
            this.buttonExitReports.Click += new System.EventHandler(this.buttonExitReports_Click);
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.AllowUserToAddRows = false;
            this.dataGridViewReports.AllowUserToDeleteRows = false;
            this.dataGridViewReports.AutoGenerateColumns = false;
            this.dataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.businessEntityIDDataGridViewTextBoxColumn,
            this.totalPurchaseYTDDataGridViewTextBoxColumn,
            this.dateFirstPurchaseDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.maritalStatusDataGridViewTextBoxColumn,
            this.yearlyIncomeDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.totalChildrenDataGridViewTextBoxColumn,
            this.numberChildrenAtHomeDataGridViewTextBoxColumn,
            this.educationDataGridViewTextBoxColumn,
            this.occupationDataGridViewTextBoxColumn,
            this.homeOwnerFlagDataGridViewCheckBoxColumn,
            this.numberCarsOwnedDataGridViewTextBoxColumn});
            this.dataGridViewReports.DataSource = this.vPersonDemographicsBindingSource;
            this.dataGridViewReports.Location = new System.Drawing.Point(12, 87);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.ReadOnly = true;
            this.dataGridViewReports.Size = new System.Drawing.Size(986, 277);
            this.dataGridViewReports.TabIndex = 1;
            // 
            // businessEntityIDDataGridViewTextBoxColumn
            // 
            this.businessEntityIDDataGridViewTextBoxColumn.DataPropertyName = "BusinessEntityID";
            this.businessEntityIDDataGridViewTextBoxColumn.HeaderText = "BusinessEntityID";
            this.businessEntityIDDataGridViewTextBoxColumn.Name = "businessEntityIDDataGridViewTextBoxColumn";
            this.businessEntityIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPurchaseYTDDataGridViewTextBoxColumn
            // 
            this.totalPurchaseYTDDataGridViewTextBoxColumn.DataPropertyName = "TotalPurchaseYTD";
            this.totalPurchaseYTDDataGridViewTextBoxColumn.HeaderText = "TotalPurchaseYTD";
            this.totalPurchaseYTDDataGridViewTextBoxColumn.Name = "totalPurchaseYTDDataGridViewTextBoxColumn";
            this.totalPurchaseYTDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateFirstPurchaseDataGridViewTextBoxColumn
            // 
            this.dateFirstPurchaseDataGridViewTextBoxColumn.DataPropertyName = "DateFirstPurchase";
            this.dateFirstPurchaseDataGridViewTextBoxColumn.HeaderText = "DateFirstPurchase";
            this.dateFirstPurchaseDataGridViewTextBoxColumn.Name = "dateFirstPurchaseDataGridViewTextBoxColumn";
            this.dateFirstPurchaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maritalStatusDataGridViewTextBoxColumn
            // 
            this.maritalStatusDataGridViewTextBoxColumn.DataPropertyName = "MaritalStatus";
            this.maritalStatusDataGridViewTextBoxColumn.HeaderText = "MaritalStatus";
            this.maritalStatusDataGridViewTextBoxColumn.Name = "maritalStatusDataGridViewTextBoxColumn";
            this.maritalStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearlyIncomeDataGridViewTextBoxColumn
            // 
            this.yearlyIncomeDataGridViewTextBoxColumn.DataPropertyName = "YearlyIncome";
            this.yearlyIncomeDataGridViewTextBoxColumn.HeaderText = "YearlyIncome";
            this.yearlyIncomeDataGridViewTextBoxColumn.Name = "yearlyIncomeDataGridViewTextBoxColumn";
            this.yearlyIncomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalChildrenDataGridViewTextBoxColumn
            // 
            this.totalChildrenDataGridViewTextBoxColumn.DataPropertyName = "TotalChildren";
            this.totalChildrenDataGridViewTextBoxColumn.HeaderText = "TotalChildren";
            this.totalChildrenDataGridViewTextBoxColumn.Name = "totalChildrenDataGridViewTextBoxColumn";
            this.totalChildrenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberChildrenAtHomeDataGridViewTextBoxColumn
            // 
            this.numberChildrenAtHomeDataGridViewTextBoxColumn.DataPropertyName = "NumberChildrenAtHome";
            this.numberChildrenAtHomeDataGridViewTextBoxColumn.HeaderText = "NumberChildrenAtHome";
            this.numberChildrenAtHomeDataGridViewTextBoxColumn.Name = "numberChildrenAtHomeDataGridViewTextBoxColumn";
            this.numberChildrenAtHomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // educationDataGridViewTextBoxColumn
            // 
            this.educationDataGridViewTextBoxColumn.DataPropertyName = "Education";
            this.educationDataGridViewTextBoxColumn.HeaderText = "Education";
            this.educationDataGridViewTextBoxColumn.Name = "educationDataGridViewTextBoxColumn";
            this.educationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // occupationDataGridViewTextBoxColumn
            // 
            this.occupationDataGridViewTextBoxColumn.DataPropertyName = "Occupation";
            this.occupationDataGridViewTextBoxColumn.HeaderText = "Occupation";
            this.occupationDataGridViewTextBoxColumn.Name = "occupationDataGridViewTextBoxColumn";
            this.occupationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homeOwnerFlagDataGridViewCheckBoxColumn
            // 
            this.homeOwnerFlagDataGridViewCheckBoxColumn.DataPropertyName = "HomeOwnerFlag";
            this.homeOwnerFlagDataGridViewCheckBoxColumn.HeaderText = "HomeOwnerFlag";
            this.homeOwnerFlagDataGridViewCheckBoxColumn.Name = "homeOwnerFlagDataGridViewCheckBoxColumn";
            this.homeOwnerFlagDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // numberCarsOwnedDataGridViewTextBoxColumn
            // 
            this.numberCarsOwnedDataGridViewTextBoxColumn.DataPropertyName = "NumberCarsOwned";
            this.numberCarsOwnedDataGridViewTextBoxColumn.HeaderText = "NumberCarsOwned";
            this.numberCarsOwnedDataGridViewTextBoxColumn.Name = "numberCarsOwnedDataGridViewTextBoxColumn";
            this.numberCarsOwnedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vPersonDemographicsBindingSource
            // 
            this.vPersonDemographicsBindingSource.DataMember = "vPersonDemographics";
            this.vPersonDemographicsBindingSource.DataSource = this.adventureWorks2012_DataDataSet;
            // 
            // adventureWorks2012_DataDataSet
            // 
            this.adventureWorks2012_DataDataSet.DataSetName = "AdventureWorks2012_DataDataSet";
            this.adventureWorks2012_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelReports
            // 
            this.labelReports.AutoSize = true;
            this.labelReports.Location = new System.Drawing.Point(157, 59);
            this.labelReports.Name = "labelReports";
            this.labelReports.Size = new System.Drawing.Size(596, 13);
            this.labelReports.TabIndex = 2;
            this.labelReports.Text = "Enter values in each of the Parameters above. Then Click the \"Click Here to Run R" +
    "eport\" option above to execute the report";
            // 
            // demographicReportOptionsToolStrip
            // 
            this.demographicReportOptionsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maritalStatusToolStripLabel,
            this.maritalStatusToolStripTextBox,
            this.genderToolStripLabel,
            this.genderToolStripTextBox,
            this.totalChildrenToolStripLabel,
            this.totalChildrenToolStripTextBox,
            this.educationToolStripLabel,
            this.educationToolStripTextBox,
            this.occupationToolStripLabel,
            this.occupationToolStripTextBox,
            this.demographicReportOptionsToolStripButton});
            this.demographicReportOptionsToolStrip.Location = new System.Drawing.Point(0, 0);
            this.demographicReportOptionsToolStrip.Name = "demographicReportOptionsToolStrip";
            this.demographicReportOptionsToolStrip.Size = new System.Drawing.Size(1010, 25);
            this.demographicReportOptionsToolStrip.TabIndex = 3;
            this.demographicReportOptionsToolStrip.Text = "demographicReportOptionsToolStrip";
            // 
            // maritalStatusToolStripLabel
            // 
            this.maritalStatusToolStripLabel.Name = "maritalStatusToolStripLabel";
            this.maritalStatusToolStripLabel.Size = new System.Drawing.Size(79, 22);
            this.maritalStatusToolStripLabel.Text = "MaritalStatus:";
            // 
            // maritalStatusToolStripTextBox
            // 
            this.maritalStatusToolStripTextBox.Name = "maritalStatusToolStripTextBox";
            this.maritalStatusToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // genderToolStripLabel
            // 
            this.genderToolStripLabel.Name = "genderToolStripLabel";
            this.genderToolStripLabel.Size = new System.Drawing.Size(48, 22);
            this.genderToolStripLabel.Text = "Gender:";
            // 
            // genderToolStripTextBox
            // 
            this.genderToolStripTextBox.Name = "genderToolStripTextBox";
            this.genderToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // totalChildrenToolStripLabel
            // 
            this.totalChildrenToolStripLabel.Name = "totalChildrenToolStripLabel";
            this.totalChildrenToolStripLabel.Size = new System.Drawing.Size(81, 22);
            this.totalChildrenToolStripLabel.Text = "TotalChildren:";
            // 
            // totalChildrenToolStripTextBox
            // 
            this.totalChildrenToolStripTextBox.Name = "totalChildrenToolStripTextBox";
            this.totalChildrenToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // educationToolStripLabel
            // 
            this.educationToolStripLabel.Name = "educationToolStripLabel";
            this.educationToolStripLabel.Size = new System.Drawing.Size(63, 22);
            this.educationToolStripLabel.Text = "Education:";
            // 
            // educationToolStripTextBox
            // 
            this.educationToolStripTextBox.Name = "educationToolStripTextBox";
            this.educationToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // occupationToolStripLabel
            // 
            this.occupationToolStripLabel.Name = "occupationToolStripLabel";
            this.occupationToolStripLabel.Size = new System.Drawing.Size(72, 22);
            this.occupationToolStripLabel.Text = "Occupation:";
            // 
            // occupationToolStripTextBox
            // 
            this.occupationToolStripTextBox.Name = "occupationToolStripTextBox";
            this.occupationToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // demographicReportOptionsToolStripButton
            // 
            this.demographicReportOptionsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.demographicReportOptionsToolStripButton.Name = "demographicReportOptionsToolStripButton";
            this.demographicReportOptionsToolStripButton.Size = new System.Drawing.Size(141, 19);
            this.demographicReportOptionsToolStripButton.Text = "Click Here to Run Report";
            this.demographicReportOptionsToolStripButton.Click += new System.EventHandler(this.demographicReportOptionsToolStripButton_Click);
            // 
            // vPersonDemographicsTableAdapter
            // 
            this.vPersonDemographicsTableAdapter.ClearBeforeFill = true;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 422);
            this.Controls.Add(this.demographicReportOptionsToolStrip);
            this.Controls.Add(this.labelReports);
            this.Controls.Add(this.dataGridViewReports);
            this.Controls.Add(this.buttonExitReports);
            this.Name = "FormReports";
            this.Text = "Demographic Analytical Reports";
            this.Load += new System.EventHandler(this.FormReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPersonDemographicsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2012_DataDataSet)).EndInit();
            this.demographicReportOptionsToolStrip.ResumeLayout(false);
            this.demographicReportOptionsToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExitReports;
        private System.Windows.Forms.DataGridView dataGridViewReports;
        private System.Windows.Forms.Label labelReports;
        private AdventureWorks2012_DataDataSet adventureWorks2012_DataDataSet;
        private System.Windows.Forms.BindingSource vPersonDemographicsBindingSource;
        private AdventureWorks2012_DataDataSetTableAdapters.vPersonDemographicsTableAdapter vPersonDemographicsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessEntityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPurchaseYTDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFirstPurchaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearlyIncomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalChildrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberChildrenAtHomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn homeOwnerFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberCarsOwnedDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip demographicReportOptionsToolStrip;
        private System.Windows.Forms.ToolStripLabel maritalStatusToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox maritalStatusToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel genderToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox genderToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel totalChildrenToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox totalChildrenToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel educationToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox educationToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel occupationToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox occupationToolStripTextBox;
        private System.Windows.Forms.ToolStripButton demographicReportOptionsToolStripButton;
    }
}

