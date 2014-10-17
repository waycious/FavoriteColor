using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace FavoriteColor
{
    public class ColorModel
    {
        private SqlConnection _con = new SqlConnection("*");
        public List<Color> GetColors()
        {
            SqlCommand cmd = new SqlCommand("Select * FROM Colors", _con);
            _con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            List<Color> Colors = new List<Color>();
            while (rdr.Read())
            {
                Colors.Add(new Color(rdr[1].ToString(), rdr[2].ToString()));
            }
            _con.Close();
            return Colors;
        }

        public void AddColor(Color c)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Colors (color_name, color_value) VALUES ('" + c.Name + "', '" + c.Value + "')");
            _con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}