namespace eClerx.Question2.Kishore
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
            this.LabCustomerCity = new System.Windows.Forms.Label();
            this.LabSortBy = new System.Windows.Forms.Label();
            this.TxtCustomerCity = new System.Windows.Forms.TextBox();
            this.ComboSortBy = new System.Windows.Forms.ComboBox();
            this.BtnGetData = new System.Windows.Forms.Button();
            this.GridCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // LabCustomerCity
            // 
            this.LabCustomerCity.AutoSize = true;
            this.LabCustomerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCustomerCity.Location = new System.Drawing.Point(115, 52);
            this.LabCustomerCity.Name = "LabCustomerCity";
            this.LabCustomerCity.Size = new System.Drawing.Size(151, 26);
            this.LabCustomerCity.TabIndex = 0;
            this.LabCustomerCity.Text = "Customer City";
            // 
            // LabSortBy
            // 
            this.LabSortBy.AutoSize = true;
            this.LabSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSortBy.Location = new System.Drawing.Point(115, 123);
            this.LabSortBy.Name = "LabSortBy";
            this.LabSortBy.Size = new System.Drawing.Size(84, 26);
            this.LabSortBy.TabIndex = 1;
            this.LabSortBy.Text = "Sort By";
            // 
            // TxtCustomerCity
            // 
            this.TxtCustomerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerCity.Location = new System.Drawing.Point(282, 54);
            this.TxtCustomerCity.Name = "TxtCustomerCity";
            this.TxtCustomerCity.Size = new System.Drawing.Size(229, 32);
            this.TxtCustomerCity.TabIndex = 2;
            // 
            // ComboSortBy
            // 
            this.ComboSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboSortBy.FormattingEnabled = true;
            this.ComboSortBy.Location = new System.Drawing.Point(282, 121);
            this.ComboSortBy.Name = "ComboSortBy";
            this.ComboSortBy.Size = new System.Drawing.Size(229, 34);
            this.ComboSortBy.TabIndex = 3;
            // 
            // BtnGetData
            // 
            this.BtnGetData.AutoSize = true;
            this.BtnGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetData.Location = new System.Drawing.Point(658, 32);
            this.BtnGetData.Name = "BtnGetData";
            this.BtnGetData.Size = new System.Drawing.Size(109, 36);
            this.BtnGetData.TabIndex = 4;
            this.BtnGetData.Text = "Get Data";
            this.BtnGetData.UseVisualStyleBackColor = true;
            this.BtnGetData.Click += new System.EventHandler(this.BtnGetData_Click);
            // 
            // GridCustomer
            // 
            this.GridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCustomer.Location = new System.Drawing.Point(47, 192);
            this.GridCustomer.Name = "GridCustomer";
            this.GridCustomer.RowHeadersWidth = 62;
            this.GridCustomer.RowTemplate.Height = 28;
            this.GridCustomer.Size = new System.Drawing.Size(618, 246);
            this.GridCustomer.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridCustomer);
            this.Controls.Add(this.BtnGetData);
            this.Controls.Add(this.ComboSortBy);
            this.Controls.Add(this.TxtCustomerCity);
            this.Controls.Add(this.LabSortBy);
            this.Controls.Add(this.LabCustomerCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabCustomerCity;
        private System.Windows.Forms.Label LabSortBy;
        private System.Windows.Forms.TextBox TxtCustomerCity;
        private System.Windows.Forms.ComboBox ComboSortBy;
        private System.Windows.Forms.Button BtnGetData;
        private System.Windows.Forms.DataGridView GridCustomer;
    }
}

