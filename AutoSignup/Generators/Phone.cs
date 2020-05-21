﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSignup.Generators
{
    public static class Phone
    {
        private static Random random = new Random();

        public static string Generate()
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, 12)
              .Select(s => s[random.Next(s.Length)]).ToArray());

        }
    }
}
