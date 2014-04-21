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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("dhfghfgh");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("fghfghfgh");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("fghfgh");
            this.questionsLV = new System.Windows.Forms.ListView();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextRTB = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.booleanAP = new System.Windows.Forms.Panel();
            this.trueRB = new System.Windows.Forms.RadioButton();
            this.falseRB = new System.Windows.Forms.RadioButton();
            this.someOfManyAP = new System.Windows.Forms.Panel();
            this.numberAP = new System.Windows.Forms.Panel();
            this.numberTB = new System.Windows.Forms.TextBox();
            this.intervalAP = new System.Windows.Forms.Panel();
            this.intervalStartTB = new System.Windows.Forms.TextBox();
            this.intervalEndTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.booleanAP.SuspendLayout();
            this.numberAP.SuspendLayout();
            this.intervalAP.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionsLV
            // 
            this.questionsLV.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.questionsLV.FullRowSelect = true;
            this.questionsLV.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            this.questionsLV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
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
            // booleanAP
            // 
            this.booleanAP.Controls.Add(this.falseRB);
            this.booleanAP.Controls.Add(this.trueRB);
            this.booleanAP.Location = new System.Drawing.Point(337, 267);
            this.booleanAP.Name = "booleanAP";
            this.booleanAP.Size = new System.Drawing.Size(159, 89);
            this.booleanAP.TabIndex = 4;
            this.booleanAP.Visible = false;
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
            // someOfManyAP
            // 
            this.someOfManyAP.Location = new System.Drawing.Point(125, 161);
            this.someOfManyAP.Name = "someOfManyAP";
            this.someOfManyAP.Size = new System.Drawing.Size(202, 121);
            this.someOfManyAP.TabIndex = 5;
            this.someOfManyAP.Visible = false;
            // 
            // numberAP
            // 
            this.numberAP.Controls.Add(this.numberTB);
            this.numberAP.Location = new System.Drawing.Point(333, 161);
            this.numberAP.Name = "numberAP";
            this.numberAP.Size = new System.Drawing.Size(111, 47);
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
            this.intervalAP.Location = new System.Drawing.Point(450, 161);
            this.intervalAP.Name = "intervalAP";
            this.intervalAP.Size = new System.Drawing.Size(200, 100);
            this.intervalAP.TabIndex = 7;
            this.intervalAP.Visible = false;
            // 
            // intervalStartTB
            // 
            this.intervalStartTB.Location = new System.Drawing.Point(3, 4);
            this.intervalStartTB.Name = "intervalStartTB";
            this.intervalStartTB.Size = new System.Drawing.Size(100, 20);
            this.intervalStartTB.TabIndex = 0;
            // 
            // intervalEndTB
            // 
            this.intervalEndTB.Location = new System.Drawing.Point(3, 31);
            this.intervalEndTB.Name = "intervalEndTB";
            this.intervalEndTB.Size = new System.Drawing.Size(100, 20);
            this.intervalEndTB.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End";
            // 
            // QuestionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 429);
            this.Controls.Add(this.intervalAP);
            this.Controls.Add(this.numberAP);
            this.Controls.Add(this.someOfManyAP);
            this.Controls.Add(this.booleanAP);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.questionTextRTB);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.questionsLV);
            this.Enabled = false;
            this.Name = "QuestionaryForm";
            this.Text = "QuestionaryForm";
            this.Load += new System.EventHandler(this.QuestionaryForm_Load);
            this.booleanAP.ResumeLayout(false);
            this.booleanAP.PerformLayout();
            this.numberAP.ResumeLayout(false);
            this.numberAP.PerformLayout();
            this.intervalAP.ResumeLayout(false);
            this.intervalAP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView questionsLV;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.RichTextBox questionTextRTB;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel booleanAP;
        private System.Windows.Forms.RadioButton falseRB;
        private System.Windows.Forms.RadioButton trueRB;
        private System.Windows.Forms.Panel someOfManyAP;
        private System.Windows.Forms.Panel numberAP;
        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.Panel intervalAP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox intervalEndTB;
        private System.Windows.Forms.TextBox intervalStartTB;
    }
}