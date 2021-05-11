using DannyMarkusLabb3.Models;
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
            //using (var context = new everyloopContext())
            //{
            //    try
            //    {
            //        dataGridView1.DataSource = context.Playlists.ToList();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(Convert.ToString(ex));
            //    }

            //}
        }

        private void ViewPlaylistsbutton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-JP6OAR1\\SQLEXPRESS;Database=everyloop;Trusted_Connection=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM playlists", sqlConnection);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                DGVPlaylistForm.DataSource = dtbl;
            }
            //using (var db = new everyloopContext())
            //{
            //    var playlists = db.Playlists
            //     .Select(p =>
            //     new Playlist
            //     {
            //         PlaylistId = p.PlaylistId,
            //         Name = p.Name,
            //     }).ToList();

            //    DataTable dataTable = new DataTable();
            //    dataTable.Fill();

            //    //dataGridView1.DataSource = playlists;
            //    //foreach(var p in playlists)
            //    //{
            //    //    dataGridView1.DataSource = p;
            //    //}
            //}
        }
    }
}
