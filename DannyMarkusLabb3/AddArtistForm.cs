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
            //using(var context = new everyloopContext())
            //{
            //    try
            //    {
            //        dataGridView1.DataSource = context.Artists.ToList();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(Convert.ToString(ex));
            //    }
                
            //}
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
