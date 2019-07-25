using System;
using System.Text.RegularExpressions;

namespace Speller
{
    public class SpellToText : ISpellToText
    {
        private const int TENS = 10;
        private const int HUNDREDS = TENS * TENS;
        private const int THOUSANDS = HUNDREDS * TENS;
        private const int LACS = HUNDREDS * THOUSANDS;
        private const int CRORES = HUNDREDS * LACS;
        private const int ARABS = HUNDREDS * CRORES;

        private const string HUNDRED = "hundred";
        private const string THOUSAND = "thousand";
        private const string LAC = "lac";
        private const string CRORE = "crore";
        private const string ARAB = "arab";
        private const string kharab = "kharab";

        public string UnitsToText(int number)
        {
            if (number == 1)
                return "one";
            if (number == 2)
                return "two";
            if (number == 3)
                return "three";
            if (number == 4)
                return "four";
            if (number == 5)
                return "five";
            if (number == 6)
                return "six";
            if (number == 7)
                return "seven";
            if (number == 8)
                return "eight";
            if (number == 9)
                return "nine";
            else
                return string.Empty;
        }

        public string TeensToText(int number)
        {
            if (number == 10)
                return "ten";
            if (number == 11)
                return "eleven";
            if (number == 12)
                return "twelve";
            if (number == 13)
                return "thirteen";
            if (number == 14)
                return "fourteen";
            if (number == 15)
                return "fifteen";
            if (number == 16)
                return "sixteen";
            if (number == 17)
                return "seventeen";
            if (number == 18)
                return "eighteen";
            if (number == 19)
                return "nineteen";
            else
                return string.Empty;
        }

        public string TensToText(int number)
        {
            var remainder = number % TENS;
            var ty = number - remainder;

            var text = string.Empty;

            if (ty == 20)
                text = "twenty";
            if (ty == 30)
                text = "thirty";
            if (ty == 40)
                text = "forty";
            if (ty == 50)
                text = "fifty";
            if (ty == 60)
                text = "sixty";
            if (ty == 70)
                text = "seventy";
            if (ty == 80)
                text = "eighty";
            if (ty == 90)
                text = "ninety";

            return $"{text} {SpellRemainder(remainder)}".Trim();

        }

        public string HundredsToText(int number, out int remainder)
        {
            var _remainder = number % HUNDREDS;

            var hundreds = number - _remainder;
            var units = hundreds / HUNDREDS;

            remainder = _remainder;
            return SpellUnitify(units, HUNDRED);

        }

        public string ThousandsToText(int number, out int remainder)
        {
            var _remainder = number % THOUSANDS;
            var thousand = number - _remainder;

            var units = thousand / THOUSANDS;
            remainder = _remainder;
            return SpellUnitify(units, THOUSAND);

        }

        public string LacsToText(int number, out int remainder)
        {
            var _remainder = number % LACS;
            var lacs = number - _remainder;

            var units = lacs / LACS;

            remainder = _remainder;
            return SpellUnitify(units, LAC);

        }

        public string CroreToText(int number, out int remainder)
        {

            var _remainder = number % CRORES;
            var crores = number - _remainder;

            var units = crores / CRORES;
            remainder = _remainder;
            return SpellUnitify(units, CRORE);
        }

        public string ArabToText(int number, out int remainder)
        {
            var _remainder = number % ARABS;
            var arabs = number - _remainder;

            var units = arabs / ARABS;
            remainder = _remainder;
            return SpellUnitify(units, ARAB);
        }

        private string SpellUnitify(int units, string name)
        {

            if (units >= 20)
                return $"{TensToText(units)} {name}";
            else if (units >= 10)
                return $"{TeensToText(units)} {name}";
            else if (units > 0)
                return $"{UnitsToText(units)} {name}";
            else
                return string.Empty;
        }

        private string SpellRemainder(int remainder)
        {
            //if (remainder >= CRORES)
            //    return CroreToText(remainder);
            //if (remainder >= LACS)
            //    return LacsToText(remainder);
            //if (remainder >= THOUSANDS)
            //    return ThousandsToText(remainder);
            //if (remainder >= HUNDREDS)
            //    return HundredsToText(remainder);
            //if (remainder >= 20)
            //    return TensToText(remainder);
            //if (remainder >= TENS)
            //    return TeensToText(remainder);
            //if (remainder > 0)
            return UnitsToText(remainder);

            // return string.Empty;
        }

        public string Spell(int number)
        {
            var _remainder = 0;
            if (number < 0)
                throw new NegativeIntegerException();
            else if (number == 0)
                return "zero";
            else
            {
                if (number <= 9)
                    return UnitsToText(number);
                else if (number <= 19)
                    return TeensToText(number);
                else if (number <= 99)
                    return TensToText(number);
                else if (number <= 999)
                    return $"{HundredsToText(number, out _remainder)} {(_remainder > 0 ? Spell(_remainder) : string.Empty)} ".Trim();
                else if (number <= 99999)
                    return $"{ThousandsToText(number, out _remainder)} {(_remainder > 0 ? Spell(_remainder) : string.Empty)} ".Trim();
                else if (number <= 9999999)
                    return $"{LacsToText(number, out _remainder)} {(_remainder > 0 ? Spell(_remainder) : string.Empty)} ".Trim();
               else if (number <= 999999999)
                    return $"{CroreToText(number, out _remainder)} {(_remainder > 0 ? Spell(_remainder) : string.Empty)} ".Trim();
               else if (number <= int.MaxValue)
                    return $"{ArabToText(number, out _remainder)} {(_remainder > 0 ? Spell(_remainder) : string.Empty)} ".Trim();
                else
                    return string.Empty;

            }
        }

        public string Spell(int number, string trail)
        {
            return $"{Spell(number)} {trail}".Trim();
        }

        public string SpellAnd(int number)
        {

            // var text = Spell(number);

            // if (text.EndsWith(HUNDRED))
            // {
            //     var and = $"and {HUNDRED}";

            //     text = text.Replace(HUNDRED, and);
            // }
            // else if (text.EndsWith(THOUSAND))
            // {
            //     var and = $"and {THOUSAND}";

            //     text = text.Replace(THOUSAND, and);
            // }
            //  else if (text.EndsWith(LAC))
            // {
            //     var and = $"and {LAC}";

            //     text = text.Replace(LAC, and);
            // }


            //return Regex.Replace(text, @"\s+", " "); 

            var _remainder = 0;
            if (number < 0)
                throw new NegativeIntegerException();
            else if (number == 0)
                return "zero";
            else
            {
                var text = string.Empty;
                if (number <= 9)
                {
                    text = UnitsToText(number);
                }
                else if (number <= 19)
                {
                    text = TeensToText(number);
                }
                else if (number <= 99)
                {
                    text = TensToText(number);
                }
                else if (number <= 999)
                {
                    var hundredsText = HundredsToText(number, out _remainder);

                    var and = string.Empty;
                    if (_remainder > 0)
                        and = "and";
                    text = $"{hundredsText} {and} {(_remainder > 0 ? SpellAnd(_remainder) : string.Empty)} ".Trim();
                }
                else if (number <= 99999)
                {
                    var thousandsText = ThousandsToText(number, out _remainder);

                    var and = string.Empty;
                    if ((_remainder > 0 && _remainder % HUNDREDS == 0) || (_remainder > 0 && _remainder < HUNDREDS))
                        and = "and";

                    text = $"{thousandsText} {and} {(_remainder > 0 ? SpellAnd(_remainder) : string.Empty)} ".Trim();
                }
                else if (number <= 9999999)
                {
                    var lacsText = LacsToText(number, out _remainder);

                    var and = string.Empty;

                    if ((_remainder > 0 && _remainder % HUNDREDS == 0) || (_remainder > 0 && _remainder < HUNDREDS))
                        and = "and";

                    text = $"{lacsText} {and} {(_remainder > 0 ? SpellAnd(_remainder) : string.Empty)} ".Trim();
                }
                else if (number <= 999999999)
                {
                    var croresText = CroreToText(number, out _remainder);
                    var and = string.Empty;

                    //10100100
                    //100100

                    if ((_remainder > 0 && _remainder % HUNDREDS == 0 && !(_remainder%LACS>0)) || (_remainder > 0 && _remainder < HUNDREDS))
                        and = "and";

                    text = $"{croresText} {and} {(_remainder > 0 ? SpellAnd(_remainder) : string.Empty)} ".Trim();
                }
                else if (number <= int.MaxValue)
                {
                    text = $"{ArabToText(number, out _remainder)} {(_remainder > 0 ? SpellAnd(_remainder) : string.Empty)} ".Trim();
                }

                return Regex.Replace(text, @"\s+", " ");
            }
        }
    }
}
