
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
            this.RandColor = new System.Windows.Forms.CheckBox();
            this.EvangelionOutput = new System.Windows.Forms.RichTextBox();
            this.EvaSheet.SuspendLayout();
            this.SuspendLayout();
            // 
            // RandomSoul
            // 
            this.RandomSoul.AutoSize = true;
            this.RandomSoul.Checked = true;
            this.RandomSoul.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.RandMutation.Checked = true;
            this.RandMutation.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.RandConstruction.Checked = true;
            this.RandConstruction.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.RandHistory.Checked = true;
            this.RandHistory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RandHistory.Location = new System.Drawing.Point(51, 198);
            this.RandHistory.Name = "RandHistory";
            this.RandHistory.Size = new System.Drawing.Size(131, 21);
            this.RandHistory.TabIndex = 3;
            this.RandHistory.Text = "Random History";
            this.RandHistory.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EvaSheet
            // 
            this.EvaSheet.Controls.Add(this.EvangelionOutput);
            this.EvaSheet.Location = new System.Drawing.Point(276, 42);
            this.EvaSheet.Name = "EvaSheet";
            this.EvaSheet.Size = new System.Drawing.Size(512, 396);
            this.EvaSheet.TabIndex = 5;
            this.EvaSheet.TabStop = false;
            this.EvaSheet.Text = "Evangelion Unit:";
            // 
            // RandColor
            // 
            this.RandColor.AutoSize = true;
            this.RandColor.Checked = true;
            this.RandColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RandColor.Location = new System.Drawing.Point(51, 225);
            this.RandColor.Name = "RandColor";
            this.RandColor.Size = new System.Drawing.Size(120, 21);
            this.RandColor.TabIndex = 6;
            this.RandColor.Text = "Random Color";
            this.RandColor.UseVisualStyleBackColor = true;
            // 
            // EvangelionOutput
            // 
            this.EvangelionOutput.Location = new System.Drawing.Point(7, 22);
            this.EvangelionOutput.Name = "EvangelionOutput";
            this.EvangelionOutput.ReadOnly = true;
            this.EvangelionOutput.Size = new System.Drawing.Size(499, 368);
            this.EvangelionOutput.TabIndex = 0;
            this.EvangelionOutput.Text = "";
            // 
            // EvangelionGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RandColor);
            this.Controls.Add(this.EvaSheet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RandHistory);
            this.Controls.Add(this.RandConstruction);
            this.Controls.Add(this.RandMutation);
            this.Controls.Add(this.RandomSoul);
            this.Name = "EvangelionGenerator";
            this.Text = "EvangelionGenerator";
            this.EvaSheet.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox RandColor;
        private System.Windows.Forms.RichTextBox EvangelionOutput;
    }
}