namespace VehicleProject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.available = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Financial = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soldVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financialSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.makeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.makeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleTypeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 237);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // available
            // 
            this.available.Location = new System.Drawing.Point(106, 304);
            this.available.Name = "available";
            this.available.Size = new System.Drawing.Size(75, 23);
            this.available.TabIndex = 1;
            this.available.Text = "Available";
            this.available.UseVisualStyleBackColor = true;
            this.available.Click += new System.EventHandler(this.available_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sold";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Financial
            // 
            this.btn_Financial.Location = new System.Drawing.Point(294, 304);
            this.btn_Financial.Name = "btn_Financial";
            this.btn_Financial.Size = new System.Drawing.Size(119, 23);
            this.btn_Financial.TabIndex = 3;
            this.btn_Financial.Text = "Financial Report";
            this.btn_Financial.UseVisualStyleBackColor = true;
            this.btn_Financial.Click += new System.EventHandler(this.btn_Financial_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 237);
            this.panel2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(250, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(140, 25);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(250, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(140, 25);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(250, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(140, 25);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(18, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Income Gained";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(18, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Vehicles Remaining";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Vehicles Sold";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Summary";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportDataToolStripMenuItem,
            this.addDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allDataToolStripMenuItem,
            this.soldVehicleToolStripMenuItem,
            this.availableVehicleToolStripMenuItem,
            this.financialSummaryToolStripMenuItem});
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.exportDataToolStripMenuItem.Text = "Export Data";
            // 
            // allDataToolStripMenuItem
            // 
            this.allDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleToolStripMenuItem,
            this.modelToolStripMenuItem,
            this.makeToolStripMenuItem,
            this.vehicleTypeToolStripMenuItem});
            this.allDataToolStripMenuItem.Name = "allDataToolStripMenuItem";
            this.allDataToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.allDataToolStripMenuItem.Text = "All Data";
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.vehicleToolStripMenuItem.Text = "Vehicle";
            this.vehicleToolStripMenuItem.Click += new System.EventHandler(this.vehicleToolStripMenuItem_Click);
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.modelToolStripMenuItem.Text = "Model";
            this.modelToolStripMenuItem.Click += new System.EventHandler(this.modelToolStripMenuItem_Click);
            // 
            // makeToolStripMenuItem
            // 
            this.makeToolStripMenuItem.Name = "makeToolStripMenuItem";
            this.makeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.makeToolStripMenuItem.Text = "Make";
            this.makeToolStripMenuItem.Click += new System.EventHandler(this.makeToolStripMenuItem_Click);
            // 
            // vehicleTypeToolStripMenuItem
            // 
            this.vehicleTypeToolStripMenuItem.Name = "vehicleTypeToolStripMenuItem";
            this.vehicleTypeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.vehicleTypeToolStripMenuItem.Text = "Vehicle Type";
            this.vehicleTypeToolStripMenuItem.Click += new System.EventHandler(this.vehicleTypeToolStripMenuItem_Click);
            // 
            // soldVehicleToolStripMenuItem
            // 
            this.soldVehicleToolStripMenuItem.Name = "soldVehicleToolStripMenuItem";
            this.soldVehicleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.soldVehicleToolStripMenuItem.Text = "Sold vehicle";
            this.soldVehicleToolStripMenuItem.Click += new System.EventHandler(this.soldVehicleToolStripMenuItem_Click);
            // 
            // availableVehicleToolStripMenuItem
            // 
            this.availableVehicleToolStripMenuItem.Name = "availableVehicleToolStripMenuItem";
            this.availableVehicleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.availableVehicleToolStripMenuItem.Text = "Available vehicle";
            this.availableVehicleToolStripMenuItem.Click += new System.EventHandler(this.availableVehicleToolStripMenuItem_Click);
            // 
            // financialSummaryToolStripMenuItem
            // 
            this.financialSummaryToolStripMenuItem.Name = "financialSummaryToolStripMenuItem";
            this.financialSummaryToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.financialSummaryToolStripMenuItem.Text = "Financial Summary";
            this.financialSummaryToolStripMenuItem.Click += new System.EventHandler(this.financialSummaryToolStripMenuItem_Click);
            // 
            // addDataToolStripMenuItem
            // 
            this.addDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.addDataToolStripMenuItem.Name = "addDataToolStripMenuItem";
            this.addDataToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.addDataToolStripMenuItem.Text = "Add Data";
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleToolStripMenuItem1,
            this.modelToolStripMenuItem1,
            this.makeToolStripMenuItem1,
            this.vehicleTypeToolStripMenuItem1});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.formToolStripMenuItem.Text = "Form";
            // 
            // vehicleToolStripMenuItem1
            // 
            this.vehicleToolStripMenuItem1.Name = "vehicleToolStripMenuItem1";
            this.vehicleToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.vehicleToolStripMenuItem1.Text = "Vehicle";
            this.vehicleToolStripMenuItem1.Click += new System.EventHandler(this.vehicleToolStripMenuItem1_Click);
            // 
            // modelToolStripMenuItem1
            // 
            this.modelToolStripMenuItem1.Name = "modelToolStripMenuItem1";
            this.modelToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.modelToolStripMenuItem1.Text = "Model";
            this.modelToolStripMenuItem1.Click += new System.EventHandler(this.modelToolStripMenuItem1_Click);
            // 
            // makeToolStripMenuItem1
            // 
            this.makeToolStripMenuItem1.Name = "makeToolStripMenuItem1";
            this.makeToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.makeToolStripMenuItem1.Text = "Make";
            this.makeToolStripMenuItem1.Click += new System.EventHandler(this.makeToolStripMenuItem1_Click);
            // 
            // vehicleTypeToolStripMenuItem1
            // 
            this.vehicleTypeToolStripMenuItem1.Name = "vehicleTypeToolStripMenuItem1";
            this.vehicleTypeToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.vehicleTypeToolStripMenuItem1.Text = "Vehicle Type";
            this.vehicleTypeToolStripMenuItem1.Click += new System.EventHandler(this.vehicleTypeToolStripMenuItem1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleToolStripMenuItem2,
            this.modelToolStripMenuItem2,
            this.makeToolStripMenuItem2,
            this.vehicleTypeToolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // vehicleToolStripMenuItem2
            // 
            this.vehicleToolStripMenuItem2.Name = "vehicleToolStripMenuItem2";
            this.vehicleToolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.vehicleToolStripMenuItem2.Text = "Vehicle";
            this.vehicleToolStripMenuItem2.Click += new System.EventHandler(this.vehicleToolStripMenuItem2_Click);
            // 
            // modelToolStripMenuItem2
            // 
            this.modelToolStripMenuItem2.Name = "modelToolStripMenuItem2";
            this.modelToolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.modelToolStripMenuItem2.Text = "Model";
            this.modelToolStripMenuItem2.Click += new System.EventHandler(this.modelToolStripMenuItem2_Click);
            // 
            // makeToolStripMenuItem2
            // 
            this.makeToolStripMenuItem2.Name = "makeToolStripMenuItem2";
            this.makeToolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.makeToolStripMenuItem2.Text = "Make";
            this.makeToolStripMenuItem2.Click += new System.EventHandler(this.makeToolStripMenuItem2_Click);
            // 
            // vehicleTypeToolStripMenuItem2
            // 
            this.vehicleTypeToolStripMenuItem2.Name = "vehicleTypeToolStripMenuItem2";
            this.vehicleTypeToolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.vehicleTypeToolStripMenuItem2.Text = "Vehicle Type";
            this.vehicleTypeToolStripMenuItem2.Click += new System.EventHandler(this.vehicleTypeToolStripMenuItem2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "All ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 348);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Financial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.available);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button available;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Financial;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soldVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availableVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem makeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vehicleTypeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem makeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem vehicleTypeToolStripMenuItem2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem financialSummaryToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

