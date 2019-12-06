
using System;

namespace CleanCode
{
    class Person
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public DateTime Birthdate { get; set; }
        public Genders? Gender { get; set; }
    }
}
