namespace Sorting_algorithms_visualizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbArraySize = new System.Windows.Forms.TrackBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSortingMethod = new System.Windows.Forms.ToolStripDropDownButton();
            this.quicksortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bubblesortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertionSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.tbSortingSpeed = new System.Windows.Forms.TrackBar();
            this.pbArrayDisplay = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbArraySize = new System.Windows.Forms.GroupBox();
            this.gbSortingSpeed = new System.Windows.Forms.GroupBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPause = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbArraySize)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSortingSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrayDisplay)).BeginInit();
            this.gbArraySize.SuspendLayout();
            this.gbSortingSpeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbArraySize
            // 
            this.tbArraySize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbArraySize.Location = new System.Drawing.Point(6, 19);
            this.tbArraySize.Maximum = 1000;
            this.tbArraySize.Minimum = 10;
            this.tbArraySize.Name = "tbArraySize";
            this.tbArraySize.Size = new System.Drawing.Size(484, 45);
            this.tbArraySize.TabIndex = 0;
            this.tbArraySize.Value = 10;
            this.tbArraySize.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSortingMethod,
            this.toolStripSeparator1,
            this.btnSort,
            this.toolStripSeparator2,
            this.btnStop,
            this.toolStripSeparator3,
            this.btnPause});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(718, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSortingMethod
            // 
            this.btnSortingMethod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSortingMethod.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quicksortToolStripMenuItem,
            this.bubblesortToolStripMenuItem,
            this.insertionSortToolStripMenuItem,
            this.mergeSortToolStripMenuItem});
            this.btnSortingMethod.Image = ((System.Drawing.Image)(resources.GetObject("btnSortingMethod.Image")));
            this.btnSortingMethod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSortingMethod.Name = "btnSortingMethod";
            this.btnSortingMethod.Size = new System.Drawing.Size(115, 22);
            this.btnSortingMethod.Text = "Sorting Algorithm";
            this.btnSortingMethod.ToolTipText = "Sorting Algorithm";
            // 
            // quicksortToolStripMenuItem
            // 
            this.quicksortToolStripMenuItem.Name = "quicksortToolStripMenuItem";
            this.quicksortToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.quicksortToolStripMenuItem.Text = "Quicksort";
            this.quicksortToolStripMenuItem.Click += new System.EventHandler(this.quicksortToolStripMenuItem_Click);
            // 
            // bubblesortToolStripMenuItem
            // 
            this.bubblesortToolStripMenuItem.Name = "bubblesortToolStripMenuItem";
            this.bubblesortToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.bubblesortToolStripMenuItem.Text = "Bubblesort";
            this.bubblesortToolStripMenuItem.Click += new System.EventHandler(this.quicksortToolStripMenuItem_Click);
            // 
            // insertionSortToolStripMenuItem
            // 
            this.insertionSortToolStripMenuItem.Name = "insertionSortToolStripMenuItem";
            this.insertionSortToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.insertionSortToolStripMenuItem.Text = "Insertion sort";
            this.insertionSortToolStripMenuItem.Click += new System.EventHandler(this.quicksortToolStripMenuItem_Click);
            // 
            // mergeSortToolStripMenuItem
            // 
            this.mergeSortToolStripMenuItem.Name = "mergeSortToolStripMenuItem";
            this.mergeSortToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.mergeSortToolStripMenuItem.Text = "Merge sort";
            this.mergeSortToolStripMenuItem.Click += new System.EventHandler(this.quicksortToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSort
            // 
            this.btnSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSort.Image = ((System.Drawing.Image)(resources.GetObject("btnSort.Image")));
            this.btnSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(32, 22);
            this.btnSort.Text = "Sort";
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStop.Enabled = false;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(35, 22);
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbSortingSpeed
            // 
            this.tbSortingSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSortingSpeed.Location = new System.Drawing.Point(6, 19);
            this.tbSortingSpeed.Maximum = 500;
            this.tbSortingSpeed.Minimum = 1;
            this.tbSortingSpeed.Name = "tbSortingSpeed";
            this.tbSortingSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSortingSpeed.Size = new System.Drawing.Size(180, 45);
            this.tbSortingSpeed.TabIndex = 3;
            this.tbSortingSpeed.Value = 50;
            // 
            // pbArrayDisplay
            // 
            this.pbArrayDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbArrayDisplay.Location = new System.Drawing.Point(12, 106);
            this.pbArrayDisplay.Name = "pbArrayDisplay";
            this.pbArrayDisplay.Size = new System.Drawing.Size(694, 272);
            this.pbArrayDisplay.TabIndex = 0;
            this.pbArrayDisplay.TabStop = false;
            this.pbArrayDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pbArrayDisplay_Paint);
            this.pbArrayDisplay.Resize += new System.EventHandler(this.pbArrayDisplay_Resize);
            // 
            // gbArraySize
            // 
            this.gbArraySize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbArraySize.Controls.Add(this.tbArraySize);
            this.gbArraySize.Location = new System.Drawing.Point(12, 28);
            this.gbArraySize.Name = "gbArraySize";
            this.gbArraySize.Size = new System.Drawing.Size(496, 72);
            this.gbArraySize.TabIndex = 4;
            this.gbArraySize.TabStop = false;
            this.gbArraySize.Text = "Array size: 10";
            // 
            // gbSortingSpeed
            // 
            this.gbSortingSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSortingSpeed.Controls.Add(this.tbSortingSpeed);
            this.gbSortingSpeed.Location = new System.Drawing.Point(514, 28);
            this.gbSortingSpeed.Name = "gbSortingSpeed";
            this.gbSortingSpeed.Size = new System.Drawing.Size(192, 72);
            this.gbSortingSpeed.TabIndex = 5;
            this.gbSortingSpeed.TabStop = false;
            this.gbSortingSpeed.Text = "Sorting speed";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPause
            // 
            this.btnPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPause.Enabled = false;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(42, 22);
            this.btnPause.Text = "Pause";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 390);
            this.Controls.Add(this.gbSortingSpeed);
            this.Controls.Add(this.gbArraySize);
            this.Controls.Add(this.pbArrayDisplay);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.Text = "Sorting visualizer";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tbArraySize)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSortingSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrayDisplay)).EndInit();
            this.gbArraySize.ResumeLayout(false);
            this.gbArraySize.PerformLayout();
            this.gbSortingSpeed.ResumeLayout(false);
            this.gbSortingSpeed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbArraySize;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnSortingMethod;
        private System.Windows.Forms.ToolStripMenuItem quicksortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bubblesortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertionSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnSort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TrackBar tbSortingSpeed;
        private System.Windows.Forms.PictureBox pbArrayDisplay;
        private System.Windows.Forms.ToolStripMenuItem mergeSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbArraySize;
        private System.Windows.Forms.GroupBox gbSortingSpeed;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnPause;
    }
}

