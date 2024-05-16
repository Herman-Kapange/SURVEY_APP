
namespace SurveyApp
{
    partial class SurveyForm
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
            this.txBxSrTitle = new System.Windows.Forms.TextBox();
            this.lblSurveyTitle = new System.Windows.Forms.Label();
            this.txBxSrDescription = new System.Windows.Forms.TextBox();
            this.lblSrDescription = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSurveySave = new System.Windows.Forms.Button();
            this.txBxQuestion = new System.Windows.Forms.TextBox();
            this.cmBxQuestionType = new System.Windows.Forms.ComboBox();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstVwQuestions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txBxSrTitle
            // 
            this.txBxSrTitle.Location = new System.Drawing.Point(126, 12);
            this.txBxSrTitle.Name = "txBxSrTitle";
            this.txBxSrTitle.Size = new System.Drawing.Size(341, 20);
            this.txBxSrTitle.TabIndex = 0;
            // 
            // lblSurveyTitle
            // 
            this.lblSurveyTitle.AutoSize = true;
            this.lblSurveyTitle.Location = new System.Drawing.Point(36, 15);
            this.lblSurveyTitle.Name = "lblSurveyTitle";
            this.lblSurveyTitle.Size = new System.Drawing.Size(63, 13);
            this.lblSurveyTitle.TabIndex = 1;
            this.lblSurveyTitle.Text = "Survey Title";
            // 
            // txBxSrDescription
            // 
            this.txBxSrDescription.Location = new System.Drawing.Point(126, 41);
            this.txBxSrDescription.Multiline = true;
            this.txBxSrDescription.Name = "txBxSrDescription";
            this.txBxSrDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txBxSrDescription.Size = new System.Drawing.Size(341, 67);
            this.txBxSrDescription.TabIndex = 2;
            // 
            // lblSrDescription
            // 
            this.lblSrDescription.AutoSize = true;
            this.lblSrDescription.Location = new System.Drawing.Point(39, 41);
            this.lblSrDescription.Name = "lblSrDescription";
            this.lblSrDescription.Size = new System.Drawing.Size(60, 13);
            this.lblSrDescription.TabIndex = 3;
            this.lblSrDescription.Text = "Description";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(126, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 37);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSurveySave
            // 
            this.btnSurveySave.Location = new System.Drawing.Point(239, 415);
            this.btnSurveySave.Name = "btnSurveySave";
            this.btnSurveySave.Size = new System.Drawing.Size(180, 37);
            this.btnSurveySave.TabIndex = 5;
            this.btnSurveySave.Text = "Save Survey";
            this.btnSurveySave.UseVisualStyleBackColor = true;
            this.btnSurveySave.Click += new System.EventHandler(this.btnSurveySave_Click);
            // 
            // txBxQuestion
            // 
            this.txBxQuestion.Location = new System.Drawing.Point(126, 359);
            this.txBxQuestion.Multiline = true;
            this.txBxQuestion.Name = "txBxQuestion";
            this.txBxQuestion.Size = new System.Drawing.Size(341, 20);
            this.txBxQuestion.TabIndex = 7;
            this.txBxQuestion.Tag = "";
            // 
            // cmBxQuestionType
            // 
            this.cmBxQuestionType.FormattingEnabled = true;
            this.cmBxQuestionType.Location = new System.Drawing.Point(502, 359);
            this.cmBxQuestionType.Name = "cmBxQuestionType";
            this.cmBxQuestionType.Size = new System.Drawing.Size(119, 21);
            this.cmBxQuestionType.TabIndex = 8;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(655, 359);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(98, 23);
            this.btnAddQuestion.TabIndex = 9;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(655, 429);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstVwQuestions
            // 
            this.lstVwQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstVwQuestions.FullRowSelect = true;
            this.lstVwQuestions.GridLines = true;
            this.lstVwQuestions.HideSelection = false;
            this.lstVwQuestions.Location = new System.Drawing.Point(126, 128);
            this.lstVwQuestions.Name = "lstVwQuestions";
            this.lstVwQuestions.Size = new System.Drawing.Size(604, 212);
            this.lstVwQuestions.TabIndex = 11;
            this.lstVwQuestions.UseCompatibleStateImageBehavior = false;
            this.lstVwQuestions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Question Text";
            this.columnHeader1.Width = 500;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Answer Type";
            this.columnHeader2.Width = 100;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(655, 388);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(98, 35);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove Question";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Question ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Answer Type";
            // 
            // SurveyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstVwQuestions);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.cmBxQuestionType);
            this.Controls.Add(this.txBxQuestion);
            this.Controls.Add(this.btnSurveySave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSrDescription);
            this.Controls.Add(this.txBxSrDescription);
            this.Controls.Add(this.lblSurveyTitle);
            this.Controls.Add(this.txBxSrTitle);
            this.Name = "SurveyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SurveyForm";
            this.Load += new System.EventHandler(this.SurveyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBxSrTitle;
        private System.Windows.Forms.Label lblSurveyTitle;
        private System.Windows.Forms.TextBox txBxSrDescription;
        private System.Windows.Forms.Label lblSrDescription;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSurveySave;
        private System.Windows.Forms.TextBox txBxQuestion;
        private System.Windows.Forms.ComboBox cmBxQuestionType;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView lstVwQuestions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}