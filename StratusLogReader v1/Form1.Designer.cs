namespace StratusLogReader_v1
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
            this.searchButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.totalTimeAverage = new System.Windows.Forms.Label();
            this.ContainsLabel = new System.Windows.Forms.Label();
            this.containsBox = new System.Windows.Forms.TextBox();
            this.DoesNotContainLabel = new System.Windows.Forms.Label();
            this.doesNotContainBox = new System.Windows.Forms.TextBox();
            this.highlightLabel = new System.Windows.Forms.Label();
            this.highlightBox = new System.Windows.Forms.TextBox();
            this.progress = new System.Windows.Forms.Label();
            this.totalCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(29, 564);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(29, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1234, 482);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // totalTimeAverage
            // 
            this.totalTimeAverage.AutoSize = true;
            this.totalTimeAverage.Location = new System.Drawing.Point(965, 549);
            this.totalTimeAverage.Name = "totalTimeAverage";
            this.totalTimeAverage.Size = new System.Drawing.Size(28, 13);
            this.totalTimeAverage.TabIndex = 4;
            this.totalTimeAverage.Text = "0.00";
            // 
            // ContainsLabel
            // 
            this.ContainsLabel.AutoSize = true;
            this.ContainsLabel.Location = new System.Drawing.Point(29, 504);
            this.ContainsLabel.Name = "ContainsLabel";
            this.ContainsLabel.Size = new System.Drawing.Size(48, 13);
            this.ContainsLabel.TabIndex = 5;
            this.ContainsLabel.Text = "Contains";
            // 
            // containsBox
            // 
            this.containsBox.Location = new System.Drawing.Point(32, 521);
            this.containsBox.Name = "containsBox";
            this.containsBox.Size = new System.Drawing.Size(250, 20);
            this.containsBox.TabIndex = 6;
            // 
            // DoesNotContainLabel
            // 
            this.DoesNotContainLabel.AutoSize = true;
            this.DoesNotContainLabel.Location = new System.Drawing.Point(315, 503);
            this.DoesNotContainLabel.Name = "DoesNotContainLabel";
            this.DoesNotContainLabel.Size = new System.Drawing.Size(88, 13);
            this.DoesNotContainLabel.TabIndex = 7;
            this.DoesNotContainLabel.Text = "Does not contain";
            // 
            // doesNotContainBox
            // 
            this.doesNotContainBox.Location = new System.Drawing.Point(318, 521);
            this.doesNotContainBox.Name = "doesNotContainBox";
            this.doesNotContainBox.Size = new System.Drawing.Size(202, 20);
            this.doesNotContainBox.TabIndex = 8;
            // 
            // highlightLabel
            // 
            this.highlightLabel.AutoSize = true;
            this.highlightLabel.Location = new System.Drawing.Point(562, 504);
            this.highlightLabel.Name = "highlightLabel";
            this.highlightLabel.Size = new System.Drawing.Size(48, 13);
            this.highlightLabel.TabIndex = 9;
            this.highlightLabel.Text = "Highlight";
            // 
            // highlightBox
            // 
            this.highlightBox.Location = new System.Drawing.Point(565, 521);
            this.highlightBox.Name = "highlightBox";
            this.highlightBox.Size = new System.Drawing.Size(171, 20);
            this.highlightBox.TabIndex = 10;
            // 
            // progress
            // 
            this.progress.AutoSize = true;
            this.progress.Location = new System.Drawing.Point(1161, 549);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(21, 13);
            this.progress.TabIndex = 11;
            this.progress.Text = "0%";
            // 
            // totalCount
            // 
            this.totalCount.AutoSize = true;
            this.totalCount.Location = new System.Drawing.Point(795, 548);
            this.totalCount.Name = "totalCount";
            this.totalCount.Size = new System.Drawing.Size(13, 13);
            this.totalCount.TabIndex = 12;
            this.totalCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(773, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(945, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Average Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1073, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1061, 510);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(170, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 602);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalCount);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.highlightBox);
            this.Controls.Add(this.highlightLabel);
            this.Controls.Add(this.doesNotContainBox);
            this.Controls.Add(this.DoesNotContainLabel);
            this.Controls.Add(this.containsBox);
            this.Controls.Add(this.ContainsLabel);
            this.Controls.Add(this.totalTimeAverage);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.searchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label totalTimeAverage;
        private System.Windows.Forms.Label ContainsLabel;
        private System.Windows.Forms.TextBox containsBox;
        private System.Windows.Forms.Label DoesNotContainLabel;
        private System.Windows.Forms.TextBox doesNotContainBox;
        private System.Windows.Forms.Label highlightLabel;
        private System.Windows.Forms.TextBox highlightBox;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Label totalCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

