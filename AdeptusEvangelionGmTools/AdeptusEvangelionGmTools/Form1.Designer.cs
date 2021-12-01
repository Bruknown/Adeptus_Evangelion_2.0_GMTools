
namespace AdeptusEvangelionGmTools
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.ContentGenerator = new System.Windows.Forms.Button();
            this.ContentManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(180, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(431, 35);
            this.Title.TabIndex = 0;
            this.Title.Text = "Adeptus Evangelion Gm Tools";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(13, 421);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(96, 17);
            this.Version.TabIndex = 1;
            this.Version.Text = "Version: 0.0.1";
            // 
            // ContentGenerator
            // 
            this.ContentGenerator.Location = new System.Drawing.Point(289, 160);
            this.ContentGenerator.Name = "ContentGenerator";
            this.ContentGenerator.Size = new System.Drawing.Size(195, 43);
            this.ContentGenerator.TabIndex = 2;
            this.ContentGenerator.Text = "Content Generator";
            this.ContentGenerator.UseVisualStyleBackColor = true;
            this.ContentGenerator.Click += new System.EventHandler(this.ContentGenerator_Click);
            // 
            // ContentManagement
            // 
            this.ContentManagement.Location = new System.Drawing.Point(289, 230);
            this.ContentManagement.Name = "ContentManagement";
            this.ContentManagement.Size = new System.Drawing.Size(195, 43);
            this.ContentManagement.TabIndex = 3;
            this.ContentManagement.Text = "Content Management";
            this.ContentManagement.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContentManagement);
            this.Controls.Add(this.ContentGenerator);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Title);
            this.Name = "FormMain";
            this.Text = "AdEva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Button ContentGenerator;
        private System.Windows.Forms.Button ContentManagement;
    }
}

