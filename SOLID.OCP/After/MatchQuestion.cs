﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.After
{
    internal class MatchQuestion : Question
    {
        public Dictionary<string, string> Rows =
            new Dictionary<string, string>();
        public override void Print()
        {
            Console.WriteLine($"{Title}[{Mark}]");
            foreach (var row in Rows)
            {
                Console.WriteLine($"{row.Key}              {row.Value}");
            }
        }
    }
}
