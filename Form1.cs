using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.Windows.Forms;

namespace DatabaseSQLMusicApp
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource();

        List<Album> albums = new List<Album>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albums = albumsDAO.getAllAlbums();

            albumBindingSource.DataSource = albums;
            dataGridView1.DataSource = albumBindingSource;
            Dictionary<int,string>AlbumDic = new Dictionary<int, string>();
            for (int i = 0; i < albums.Count; i++) 
            {
                AlbumDic.Add(albums[i].ID, $"{albums[i].AlbumName} {albums[i].ID}");
            }
            comboBox1.DataSource = new BindingSource(AlbumDic, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albumBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);
            dataGridView1.DataSource = albumBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int rowClicked = dataGridView.CurrentRow.Index;
            String imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();
            pictureBox1.Load(imageURL);


            tracksBindingSource.DataSource = albums[rowClicked].Tracks;
            dataGridView2.DataSource = tracksBindingSource;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)(sender);
            int rowClicked = dataGridView.CurrentRow.Index;
            String videoURL = dataGridView.Rows[rowClicked].Cells[3].Value.ToString();
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(videoURL);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Album album = new Album
                {
                    AlbumName = txt_album.Text,
                    Artist = txt_artist.Text,
                    Year = Int32.Parse(txt_year.Text),
                    ImageURL = txt_imageurl.Text,
                    Description = txt_description.Text,
                };

                int albumID = Int32.Parse(label8.Text);

                AlbumsDAO albumsDAO = new AlbumsDAO();
                int result = albumsDAO.updateAlbum(album, albumID);
                checkBox1.Checked = false;
                MessageBox.Show(result + " album updated");
                txt_album.Text = "";
                txt_artist.Text = "";
                txt_year.Text = "";
                txt_imageurl.Text = "";
                txt_description.Text = "";
                label8.Text = "";
                dataGridView2.DataSource = null;
                albums = albumsDAO.getAllAlbums();
            }
            else
            {
                Album album = new Album
                {
                    AlbumName = txt_album.Text,
                    Artist = txt_artist.Text,
                    Year = Int32.Parse(txt_year.Text),
                    ImageURL = txt_imageurl.Text,
                    Description = txt_description.Text,
                };

                AlbumsDAO albumsDAO = new AlbumsDAO();
                int result = albumsDAO.addOneAlbum(album);
                MessageBox.Show(result + " new row(s) inserted");
                txt_album.Text = "";
                txt_artist.Text = "";
                txt_year.Text = "";
                txt_imageurl.Text = "";
                txt_description.Text = "";
                label8.Text = "";
                dataGridView2.DataSource = null;
                albums = albumsDAO.getAllAlbums();
            }
        }
        private void addTrack(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Track track = new Track
                {
                    Name = textBox6.Text,
                    Number = Int32.Parse(textBox5.Text),
                    VideoURL = textBox4.Text,
                    Lyrics = textBox3.Text,
                    AlbumID = (int)comboBox1.SelectedValue
                };
                int trackID = Int32.Parse(label11.Text);
                AlbumsDAO albumsDAO = new AlbumsDAO();
                int result = albumsDAO.updateOneTrack(track, trackID);
                MessageBox.Show(result + " new row(s) updated");
            }
            else
            {
                Track track = new Track
                {
                    Name = textBox6.Text,
                    Number = Int32.Parse(textBox5.Text),
                    VideoURL = textBox4.Text,
                    Lyrics = textBox3.Text,
                    AlbumID = (int)comboBox1.SelectedValue
                };
                AlbumsDAO albumsDAO = new AlbumsDAO();
                int result = albumsDAO.addOneTrack(track);
                MessageBox.Show(result + " new row(s) inserted");
            }
        }

        private void deleteTrack(object sender, EventArgs e)
        {
            int rowClicked = dataGridView2.CurrentRow.Index;
            int trackID = (int)dataGridView2.Rows[rowClicked].Cells[0].Value;

            AlbumsDAO albumsDao = new AlbumsDAO();
            int result = albumsDao.deleteTrack(trackID);
            dataGridView2.DataSource = null;
            albums = albumsDao.getAllAlbums();
        }

        private void updateAlbum(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            txt_album.Text = dataGridView1.Rows[rowClicked].Cells[1].Value.ToString();
            txt_artist.Text = dataGridView1.Rows[rowClicked].Cells[2].Value.ToString();
            txt_year.Text = dataGridView1.Rows[rowClicked].Cells[3].Value.ToString();
            txt_imageurl.Text = dataGridView1.Rows[rowClicked].Cells[4].Value.ToString();
            txt_description.Text = dataGridView1.Rows[rowClicked].Cells[5].Value.ToString();
            checkBox1.Checked = true;
            label8.Text = dataGridView1.Rows[rowClicked].Cells[0].Value.ToString();
        }

        private void updateTrack(object sender, EventArgs e)
        {
            int rowClicked = dataGridView2.CurrentRow.Index;
            textBox6.Text = dataGridView2.Rows[rowClicked].Cells[1].Value.ToString();
            textBox5.Text = dataGridView2.Rows[rowClicked].Cells[2].Value.ToString();
            textBox4.Text = dataGridView2.Rows[rowClicked].Cells[3].Value.ToString();
            textBox3.Text = dataGridView2.Rows[rowClicked].Cells[4].Value.ToString();
            checkBox2.Checked = true;
            label11.Text = dataGridView2.Rows[rowClicked].Cells[0].Value.ToString();
        }
    }
}
