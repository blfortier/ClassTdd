using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.UnitTests
{
    [TestFixture]

    public class BookTests
    {
        BookStore _bookStore;
        List<string> booksToBuy;

        [SetUp]
        public void TestFixtureSetup()
        {
            _bookStore = new BookStore();
            booksToBuy = new List<string>();
        }

        [Test]
        public void BuyNoBooks_NoCost()
        {
            string noBook = "";
            booksToBuy.Add(noBook);

            int expected = 0;
            var actual = _bookStore.DetermineCostOfBooks(booksToBuy);
        }
        [Test]
        public void BuyOneBook_CostIs8Dollars()
        {
            string book = "Harry Potter and the Sorcerer's Stone";
            booksToBuy.Add(book);

            int expected = 8;
            var actual = _bookStore.DetermineCostOfBooks(booksToBuy);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void BuyTwoOfSameBook_CostIs16Dollars()
        {
            string book1 = "Harry Potter and the Sorcerer's Stone";
            string book2 = "Harry Potter and the Sorcerer's Stone";

            booksToBuy.Add(book1);
            booksToBuy.Add(book2);

            int expected = 16;
            var actual = _bookStore.DetermineCostOfBooks(booksToBuy);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void BuyTwoDifferentBooks_GetFivePercentDiscount_CostIsDiscounted()
        {
            string book1 = "Harry Potter and the Sorcerer's Stone";
            string book2 = "Harry Potter and the Chamber of Secrets";

            booksToBuy.Add(book1);
            booksToBuy.Add(book2);

            decimal expected = 15.2m;
            var actual = _bookStore.DetermineCostOfBooks(booksToBuy);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void BuyThreeOfSameBooks_GetNoBookDiscount_CostIs24()
        {
            string book1 = "Harry Potter and the Chamber of Secrets";
            string book2 = "Harry Potter and the Chamber of Secrets";
            string book3 = "Harry Potter and the Chamber of Secrets";

            booksToBuy.Add(book1);
            booksToBuy.Add(book2);
            booksToBuy.Add(book2);

            decimal expected = 24;
            var actual = _bookStore.DetermineCostOfBooks(booksToBuy);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuyThreeDifferentBooks_Get10PercentDiscount()
        {
            string book1 = "Harry Potter and the Chamber of Secrets";
            string book2 = "Harry Potter and the Goblet of Fire";
            string book3 = "Harry Potter and the Order of the Phoenix";

            booksToBuy.Add(book1);
            booksToBuy.Add(book2);
            booksToBuy.Add(book3);

            decimal expected = 21.6m;
            var actual = _bookStore.DetermineCostOfBooks(booksToBuy);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuyThreeBooks_TwoSameTitleOneDifferentTitle_Get5PercentDiscountOn2OfSameTitle()
        {
            string book1 = "Harry Potter and the Chamber of Secrets";
            string book2 = "Harry Potter and the Order of the Phoenix";
            string book3 = "Harry Potter and the Order of the Phoenix";

            booksToBuy.Add(book1);
            booksToBuy.Add(book2);
            booksToBuy.Add(book3);

            decimal expected = 23.2m;
            var actual = _bookStore.DetermineCostOfBooks(booksToBuy);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuyFourDifferentBooks_GetTwentyPercentDiscount()
        {
            string book1 = "Harry Potter and the Chamber of Secrets";
            string book2 = "Harry Potter and the Goblet of Fire";
            string book3 = "Harry Potter and the Order of the Phoenix";
            string book4 = "Harry Potter and the Prisoner of Azkaban";

            booksToBuy.Add(book1);
            booksToBuy.Add(book2);
            booksToBuy.Add(book3);
            booksToBuy.Add(book4);

            decimal expected = 25.6m;
            var actual = _bookStore.DetermineCostOfBooks(booksToBuy);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void BuyFourBooks_2OfSameTitle_2Unique_Get5PercentDiscount()
        {
            string book1 = "Harry Potter and the Chamber of Secrets";
            string book2 = "Harry Potter and the Goblet of Fire";
            string book3 = "Harry Potter and the Order of the Phoenix";
            string book4 = "Harry Potter and the Prisoner of Azkaban";

            booksToBuy.Add(book1);
            booksToBuy.Add(book2);
            booksToBuy.Add(book3);
            booksToBuy.Add(book4);

            decimal expected = 25.6m;
            var actual = _bookStore.DetermineCostOfBooks(booksToBuy);

            Assert.AreEqual(expected, actual);
        }

    }
}


/*
 "Harry Potter and the Sorcerer's Stone"
 "Harry Potter and the Chamber of Secrets" 
 "Harry Potter and the Prisoner of Azkaban"
 "Harry Potter and the Goblet of Fire" 
 "Harry Potter and the Order of the Phoenix"
 */


/* To try and encourage more sales of the 5 different Harry
        Potter books they sell, a bookshop has decided to offer
        discounts of multiple-book purchases.
        One copy of any of the five books costs 8 USD.
        If, however, you buy two different books, you get a 5%
        discount on those two books.
        If you buy 3 different books, you get a 10% discount.
        If you buy 4 different books, you get a 20% discount.
        If you go the whole hog, and buy all 5, you get a huge 25%
        discount.
        Note that if you buy, say, four books, of which 3 are
        different titles, you get a 10% discount on the 3 that
        form part of a set, but the fourth book still costs 8 USD.
        Your mission is to write a piece of code to calculate the
        price of any conceivable shopping basket (containing only
        Harry Potter books), giving as big a discount as possible.
        For example, how much does this basket of books cost?
        2 copies of the first book
        2 copies of the second book
        2 copies of the third book
        1 copy of the fourth book
        1 copy of the fifth book
        Answer: 51.60 USD
    */
