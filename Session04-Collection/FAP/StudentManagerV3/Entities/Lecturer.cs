﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Entities
{
    public class Lecturer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public int Salary { get; set; }
        public override string ToString() => $"Id: {Id} | Name: {Name} | Yob: {Yob} | Faculty: {Salary}";
        public void ShowProfile() => Console.WriteLine(ToString());
    }
}
