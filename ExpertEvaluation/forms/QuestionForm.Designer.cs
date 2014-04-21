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
            this.numberQuestionTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.booleanQuestionPanel.SuspendLayout();
            this.oneOfManyQuestionPanel.SuspendLayout();
            this.manyOfManyQuestionPanel.SuspendLayout();
            this.numberQuestionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Location = new System.Drawing.Point(80, 12);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(315, 106);
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
            this.booleanQuestionPanel.Location = new System.Drawing.Point(401, 13);
            this.booleanQuestionPanel.Name = "booleanQuestionPanel";
            this.booleanQuestionPanel.Size = new System.Drawing.Size(221, 122);
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
            this.oneOfManyQuestionPanel.Location = new System.Drawing.Point(354, 185);
            this.oneOfManyQuestionPanel.Name = "oneOfManyQuestionPanel";
            this.oneOfManyQuestionPanel.Size = new System.Drawing.Size(315, 158);
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
            this.okButton.Location = new System.Drawing.Point(80, 394);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(173, 394);
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
            this.manyOfManyQuestionPanel.Location = new System.Drawing.Point(19, 175);
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
            this.numberQuestionPanel.Location = new System.Drawing.Point(236, 141);
            this.numberQuestionPanel.Name = "numberQuestionPanel";
            this.numberQuestionPanel.Size = new System.Drawing.Size(200, 100);
            this.numberQuestionPanel.TabIndex = 9;
            this.numberQuestionPanel.Visible = false;
            // 
            // numberQuestionTB
            // 
            this.numberQuestionTB.Location = new System.Drawing.Point(16, 37);
            this.numberQuestionTB.Name = "numberQuestionTB";
            this.numberQuestionTB.Size = new System.Drawing.Size(100, 20);
            this.numberQuestionTB.TabIndex = 0;
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
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 486);
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
            this.Text = "Questions";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            this.booleanQuestionPanel.ResumeLayout(false);
            this.booleanQuestionPanel.PerformLayout();
            this.oneOfManyQuestionPanel.ResumeLayout(false);
            this.oneOfManyQuestionPanel.PerformLayout();
            this.manyOfManyQuestionPanel.ResumeLayout(false);
            this.manyOfManyQuestionPanel.PerformLayout();
            this.numberQuestionPanel.ResumeLayout(false);
            this.numberQuestionPanel.PerformLayout();
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
    }
}