using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Db.Entities
{
    public class User
    {
        public int UserId { get; set; }

        public string Name { set; get; }

        public string Adress { get; set; }

        public string contact { get; set; }
    }
}
