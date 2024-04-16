using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQLMusicApp
{
    internal class AlbumsDAO
    {
        string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");

        public List<Album> getAllAlbums()
        {
            List<Album> returnThese = new List<Album>();

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("SELECT ID, ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION from dbo.albums",connection);

            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        Artist = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),
                    };

                    a.Tracks = getTracksForAlbum(a.ID);

                    returnThese.Add(a);
                }
            }
            connection.Close();
            return returnThese;
        }

        public List<Album> searchTitles(String searchTerm)
        {
            List<Album> returnThese = new List<Album>();

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            String searchWildPhrase = "%" + searchTerm + "%";
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT ID, ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION from dbo.albums WHERE ALBUM_TITLE LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        Artist = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),
                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();

            return returnThese;
        }

        public int addOneAlbum(Album album)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            int lastAlbumId = 0;
            connection.Open();

            SqlCommand getLasAlbumCommand = new SqlCommand("SELECT TOP 1 ID FROM [music].[dbo].[albums] ORDER BY ID DESC", connection);

            using (SqlDataReader reader = getLasAlbumCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    lastAlbumId = reader.GetInt32(0);
                }
            }

            SqlCommand command = new SqlCommand("INSERT INTO [music].[dbo].[albums] (ID,ALBUM_TITLE,ARTIST,YEAR,IMAGE_NAME,DESCRIPTION) VALUES (@id,@albumtitle, @artist, @year, @imageURL, @description)", connection);
            command.Parameters.AddWithValue("@id", lastAlbumId + 1);
            command.Parameters.AddWithValue("@albumtitle", album.AlbumName);
            command.Parameters.AddWithValue("@artist", album.Artist);
            command.Parameters.AddWithValue("@year", album.Year);
            command.Parameters.AddWithValue("@imageURL", album.ImageURL);
            command.Parameters.AddWithValue("@description", album.Description);
            int newRows = command.ExecuteNonQuery();
            connection.Close();
            return newRows;
        }

        public int updateAlbum(Album album, int albumID) 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE [music].[dbo].[albums] SET ALBUM_TITLE = @albumtitle, ARTIST = @artist, YEAR = @year, IMAGE_NAME = @imageURL, DESCRIPTION = @description WHERE ID = @albumID", connection);
            command.Parameters.AddWithValue("@albumtitle", album.AlbumName);
            command.Parameters.AddWithValue("@artist", album.Artist);
            command.Parameters.AddWithValue("@year", album.Year);
            command.Parameters.AddWithValue("@imageURL", album.ImageURL);
            command.Parameters.AddWithValue("@description", album.Description);
            command.Parameters.AddWithValue("@albumID", albumID);
            int newRows = command.ExecuteNonQuery();
            connection.Close();
            return newRows;
        }

        public List<Track> getTracksForAlbum(int albumID)
        {
            List<Track> returnThese = new List<Track>();

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM TRACKS WHERE ALBUM_ID = @albumid";
            command.Parameters.AddWithValue("@albumid", albumID);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Track t = new Track
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Number = reader.GetInt32(2),
                        VideoURL = reader.GetString(3),
                        Lyrics = reader.GetString(4),
                    };
                    returnThese.Add(t);
                }
            }
            connection.Close();

            return returnThese;
        }

        public int deleteTrack(int trackID)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM TRACKS WHERE TRACKS.ID=@trackID", connection);
            command.Parameters.AddWithValue("@trackID", trackID);
            int newRows = command.ExecuteNonQuery();
            connection.Close();
            return newRows;
        }

        internal int addOneTrack(Track track)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            int lastTrackId = 0;
            connection.Open();

            SqlCommand getLasTrackCommand = new SqlCommand("SELECT TOP 1 ID FROM [music].[dbo].[tracks] ORDER BY ID DESC", connection);

            using (SqlDataReader reader = getLasTrackCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    lastTrackId = reader.GetInt32(0);
                }
            }

            SqlCommand command = new SqlCommand("INSERT INTO [music].[dbo].[tracks] (ID,TRACK_TITLE,TRACK_NUMBER,VIDEO_NAME,TRACK_LYRICS,ALBUM_ID) VALUES (@id,@tracktitle, @tracknumber, @videoname, @tracklyrics, @albumid)", connection);
            command.Parameters.AddWithValue("@id", lastTrackId + 1);
            command.Parameters.AddWithValue("@tracktitle", track.Name);
            command.Parameters.AddWithValue("@tracknumber", track.Number);
            command.Parameters.AddWithValue("@videoname", track.VideoURL);
            command.Parameters.AddWithValue("@tracklyrics", track.Lyrics);
            command.Parameters.AddWithValue("@albumid", track.AlbumID);
            int newRows = command.ExecuteNonQuery();
            connection.Close();
            return newRows;
        }

        internal int updateOneTrack(Track track, int trackID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE [music].[dbo].[tracks] SET TRACK_TITLE= @tracktitle, TRACK_NUMBER= @tracknumber, VIDEO_NAME = @videoname, TRACK_LYRICS = @tracklyrics, ALBUM_ID= @albumid WHERE ID = @trackID", connection);
            command.Parameters.AddWithValue("@tracktitle", track.Name);
            command.Parameters.AddWithValue("@tracknumber",track.Number);
            command.Parameters.AddWithValue("@videoname", track.VideoURL);
            command.Parameters.AddWithValue("@tracklyrics", track.Lyrics);
            command.Parameters.AddWithValue("@trackid", trackID);
            command.Parameters.AddWithValue("@albumID", track.AlbumID);
            int newRows = command.ExecuteNonQuery();
            connection.Close();
            return newRows;
        }
    }

}
