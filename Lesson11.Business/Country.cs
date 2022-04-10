﻿using System;

namespace Lesson11.Business
{
    public class Country
    {
        public string Code { get; }
        public string Name { get; }
   

        public Country(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
