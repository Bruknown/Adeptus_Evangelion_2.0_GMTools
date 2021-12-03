
namespace AdeptusEvangelionGmTools
{
    partial class ContentGen
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
            this.EvaGen = new System.Windows.Forms.Button();
            this.AngelGen = new System.Windows.Forms.Button();
            this.PilotGen = new System.Windows.Forms.Button();
            this.EncounterGen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EvaGen
            // 
            this.EvaGen.Location = new System.Drawing.Point(267, 81);
            this.EvaGen.Name = "EvaGen";
            this.EvaGen.Size = new System.Drawing.Size(217, 51);
            this.EvaGen.TabIndex = 0;
            this.EvaGen.Text = "Evangelion Generator";
            this.EvaGen.UseVisualStyleBackColor = true;
            this.EvaGen.Click += new System.EventHandler(this.EvaGen_Click);
            // 
            // AngelGen
            // 
            this.AngelGen.Location = new System.Drawing.Point(267, 138);
            this.AngelGen.Name = "AngelGen";
            this.AngelGen.Size = new System.Drawing.Size(217, 51);
            this.AngelGen.TabIndex = 1;
            this.AngelGen.Text = "Angel Generator";
            this.AngelGen.UseVisualStyleBackColor = true;
            this.AngelGen.Click += new System.EventHandler(this.AngelGen_Click);
            // 
            // PilotGen
            // 
            this.PilotGen.Location = new System.Drawing.Point(267, 195);
            this.PilotGen.Name = "PilotGen";
            this.PilotGen.Size = new System.Drawing.Size(217, 51);
            this.PilotGen.TabIndex = 2;
            this.PilotGen.Text = "Pilot Generator";
            this.PilotGen.UseVisualStyleBackColor = true;
            // 
            // EncounterGen
            // 
            this.EncounterGen.Location = new System.Drawing.Point(267, 252);
            this.EncounterGen.Name = "EncounterGen";
            this.EncounterGen.Size = new System.Drawing.Size(217, 51);
            this.EncounterGen.TabIndex = 3;
            this.EncounterGen.Text = "Encounter Generator";
            this.EncounterGen.UseVisualStyleBackColor = true;
            // 
            // ContentGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EncounterGen);
            this.Controls.Add(this.PilotGen);
            this.Controls.Add(this.AngelGen);
            this.Controls.Add(this.EvaGen);
            this.Name = "ContentGen";
            this.Text = "ContentGen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EvaGen;
        private System.Windows.Forms.Button AngelGen;
        private System.Windows.Forms.Button PilotGen;
        private System.Windows.Forms.Button EncounterGen;
    }
}