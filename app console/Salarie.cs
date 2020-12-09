using System;
using System.Collections.Generic;
using System.Text;

namespace app_console
{
    public class Salarie
    {
        public static int GlobalId { get; set; }
        public int Id { get; set; }

        public Salarie()
        {
            GlobalId++;
            Id = GlobalId;
        }
    }
}
