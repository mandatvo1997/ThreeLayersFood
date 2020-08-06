using Food_Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Server
{
    public interface IFood
    {
        bool Add_new(Item food);
        bool Delete_Food(Item food);
        bool Update_Food(Item food);
        int TestNumber();
        List<Item> Load_Item();


    }
}
