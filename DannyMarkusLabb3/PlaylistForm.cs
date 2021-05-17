using DannyMarkusLabb3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

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
                    CurrentPlaylistBox.DataSource = db.Playlists.ToList();
                    TrackPlaylistBox.DataSource = db.Playlists.ToList();

                    DGVPlaylistForm.DataSource = db.Playlists.ToList();
                    ShowAllTracks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
                CurrentPlaylistBox.Text = "Playlist";
                CurrentPlaylistBox.DisplayMember = "Name";
                CurrentPlaylistBox.ValueMember = "PlaylistId";

                TrackPlaylistBox.Text = "Playlist";
                TrackPlaylistBox.DisplayMember = "Name";
                TrackPlaylistBox.ValueMember = "PlaylistId";
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
                if (db.Playlists.Any(x => x.Name.ToLower() == NewPlaylistNameBox.Text.ToLower()))
                {
                    MessageBox.Show("Playlist already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                var plId = db.Playlists.Max(x => x.PlaylistId) + 1;
                var newPlaylist = new Playlist()
                {
                    PlaylistId = plId,
                    Name = NewPlaylistNameBox.Text,
                };

                db.Add(newPlaylist);
                db.SaveChanges();
                UpdateForm();
            }
        }

        private void DGVPlaylistForm_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (var db = new everyloopContext())
            {
                if (!int.TryParse(DGVPlaylistForm.Rows[e.RowIndex].Cells["PlaylistId"].Value.ToString(), out int playlistId))
                {
                    return;
                }

                var playlistTracks = db.PlaylistTracks
                    .Where(x => x.PlaylistId == playlistId)
                    .Include(x => x.Playlist)
                    .Include(x => x.Track).ThenInclude(x => x.Album)
                                          .ThenInclude(x => x.Artist)
                    .Include(x => x.Track).ThenInclude(x => x.Genre);


                DGVTracks.DataSource = playlistTracks.Select(x => new
                {
                    Name = x.Track.Name,
                    Artist = x.Track.Album.Artist.Name ?? "No artist",
                    Album = x.Track.Album.Title,
                    Genre = x.Track.Genre.Name
                }).ToList();
            }
        }

        private void DeletePlaylistButton_Click(object sender, EventArgs e)
        {
            using (var db = new everyloopContext())
            {
                var item = CurrentPlaylistBox.SelectedValue;
                var id = Convert.ToInt32(item);

                var playlist = db.Playlists.SingleOrDefault(x => x.PlaylistId == id);
                var playlistTracks = db.PlaylistTracks.Where(x => x.PlaylistId == id);

                if (playlist == null)
                {
                    MessageBox.Show("Playlist already removed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.PlaylistTracks.RemoveRange(playlistTracks);
                db.Playlists.Remove(playlist);
                db.SaveChanges();
                UpdateForm();
            }
        }

        private void ViewTracksButton_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(CurrentPlaylistBox.SelectedValue);
            var tracks = new List<(Track track, Artist artist)>();
            
            using (var db = new everyloopContext()) 
            {
                var playlistTracks = db.PlaylistTracks
                    .Where(x => x.PlaylistId == id)
                    .Include(x => x.Playlist)
                    .Include(x => x.Track).ThenInclude(x => x.Album)
                                          .ThenInclude(x => x.Artist)
                    .Include(x => x.Track).ThenInclude(x => x.Genre);
                    

                DGVPlaylistForm.DataSource = playlistTracks.Select(x => new
                {
                    Name = x.Track.Name,
                    Artist = x.Track.Album.Artist.Name ?? "No artist",
                    Album = x.Track.Album.Title,
                    Genre = x.Track.Genre.Name
                }).ToList();
            }
        }

        private void RemoveTrackButton_Click(object sender, EventArgs e)
        {
            using (var db = new everyloopContext())
            {
                var trackName = db.Tracks.SingleOrDefault(x => x.Name.ToLower() == TrackNameBox.Text.ToLower());
                if(trackName == null)
                {
                    MessageBox.Show("Could not find track", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var id = Convert.ToInt32(TrackPlaylistBox.SelectedValue);
                var trackNameId = trackName.TrackId;
                PlaylistTrack playlistTrack = db.PlaylistTracks.SingleOrDefault(x => x.TrackId == trackNameId && x.PlaylistId == id);

                if (playlistTrack == null)
                {
                    MessageBox.Show("Track already removed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.PlaylistTracks.Remove(playlistTrack); 
                db.SaveChanges();
            }
        }

        private void AddTrackButton_Click(object sender, EventArgs e)
        {
            using (var db = new everyloopContext())
            {
                var trackName = db.Tracks.SingleOrDefault(x => x.Name.ToLower() == TrackNameBox.Text.ToLower());
                if (trackName == null)
                {
                    MessageBox.Show("Could not find track", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var id = Convert.ToInt32(TrackPlaylistBox.SelectedValue);
                var trackNameId = trackName.TrackId;
                PlaylistTrack playlistTrack = db.PlaylistTracks.SingleOrDefault(x => x.TrackId == trackNameId && x.PlaylistId == id);

                if (playlistTrack != null)
                {
                    MessageBox.Show("Track already added", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.PlaylistTracks.Add(new PlaylistTrack { PlaylistId = id, TrackId = trackNameId });
                db.SaveChanges();
                
            }
        }

        private void SearchTracksButton_Click(object sender, EventArgs e)
        {
             using (var db = new everyloopContext())
            {
                var tracks = (from t in db.Tracks
                              where t.Name.ToLower() == SearchTracksBox.Text
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
                    DGVTracks.DataSource = tracks;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
        }

        private void ViewAllTracksButton_Click(object sender, EventArgs e)
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
                    DGVTracks.DataSource = tracks;
                }
                catch (Exception)
                {

                    MessageBox.Show("Could not find data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void UpdateForm()
        {
            using (var db = new everyloopContext())
            {
                CurrentPlaylistBox.DataSource = db.Playlists.ToList();
                TrackPlaylistBox.DataSource = db.Playlists.ToList();

                DGVPlaylistForm.DataSource = db.Playlists.ToList();
            }
        }

        public void ShowAllTracks() 
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


                DGVTracks.DataSource = tracks;


            }
        }
       
    }

}
