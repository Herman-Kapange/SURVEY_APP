
namespace SurveyApp
{
    partial class SurveyListForm
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewSurvey = new System.Windows.Forms.Button();
            this.lstVwSurvey = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 415);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(107, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Answer Survey";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(664, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewSurvey
            // 
            this.btnNewSurvey.Location = new System.Drawing.Point(184, 415);
            this.btnNewSurvey.Name = "btnNewSurvey";
            this.btnNewSurvey.Size = new System.Drawing.Size(94, 23);
            this.btnNewSurvey.TabIndex = 2;
            this.btnNewSurvey.Text = "New Survey..";
            this.btnNewSurvey.UseVisualStyleBackColor = true;
            this.btnNewSurvey.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lstVwSurvey
            // 
            this.lstVwSurvey.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstVwSurvey.GridLines = true;
            this.lstVwSurvey.HideSelection = false;
            this.lstVwSurvey.Location = new System.Drawing.Point(4, 2);
            this.lstVwSurvey.Name = "lstVwSurvey";
            this.lstVwSurvey.Size = new System.Drawing.Size(791, 405);
            this.lstVwSurvey.TabIndex = 4;
            this.lstVwSurvey.UseCompatibleStateImageBehavior = false;
            this.lstVwSurvey.View = System.Windows.Forms.View.Details;
            this.lstVwSurvey.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstVwSurvey_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SurveyId";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Survey Title";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Survey Description";
            this.columnHeader3.Width = 370;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Survey Author";
            this.columnHeader4.Width = 157;
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(12, 415);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(149, 23);
            this.btnReview.TabIndex = 5;
            this.btnReview.Text = "Review answered Survey";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // SurveyListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.lstVwSurvey);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewSurvey);
            this.Controls.Add(this.btnLoad);
            this.Name = "SurveyListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SurveyForm";
            this.Load += new System.EventHandler(this.SurveyList_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewSurvey;
        private System.Windows.Forms.ListView lstVwSurvey;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnReview;
    }
}