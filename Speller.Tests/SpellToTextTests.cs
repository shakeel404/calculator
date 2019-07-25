using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Speller;
namespace Speller.Tests
{
    [TestFixture]
    public class SpellToTextTests
    {
        [TestCase(1,"one")]
        [TestCase(2,"two")]
        [TestCase(3,"three")]
        [TestCase(4,"four")]
        [TestCase(5,"five")]
        [TestCase(6,"six")]
        [TestCase(7,"seven")] 
        [TestCase(8,"eight")] 
        [TestCase(9,"nine")] 
        public void UnitsToText_Should_Return_ValidText(int number,string text)
        {
            //Arrange
            var spltotxt = new SpellToText();

            //Act
            var _text = spltotxt.UnitsToText(number);

            //Assert
            Assert.AreEqual(text,_text);
        }

        [TestCase(11, "eleven")]
        [TestCase(12, "twelve")]
        [TestCase(13, "thirteen")]
        [TestCase(14, "fourteen")]
        [TestCase(15, "fifteen")]
        [TestCase(16, "sixteen")]
        [TestCase(17, "seventeen")]
        [TestCase(18, "eighteen")]
        [TestCase(19, "nineteen")]
        public void TeensToText_Should_Return_ValidText(int number, string text)
        {
            //Arrange
            var spltotxt = new SpellToText();

            //Act
            var _text = spltotxt.TeensToText(number);

            //Assert
            Assert.AreEqual(text, _text);
        }

        [TestCase(20,"twenty")] 
        [TestCase(30,"thirty")] 
        [TestCase(40,"forty")] 
        [TestCase(50,"fifty")] 
        [TestCase(60,"sixty")] 
        [TestCase(70,"seventy")] 
        [TestCase(80,"eighty")] 
        [TestCase(90,"ninety")] 
        public void TensToText_Should_Return_ValidText(int number, string text)
        {
            //Arrange
            var spltotxt = new SpellToText();

            //Act 
            var _text = spltotxt.TensToText(number);

            //Assert
            Assert.AreEqual(text, _text);
        }

         
        [TestCase(100, "one hundred")]
        [TestCase(200, "two hundred")] 
        [TestCase(300, "three hundred")]
        [TestCase(400, "four hundred")] 
        [TestCase(500, "five hundred")]
        [TestCase(600, "six hundred")]
        [TestCase(700, "seven hundred")]
        [TestCase(800, "eight hundred")]
        [TestCase(900, "nine hundred")]
        public void HoundredsToText_Should_Return_ValidText(int number, string text)
        {
            //Arrange
            var spltotxt = new SpellToText();

            //Act
            var remainder = 0;
            var _text = spltotxt.HundredsToText(number,out remainder);

            //Assert
            Assert.AreEqual(text, _text);
        }

        [TestCase(1000, "one thousand")]
        [TestCase(2000, "two thousand")]
        [TestCase(3000, "three thousand")]
        [TestCase(33000, "thirty three thousand")]
        [TestCase(4000, "four thousand")]
        [TestCase(5000, "five thousand")]
        [TestCase(6000, "six thousand")]
        [TestCase(7000, "seven thousand")]
        [TestCase(8000, "eight thousand")]
        [TestCase(9000, "nine thousand")]
        [TestCase(10000, "ten thousand")]
        [TestCase(15000, "fifteen thousand")]
        [TestCase(99000, "ninety nine thousand")] 
        public void ThousandsToText_Should_Return_ValidText(int number, string text)
        {
            //Arrange
            var spltotxt = new SpellToText();

            //Act
            var remainder = 0;
            var _text = spltotxt.ThousandsToText(number,out remainder);

            //Assert
            Assert.AreEqual(text, _text);
        }

        [TestCase(100000, "one lac")]
        [TestCase(200000, "two lac")]
        [TestCase(300000, "three lac")]
        [TestCase(400000, "four lac")]
        [TestCase(500000, "five lac")]
        [TestCase(5500000, "fifty five lac")]
        [TestCase(600000, "six lac")]
        [TestCase(700000, "seven lac")]
        [TestCase(800000, "eight lac")]
        [TestCase(900000, "nine lac")]
        [TestCase(1000000, "ten lac")]
        [TestCase(1500000, "fifteen lac")]
        [TestCase(9900000, "ninety nine lac")]
        public void LacsToText_Should_Return_ValidText(int number, string text)
        {
            //Arrange
            var spltotxt = new SpellToText();

            //Act
            var remainder = 0;
            var _text = spltotxt.LacsToText(number,out remainder);

            //Assert
            Assert.AreEqual(text, _text);
        }

        [TestCase(10000000, "one crore")]
        [TestCase(20000000, "two crore")]
        [TestCase(30000000, "three crore")]
        [TestCase(40000000, "four crore")]
        [TestCase(50000000, "five crore")]
        [TestCase(60000000, "six crore")]
        [TestCase(70000000, "seven crore")]
        [TestCase(80000000, "eight crore")]
        [TestCase(90000000, "nine crore")]
        [TestCase(100000000, "ten crore")]
        [TestCase(150000000, "fifteen crore")]
        [TestCase(770000000, "seventy seven crore")]
        [TestCase(990000000, "ninety nine crore")]
        public void CroreToText_Should_Return_ValidText(int number, string text)
        {
            //Arrange
            var spltotxt = new SpellToText();

            //Act
            var _remainder = 0;
            var _text = spltotxt.CroreToText(number,out _remainder);

            //Assert
            Assert.AreEqual(text, _text);
        }

        [TestCase(1000000000, "one arab")]
        [TestCase(2000000000, "two arab")]
        public void ArabToText_Should_Return_ValidText(int number, string text)
        {
            //Arrange
            var spltotxt = new SpellToText();

            //Act
            var _remainder = 0;
            var _text = spltotxt.ArabToText(number,out _remainder);

            //Assert
            Assert.AreEqual(text, _text);
        }

        [Ignore("not ready")]
        [TestCase(2147483648,"")]
        [TestCase(21474836471,"")]
        [TestCase(123456789012,"")]
        public void ArabToText_Should_ThrowArgumentOutOfRangeException(Int64 number,string text)
        {
            //Arrange
            var spltotxt = new SpellToText();

            //Act
            var _remainder = 0;
            var _text = spltotxt.ArabToText((int)number,out _remainder);

            //Assert
            Assert.AreEqual(text, _text);
        }


        [TestCase(1, "one")]
        [TestCase(2, "two")]
        [TestCase(3, "three")]
        [TestCase(4, "four")]
        [TestCase(5, "five")]
        [TestCase(6, "six")]
        [TestCase(7, "seven")]
        [TestCase(8, "eight")]
        [TestCase(9, "nine")]
        [TestCase(11, "eleven")]
        [TestCase(12, "twelve")]
        [TestCase(13, "thirteen")]
        [TestCase(14, "fourteen")]
        [TestCase(15, "fifteen")]
        [TestCase(16, "sixteen")]
        [TestCase(17, "seventeen")]
        [TestCase(18, "eighteen")]
        [TestCase(19, "nineteen")]
        [TestCase(20, "twenty")]
        [TestCase(21, "twenty one")]
        [TestCase(38, "thirty eight")]
        [TestCase(49, "forty nine")]
        [TestCase(99, "ninety nine")]
        [TestCase(59, "fifty nine")]
        [TestCase(75, "seventy five")]
        [TestCase(70, "seventy")]
        [TestCase(80, "eighty")]
        [TestCase(82, "eighty two")]
        [TestCase(95, "ninety five")]
        [TestCase(33, "thirty three")]
        [TestCase(100, "one hundred")]
        [TestCase(101, "one hundred one")]
        [TestCase(110, "one hundred ten")]
        [TestCase(109, "one hundred nine")]
        [TestCase(117, "one hundred seventeen")]
        [TestCase(138, "one hundred thirty eight")]
        [TestCase(258, "two hundred fifty eight")]
        [TestCase(793, "seven hundred ninety three")]
        [TestCase(999, "nine hundred ninety nine")]
        [TestCase(563, "five hundred sixty three")]
        [TestCase(900, "nine hundred")]
        [TestCase(333, "three hundred thirty three")]
        [TestCase(400, "four hundred")]
        [TestCase(1000, "one thousand")]
        [TestCase(1001, "one thousand one")]
        [TestCase(1101, "one thousand one hundred one")]
        [TestCase(1673, "one thousand six hundred seventy three")]
        [TestCase(1889, "one thousand eight hundred eighty nine")]
        [TestCase(1234, "one thousand two hundred thirty four")]
        [TestCase(5555, "five thousand five hundred fifty five")]
        [TestCase(9999, "nine thousand nine hundred ninety nine")]
        [TestCase(1047, "one thousand forty seven")]
        [TestCase(10000, "ten thousand")]
        [TestCase(11111, "eleven thousand one hundred eleven")]
        [TestCase(99999, "ninety nine thousand nine hundred ninety nine")]
        [TestCase(12345, "twelve thousand three hundred forty five")]
        [TestCase(98765, "ninety eight thousand seven hundred sixty five")]
        [TestCase(100000, "one lac")]
        [TestCase(100001, "one lac one")]
        [TestCase(100010, "one lac ten")]
        [TestCase(100100, "one lac one hundred")]
        [TestCase(101000, "one lac one thousand")]
        [TestCase(110000, "one lac ten thousand")]
        [TestCase(123456, "one lac twenty three thousand four hundred fifty six")]
        [TestCase(123456, "one lac twenty three thousand four hundred fifty six")]
        [TestCase(123456, "one lac twenty three thousand four hundred fifty six")]
        [TestCase(999999, "nine lac ninety nine thousand nine hundred ninety nine")]
        [TestCase(111111, "one lac eleven thousand one hundred eleven")]
        [TestCase(1000000, "ten lac")]
        [TestCase(1000001, "ten lac one")]
        [TestCase(1111111, "eleven lac eleven thousand one hundred eleven")]
        [TestCase(9999999, "ninety nine lac ninety nine thousand nine hundred ninety nine")]
        [TestCase(1234567, "twelve lac thirty four thousand five hundred sixty seven")]
        [TestCase(9876543, "ninety eight lac seventy six thousand five hundred forty three")]
        [TestCase(10000000, "one crore")]
        [TestCase(10000001, "one crore one")]
        [TestCase(12345678, "one crore twenty three lac forty five thousand six hundred seventy eight")]
        [TestCase(98765432, "nine crore eighty seven lac sixty five thousand four hundred thirty two")]
        [TestCase(11111111, "one crore eleven lac eleven thousand one hundred eleven")]
        [TestCase(99999999, "nine crore ninety nine lac ninety nine thousand nine hundred ninety nine")]
        [TestCase(100000000, "ten crore")]
        [TestCase(123456789, "twelve crore thirty four lac fifty six thousand seven hundred eighty nine")]
        [TestCase(987654321, "ninety eight crore seventy six lac fifty four thousand three hundred twenty one")]
        [TestCase(111111111, "eleven crore eleven lac eleven thousand one hundred eleven")]
        [TestCase(100110111, "ten crore one lac ten thousand one hundred eleven")]
        [TestCase(111001000, "eleven crore ten lac one thousand")]
        [TestCase(999999999, "ninety nine crore ninety nine lac ninety nine thousand nine hundred ninety nine")]
        [TestCase(1000000000, "one arab")]
        [TestCase(2000000000, "two arab")]
        [TestCase(1987654321, "one arab ninety eight crore seventy six lac fifty four thousand three hundred twenty one")]
        [TestCase(0, "zero")]
        [TestCase(000001, "one")]
        public void Spell_Should_Return_ValidText(int number, string text)
        {
            //Arrange
            var spltotxt = new SpellToText();

            //Act
            var _text = spltotxt.Spell(number);

            //Assert
            Assert.AreEqual(text, _text);
        }

        [Test]
        public void NegativeNumber_Should_ThrowException()
        {
            //Arrange
            var spltotxt = new SpellToText();

            //Act Assert
            Assert.Throws(typeof(NegativeIntegerException), delegate { spltotxt.Spell(-1); });
        }

         
        [TestCase(1,"one", "only")]
        [TestCase(11,"eleven", "rupees")]
        [TestCase(123456,"one lac twenty three thousand four hundred fifty six","marks")]
        public void SpellTrail_Should_Return_ValidText(int number,string text,string trail)
        {
            //Arrange
            var spltotxt = new SpellToText();

            //Act
            var _text = spltotxt.Spell(number,trail);

            //Assert
            Assert.AreEqual($"{text} {trail}", _text);
        }

         
        //[TestCase(101, "one hundred and one")]
        //[TestCase(115, "one hundred and fifteen")]
        //[TestCase(148, "one hundred and forty eight")]
        //[TestCase(1164, "one thousand one hundred and sixty four")]
        //[TestCase(1264, "one thousand two hundred and sixty four")]
        //[TestCase(9999, "nine thousand nine hundred and ninety nine")]
        //[TestCase(99876, "ninety nine thousand eight hundred and seventy six")]
        //[TestCase(16164, "sixteen thousand one hundred and sixty four")]
        //[TestCase(10100, "ten thousand and one hundred")] 
        //[TestCase(10101, "ten thousand one hundred and one")] 
        //[TestCase(123456, "one lac twenty three thousand four hundred and fifty six")] 
        //[TestCase(123400, "one lac twenty three thousand and four hundred")] 
        //[TestCase(123401, "one lac twenty three thousand four hundred and one")] 
        //[TestCase(100000, "one lac")]  
        //[TestCase(130000, "one lac and thirty thousand")]  
        //[TestCase(102681, "one lac two thousand six hundred and eighty one")] 
        //[TestCase(123000, "one lac and twenty three thousand")] 
        //[TestCase(100001, "one lac and one")] 
        //[TestCase(123571, "one lac twenty three thousand five hundred and seventy one")] 
        //[TestCase(123012, "one lac twenty three thousand and twelve")] 
        //[TestCase(100039, "one lac and thirty nine")] 
        [TestCase(1,"one")]
        [TestCase(13,"thirteen")]
        [TestCase(77,"seventy seven")]
        [TestCase(100,"one hundred")] 
        [TestCase(101,"one hundred and one")] 
        [TestCase(113,"one hundred and thirteen")] 
        [TestCase(177,"one hundred and seventy seven")] 
        [TestCase(1000,"one thousand")]
        [TestCase(1001,"one thousand and one")]
        [TestCase(1011,"one thousand and eleven")]
        [TestCase(1021,"one thousand and twenty one")]
        [TestCase(1100,"one thousand and one hundred")]
        [TestCase(1101,"one thousand one hundred and one")]
        [TestCase(1110,"one thousand one hundred and ten")]
        [TestCase(1111,"one thousand one hundred and eleven")]
        [TestCase(1121,"one thousand one hundred and twenty one")]
        [TestCase(10000,"ten thousand")] 
        [TestCase(10001,"ten thousand and one")] 
        [TestCase(10011,"ten thousand and eleven")] 
        [TestCase(10021,"ten thousand and twenty one")] 
        [TestCase(10101,"ten thousand one hundred and one")] 
        [TestCase(10111,"ten thousand one hundred and eleven")] 
        [TestCase(10121,"ten thousand one hundred and twenty one")] 
        [TestCase(10100,"ten thousand and one hundred")] 
        [TestCase(21000,"twenty one thousand")] 
        [TestCase(21001,"twenty one thousand and one")] 
        [TestCase(21011,"twenty one thousand and eleven")] 
        [TestCase(21021,"twenty one thousand and twenty one")] 
        [TestCase(21121,"twenty one thousand one hundred and twenty one")] 
        [TestCase(100000,"one lac")] 
        [TestCase(100001,"one lac and one")] 
        [TestCase(100011,"one lac and eleven")] 
        [TestCase(100021,"one lac and twenty one")] 
        [TestCase(100100,"one lac and one hundred")] 
        [TestCase(100101,"one lac one hundred and one")] 
        [TestCase(100111,"one lac one hundred and eleven")] 
        [TestCase(100121,"one lac one hundred and twenty one")] 
        [TestCase(101000,"one lac and one thousand")] 
        [TestCase(101001,"one lac one thousand and one")] 
        [TestCase(101011,"one lac one thousand and eleven")] 
        [TestCase(101021,"one lac one thousand and twenty one")] 
        [TestCase(101121,"one lac one thousand one hundred and twenty one")] 
        [TestCase(111121,"one lac eleven thousand one hundred and twenty one")] 
        [TestCase(121121,"one lac twenty one thousand one hundred and twenty one")] 
        [TestCase(1021121,"ten lac twenty one thousand one hundred and twenty one")] 
        [TestCase(2021121,"twenty lac twenty one thousand one hundred and twenty one")] 
        [TestCase(2121121,"twenty one lac twenty one thousand one hundred and twenty one")] 
        [TestCase(10000000,"one crore")] 
        [TestCase(10000001,"one crore and one")] 
        [TestCase(10000011,"one crore and eleven")] 
        [TestCase(10000021,"one crore and twenty one")] 
        [TestCase(10000100,"one crore and one hundred")] 
        [TestCase(10000101,"one crore one hundred and one")] 
        [TestCase(10000111,"one crore one hundred and eleven")] 
        [TestCase(10000121,"one crore one hundred and twenty one")] 
        [TestCase(10100001, "one crore one lac and one")]
        [TestCase(10100011, "one crore one lac and eleven")]
        [TestCase(10100021, "one crore one lac and twenty one")]
        [TestCase(10100100, "one crore one lac and one hundred")]
        [TestCase(10100101, "one crore one lac one hundred and one")]
        [TestCase(10100111, "one crore one lac one hundred and eleven")]
        [TestCase(10100121, "one crore one lac one hundred and twenty one")]
        [TestCase(10101000, "one crore one lac and one thousand")]
        [TestCase(10101001, "one crore one lac one thousand and one")]
        [TestCase(10101011, "one crore one lac one thousand and eleven")]
        [TestCase(10101021, "one crore one lac one thousand and twenty one")]
        [TestCase(10101121, "one crore one lac one thousand one hundred and twenty one")]
        [TestCase(10111121, "one crore one lac eleven thousand one hundred and twenty one")]
        [TestCase(10121121, "one crore one lac twenty one thousand one hundred and twenty one")]
        [TestCase(11021121, "one crore ten lac twenty one thousand one hundred and twenty one")]
        [TestCase(12021121, "one crore twenty lac twenty one thousand one hundred and twenty one")]
        [TestCase(12121121, "one crore twenty one lac twenty one thousand one hundred and twenty one")]
        public void SpellAnd_Should_Return_ValidTextWithAnd(int number, string text)
        {
            //Arrange
            var spltotxt = new SpellToText();

            //Act
            var _text = spltotxt.SpellAnd(number);

            //Assert
            Assert.AreEqual(text, _text);
        }


    }
}
