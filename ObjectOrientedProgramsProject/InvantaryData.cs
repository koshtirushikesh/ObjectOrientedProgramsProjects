﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramsProject
{
    public class InvantaryData
    {
        public List<TypesOfRice> typesOfRice;
        public List<TypesOfWheet> typesOfWheet;
        public List<TypesOfPulse> typesOfPulse;
    }

    public class TypesOfRice
    {
        public string name;
        public int weight;
        public int price;
    }

    public class TypesOfWheet
    {
        public string name;
        public int weight;
        public int price;
    }

    public class TypesOfPulse
    {
        public string name;
        public int weight;
        public int price;
    }
}
