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
    public partial class PlaylistForm : Form
    {
        public PlaylistForm()
        {
            InitializeComponent();
        }

        private void PlaylistForm_Load(object sender, EventArgs e)
        {
            using (var db = new everyloopContext())
            {
                try
                {
                    DGVPlaylistForm.DataSource = db.Playlists.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
        }

        private void ViewPlaylistsbutton_Click(object sender, EventArgs e)
        {
            using (var db = new everyloopContext())
            {
                try
                {
                    DGVPlaylistForm.DataSource = db.Playlists.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
        }

        private void AddPlaylistButton_Click(object sender, EventArgs e)
        {
            using (var db = new everyloopContext())
            {

            }
        }

        private void DGVPlaylistForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new everyloopContext())
            {
                int index = e.RowIndex;
                //måste kopplas ihop med CellContentClick = playlistId = tracks
                var playlistTracks = (from t in db.Tracks
                                      join pt in db.PlaylistTracks
                                      on t.TrackId equals pt.TrackId
                                      join p in db.Playlists
                                      on pt.PlaylistId equals p.PlaylistId
                                      select new
                                      {
                                          Name = t.Name,
                                          Compser = t.Composer,
                                          Length = t.Milliseconds,
                                          AlbumId = t.AlbumId
                                      }).ToList();

                DGVTracks.DataSource = playlistTracks;
            }
        }

        private void DGVPlaylistForm_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //using (var db = new everyloopContext())
            //{
            //    //måste kopplas ihop med CellContentClick
            //    var playlistTracks = (from t in db.Tracks
            //                          join pt in db.PlaylistTracks
            //                          on t.TrackId equals pt.TrackId
            //                          join p in db.Playlists
            //                          on pt.PlaylistId equals p.PlaylistId
            //                          select new
            //                          {
            //                              Name = t.Name,
            //                              Compser = t.Composer,
            //                              Length = t.Milliseconds,
            //                              AlbumId = t.AlbumId
            //                          }).ToList();

            //    DGVTracks.DataSource = playlistTracks;
            //}
        }

        private void DeletePlaylistButton_Click(object sender, EventArgs e)
        {

        }

        private void ViewTracksButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveTrackButton_Click(object sender, EventArgs e)
        {

        }

        private void AddTrackButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchTracksButton_Click(object sender, EventArgs e)
        {

        }
    }
}
