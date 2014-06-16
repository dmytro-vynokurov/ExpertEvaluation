namespace ExpertEvaluation.forms
{
    partial class QuestionForm
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
            this.QuestionTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.questionTypeCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.booleanQuestionPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.falseRB = new System.Windows.Forms.RadioButton();
            this.trueRB = new System.Windows.Forms.RadioButton();
            this.oneOfManyQuestionPanel = new System.Windows.Forms.Panel();
            this.oneOfManyCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.oneOfManyRTB = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.manyOfManyQuestionPanel = new System.Windows.Forms.Panel();
            this.manyOfManyDeleteButton = new System.Windows.Forms.Button();
            this.manyofManyAddButton = new System.Windows.Forms.Button();
            this.manyOfManyTB = new System.Windows.Forms.TextBox();
            this.manyOfManyCLB = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numberQuestionPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.numberQuestionTB = new System.Windows.Forms.TextBox();
            this.intervalQuestionPanel = new System.Windows.Forms.Panel();
            this.intervalFromQuestionTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.intervalToQuestionTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.weightTB = new System.Windows.Forms.TextBox();
            this.booleanQuestionPanel.SuspendLayout();
            this.oneOfManyQuestionPanel.SuspendLayout();
            this.manyOfManyQuestionPanel.SuspendLayout();
            this.numberQuestionPanel.SuspendLayout();
            this.intervalQuestionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Location = new System.Drawing.Point(80, 12);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(268, 109);
            this.QuestionTextBox.TabIndex = 1;
            this.QuestionTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Question";
            // 
            // questionTypeCB
            // 
            this.questionTypeCB.FormattingEnabled = true;
            this.questionTypeCB.Location = new System.Drawing.Point(80, 149);
            this.questionTypeCB.Name = "questionTypeCB";
            this.questionTypeCB.Size = new System.Drawing.Size(121, 21);
            this.questionTypeCB.TabIndex = 3;
            this.questionTypeCB.SelectedIndexChanged += new System.EventHandler(this.questionTypeCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type";
            // 
            // booleanQuestionPanel
            // 
            this.booleanQuestionPanel.Controls.Add(this.label3);
            this.booleanQuestionPanel.Controls.Add(this.falseRB);
            this.booleanQuestionPanel.Controls.Add(this.trueRB);
            this.booleanQuestionPanel.Location = new System.Drawing.Point(19, 203);
            this.booleanQuestionPanel.Name = "booleanQuestionPanel";
            this.booleanQuestionPanel.Size = new System.Drawing.Size(329, 165);
            this.booleanQuestionPanel.TabIndex = 5;
            this.booleanQuestionPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Answers";
            // 
            // falseRB
            // 
            this.falseRB.AutoSize = true;
            this.falseRB.Location = new System.Drawing.Point(23, 58);
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
            this.trueRB.Location = new System.Drawing.Point(23, 35);
            this.trueRB.Name = "trueRB";
            this.trueRB.Size = new System.Drawing.Size(47, 17);
            this.trueRB.TabIndex = 0;
            this.trueRB.TabStop = true;
            this.trueRB.Text = "True";
            this.trueRB.UseVisualStyleBackColor = true;
            // 
            // oneOfManyQuestionPanel
            // 
            this.oneOfManyQuestionPanel.Controls.Add(this.oneOfManyCB);
            this.oneOfManyQuestionPanel.Controls.Add(this.label5);
            this.oneOfManyQuestionPanel.Controls.Add(this.oneOfManyRTB);
            this.oneOfManyQuestionPanel.Controls.Add(this.label4);
            this.oneOfManyQuestionPanel.Location = new System.Drawing.Point(19, 203);
            this.oneOfManyQuestionPanel.Name = "oneOfManyQuestionPanel";
            this.oneOfManyQuestionPanel.Size = new System.Drawing.Size(329, 165);
            this.oneOfManyQuestionPanel.TabIndex = 7;
            this.oneOfManyQuestionPanel.Visible = false;
            // 
            // oneOfManyCB
            // 
            this.oneOfManyCB.FormattingEnabled = true;
            this.oneOfManyCB.Location = new System.Drawing.Point(147, 21);
            this.oneOfManyCB.Name = "oneOfManyCB";
            this.oneOfManyCB.Size = new System.Drawing.Size(121, 21);
            this.oneOfManyCB.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Correct answer";
            // 
            // oneOfManyRTB
            // 
            this.oneOfManyRTB.Location = new System.Drawing.Point(7, 21);
            this.oneOfManyRTB.Name = "oneOfManyRTB";
            this.oneOfManyRTB.Size = new System.Drawing.Size(114, 134);
            this.oneOfManyRTB.TabIndex = 1;
            this.oneOfManyRTB.Text = "";
            this.oneOfManyRTB.TextChanged += new System.EventHandler(this.oneOfManyRTB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Possible answers";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(16, 374);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(97, 374);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // manyOfManyQuestionPanel
            // 
            this.manyOfManyQuestionPanel.Controls.Add(this.manyOfManyDeleteButton);
            this.manyOfManyQuestionPanel.Controls.Add(this.manyofManyAddButton);
            this.manyOfManyQuestionPanel.Controls.Add(this.manyOfManyTB);
            this.manyOfManyQuestionPanel.Controls.Add(this.manyOfManyCLB);
            this.manyOfManyQuestionPanel.Controls.Add(this.label6);
            this.manyOfManyQuestionPanel.Location = new System.Drawing.Point(19, 203);
            this.manyOfManyQuestionPanel.Name = "manyOfManyQuestionPanel";
            this.manyOfManyQuestionPanel.Size = new System.Drawing.Size(329, 165);
            this.manyOfManyQuestionPanel.TabIndex = 8;
            this.manyOfManyQuestionPanel.Visible = false;
            // 
            // manyOfManyDeleteButton
            // 
            this.manyOfManyDeleteButton.Location = new System.Drawing.Point(154, 81);
            this.manyOfManyDeleteButton.Name = "manyOfManyDeleteButton";
            this.manyOfManyDeleteButton.Size = new System.Drawing.Size(100, 23);
            this.manyOfManyDeleteButton.TabIndex = 5;
            this.manyOfManyDeleteButton.Text = "Delete checked";
            this.manyOfManyDeleteButton.UseVisualStyleBackColor = true;
            this.manyOfManyDeleteButton.Click += new System.EventHandler(this.manyOfManyDeleteButton_Click);
            // 
            // manyofManyAddButton
            // 
            this.manyofManyAddButton.Location = new System.Drawing.Point(154, 52);
            this.manyofManyAddButton.Name = "manyofManyAddButton";
            this.manyofManyAddButton.Size = new System.Drawing.Size(100, 23);
            this.manyofManyAddButton.TabIndex = 4;
            this.manyofManyAddButton.Text = "Add answer";
            this.manyofManyAddButton.UseVisualStyleBackColor = true;
            this.manyofManyAddButton.Click += new System.EventHandler(this.manyofManyAddButton_Click);
            // 
            // manyOfManyTB
            // 
            this.manyOfManyTB.Location = new System.Drawing.Point(154, 26);
            this.manyOfManyTB.Name = "manyOfManyTB";
            this.manyOfManyTB.Size = new System.Drawing.Size(148, 20);
            this.manyOfManyTB.TabIndex = 3;
            // 
            // manyOfManyCLB
            // 
            this.manyOfManyCLB.FormattingEnabled = true;
            this.manyOfManyCLB.Items.AddRange(new object[] {
            "A",
            "B",
            "b",
            "c",
            "C"});
            this.manyOfManyCLB.Location = new System.Drawing.Point(3, 26);
            this.manyOfManyCLB.MultiColumn = true;
            this.manyOfManyCLB.Name = "manyOfManyCLB";
            this.manyOfManyCLB.Size = new System.Drawing.Size(119, 124);
            this.manyOfManyCLB.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Possible Answers";
            // 
            // numberQuestionPanel
            // 
            this.numberQuestionPanel.Controls.Add(this.label7);
            this.numberQuestionPanel.Controls.Add(this.numberQuestionTB);
            this.numberQuestionPanel.Location = new System.Drawing.Point(19, 203);
            this.numberQuestionPanel.Name = "numberQuestionPanel";
            this.numberQuestionPanel.Size = new System.Drawing.Size(329, 165);
            this.numberQuestionPanel.TabIndex = 9;
            this.numberQuestionPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Correct answer";
            // 
            // numberQuestionTB
            // 
            this.numberQuestionTB.Location = new System.Drawing.Point(16, 37);
            this.numberQuestionTB.Name = "numberQuestionTB";
            this.numberQuestionTB.Size = new System.Drawing.Size(100, 20);
            this.numberQuestionTB.TabIndex = 0;
            // 
            // intervalQuestionPanel
            // 
            this.intervalQuestionPanel.Controls.Add(this.intervalToQuestionTB);
            this.intervalQuestionPanel.Controls.Add(this.label10);
            this.intervalQuestionPanel.Controls.Add(this.label9);
            this.intervalQuestionPanel.Controls.Add(this.label8);
            this.intervalQuestionPanel.Controls.Add(this.intervalFromQuestionTB);
            this.intervalQuestionPanel.Location = new System.Drawing.Point(19, 203);
            this.intervalQuestionPanel.Name = "intervalQuestionPanel";
            this.intervalQuestionPanel.Size = new System.Drawing.Size(329, 165);
            this.intervalQuestionPanel.TabIndex = 10;
            // 
            // intervalFromQuestionTB
            // 
            this.intervalFromQuestionTB.Location = new System.Drawing.Point(50, 31);
            this.intervalFromQuestionTB.Name = "intervalFromQuestionTB";
            this.intervalFromQuestionTB.Size = new System.Drawing.Size(100, 20);
            this.intervalFromQuestionTB.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Correct answer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "From";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "To";
            // 
            // intervalToQuestionTB
            // 
            this.intervalToQuestionTB.Location = new System.Drawing.Point(50, 57);
            this.intervalToQuestionTB.Name = "intervalToQuestionTB";
            this.intervalToQuestionTB.Size = new System.Drawing.Size(100, 20);
            this.intervalToQuestionTB.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Weight";
            // 
            // weightTB
            // 
            this.weightTB.Location = new System.Drawing.Point(80, 177);
            this.weightTB.Name = "weightTB";
            this.weightTB.Size = new System.Drawing.Size(121, 20);
            this.weightTB.TabIndex = 12;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 457);
            this.Controls.Add(this.weightTB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.intervalQuestionPanel);
            this.Controls.Add(this.numberQuestionPanel);
            this.Controls.Add(this.manyOfManyQuestionPanel);
            this.Controls.Add(this.oneOfManyQuestionPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.booleanQuestionPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.questionTypeCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuestionTextBox);
            this.Name = "QuestionForm";
            this.Text = "Question";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            this.booleanQuestionPanel.ResumeLayout(false);
            this.booleanQuestionPanel.PerformLayout();
            this.oneOfManyQuestionPanel.ResumeLayout(false);
            this.oneOfManyQuestionPanel.PerformLayout();
            this.manyOfManyQuestionPanel.ResumeLayout(false);
            this.manyOfManyQuestionPanel.PerformLayout();
            this.numberQuestionPanel.ResumeLayout(false);
            this.numberQuestionPanel.PerformLayout();
            this.intervalQuestionPanel.ResumeLayout(false);
            this.intervalQuestionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox QuestionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox questionTypeCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel booleanQuestionPanel;
        private System.Windows.Forms.Panel oneOfManyQuestionPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton falseRB;
        private System.Windows.Forms.RadioButton trueRB;
        private System.Windows.Forms.ComboBox oneOfManyCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox oneOfManyRTB;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel manyOfManyQuestionPanel;
        private System.Windows.Forms.CheckedListBox manyOfManyCLB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button manyOfManyDeleteButton;
        private System.Windows.Forms.Button manyofManyAddButton;
        private System.Windows.Forms.TextBox manyOfManyTB;
        private System.Windows.Forms.Panel numberQuestionPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numberQuestionTB;
        private System.Windows.Forms.Panel intervalQuestionPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox intervalFromQuestionTB;
        private System.Windows.Forms.TextBox intervalToQuestionTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox weightTB;
    }
}