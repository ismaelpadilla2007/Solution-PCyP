﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.pcyp.BIZ
{   
    public class EntityBase
    {

        //prop
        public int Id
        {
            get; set;
        }
        public DateTime CreatedOn
        {
            get; set;
        }
        public int CreatedBy
        {
            get; set;
        }
        public DateTime ChangedOn
        {
            get; set;
        }
        public int ChangedBy
        {
            get; set;
        }
    }
}
