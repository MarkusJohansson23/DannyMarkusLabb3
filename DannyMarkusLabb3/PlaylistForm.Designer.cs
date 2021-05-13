
namespace DannyMarkusLabb3
{
    partial class PlaylistForm
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
            this.DGVPlaylistForm = new System.Windows.Forms.DataGridView();
            this.RemovePlaylistButton = new System.Windows.Forms.Button();
            this.ViewTracksButton = new System.Windows.Forms.Button();
            this.AddPlaylistButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PlaylistNameTextBox = new System.Windows.Forms.TextBox();
            this.ViewPlaylistsbutton = new System.Windows.Forms.Button();
            this.PlaylistNameLable = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPlaylistForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPlaylistForm
            // 
            this.DGVPlaylistForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPlaylistForm.Location = new System.Drawing.Point(12, 215);
            this.DGVPlaylistForm.Name = "DGVPlaylistForm";
            this.DGVPlaylistForm.RowTemplate.Height = 25;
            this.DGVPlaylistForm.Size = new System.Drawing.Size(411, 334);
            this.DGVPlaylistForm.TabIndex = 0;
            // 
            // RemovePlaylistButton
            // 
            this.RemovePlaylistButton.Location = new System.Drawing.Point(258, 146);
            this.RemovePlaylistButton.Name = "RemovePlaylistButton";
            this.RemovePlaylistButton.Size = new System.Drawing.Size(104, 39);
            this.RemovePlaylistButton.TabIndex = 1;
            this.RemovePlaylistButton.Text = "Remove";
            this.RemovePlaylistButton.UseVisualStyleBackColor = true;
            // 
            // ViewTracksButton
            // 
            this.ViewTracksButton.Location = new System.Drawing.Point(258, 101);
            this.ViewTracksButton.Name = "ViewTracksButton";
            this.ViewTracksButton.Size = new System.Drawing.Size(104, 39);
            this.ViewTracksButton.TabIndex = 2;
            this.ViewTracksButton.Text = "View Tracks";
            this.ViewTracksButton.UseVisualStyleBackColor = true;
            // 
            // AddPlaylistButton
            // 
            this.AddPlaylistButton.Location = new System.Drawing.Point(258, 56);
            this.AddPlaylistButton.Name = "AddPlaylistButton";
            this.AddPlaylistButton.Size = new System.Drawing.Size(104, 39);
            this.AddPlaylistButton.TabIndex = 3;
            this.AddPlaylistButton.Text = "Add";
            this.AddPlaylistButton.UseVisualStyleBackColor = true;
            this.AddPlaylistButton.Click += new System.EventHandler(this.AddPlaylistButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(382, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(763, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 5;
            // 
            // PlaylistNameTextBox
            // 
            this.PlaylistNameTextBox.Location = new System.Drawing.Point(97, 88);
            this.PlaylistNameTextBox.Name = "PlaylistNameTextBox";
            this.PlaylistNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.PlaylistNameTextBox.TabIndex = 6;
            // 
            // ViewPlaylistsbutton
            // 
            this.ViewPlaylistsbutton.Location = new System.Drawing.Point(12, 186);
            this.ViewPlaylistsbutton.Name = "ViewPlaylistsbutton";
            this.ViewPlaylistsbutton.Size = new System.Drawing.Size(109, 23);
            this.ViewPlaylistsbutton.TabIndex = 7;
            this.ViewPlaylistsbutton.Text = "View Playlists";
            this.ViewPlaylistsbutton.UseVisualStyleBackColor = true;
            this.ViewPlaylistsbutton.Click += new System.EventHandler(this.ViewPlaylistsbutton_Click);
            // 
            // PlaylistNameLable
            // 
            this.PlaylistNameLable.AutoSize = true;
            this.PlaylistNameLable.Location = new System.Drawing.Point(12, 91);
            this.PlaylistNameLable.Name = "PlaylistNameLable";
            this.PlaylistNameLable.Size = new System.Drawing.Size(79, 15);
            this.PlaylistNameLable.TabIndex = 8;
            this.PlaylistNameLable.Text = "Playlist Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(429, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(456, 334);
            this.dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(699, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // PlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PlaylistNameLable);
            this.Controls.Add(this.ViewPlaylistsbutton);
            this.Controls.Add(this.PlaylistNameTextBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddPlaylistButton);
            this.Controls.Add(this.ViewTracksButton);
            this.Controls.Add(this.RemovePlaylistButton);
            this.Controls.Add(this.DGVPlaylistForm);
            this.Name = "PlaylistForm";
            this.Text = "PlaylistForm";
            this.Load += new System.EventHandler(this.PlaylistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPlaylistForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPlaylistForm;
        private System.Windows.Forms.Button RemovePlaylistButton;
        private System.Windows.Forms.Button ViewTracksButton;
        private System.Windows.Forms.Button AddPlaylistButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox PlaylistNameTextBox;
        private System.Windows.Forms.Button ViewPlaylistsbutton;
        private System.Windows.Forms.Label PlaylistNameLable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}