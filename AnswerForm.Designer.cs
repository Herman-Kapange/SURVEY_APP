
namespace SurveyApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstVwQuestions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblQuestion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNo = new System.Windows.Forms.RadioButton();
            this.rdYes = new System.Windows.Forms.RadioButton();
            this.rdStronglyAgree = new System.Windows.Forms.RadioButton();
            this.rdAgree = new System.Windows.Forms.RadioButton();
            this.rdNeutral = new System.Windows.Forms.RadioButton();
            this.rdDisagree = new System.Windows.Forms.RadioButton();
            this.rdStronglyDisagree = new System.Windows.Forms.RadioButton();
            this.cmBxAnswer = new System.Windows.Forms.ComboBox();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.txBxSurveyId = new System.Windows.Forms.TextBox();
            this.txBxSurveyTitle = new System.Windows.Forms.TextBox();
            this.txBxSurveyDescription = new System.Windows.Forms.TextBox();
            this.txBxSurveyAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SurveyId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Survey Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Survey Author";
            // 
            // lstVwQuestions
            // 
            this.lstVwQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.ColumnHeader4,
            this.columnHeader5});
            this.lstVwQuestions.FullRowSelect = true;
            this.lstVwQuestions.GridLines = true;
            this.lstVwQuestions.HideSelection = false;
            this.lstVwQuestions.Location = new System.Drawing.Point(6, 329);
            this.lstVwQuestions.Name = "lstVwQuestions";
            this.lstVwQuestions.Size = new System.Drawing.Size(900, 200);
            this.lstVwQuestions.TabIndex = 4;
            this.lstVwQuestions.UseCompatibleStateImageBehavior = false;
            this.lstVwQuestions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "QuestionId";
            this.columnHeader1.Width = 63;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Question Text";
            this.columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Answer Type";
            this.columnHeader3.Width = 120;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Answer ";
            this.ColumnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Respondent";
            this.columnHeader5.Width = 110;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(20, 16);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(152, 13);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Question will be displayed here";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNo);
            this.groupBox1.Controls.Add(this.rdYes);
            this.groupBox1.Controls.Add(this.rdStronglyAgree);
            this.groupBox1.Controls.Add(this.rdAgree);
            this.groupBox1.Controls.Add(this.rdNeutral);
            this.groupBox1.Controls.Add(this.rdDisagree);
            this.groupBox1.Controls.Add(this.rdStronglyDisagree);
            this.groupBox1.Controls.Add(this.cmBxAnswer);
            this.groupBox1.Controls.Add(this.btnSubmitAnswer);
            this.groupBox1.Controls.Add(this.lblQuestion);
            this.groupBox1.Location = new System.Drawing.Point(106, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 135);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rdNo
            // 
            this.rdNo.AutoSize = true;
            this.rdNo.Location = new System.Drawing.Point(311, 57);
            this.rdNo.Name = "rdNo";
            this.rdNo.Size = new System.Drawing.Size(39, 17);
            this.rdNo.TabIndex = 16;
            this.rdNo.TabStop = true;
            this.rdNo.Text = "No";
            this.rdNo.UseVisualStyleBackColor = true;
            // 
            // rdYes
            // 
            this.rdYes.AutoSize = true;
            this.rdYes.Location = new System.Drawing.Point(253, 57);
            this.rdYes.Name = "rdYes";
            this.rdYes.Size = new System.Drawing.Size(43, 17);
            this.rdYes.TabIndex = 15;
            this.rdYes.TabStop = true;
            this.rdYes.Text = "Yes";
            this.rdYes.UseVisualStyleBackColor = true;
            // 
            // rdStronglyAgree
            // 
            this.rdStronglyAgree.AutoSize = true;
            this.rdStronglyAgree.Location = new System.Drawing.Point(503, 61);
            this.rdStronglyAgree.Name = "rdStronglyAgree";
            this.rdStronglyAgree.Size = new System.Drawing.Size(94, 17);
            this.rdStronglyAgree.TabIndex = 12;
            this.rdStronglyAgree.TabStop = true;
            this.rdStronglyAgree.Text = "Strongly Agree";
            this.rdStronglyAgree.UseVisualStyleBackColor = true;
            // 
            // rdAgree
            // 
            this.rdAgree.AutoSize = true;
            this.rdAgree.Location = new System.Drawing.Point(390, 61);
            this.rdAgree.Name = "rdAgree";
            this.rdAgree.Size = new System.Drawing.Size(53, 17);
            this.rdAgree.TabIndex = 11;
            this.rdAgree.TabStop = true;
            this.rdAgree.Text = "Agree";
            this.rdAgree.UseVisualStyleBackColor = true;
            // 
            // rdNeutral
            // 
            this.rdNeutral.AutoSize = true;
            this.rdNeutral.Location = new System.Drawing.Point(291, 61);
            this.rdNeutral.Name = "rdNeutral";
            this.rdNeutral.Size = new System.Drawing.Size(59, 17);
            this.rdNeutral.TabIndex = 10;
            this.rdNeutral.TabStop = true;
            this.rdNeutral.Text = "Neutral";
            this.rdNeutral.UseVisualStyleBackColor = true;
            // 
            // rdDisagree
            // 
            this.rdDisagree.AutoSize = true;
            this.rdDisagree.Location = new System.Drawing.Point(193, 61);
            this.rdDisagree.Name = "rdDisagree";
            this.rdDisagree.Size = new System.Drawing.Size(67, 17);
            this.rdDisagree.TabIndex = 9;
            this.rdDisagree.TabStop = true;
            this.rdDisagree.Text = "Disagree";
            this.rdDisagree.UseVisualStyleBackColor = true;
            // 
            // rdStronglyDisagree
            // 
            this.rdStronglyDisagree.AutoSize = true;
            this.rdStronglyDisagree.Location = new System.Drawing.Point(64, 61);
            this.rdStronglyDisagree.Name = "rdStronglyDisagree";
            this.rdStronglyDisagree.Size = new System.Drawing.Size(108, 17);
            this.rdStronglyDisagree.TabIndex = 8;
            this.rdStronglyDisagree.TabStop = true;
            this.rdStronglyDisagree.Text = "Strongly Disagree";
            this.rdStronglyDisagree.UseVisualStyleBackColor = true;
            // 
            // cmBxAnswer
            // 
            this.cmBxAnswer.FormattingEnabled = true;
            this.cmBxAnswer.Location = new System.Drawing.Point(164, 57);
            this.cmBxAnswer.Name = "cmBxAnswer";
            this.cmBxAnswer.Size = new System.Drawing.Size(279, 21);
            this.cmBxAnswer.TabIndex = 7;
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Location = new System.Drawing.Point(253, 102);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(97, 23);
            this.btnSubmitAnswer.TabIndex = 6;
            this.btnSubmitAnswer.Text = "Save Answer";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // txBxSurveyId
            // 
            this.txBxSurveyId.Location = new System.Drawing.Point(106, 10);
            this.txBxSurveyId.Name = "txBxSurveyId";
            this.txBxSurveyId.ReadOnly = true;
            this.txBxSurveyId.Size = new System.Drawing.Size(410, 20);
            this.txBxSurveyId.TabIndex = 7;
            // 
            // txBxSurveyTitle
            // 
            this.txBxSurveyTitle.Location = new System.Drawing.Point(106, 40);
            this.txBxSurveyTitle.Name = "txBxSurveyTitle";
            this.txBxSurveyTitle.ReadOnly = true;
            this.txBxSurveyTitle.Size = new System.Drawing.Size(410, 20);
            this.txBxSurveyTitle.TabIndex = 8;
            // 
            // txBxSurveyDescription
            // 
            this.txBxSurveyDescription.Location = new System.Drawing.Point(106, 72);
            this.txBxSurveyDescription.Name = "txBxSurveyDescription";
            this.txBxSurveyDescription.ReadOnly = true;
            this.txBxSurveyDescription.Size = new System.Drawing.Size(410, 20);
            this.txBxSurveyDescription.TabIndex = 9;
            // 
            // txBxSurveyAuthor
            // 
            this.txBxSurveyAuthor.Location = new System.Drawing.Point(106, 104);
            this.txBxSurveyAuthor.Name = "txBxSurveyAuthor";
            this.txBxSurveyAuthor.ReadOnly = true;
            this.txBxSurveyAuthor.Size = new System.Drawing.Size(410, 20);
            this.txBxSurveyAuthor.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Survey Description";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 300);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(106, 23);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Load Question";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(146, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 541);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txBxSurveyAuthor);
            this.Controls.Add(this.txBxSurveyDescription);
            this.Controls.Add(this.txBxSurveyTitle);
            this.Controls.Add(this.txBxSurveyId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstVwQuestions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AnswerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnswerForm";
            this.Load += new System.EventHandler(this.AnswerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstVwQuestions;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdStronglyAgree;
        private System.Windows.Forms.RadioButton rdAgree;
        private System.Windows.Forms.RadioButton rdNeutral;
        private System.Windows.Forms.RadioButton rdDisagree;
        private System.Windows.Forms.RadioButton rdStronglyDisagree;
        private System.Windows.Forms.ComboBox cmBxAnswer;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.TextBox txBxSurveyId;
        private System.Windows.Forms.TextBox txBxSurveyTitle;
        private System.Windows.Forms.TextBox txBxSurveyDescription;
        private System.Windows.Forms.TextBox txBxSurveyAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader ColumnHeader4;
        private System.Windows.Forms.RadioButton rdNo;
        private System.Windows.Forms.RadioButton rdYes;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
    }
}