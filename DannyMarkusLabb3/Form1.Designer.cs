
namespace DannyMarkusLabb3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddPlaylistButton = new System.Windows.Forms.Button();
            this.RemovePlaylistButton = new System.Windows.Forms.Button();
            this.EditPlaylistButton = new System.Windows.Forms.Button();
            this.AddArtistsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditArtistsButton = new System.Windows.Forms.Button();
            this.RemoveArtistsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPlaylistButton
            // 
            this.AddPlaylistButton.Location = new System.Drawing.Point(55, 53);
            this.AddPlaylistButton.Name = "AddPlaylistButton";
            this.AddPlaylistButton.Size = new System.Drawing.Size(109, 23);
            this.AddPlaylistButton.TabIndex = 0;
            this.AddPlaylistButton.Text = "Add Playlist";
            this.AddPlaylistButton.UseVisualStyleBackColor = true;
            this.AddPlaylistButton.Click += new System.EventHandler(this.AddPlaylistButton_Click);
            // 
            // RemovePlaylistButton
            // 
            this.RemovePlaylistButton.Location = new System.Drawing.Point(55, 111);
            this.RemovePlaylistButton.Name = "RemovePlaylistButton";
            this.RemovePlaylistButton.Size = new System.Drawing.Size(109, 23);
            this.RemovePlaylistButton.TabIndex = 1;
            this.RemovePlaylistButton.Text = "Remove Playlist";
            this.RemovePlaylistButton.UseVisualStyleBackColor = true;
            this.RemovePlaylistButton.Click += new System.EventHandler(this.RemovePlaylistButton_Click);
            // 
            // EditPlaylistButton
            // 
            this.EditPlaylistButton.Location = new System.Drawing.Point(55, 82);
            this.EditPlaylistButton.Name = "EditPlaylistButton";
            this.EditPlaylistButton.Size = new System.Drawing.Size(109, 23);
            this.EditPlaylistButton.TabIndex = 2;
            this.EditPlaylistButton.Text = "Edit Playlist";
            this.EditPlaylistButton.UseVisualStyleBackColor = true;
            this.EditPlaylistButton.Click += new System.EventHandler(this.EditPlaylistButton_Click);
            // 
            // AddArtistsButton
            // 
            this.AddArtistsButton.Location = new System.Drawing.Point(55, 228);
            this.AddArtistsButton.Name = "AddArtistsButton";
            this.AddArtistsButton.Size = new System.Drawing.Size(109, 60);
            this.AddArtistsButton.TabIndex = 6;
            this.AddArtistsButton.Text = "Add artists, albums and tracks";
            this.AddArtistsButton.UseVisualStyleBackColor = true;
            this.AddArtistsButton.Click += new System.EventHandler(this.AddArtistsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Playlists";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Artists, albums and";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "tracks";
            // 
            // EditArtistsButton
            // 
            this.EditArtistsButton.Location = new System.Drawing.Point(55, 294);
            this.EditArtistsButton.Name = "EditArtistsButton";
            this.EditArtistsButton.Size = new System.Drawing.Size(109, 62);
            this.EditArtistsButton.TabIndex = 10;
            this.EditArtistsButton.Text = "Edit artists, albums and tracks";
            this.EditArtistsButton.UseVisualStyleBackColor = true;
            this.EditArtistsButton.Click += new System.EventHandler(this.EditArtistsButton_Click);
            // 
            // RemoveArtistsButton
            // 
            this.RemoveArtistsButton.Location = new System.Drawing.Point(55, 362);
            this.RemoveArtistsButton.Name = "RemoveArtistsButton";
            this.RemoveArtistsButton.Size = new System.Drawing.Size(109, 60);
            this.RemoveArtistsButton.TabIndex = 11;
            this.RemoveArtistsButton.Text = "Remove artists, albums and tracks";
            this.RemoveArtistsButton.UseVisualStyleBackColor = true;
            this.RemoveArtistsButton.Click += new System.EventHandler(this.RemoveArtistsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(225, 435);
            this.Controls.Add(this.RemoveArtistsButton);
            this.Controls.Add(this.EditArtistsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddArtistsButton);
            this.Controls.Add(this.EditPlaylistButton);
            this.Controls.Add(this.RemovePlaylistButton);
            this.Controls.Add(this.AddPlaylistButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPlaylistButton;
        private System.Windows.Forms.Button RemovePlaylistButton;
        private System.Windows.Forms.Button EditPlaylistButton;
        private System.Windows.Forms.Button AddArtistsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EditArtistsButton;
        private System.Windows.Forms.Button RemoveArtistsButton;
    }
}

