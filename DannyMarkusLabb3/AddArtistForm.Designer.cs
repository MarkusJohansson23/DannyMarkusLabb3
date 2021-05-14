
namespace DannyMarkusLabb3
{
    partial class AddArtistForm
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
            this.DGVArtistForm = new System.Windows.Forms.DataGridView();
            this.ArtistTextBox = new System.Windows.Forms.TextBox();
            this.AlbumTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.AddArtistButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.UpdateArtistButton = new System.Windows.Forms.Button();
            this.RemoveArtistButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVArtistForm)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVArtistForm
            // 
            this.DGVArtistForm.AllowUserToDeleteRows = false;
            this.DGVArtistForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVArtistForm.Location = new System.Drawing.Point(2, 162);
            this.DGVArtistForm.Name = "DGVArtistForm";
            this.DGVArtistForm.ReadOnly = true;
            this.DGVArtistForm.Size = new System.Drawing.Size(797, 287);
            this.DGVArtistForm.TabIndex = 0;
            this.DGVArtistForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ArtistTextBox
            // 
            this.ArtistTextBox.Location = new System.Drawing.Point(70, 50);
            this.ArtistTextBox.Name = "ArtistTextBox";
            this.ArtistTextBox.Size = new System.Drawing.Size(134, 23);
            this.ArtistTextBox.TabIndex = 1;
            // 
            // AlbumTextBox
            // 
            this.AlbumTextBox.Location = new System.Drawing.Point(70, 79);
            this.AlbumTextBox.Name = "AlbumTextBox";
            this.AlbumTextBox.Size = new System.Drawing.Size(134, 23);
            this.AlbumTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genre";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(70, 108);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(134, 23);
            this.GenreTextBox.TabIndex = 6;
            // 
            // AddArtistButton
            // 
            this.AddArtistButton.Location = new System.Drawing.Point(295, 79);
            this.AddArtistButton.Name = "AddArtistButton";
            this.AddArtistButton.Size = new System.Drawing.Size(75, 23);
            this.AddArtistButton.TabIndex = 7;
            this.AddArtistButton.Text = "Add";
            this.AddArtistButton.UseVisualStyleBackColor = true;
            this.AddArtistButton.Click += new System.EventHandler(this.AddArtistButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(295, 21);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // UpdateArtistButton
            // 
            this.UpdateArtistButton.Location = new System.Drawing.Point(295, 50);
            this.UpdateArtistButton.Name = "UpdateArtistButton";
            this.UpdateArtistButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateArtistButton.TabIndex = 9;
            this.UpdateArtistButton.Text = "Update";
            this.UpdateArtistButton.UseVisualStyleBackColor = true;
            // 
            // RemoveArtistButton
            // 
            this.RemoveArtistButton.Location = new System.Drawing.Point(295, 108);
            this.RemoveArtistButton.Name = "RemoveArtistButton";
            this.RemoveArtistButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveArtistButton.TabIndex = 10;
            this.RemoveArtistButton.Text = "Remove";
            this.RemoveArtistButton.UseVisualStyleBackColor = true;
            // 
            // AddArtistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoveArtistButton);
            this.Controls.Add(this.UpdateArtistButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddArtistButton);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlbumTextBox);
            this.Controls.Add(this.ArtistTextBox);
            this.Controls.Add(this.DGVArtistForm);
            this.Name = "AddArtistForm";
            this.Text = "AddArtistForm";
            this.Load += new System.EventHandler(this.AddArtistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVArtistForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVArtistForm;
        private System.Windows.Forms.TextBox ArtistTextBox;
        private System.Windows.Forms.TextBox AlbumTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Button AddArtistButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button UpdateArtistButton;
        private System.Windows.Forms.Button RemoveArtistButton;
    }
}