﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_Batch1_DET_2022
{
    internal class InvalidAgeException : Exception
    {
        public  InvalidAgeException(string msg) : base(msg){
            
        }
    }
}
