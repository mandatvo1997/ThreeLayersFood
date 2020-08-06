using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayersFood.DataAccessLayers;
namespace ThreeLayersFood.BusinessLogicLayers
{
    class FoodBLL
    {
        DataClassesFoodDataContext db = new DataClassesFoodDataContext();
        FoodDA da = new FoodDA();
        public string new_ID()// tao ID moi
        {
            string temp;
            var list_id = (from m in db.Items select m).OrderBy(m => m.Food_ID).ToList();
            list_id = list_id.OrderBy(c => c.Food_ID.Length).ThenBy(c => c.Food_ID).ToList();

            if (list_id.Count <= 0)
            {
                return temp = "F0";
            }
            temp = list_id[list_id.Count - 1].Food_ID;

            string numeric = new String(temp.Where(Char.IsDigit).ToArray());
            temp = "F" + (int.Parse(numeric) + 1);
            return temp;
        }
        public int IsAvailable(string food_name)//kiem tra ten da ton tai hay chua
        {
            int IDCount = 0;
            var member = (from m in db.Items where m.Name_Food == food_name select m).FirstOrDefault();

            if (member == null)
                IDCount = 0;
            else IDCount = 1;
            return IDCount;
        }
        public bool Add_new(Item food)
        {
            food.Food_ID = new_ID();
            if (food.Name_Food == "") return false;
            if (food.Detail == "") return false;
            if (food.Price.ToString() == "") return false;
            if (food.Quantity.ToString() == "") return false;
            if (food.Unit == "") return false;
            if (food.Seller_ID == "") return false;

            if (IsAvailable(food.Name_Food) == 0)
            {
                da.Insert_Food(food);
                return true;
            }
            else return false;
        }
        public bool Delete_Food(Item food)
        {
            da.Delete_Food(food);
            return true;
        }
        public bool Update_Food(Item food)
        {
          
            if (food.Name_Food == "") return false;
            if (food.Detail == "") return false;
            if (food.Price.ToString() == "") return false;
            if (food.Quantity.ToString() == "") return false;
            if (food.Unit == "") return false;
            if (food.Seller_ID == "") return false;

           // if (IsAvailable(food.Name_Food) == 0)
          //  {
                da.Update_Food(food);
                return true;
           // }
          //  else return false;
        }
        public List<Item> Load_Item()
        {
            return da.Select_Food();
        }
    }
}
