﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Training.Exceptions
{
   
        public class DuplicateNameException : Exception
        {
            public DuplicateNameException(string mess)
                : base(mess)
            {

            }
        }
    
}
