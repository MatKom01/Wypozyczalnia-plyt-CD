using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ProjektMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektMVC.Controllers
{
    public class CategoryController : Controller
    {
        public static List<Models.CD> dupListOfFilm = new List<Models.CD>();
       
        public IActionResult CategoryTemplate(string kat)
        {
            List<Models.CD> listOfFilm = new List<Models.CD>();

            string connectionString = "Server=localhost\\SQLExpress;Initial Catalog=CDDB;Integrated Security=True;TrustServerCertificate=True" ;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from CDs", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Models.CD cd = new Models.CD();

                cd.ID = Convert.ToInt32(reader["ID"]);
                cd.Title = reader["Title"].ToString();
                cd.Price = Convert.ToDouble(reader["Price"]);
                cd.Lenght = Convert.ToInt32(reader["Lenght"]);
                cd.Direction = reader["Direction"].ToString();
                cd.Scenario = reader["Scenario"].ToString();
                cd.Type = reader["Type"].ToString();
                cd.Production = reader["Production"].ToString();
                cd.Premiere = reader["Premiere"].ToString();
                cd.Picture = reader["Picture"].ToString();

                listOfFilm.Add(cd);
            }
            reader.Close();

            dupListOfFilm = listOfFilm;

            List<Models.CD> listOfCategory = new List<Models.CD>();

            foreach (var item in listOfFilm)
            {
                if(item.Type == kat)
                {
                    listOfCategory.Add(item);
                }
                    
            }

            return View(listOfCategory);
        }
    }
}
