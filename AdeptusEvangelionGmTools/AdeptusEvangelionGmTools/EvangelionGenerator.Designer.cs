
namespace AdeptusEvangelionGmTools
{
    partial class EvangelionGenerator
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
            this.RandomSoul = new System.Windows.Forms.CheckBox();
            this.RandMutation = new System.Windows.Forms.CheckBox();
            this.RandConstruction = new System.Windows.Forms.CheckBox();
            this.RandHistory = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EvaSheet = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // RandomSoul
            // 
            this.RandomSoul.AutoSize = true;
            this.RandomSoul.Location = new System.Drawing.Point(51, 117);
            this.RandomSoul.Name = "RandomSoul";
            this.RandomSoul.Size = new System.Drawing.Size(115, 21);
            this.RandomSoul.TabIndex = 0;
            this.RandomSoul.Text = "Random Soul";
            this.RandomSoul.UseVisualStyleBackColor = true;
            // 
            // RandMutation
            // 
            this.RandMutation.AutoSize = true;
            this.RandMutation.Location = new System.Drawing.Point(51, 144);
            this.RandMutation.Name = "RandMutation";
            this.RandMutation.Size = new System.Drawing.Size(141, 21);
            this.RandMutation.TabIndex = 1;
            this.RandMutation.Text = "Random Mutation";
            this.RandMutation.UseVisualStyleBackColor = true;
            // 
            // RandConstruction
            // 
            this.RandConstruction.AutoSize = true;
            this.RandConstruction.Location = new System.Drawing.Point(51, 171);
            this.RandConstruction.Name = "RandConstruction";
            this.RandConstruction.Size = new System.Drawing.Size(166, 21);
            this.RandConstruction.TabIndex = 2;
            this.RandConstruction.Text = "Random Construction";
            this.RandConstruction.UseVisualStyleBackColor = true;
            // 
            // RandHistory
            // 
            this.RandHistory.AutoSize = true;
            this.RandHistory.Location = new System.Drawing.Point(51, 198);
            this.RandHistory.Name = "RandHistory";
            this.RandHistory.Size = new System.Drawing.Size(131, 21);
            this.RandHistory.TabIndex = 3;
            this.RandHistory.Text = "Random History";
            this.RandHistory.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EvaSheet
            // 
            this.EvaSheet.Location = new System.Drawing.Point(276, 42);
            this.EvaSheet.Name = "EvaSheet";
            this.EvaSheet.Size = new System.Drawing.Size(277, 396);
            this.EvaSheet.TabIndex = 5;
            this.EvaSheet.TabStop = false;
            this.EvaSheet.Text = "Evangelion Unit:";
            // 
            // EvangelionGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EvaSheet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RandHistory);
            this.Controls.Add(this.RandConstruction);
            this.Controls.Add(this.RandMutation);
            this.Controls.Add(this.RandomSoul);
            this.Name = "EvangelionGenerator";
            this.Text = "EvangelionGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox RandomSoul;
        private System.Windows.Forms.CheckBox RandMutation;
        private System.Windows.Forms.CheckBox RandConstruction;
        private System.Windows.Forms.CheckBox RandHistory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox EvaSheet;
    }
}