namespace ExpertEvaluation
{
    partial class AdminForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.QuestionIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VariantsAnswerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightAnswerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddQuestionButton = new System.Windows.Forms.Button();
            this.DeleteQuestionButton = new System.Windows.Forms.Button();
            this.EditQuestionButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 246);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EditQuestionButton);
            this.tabPage1.Controls.Add(this.DeleteQuestionButton);
            this.tabPage1.Controls.Add(this.AddQuestionButton);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(591, 220);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Questions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(397, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Experts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionIdColumn,
            this.QuestionText,
            this.QuestionTypeColumn,
            this.VariantsAnswerColumn,
            this.RightAnswerColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 169);
            this.dataGridView1.TabIndex = 0;
            // 
            // QuestionIdColumn
            // 
            this.QuestionIdColumn.Frozen = true;
            this.QuestionIdColumn.HeaderText = "ID";
            this.QuestionIdColumn.Name = "QuestionIdColumn";
            // 
            // QuestionText
            // 
            this.QuestionText.Frozen = true;
            this.QuestionText.HeaderText = "Text";
            this.QuestionText.Name = "QuestionText";
            // 
            // QuestionTypeColumn
            // 
            this.QuestionTypeColumn.Frozen = true;
            this.QuestionTypeColumn.HeaderText = "Type";
            this.QuestionTypeColumn.Name = "QuestionTypeColumn";
            // 
            // VariantsAnswerColumn
            // 
            this.VariantsAnswerColumn.Frozen = true;
            this.VariantsAnswerColumn.HeaderText = "PossibleAnswers";
            this.VariantsAnswerColumn.Name = "VariantsAnswerColumn";
            // 
            // RightAnswerColumn
            // 
            this.RightAnswerColumn.Frozen = true;
            this.RightAnswerColumn.HeaderText = "RightAnswer";
            this.RightAnswerColumn.Name = "RightAnswerColumn";
            // 
            // AddQuestionButton
            // 
            this.AddQuestionButton.Location = new System.Drawing.Point(77, 191);
            this.AddQuestionButton.Name = "AddQuestionButton";
            this.AddQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.AddQuestionButton.TabIndex = 1;
            this.AddQuestionButton.Text = "Add";
            this.AddQuestionButton.UseVisualStyleBackColor = true;
            // 
            // DeleteQuestionButton
            // 
            this.DeleteQuestionButton.Location = new System.Drawing.Point(158, 191);
            this.DeleteQuestionButton.Name = "DeleteQuestionButton";
            this.DeleteQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteQuestionButton.TabIndex = 2;
            this.DeleteQuestionButton.Text = "Delete";
            this.DeleteQuestionButton.UseVisualStyleBackColor = true;
            // 
            // EditQuestionButton
            // 
            this.EditQuestionButton.Location = new System.Drawing.Point(239, 191);
            this.EditQuestionButton.Name = "EditQuestionButton";
            this.EditQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.EditQuestionButton.TabIndex = 3;
            this.EditQuestionButton.Text = "Edit";
            this.EditQuestionButton.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 246);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionText;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VariantsAnswerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightAnswerColumn;
        private System.Windows.Forms.Button EditQuestionButton;
        private System.Windows.Forms.Button DeleteQuestionButton;
        private System.Windows.Forms.Button AddQuestionButton;

    }
}