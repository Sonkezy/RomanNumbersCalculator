using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RomanNumbersCalculator.Models
{
    public class RomanNumber : ICloneable, IComparable
    {
        private ushort number = 1;

        public RomanNumber(ushort number)
        {
            this.number = number;
        }
        public RomanNumber(string number)
        {
            this.number = 0;
            Dictionary<char, ushort> map = new Dictionary<char, ushort>()
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 }
            };
            for (int i = 0; i < number.Length; i++)
            {
                if (i + 1 < number.Length && map[number[i]] < map[number[i + 1]])
                {
                    this.number -= map[number[i]];
                }
                else
                {
                    this.number += map[number[i]];
                }
            }
            if (this.number < 1 || this.number > 3999) throw new RomanNumberException("#ERROR");
            
        }
        public RomanNumber Add(RomanNumber romanNumber1, RomanNumber romanNumber2)
        {
            //RomanNumber romanNumber = new RomanNumber(romanNumber1.ToUint16());
            //return romanNumber;
            number = romanNumber1.number;
            number += romanNumber2.number;
            if (this.number < 1 || this.number > 3999) throw new RomanNumberException("#ERROR");
            return new RomanNumber(number);
        }
        public RomanNumber Sub(RomanNumber romanNumber1, RomanNumber romanNumber2)
        {
            number = romanNumber1.number;
            number -= romanNumber2.number;
            if (this.number < 1 || this.number > 3999) throw new RomanNumberException("#ERROR");
            return new RomanNumber(number);
        }
        public RomanNumber Mul(RomanNumber romanNumber1, RomanNumber romanNumber2)
        {
            number = romanNumber1.number;
            number = (ushort)(number * romanNumber2.number);
            if (this.number < 1 || this.number > 3999) throw new RomanNumberException("#ERROR");
            return new RomanNumber(number);
        }
        public RomanNumber Div(RomanNumber romanNumber1, RomanNumber romanNumber2)
        {
            number = romanNumber1.number;
            number = (ushort)(number / romanNumber2.number);
            if (this.number < 1 || this.number > 3999) throw new RomanNumberException("#ERROR");
            return new RomanNumber(number);
        }
        public override string ToString()
        {
            Dictionary<ushort, string> map = new Dictionary<ushort, string>()
            {
                { 1, "I" },
                { 4, "IV" },
                { 5, "V" },
                { 9, "IX" },
                { 10, "X" },
                { 40, "XL" },
                { 50, "L" },
                { 90, "XC" },
                { 100, "C" },
                { 400, "CD" },
                { 500, "D" },
                { 900, "CM" },
                { 1000, "M" }
            };
            string romanNumber = string.Empty;
            int tmp_number = number;
            //char previousLetter = 'M';
            foreach (var romanLetter in map.Reverse())
            {
                while (tmp_number >= romanLetter.Key)
                {
                    romanNumber += romanLetter.Value;
                    tmp_number -= romanLetter.Key;
                }
            }
            return romanNumber;
        }
        public ushort ToUint16()
        {
            return number;
        }
        public int CompareTo(object? o)
        {
            if (o is RomanNumber romanNumber) return number.CompareTo(romanNumber.number);
            else throw new RomanNumberException("#ERROR");
        }
        public object Clone()
        {
            return new RomanNumber(number);
        }
    }
}
