using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Room;
using System.Windows.Forms;


namespace ClassLibrary
{
    /*30. В базе данных недвижимости хранится информация о квартирах – район города (строка), количество комнат, общая площадь, 
    площадь кухни, стоимость. Для каждого района города найти самую дешевую квартиру с указанным кол-вом комнат N (задается) 
    и площадью не меньше S (также задается).*/
    public class Base
    {
        public List<Room> MainBase { get; set; }
        public Base()
        {
            MainBase = new List<Room>();
        }
        public void Add(Room NewRoom)
        {
            MainBase.Add(NewRoom);
        }

        public List<Room> Find(int N, double S) 
        {
            List<Room> basereturn = new List<Room>();
            for (int i = 0; i < MainBase.Count; i++)
            {
                if (MainBase[i].Nroom == N && MainBase[i].Smax >= S)
                {
                    bool flag = false;
                    for (int j = 0;
                        j < basereturn.Count; j++)
                    {
                        if (MainBase[i].name == basereturn[j].name)
                        {
                            if (MainBase[i].Price < basereturn[j].Price)
                            {
                                basereturn[j] = MainBase[i];
                            }
                            flag = true;
                        }
                        
                    }
                    if (!flag && MainBase[i].name != "")
                    {
                        basereturn.Add(MainBase[i]);
                    }
                }
            }
            return basereturn;
        }
        
    }
}
