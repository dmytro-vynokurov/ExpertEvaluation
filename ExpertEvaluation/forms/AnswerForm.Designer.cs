namespace ExpertEvaluation.forms
{
    partial class AnswerForm
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "345345345",
            "23234",
            "234234"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "545345345",
            ""}, -1);
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextRTB = new System.Windows.Forms.RichTextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.booleanAP = new System.Windows.Forms.Panel();
            this.falseRB = new System.Windows.Forms.RadioButton();
            this.trueRB = new System.Windows.Forms.RadioButton();
            this.numberAP = new System.Windows.Forms.Panel();
            this.numberTB = new System.Windows.Forms.TextBox();
            this.intervalAP = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.intervalEndTB = new System.Windows.Forms.TextBox();
            this.intervalStartTB = new System.Windows.Forms.TextBox();
            this.someOfManyAP = new System.Windows.Forms.Panel();
            this.someOfManyLB = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionWeightLabel = new System.Windows.Forms.Label();
            this.booleanAP.SuspendLayout();
            this.numberAP.SuspendLayout();
            this.intervalAP.SuspendLayout();
            this.someOfManyAP.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Location = new System.Drawing.Point(10, 10);
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
            this.questionTextRTB.Location = new System.Drawing.Point(12, 26);
            this.questionTextRTB.Name = "questionTextRTB";
            this.questionTextRTB.Size = new System.Drawing.Size(315, 76);
            this.questionTextRTB.TabIndex = 2;
            this.questionTextRTB.Text = "Question text goes here";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(92, 260);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // booleanAP
            // 
            this.booleanAP.Controls.Add(this.falseRB);
            this.booleanAP.Controls.Add(this.trueRB);
            this.booleanAP.Location = new System.Drawing.Point(13, 133);
            this.booleanAP.Name = "booleanAP";
            this.booleanAP.Size = new System.Drawing.Size(202, 121);
            this.booleanAP.TabIndex = 4;
            this.booleanAP.Visible = false;
            // 
            // falseRB
            // 
            this.falseRB.AutoSize = true;
            this.falseRB.Location = new System.Drawing.Point(14, 41);
            this.falseRB.Name = "falseRB";
            this.falseRB.Size = new System.Drawing.Size(50, 17);
            this.falseRB.TabIndex = 1;
            this.falseRB.TabStop = true;
            this.falseRB.Text = "False";
            this.falseRB.UseVisualStyleBackColor = true;
            // 
            // trueRB
            // 
            this.trueRB.AutoSize = true;
            this.trueRB.Location = new System.Drawing.Point(14, 18);
            this.trueRB.Name = "trueRB";
            this.trueRB.Size = new System.Drawing.Size(47, 17);
            this.trueRB.TabIndex = 0;
            this.trueRB.TabStop = true;
            this.trueRB.Text = "True";
            this.trueRB.UseVisualStyleBackColor = true;
            // 
            // numberAP
            // 
            this.numberAP.Controls.Add(this.numberTB);
            this.numberAP.Location = new System.Drawing.Point(13, 133);
            this.numberAP.Name = "numberAP";
            this.numberAP.Size = new System.Drawing.Size(202, 121);
            this.numberAP.TabIndex = 6;
            this.numberAP.Visible = false;
            // 
            // numberTB
            // 
            this.numberTB.Location = new System.Drawing.Point(4, 4);
            this.numberTB.Name = "numberTB";
            this.numberTB.Size = new System.Drawing.Size(100, 20);
            this.numberTB.TabIndex = 0;
            // 
            // intervalAP
            // 
            this.intervalAP.Controls.Add(this.label2);
            this.intervalAP.Controls.Add(this.label1);
            this.intervalAP.Controls.Add(this.intervalEndTB);
            this.intervalAP.Controls.Add(this.intervalStartTB);
            this.intervalAP.Location = new System.Drawing.Point(13, 133);
            this.intervalAP.Name = "intervalAP";
            this.intervalAP.Size = new System.Drawing.Size(202, 121);
            this.intervalAP.TabIndex = 7;
            this.intervalAP.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start";
            // 
            // intervalEndTB
            // 
            this.intervalEndTB.Location = new System.Drawing.Point(3, 31);
            this.intervalEndTB.Name = "intervalEndTB";
            this.intervalEndTB.Size = new System.Drawing.Size(100, 20);
            this.intervalEndTB.TabIndex = 1;
            // 
            // intervalStartTB
            // 
            this.intervalStartTB.Location = new System.Drawing.Point(3, 4);
            this.intervalStartTB.Name = "intervalStartTB";
            this.intervalStartTB.Size = new System.Drawing.Size(100, 20);
            this.intervalStartTB.TabIndex = 0;
            // 
            // someOfManyAP
            // 
            this.someOfManyAP.Controls.Add(this.someOfManyLB);
            this.someOfManyAP.Location = new System.Drawing.Point(13, 133);
            this.someOfManyAP.Name = "someOfManyAP";
            this.someOfManyAP.Size = new System.Drawing.Size(202, 121);
            this.someOfManyAP.TabIndex = 8;
            // 
            // someOfManyLB
            // 
            this.someOfManyLB.CheckBoxes = true;
            this.someOfManyLB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.someOfManyLB.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            this.someOfManyLB.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.someOfManyLB.Location = new System.Drawing.Point(4, 4);
            this.someOfManyLB.Name = "someOfManyLB";
            this.someOfManyLB.Size = new System.Drawing.Size(168, 102);
            this.someOfManyLB.TabIndex = 0;
            this.someOfManyLB.UseCompatibleStateImageBehavior = false;
            this.someOfManyLB.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 120;
            // 
            // questionWeightLabel
            // 
            this.questionWeightLabel.AutoSize = true;
            this.questionWeightLabel.Location = new System.Drawing.Point(12, 109);
            this.questionWeightLabel.Name = "questionWeightLabel";
            this.questionWeightLabel.Size = new System.Drawing.Size(47, 13);
            this.questionWeightLabel.TabIndex = 9;
            this.questionWeightLabel.Text = "Weight: ";
            // 
            // AnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 308);
            this.Controls.Add(this.questionWeightLabel);
            this.Controls.Add(this.someOfManyAP);
            this.Controls.Add(this.intervalAP);
            this.Controls.Add(this.numberAP);
            this.Controls.Add(this.booleanAP);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.questionTextRTB);
            this.Controls.Add(this.questionNumberLabel);
            this.Name = "AnswerForm";
            this.Text = "Answer Form";
            this.booleanAP.ResumeLayout(false);
            this.booleanAP.PerformLayout();
            this.numberAP.ResumeLayout(false);
            this.numberAP.PerformLayout();
            this.intervalAP.ResumeLayout(false);
            this.intervalAP.PerformLayout();
            this.someOfManyAP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.RichTextBox questionTextRTB;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Panel booleanAP;
        private System.Windows.Forms.RadioButton falseRB;
        private System.Windows.Forms.RadioButton trueRB;
        private System.Windows.Forms.Panel numberAP;
        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.Panel intervalAP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox intervalEndTB;
        private System.Windows.Forms.TextBox intervalStartTB;
        private System.Windows.Forms.Panel someOfManyAP;
        private System.Windows.Forms.ListView someOfManyLB;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label questionWeightLabel;
    }
}