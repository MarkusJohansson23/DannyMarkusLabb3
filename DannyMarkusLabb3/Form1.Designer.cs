
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddArtistsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditArtistsButton = new System.Windows.Forms.Button();
            this.RemoveArtistsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddPlaylistButton
            // 
            this.AddPlaylistButton.Location = new System.Drawing.Point(7, 57);
            this.AddPlaylistButton.Name = "AddPlaylistButton";
            this.AddPlaylistButton.Size = new System.Drawing.Size(109, 23);
            this.AddPlaylistButton.TabIndex = 0;
            this.AddPlaylistButton.Text = "Add Playlist";
            this.AddPlaylistButton.UseVisualStyleBackColor = true;
            this.AddPlaylistButton.Click += new System.EventHandler(this.AddPlaylistButton_Click);
            // 
            // RemovePlaylistButton
            // 
            this.RemovePlaylistButton.Location = new System.Drawing.Point(7, 115);
            this.RemovePlaylistButton.Name = "RemovePlaylistButton";
            this.RemovePlaylistButton.Size = new System.Drawing.Size(109, 23);
            this.RemovePlaylistButton.TabIndex = 1;
            this.RemovePlaylistButton.Text = "Remove Playlist";
            this.RemovePlaylistButton.UseVisualStyleBackColor = true;
            this.RemovePlaylistButton.Click += new System.EventHandler(this.RemovePlaylistButton_Click);
            // 
            // EditPlaylistButton
            // 
            this.EditPlaylistButton.Location = new System.Drawing.Point(7, 86);
            this.EditPlaylistButton.Name = "EditPlaylistButton";
            this.EditPlaylistButton.Size = new System.Drawing.Size(109, 23);
            this.EditPlaylistButton.TabIndex = 2;
            this.EditPlaylistButton.Text = "Edit Playlist";
            this.EditPlaylistButton.UseVisualStyleBackColor = true;
            this.EditPlaylistButton.Click += new System.EventHandler(this.EditPlaylistButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(122, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 535);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playlists";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(471, 499);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(272, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(611, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 535);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Songs";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(7, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(567, 499);
            this.listBox1.TabIndex = 0;
            // 
            // AddArtistsButton
            // 
            this.AddArtistsButton.Location = new System.Drawing.Point(7, 232);
            this.AddArtistsButton.Name = "AddArtistsButton";
            this.AddArtistsButton.Size = new System.Drawing.Size(109, 60);
            this.AddArtistsButton.TabIndex = 6;
            this.AddArtistsButton.Text = "Add artists, albums and tracks";
            this.AddArtistsButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Playlists";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Artists, albums and";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "tracks";
            // 
            // EditArtistsButton
            // 
            this.EditArtistsButton.Location = new System.Drawing.Point(7, 298);
            this.EditArtistsButton.Name = "EditArtistsButton";
            this.EditArtistsButton.Size = new System.Drawing.Size(109, 62);
            this.EditArtistsButton.TabIndex = 10;
            this.EditArtistsButton.Text = "Edit artists, albums and tracks";
            this.EditArtistsButton.UseVisualStyleBackColor = true;
            // 
            // RemoveArtistsButton
            // 
            this.RemoveArtistsButton.Location = new System.Drawing.Point(7, 366);
            this.RemoveArtistsButton.Name = "RemoveArtistsButton";
            this.RemoveArtistsButton.Size = new System.Drawing.Size(109, 60);
            this.RemoveArtistsButton.TabIndex = 11;
            this.RemoveArtistsButton.Text = "Remove artists, albums and tracks";
            this.RemoveArtistsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 581);
            this.Controls.Add(this.RemoveArtistsButton);
            this.Controls.Add(this.EditArtistsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddArtistsButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EditPlaylistButton);
            this.Controls.Add(this.RemovePlaylistButton);
            this.Controls.Add(this.AddPlaylistButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPlaylistButton;
        private System.Windows.Forms.Button RemovePlaylistButton;
        private System.Windows.Forms.Button EditPlaylistButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddArtistsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EditArtistsButton;
        private System.Windows.Forms.Button RemoveArtistsButton;
    }
}

