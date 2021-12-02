
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
            this.EvangelionOutput = new System.Windows.Forms.RichTextBox();
            this.RandColor = new System.Windows.Forms.CheckBox();
            this.ChoiceBox = new System.Windows.Forms.GroupBox();
            this.SColor2Select = new System.Windows.Forms.ComboBox();
            this.SColor1Select = new System.Windows.Forms.ComboBox();
            this.MColor2Select = new System.Windows.Forms.ComboBox();
            this.MColor1Select = new System.Windows.Forms.ComboBox();
            this.HistorySelect = new System.Windows.Forms.ComboBox();
            this.ConstructionSelect = new System.Windows.Forms.ComboBox();
            this.MutationSelect = new System.Windows.Forms.ComboBox();
            this.SoulSelect = new System.Windows.Forms.ComboBox();
            this.EvaSheet.SuspendLayout();
            this.ChoiceBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RandomSoul
            // 
            this.RandomSoul.AutoSize = true;
            this.RandomSoul.Location = new System.Drawing.Point(6, 29);
            this.RandomSoul.Name = "RandomSoul";
            this.RandomSoul.Size = new System.Drawing.Size(115, 21);
            this.RandomSoul.TabIndex = 0;
            this.RandomSoul.Text = "Random Soul";
            this.RandomSoul.UseVisualStyleBackColor = true;
            this.RandomSoul.CheckedChanged += new System.EventHandler(this.RandomSoul_CheckedChanged);
            // 
            // RandMutation
            // 
            this.RandMutation.AutoSize = true;
            this.RandMutation.Location = new System.Drawing.Point(6, 60);
            this.RandMutation.Name = "RandMutation";
            this.RandMutation.Size = new System.Drawing.Size(141, 21);
            this.RandMutation.TabIndex = 1;
            this.RandMutation.Text = "Random Mutation";
            this.RandMutation.UseVisualStyleBackColor = true;
            this.RandMutation.CheckedChanged += new System.EventHandler(this.RandMutation_CheckedChanged);
            // 
            // RandConstruction
            // 
            this.RandConstruction.AutoSize = true;
            this.RandConstruction.Location = new System.Drawing.Point(6, 91);
            this.RandConstruction.Name = "RandConstruction";
            this.RandConstruction.Size = new System.Drawing.Size(166, 21);
            this.RandConstruction.TabIndex = 2;
            this.RandConstruction.Text = "Random Construction";
            this.RandConstruction.UseVisualStyleBackColor = true;
            this.RandConstruction.CheckedChanged += new System.EventHandler(this.RandConstruction_CheckedChanged);
            // 
            // RandHistory
            // 
            this.RandHistory.AutoSize = true;
            this.RandHistory.Location = new System.Drawing.Point(6, 122);
            this.RandHistory.Name = "RandHistory";
            this.RandHistory.Size = new System.Drawing.Size(131, 21);
            this.RandHistory.TabIndex = 3;
            this.RandHistory.Text = "Random History";
            this.RandHistory.UseVisualStyleBackColor = true;
            this.RandHistory.CheckedChanged += new System.EventHandler(this.RandHistory_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(38, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EvaSheet
            // 
            this.EvaSheet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EvaSheet.Controls.Add(this.EvangelionOutput);
            this.EvaSheet.Location = new System.Drawing.Point(413, 42);
            this.EvaSheet.Name = "EvaSheet";
            this.EvaSheet.Size = new System.Drawing.Size(375, 396);
            this.EvaSheet.TabIndex = 5;
            this.EvaSheet.TabStop = false;
            this.EvaSheet.Text = "Evangelion Unit:";
            // 
            // EvangelionOutput
            // 
            this.EvangelionOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EvangelionOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvangelionOutput.Location = new System.Drawing.Point(19, 22);
            this.EvangelionOutput.Name = "EvangelionOutput";
            this.EvangelionOutput.ReadOnly = true;
            this.EvangelionOutput.Size = new System.Drawing.Size(350, 368);
            this.EvangelionOutput.TabIndex = 0;
            this.EvangelionOutput.Text = "";
            // 
            // RandColor
            // 
            this.RandColor.AutoSize = true;
            this.RandColor.Location = new System.Drawing.Point(6, 205);
            this.RandColor.Name = "RandColor";
            this.RandColor.Size = new System.Drawing.Size(120, 21);
            this.RandColor.TabIndex = 6;
            this.RandColor.Text = "Random Color";
            this.RandColor.UseVisualStyleBackColor = true;
            this.RandColor.CheckedChanged += new System.EventHandler(this.RandColor_CheckedChanged);
            // 
            // ChoiceBox
            // 
            this.ChoiceBox.Controls.Add(this.SColor2Select);
            this.ChoiceBox.Controls.Add(this.SColor1Select);
            this.ChoiceBox.Controls.Add(this.MColor2Select);
            this.ChoiceBox.Controls.Add(this.MColor1Select);
            this.ChoiceBox.Controls.Add(this.HistorySelect);
            this.ChoiceBox.Controls.Add(this.ConstructionSelect);
            this.ChoiceBox.Controls.Add(this.MutationSelect);
            this.ChoiceBox.Controls.Add(this.SoulSelect);
            this.ChoiceBox.Controls.Add(this.RandHistory);
            this.ChoiceBox.Controls.Add(this.RandColor);
            this.ChoiceBox.Controls.Add(this.RandomSoul);
            this.ChoiceBox.Controls.Add(this.RandMutation);
            this.ChoiceBox.Controls.Add(this.RandConstruction);
            this.ChoiceBox.Location = new System.Drawing.Point(38, 83);
            this.ChoiceBox.Name = "ChoiceBox";
            this.ChoiceBox.Size = new System.Drawing.Size(369, 279);
            this.ChoiceBox.TabIndex = 7;
            this.ChoiceBox.TabStop = false;
            this.ChoiceBox.Text = "Random Select";
            // 
            // SColor2Select
            // 
            this.SColor2Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SColor2Select.FormattingEnabled = true;
            this.SColor2Select.Location = new System.Drawing.Point(185, 249);
            this.SColor2Select.Name = "SColor2Select";
            this.SColor2Select.Size = new System.Drawing.Size(121, 24);
            this.SColor2Select.TabIndex = 14;
            this.SColor2Select.TextChanged += new System.EventHandler(this.SColor2Select_TextChanged);
            // 
            // SColor1Select
            // 
            this.SColor1Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SColor1Select.FormattingEnabled = true;
            this.SColor1Select.Location = new System.Drawing.Point(185, 219);
            this.SColor1Select.Name = "SColor1Select";
            this.SColor1Select.Size = new System.Drawing.Size(121, 24);
            this.SColor1Select.TabIndex = 13;
            this.SColor1Select.TextChanged += new System.EventHandler(this.SColor1Select_TextChanged);
            // 
            // MColor2Select
            // 
            this.MColor2Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MColor2Select.FormattingEnabled = true;
            this.MColor2Select.Location = new System.Drawing.Point(185, 189);
            this.MColor2Select.Name = "MColor2Select";
            this.MColor2Select.Size = new System.Drawing.Size(121, 24);
            this.MColor2Select.TabIndex = 12;
            this.MColor2Select.TextChanged += new System.EventHandler(this.MColor2Select_TextChanged);
            // 
            // MColor1Select
            // 
            this.MColor1Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MColor1Select.FormattingEnabled = true;
            this.MColor1Select.Location = new System.Drawing.Point(185, 159);
            this.MColor1Select.Name = "MColor1Select";
            this.MColor1Select.Size = new System.Drawing.Size(121, 24);
            this.MColor1Select.TabIndex = 11;
            this.MColor1Select.TextChanged += new System.EventHandler(this.MColor1Select_TextChanged);
            // 
            // HistorySelect
            // 
            this.HistorySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HistorySelect.FormattingEnabled = true;
            this.HistorySelect.Location = new System.Drawing.Point(185, 119);
            this.HistorySelect.Name = "HistorySelect";
            this.HistorySelect.Size = new System.Drawing.Size(178, 24);
            this.HistorySelect.TabIndex = 10;
            this.HistorySelect.TextChanged += new System.EventHandler(this.HistorySelect_TextChanged);
            // 
            // ConstructionSelect
            // 
            this.ConstructionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConstructionSelect.FormattingEnabled = true;
            this.ConstructionSelect.Location = new System.Drawing.Point(185, 88);
            this.ConstructionSelect.Name = "ConstructionSelect";
            this.ConstructionSelect.Size = new System.Drawing.Size(178, 24);
            this.ConstructionSelect.TabIndex = 9;
            this.ConstructionSelect.TextChanged += new System.EventHandler(this.ConstructionSelect_TextChanged);
            // 
            // MutationSelect
            // 
            this.MutationSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MutationSelect.FormattingEnabled = true;
            this.MutationSelect.Location = new System.Drawing.Point(185, 57);
            this.MutationSelect.Name = "MutationSelect";
            this.MutationSelect.Size = new System.Drawing.Size(178, 24);
            this.MutationSelect.TabIndex = 8;
            this.MutationSelect.TextChanged += new System.EventHandler(this.MutationSelect_TextChanged);
            // 
            // SoulSelect
            // 
            this.SoulSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SoulSelect.FormattingEnabled = true;
            this.SoulSelect.Location = new System.Drawing.Point(185, 26);
            this.SoulSelect.Name = "SoulSelect";
            this.SoulSelect.Size = new System.Drawing.Size(178, 24);
            this.SoulSelect.TabIndex = 7;
            this.SoulSelect.TextChanged += new System.EventHandler(this.SoulSelect_TextChanged);
            // 
            // EvangelionGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChoiceBox);
            this.Controls.Add(this.EvaSheet);
            this.Controls.Add(this.button1);
            this.Name = "EvangelionGenerator";
            this.Text = "EvangelionGenerator";
            this.EvaSheet.ResumeLayout(false);
            this.ChoiceBox.ResumeLayout(false);
            this.ChoiceBox.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox ChoiceBox;
        private System.Windows.Forms.ComboBox MColor2Select;
        private System.Windows.Forms.ComboBox MColor1Select;
        private System.Windows.Forms.ComboBox HistorySelect;
        private System.Windows.Forms.ComboBox ConstructionSelect;
        private System.Windows.Forms.ComboBox MutationSelect;
        private System.Windows.Forms.ComboBox SoulSelect;
        private System.Windows.Forms.ComboBox SColor2Select;
        private System.Windows.Forms.ComboBox SColor1Select;
    }
}