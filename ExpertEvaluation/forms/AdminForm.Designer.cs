namespace ExpertEvaluation.forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EditQuestionButton = new System.Windows.Forms.Button();
            this.DeleteQuestionButton = new System.Windows.Forms.Button();
            this.AddQuestionButton = new System.Windows.Forms.Button();
            this.questionsDGV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deleteExpertButton = new System.Windows.Forms.Button();
            this.editExpertButton = new System.Windows.Forms.Button();
            this.addExpertButton = new System.Windows.Forms.Button();
            this.usersDGV = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VariantsAnswerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightAnswerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(683, 479);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EditQuestionButton);
            this.tabPage1.Controls.Add(this.DeleteQuestionButton);
            this.tabPage1.Controls.Add(this.AddQuestionButton);
            this.tabPage1.Controls.Add(this.questionsDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(675, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Questions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // EditQuestionButton
            // 
            this.EditQuestionButton.Location = new System.Drawing.Point(89, 422);
            this.EditQuestionButton.Name = "EditQuestionButton";
            this.EditQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.EditQuestionButton.TabIndex = 3;
            this.EditQuestionButton.Text = "Edit";
            this.EditQuestionButton.UseVisualStyleBackColor = true;
            this.EditQuestionButton.Click += new System.EventHandler(this.EditQuestionButton_Click);
            // 
            // DeleteQuestionButton
            // 
            this.DeleteQuestionButton.Location = new System.Drawing.Point(170, 422);
            this.DeleteQuestionButton.Name = "DeleteQuestionButton";
            this.DeleteQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteQuestionButton.TabIndex = 2;
            this.DeleteQuestionButton.Text = "Delete";
            this.DeleteQuestionButton.UseVisualStyleBackColor = true;
            this.DeleteQuestionButton.Click += new System.EventHandler(this.DeleteQuestionButton_Click);
            // 
            // AddQuestionButton
            // 
            this.AddQuestionButton.Location = new System.Drawing.Point(8, 422);
            this.AddQuestionButton.Name = "AddQuestionButton";
            this.AddQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.AddQuestionButton.TabIndex = 1;
            this.AddQuestionButton.Text = "Add";
            this.AddQuestionButton.UseVisualStyleBackColor = true;
            this.AddQuestionButton.Click += new System.EventHandler(this.AddQuestionButton_Click);
            // 
            // questionsDGV
            // 
            this.questionsDGV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.questionsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.questionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionIdColumn,
            this.QuestionText,
            this.QuestionTypeColumn,
            this.VariantsAnswerColumn,
            this.RightAnswerColumn,
            this.Weight});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.questionsDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.questionsDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.questionsDGV.Location = new System.Drawing.Point(3, 3);
            this.questionsDGV.Name = "questionsDGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.questionsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.questionsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.questionsDGV.Size = new System.Drawing.Size(669, 406);
            this.questionsDGV.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deleteExpertButton);
            this.tabPage2.Controls.Add(this.editExpertButton);
            this.tabPage2.Controls.Add(this.addExpertButton);
            this.tabPage2.Controls.Add(this.usersDGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(555, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Experts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deleteExpertButton
            // 
            this.deleteExpertButton.Location = new System.Drawing.Point(168, 424);
            this.deleteExpertButton.Name = "deleteExpertButton";
            this.deleteExpertButton.Size = new System.Drawing.Size(75, 23);
            this.deleteExpertButton.TabIndex = 3;
            this.deleteExpertButton.Text = "Delete";
            this.deleteExpertButton.UseVisualStyleBackColor = true;
            this.deleteExpertButton.Click += new System.EventHandler(this.deleteExpertButton_Click);
            // 
            // editExpertButton
            // 
            this.editExpertButton.Location = new System.Drawing.Point(86, 424);
            this.editExpertButton.Name = "editExpertButton";
            this.editExpertButton.Size = new System.Drawing.Size(75, 23);
            this.editExpertButton.TabIndex = 2;
            this.editExpertButton.Text = "Edit";
            this.editExpertButton.UseVisualStyleBackColor = true;
            this.editExpertButton.Click += new System.EventHandler(this.editExpertButton_Click);
            // 
            // addExpertButton
            // 
            this.addExpertButton.Location = new System.Drawing.Point(4, 424);
            this.addExpertButton.Name = "addExpertButton";
            this.addExpertButton.Size = new System.Drawing.Size(75, 23);
            this.addExpertButton.TabIndex = 1;
            this.addExpertButton.Text = "Add";
            this.addExpertButton.UseVisualStyleBackColor = true;
            this.addExpertButton.Click += new System.EventHandler(this.addExpertButton_Click);
            // 
            // usersDGV
            // 
            this.usersDGV.AllowUserToAddRows = false;
            this.usersDGV.AllowUserToDeleteRows = false;
            this.usersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.LoginColumn,
            this.UserTypeColumn});
            this.usersDGV.Cursor = System.Windows.Forms.Cursors.Default;
            this.usersDGV.Location = new System.Drawing.Point(3, 3);
            this.usersDGV.Name = "usersDGV";
            this.usersDGV.Size = new System.Drawing.Size(552, 414);
            this.usersDGV.TabIndex = 0;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // LoginColumn
            // 
            this.LoginColumn.HeaderText = "Login";
            this.LoginColumn.Name = "LoginColumn";
            this.LoginColumn.ReadOnly = true;
            // 
            // UserTypeColumn
            // 
            this.UserTypeColumn.HeaderText = "User type";
            this.UserTypeColumn.Name = "UserTypeColumn";
            this.UserTypeColumn.ReadOnly = true;
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
            this.VariantsAnswerColumn.HeaderText = "Possible Answers";
            this.VariantsAnswerColumn.Name = "VariantsAnswerColumn";
            this.VariantsAnswerColumn.Width = 120;
            // 
            // RightAnswerColumn
            // 
            this.RightAnswerColumn.Frozen = true;
            this.RightAnswerColumn.HeaderText = "Right Answer";
            this.RightAnswerColumn.Name = "RightAnswerColumn";
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 479);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.questionsDGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView questionsDGV;
        private System.Windows.Forms.Button EditQuestionButton;
        private System.Windows.Forms.Button DeleteQuestionButton;
        private System.Windows.Forms.Button AddQuestionButton;
        private System.Windows.Forms.Button deleteExpertButton;
        private System.Windows.Forms.Button editExpertButton;
        private System.Windows.Forms.Button addExpertButton;
        private System.Windows.Forms.DataGridView usersDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionText;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VariantsAnswerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightAnswerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;

    }
}