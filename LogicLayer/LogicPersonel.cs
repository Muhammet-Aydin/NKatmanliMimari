using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DalPersonel.PersonelListesi();
        }
    }
}
