using System;
using System.Collections.Generic;

namespace To_Do_List
{
    public class Items
    {
        public int id {get; private set;}
        public string name {get; private set;}
        public Status status {get; private set;}

            public Items()
            {
                
            }

            public Items(string iName, Status iStatus)
            {
                this.name = iName;
                this.status = iStatus;
            }


    }




}