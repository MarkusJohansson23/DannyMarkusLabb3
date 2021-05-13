﻿using DannyMarkusLabb3.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DannyMarkusLabb3
{
    public partial class AddArtistForm : Form
    {
        public AddArtistForm()
        {
            InitializeComponent();
        }

        private void AddArtistForm_Load(object sender, EventArgs e)
        {
            using (var db = new everyloopContext())
            {
                var tracks = (from t in db.Tracks
                              join al in db.Albums
                              on t.AlbumId equals al.AlbumId
                              join ar in db.Artists
                              on al.ArtistId equals ar.ArtistId
                              join g in db.Genres
                              on t.GenreId equals g.GenreId
                              select new
                              {
                                  Track = t.Name,
                                  Album = al.Title,
                                  Artist = ar.Name,
                                  Genre = g.Name
                              }).ToList();
                try
                {
                    DGVArtistForm.DataSource = tracks;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddArtistButton_Click(object sender, EventArgs e)
        {
            using (var db = new everyloopContext())
            {
                var tracks = (from t in db.Tracks
                              join al in db.Albums
                              on t.AlbumId equals al.AlbumId
                              join ar in db.Artists
                              on al.ArtistId equals ar.ArtistId
                              join g in db.Genres
                              on t.GenreId equals g.GenreId
                              select new
                              {
                                  Track = t.Name,
                                  Album = al.Title,
                                  Artist = ar.Name,
                                  Genre = g.Name
                              }).ToList();

                if (ArtistTextBox.Text != null || AlbumTextBox.Text != null || GenreTextBox.Text != null)
                {
                    var artistPkId = db.Artists.Count();
                    var albumPkId = db.Albums.Count();
                    var genrePkId = db.Genres.Count();
                    var addedArtist = new Artist()
                    {
                        ArtistId = artistPkId++,
                        Name = Convert.ToString(ArtistTextBox.Text)
                    };
                    var addedAlbum = new Album()
                    {
                        AlbumId = albumPkId++,
                        Title = Convert.ToString(AlbumTextBox.Text),
                        ArtistId = artistPkId
                    };
                    var addedGenre = new Genre()
                    {
                        GenreId = genrePkId++,
                        Name = Convert.ToString(GenreTextBox.Text)
                    };
                    db.Add(addedArtist);
                    db.Add(addedAlbum);
                    db.Add(addedGenre);
                    db.SaveChanges();
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            using (var db = new everyloopContext())
            {
                var tracks = (from t in db.Tracks
                              join al in db.Albums
                              on t.AlbumId equals al.AlbumId
                              join ar in db.Artists
                              on al.ArtistId equals ar.ArtistId
                              join g in db.Genres
                              on t.GenreId equals g.GenreId
                              where ar.Name == ArtistTextBox.Text ||
                              al.Title == AlbumTextBox.Text ||
                              g.Name == GenreTextBox.Text
                              select new
                              {
                                  Track = t.Name,
                                  Album = al.Title,
                                  Artist = ar.Name,
                                  Genre = g.Name
                              }
                              ).ToList();
                if (tracks != null)
                {
                    if (tracks.Count()<=0)
                    {
                        MessageBox.Show("No records found", "No data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                try
                {
                    DGVArtistForm.DataSource = tracks;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
        }

        private void UpdateArtistButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveArtistButton_Click(object sender, EventArgs e)
        {

        }
    }
}
