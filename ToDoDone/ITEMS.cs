using System;
using System.Collections.Generic;

namespace To_Do_List
{
    //class for items
    public class Items
    {
        public int id {get; set;}
        public string name {get; set;}
        public Status status {get; set;}

            public Items()
            {
           //     
            }

            public Items(string iName, Status iStatus)
            {
                this.name = iName;
                this.status = iStatus;
            }


    }




}