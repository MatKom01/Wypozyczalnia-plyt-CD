using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjektMVC.Controllers
{
    public class BasketController : Controller
    {
        private List<int> basket = new List<int>();
        private string str = "E:\\Basket.xml";

        public IActionResult AddFilmToBasket(int filmID)
        {
            FileInfo file = new FileInfo(str);
            if (file.Exists)
            {
                basket = readXML();
            }
            
            foreach (var item in basket)
            {
                if (item == filmID)
                {
                    return Redirect(Request.Headers["Referer"].ToString());
                }
            }
            basket.Add(filmID);

            saveXML(basket);

            return Redirect(Request.Headers["Referer"].ToString());

        }

        public IActionResult BasketTemplate()
        {
            FileInfo file = new FileInfo(str);
            if (file.Exists)
            {
                basket = readXML();
            }

            List<Models.CD> films = new List<Models.CD>();

            foreach (var item in basket)
            {
                foreach (var index in CategoryController.dupListOfFilm)
                {
                    if(item == index.ID)
                    {
                        films.Add(index);
                        break;
                    }
                }
            }
            return View(films);
        }

        public IActionResult ClearBasket()
        {
            FileInfo file = new FileInfo(str);
            if (file.Exists)
            {
                basket = readXML();
            }

            basket.Clear();

            saveXML(basket);

            return Redirect(Request.Headers["Referer"].ToString());
        }

        public string Result()
        {
            string text = "Kupiono";
            return text;
        }

        private List<int> readXML()
        {
            XmlSerializer deser = new XmlSerializer(typeof(List<int>));
            FileStream stream = new FileStream("E:\\Basket.xml", FileMode.Open);
            List<int> film = (List<int>)deser.Deserialize(stream);
            stream.Close();
            return film;
        }

        private void saveXML(List<int> film)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<int>));
            TextWriter writer = new StreamWriter("E:\\Basket.xml");
            serializer.Serialize(writer, film);
            writer.Close();
        }

        

      
    }
}
