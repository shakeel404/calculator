using System;
using System.Collections.Generic;
using System.Text;

namespace Speller
{
    public interface ISpellToText : ISpell
    {
        string UnitsToText(int number);

        string TeensToText(int number);

        string TensToText(int number);

        string HundredsToText(int number, out int remainder);

        string ThousandsToText(int number, out int remainder);

        string LacsToText(int number, out int remainder);

        string CroreToText(int number, out int remainder);

        string ArabToText(int number, out int remainder);
    }
}
