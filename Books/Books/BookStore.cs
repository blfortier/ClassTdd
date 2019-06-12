using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class BookStore
    {
        public int oneBookPrice = 8;
        public decimal twoBookDiscount = .05m;
        public decimal threeBookDiscount = .1m;
        public decimal fourBookDiscount = .2m;
        public decimal fiveBookDiscount = .25m;

        public dynamic DetermineCostOfBooks(List<string> namesOfBooks)
        {
            if (namesOfBooks.Count == 1 && namesOfBooks[0] == "")
                return 0;
            else if (namesOfBooks.Count == 2)
            {
                if (namesOfBooks[0] == namesOfBooks[1])
                    return (oneBookPrice * 2);
                else
                    return ((oneBookPrice * 2) - (oneBookPrice * 2) * twoBookDiscount);
            }
            else if (namesOfBooks.Count == 3)
            {
                bool isUnique = namesOfBooks.Distinct().Count() == namesOfBooks.Count();
                int numOfUniqueTitles = namesOfBooks.Distinct().Count();

                if (isUnique)
                    return ((oneBookPrice * 3) - (oneBookPrice * 3) * threeBookDiscount);
                else if (namesOfBooks.Count - numOfUniqueTitles == 1)
                    return ((oneBookPrice) + ((oneBookPrice * 2) - ((oneBookPrice * 2) * twoBookDiscount)));
                else
                    return oneBookPrice * namesOfBooks.Count;
            }
            else if (namesOfBooks.Count == 4)
            {
                bool isUnique = namesOfBooks.Distinct().Count() == namesOfBooks.Count();
                int numOfUniqueTitles = namesOfBooks.Distinct().Count();

                if (isUnique)
                    return ((oneBookPrice * 4) - ((oneBookPrice * 4) * fourBookDiscount));
                else if (namesOfBooks.Count - numOfUniqueTitles == 1)
                    return (((oneBookPrice * 3) - (oneBookPrice * 3) * threeBookDiscount)) + oneBookPrice;
                else if (namesOfBooks.Count - numOfUniqueTitles == 2)
                    return (((oneBookPrice * 2) - (oneBookPrice * 2) * twoBookDiscount) + oneBookPrice * 2);
            }
            else if (namesOfBooks.Count >= 5)
            {
                bool isUnique = namesOfBooks.Distinct().Count() == 5;
                int numOfUniqueTitles = namesOfBooks.Distinct().Count();

                if (isUnique)
                    return ((oneBookPrice * 5) - ((oneBookPrice * 5) * fiveBookDiscount));
                else if (namesOfBooks.Count - numOfUniqueTitles == 1)
                    return ((oneBookPrice * 4) - (oneBookPrice * 4) * fourBookDiscount) + oneBookPrice;
                else if (namesOfBooks.Count - numOfUniqueTitles == 2)
                    return ((oneBookPrice * 3) - ((oneBookPrice * 3) * threeBookDiscount) + oneBookPrice * 2);
                else if (namesOfBooks.Count - numOfUniqueTitles == 3)
                    return (((oneBookPrice * 2) - (oneBookPrice * 2) * twoBookDiscount) + oneBookPrice * 3);
                else
                    return (oneBookPrice * 5);
            }


            return oneBookPrice;
        }

    }
}

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
