namespace ExpertEvaluation
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
            this.booleanQuestionPanel.SuspendLayout();
            this.oneOfManyQuestionPanel.SuspendLayout();
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
            this.questionTypeCB.Location = new System.Drawing.Point(80, 148);
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
            this.booleanQuestionPanel.Location = new System.Drawing.Point(80, 213);
            this.booleanQuestionPanel.Name = "booleanQuestionPanel";
            this.booleanQuestionPanel.Size = new System.Drawing.Size(315, 158);
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
            this.oneOfManyQuestionPanel.Location = new System.Drawing.Point(210, 175);
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
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 429);
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
    }
}