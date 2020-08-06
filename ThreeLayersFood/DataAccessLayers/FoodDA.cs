using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayersFood.DataAccessLayers;

namespace ThreeLayersFood.DataAccessLayers
{
    class FoodDA
    {
        DataClassesFoodDataContext db = new DataClassesFoodDataContext();


        public void Insert_Food(Item food)
        {
            db.Items.InsertOnSubmit(food);
            db.SubmitChanges();

        }

        public void Update_Food(Item food)
        {
            var temp = (from m in db.Items where m.Food_ID == food.Food_ID select m).FirstOrDefault();
            temp.Name_Food = food.Name_Food;
            temp.Detail = food.Detail;
            temp.Price = food.Price;
            temp.Quantity = food.Quantity;
            temp.Unit = food.Unit;
            temp.Seller_ID = food.Seller_ID;
            db.SubmitChanges();

        }
        public List<Item> Select_Food()
        {
            List<Item> list_Food;
            return list_Food = (from m in db.Items select m).OrderBy(m => m.Food_ID).ToList();           

        }
        public void Delete_Food(Item food)
        {
            var temp = (from m in db.Items where m.Food_ID == food.Food_ID select m).FirstOrDefault();
            db.Items.DeleteOnSubmit(temp);
            db.SubmitChanges();
        }
    }
}
