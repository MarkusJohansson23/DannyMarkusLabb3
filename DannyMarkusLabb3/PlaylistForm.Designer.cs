
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
            this.ViewTracksButton = new System.Windows.Forms.Button();
            this.AddPlaylistButton = new System.Windows.Forms.Button();
            this.ViewPlaylistsbutton = new System.Windows.Forms.Button();
            this.DGVTracks = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentPlaylistBox = new System.Windows.Forms.ComboBox();
            this.DeletePlaylistButton = new System.Windows.Forms.Button();
            this.NewPlaylistNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TrackPlaylistBox = new System.Windows.Forms.ComboBox();
            this.AddTrackButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TrackNameBox = new System.Windows.Forms.TextBox();
            this.SearchTracksButton = new System.Windows.Forms.Button();
            this.SearchTracksBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPlaylistForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTracks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVPlaylistForm
            // 
            this.DGVPlaylistForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPlaylistForm.Location = new System.Drawing.Point(14, 287);
            this.DGVPlaylistForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVPlaylistForm.Name = "DGVPlaylistForm";
            this.DGVPlaylistForm.RowHeadersWidth = 51;
            this.DGVPlaylistForm.RowTemplate.Height = 25;
            this.DGVPlaylistForm.Size = new System.Drawing.Size(470, 445);
            this.DGVPlaylistForm.TabIndex = 0;
            this.DGVPlaylistForm.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVPlaylistForm_CellMouseClick);
            // 
            // ViewTracksButton
            // 
            this.ViewTracksButton.Location = new System.Drawing.Point(177, 47);
            this.ViewTracksButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewTracksButton.Name = "ViewTracksButton";
            this.ViewTracksButton.Size = new System.Drawing.Size(99, 31);
            this.ViewTracksButton.TabIndex = 2;
            this.ViewTracksButton.Text = "View Tracks";
            this.ViewTracksButton.UseVisualStyleBackColor = true;
            this.ViewTracksButton.Click += new System.EventHandler(this.ViewTracksButton_Click);
            // 
            // AddPlaylistButton
            // 
            this.AddPlaylistButton.Location = new System.Drawing.Point(177, 124);
            this.AddPlaylistButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddPlaylistButton.Name = "AddPlaylistButton";
            this.AddPlaylistButton.Size = new System.Drawing.Size(99, 31);
            this.AddPlaylistButton.TabIndex = 3;
            this.AddPlaylistButton.Text = "Add";
            this.AddPlaylistButton.UseVisualStyleBackColor = true;
            this.AddPlaylistButton.Click += new System.EventHandler(this.AddPlaylistButton_Click);
            // 
            // ViewPlaylistsbutton
            // 
            this.ViewPlaylistsbutton.Location = new System.Drawing.Point(14, 248);
            this.ViewPlaylistsbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewPlaylistsbutton.Name = "ViewPlaylistsbutton";
            this.ViewPlaylistsbutton.Size = new System.Drawing.Size(125, 31);
            this.ViewPlaylistsbutton.TabIndex = 7;
            this.ViewPlaylistsbutton.Text = "View Playlists";
            this.ViewPlaylistsbutton.UseVisualStyleBackColor = true;
            this.ViewPlaylistsbutton.Click += new System.EventHandler(this.ViewPlaylistsbutton_Click);
            // 
            // DGVTracks
            // 
            this.DGVTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTracks.Location = new System.Drawing.Point(490, 287);
            this.DGVTracks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVTracks.Name = "DGVTracks";
            this.DGVTracks.RowHeadersWidth = 51;
            this.DGVTracks.RowTemplate.Height = 25;
            this.DGVTracks.Size = new System.Drawing.Size(521, 445);
            this.DGVTracks.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current playlist";
            // 
            // CurrentPlaylistBox
            // 
            this.CurrentPlaylistBox.FormattingEnabled = true;
            this.CurrentPlaylistBox.Location = new System.Drawing.Point(14, 48);
            this.CurrentPlaylistBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurrentPlaylistBox.Name = "CurrentPlaylistBox";
            this.CurrentPlaylistBox.Size = new System.Drawing.Size(138, 28);
            this.CurrentPlaylistBox.TabIndex = 15;
            // 
            // DeletePlaylistButton
            // 
            this.DeletePlaylistButton.Location = new System.Drawing.Point(177, 85);
            this.DeletePlaylistButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeletePlaylistButton.Name = "DeletePlaylistButton";
            this.DeletePlaylistButton.Size = new System.Drawing.Size(99, 31);
            this.DeletePlaylistButton.TabIndex = 16;
            this.DeletePlaylistButton.Text = "Delete";
            this.DeletePlaylistButton.UseVisualStyleBackColor = true;
            this.DeletePlaylistButton.Click += new System.EventHandler(this.DeletePlaylistButton_Click);
            // 
            // NewPlaylistNameBox
            // 
            this.NewPlaylistNameBox.Location = new System.Drawing.Point(14, 128);
            this.NewPlaylistNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewPlaylistNameBox.Name = "NewPlaylistNameBox";
            this.NewPlaylistNameBox.Size = new System.Drawing.Size(138, 27);
            this.NewPlaylistNameBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "New playlist name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TrackPlaylistBox);
            this.groupBox1.Controls.Add(this.AddTrackButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TrackNameBox);
            this.groupBox1.Location = new System.Drawing.Point(651, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(360, 177);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Track to add";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Playlist";
            // 
            // TrackPlaylistBox
            // 
            this.TrackPlaylistBox.FormattingEnabled = true;
            this.TrackPlaylistBox.Location = new System.Drawing.Point(7, 139);
            this.TrackPlaylistBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TrackPlaylistBox.Name = "TrackPlaylistBox";
            this.TrackPlaylistBox.Size = new System.Drawing.Size(138, 28);
            this.TrackPlaylistBox.TabIndex = 6;
            // 
            // AddTrackButton
            // 
            this.AddTrackButton.Location = new System.Drawing.Point(262, 100);
            this.AddTrackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddTrackButton.Name = "AddTrackButton";
            this.AddTrackButton.Size = new System.Drawing.Size(86, 31);
            this.AddTrackButton.TabIndex = 5;
            this.AddTrackButton.Text = "Add";
            this.AddTrackButton.UseVisualStyleBackColor = true;
            this.AddTrackButton.Click += new System.EventHandler(this.AddTrackButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 139);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RemoveTrackButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Track Name";
            // 
            // TrackNameBox
            // 
            this.TrackNameBox.Location = new System.Drawing.Point(8, 68);
            this.TrackNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TrackNameBox.Name = "TrackNameBox";
            this.TrackNameBox.Size = new System.Drawing.Size(114, 27);
            this.TrackNameBox.TabIndex = 0;
            // 
            // SearchTracksButton
            // 
            this.SearchTracksButton.Location = new System.Drawing.Point(611, 247);
            this.SearchTracksButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchTracksButton.Name = "SearchTracksButton";
            this.SearchTracksButton.Size = new System.Drawing.Size(86, 31);
            this.SearchTracksButton.TabIndex = 20;
            this.SearchTracksButton.Text = "Search";
            this.SearchTracksButton.UseVisualStyleBackColor = true;
            this.SearchTracksButton.Click += new System.EventHandler(this.SearchTracksButton_Click);
            // 
            // SearchTracksBox
            // 
            this.SearchTracksBox.Location = new System.Drawing.Point(490, 248);
            this.SearchTracksBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchTracksBox.Name = "SearchTracksBox";
            this.SearchTracksBox.Size = new System.Drawing.Size(114, 27);
            this.SearchTracksBox.TabIndex = 21;
            this.SearchTracksBox.TextChanged += new System.EventHandler(this.SearchTracksBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Track";
            // 
            // PlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 748);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SearchTracksBox);
            this.Controls.Add(this.SearchTracksButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewPlaylistNameBox);
            this.Controls.Add(this.DeletePlaylistButton);
            this.Controls.Add(this.CurrentPlaylistBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVTracks);
            this.Controls.Add(this.ViewPlaylistsbutton);
            this.Controls.Add(this.AddPlaylistButton);
            this.Controls.Add(this.ViewTracksButton);
            this.Controls.Add(this.DGVPlaylistForm);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PlaylistForm";
            this.Text = "PlaylistForm";
            this.Load += new System.EventHandler(this.PlaylistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPlaylistForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTracks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPlaylistForm;
        private System.Windows.Forms.Button ViewTracksButton;
        private System.Windows.Forms.Button AddPlaylistButton;
        private System.Windows.Forms.Button ViewPlaylistsbutton;
        private System.Windows.Forms.DataGridView DGVTracks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CurrentPlaylistBox;
        private System.Windows.Forms.Button DeletePlaylistButton;
        private System.Windows.Forms.TextBox NewPlaylistNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TrackNameBox;
        private System.Windows.Forms.Button AddTrackButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TrackPlaylistBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SearchTracksButton;
        private System.Windows.Forms.TextBox SearchTracksBox;
        private System.Windows.Forms.Label label6;
    }
}