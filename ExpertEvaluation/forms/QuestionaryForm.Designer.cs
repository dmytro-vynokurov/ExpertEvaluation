namespace ExpertEvaluation.forms
{
    partial class QuestionaryForm
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
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("dhfghfgh");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("fghfghfgh");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("fghfgh");
            this.questionsLV = new System.Windows.Forms.ListView();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextRTB = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionsLV
            // 
            this.questionsLV.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.questionsLV.FullRowSelect = true;
            this.questionsLV.GridLines = true;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.StateImageIndex = 0;
            this.questionsLV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.questionsLV.Location = new System.Drawing.Point(12, 12);
            this.questionsLV.MultiSelect = false;
            this.questionsLV.Name = "questionsLV";
            this.questionsLV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.questionsLV.Size = new System.Drawing.Size(95, 393);
            this.questionsLV.TabIndex = 0;
            this.questionsLV.UseCompatibleStateImageBehavior = false;
            this.questionsLV.SelectedIndexChanged += new System.EventHandler(this.questionsLV_SelectedIndexChanged);
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Location = new System.Drawing.Point(249, 13);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(59, 13);
            this.questionNumberLabel.TabIndex = 1;
            this.questionNumberLabel.Text = "Question #";
            // 
            // questionTextRTB
            // 
            this.questionTextRTB.BackColor = System.Drawing.SystemColors.Control;
            this.questionTextRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionTextRTB.Enabled = false;
            this.questionTextRTB.Location = new System.Drawing.Point(252, 40);
            this.questionTextRTB.Name = "questionTextRTB";
            this.questionTextRTB.Size = new System.Drawing.Size(378, 101);
            this.questionTextRTB.TabIndex = 2;
            this.questionTextRTB.Text = "Question text goes here";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(252, 382);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // QuestionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 429);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.questionTextRTB);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.questionsLV);
            this.Enabled = false;
            this.Name = "QuestionaryForm";
            this.Text = "QuestionaryForm";
            this.Load += new System.EventHandler(this.QuestionaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView questionsLV;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.RichTextBox questionTextRTB;
        private System.Windows.Forms.Button saveButton;
    }
}