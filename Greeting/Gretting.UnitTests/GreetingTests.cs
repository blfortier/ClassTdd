using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greeting;

namespace Gretting.UnitTests
{
    [TestFixture]
    public class GreetingTests
    {
        GreetingMaker greet = new GreetingMaker();
        string name;
        string[] names;

        [Test]
        public void GreetASinglePerson_ReturnString()
        {
            name = "Bob";

            string expected = "Hello, Bob";
            string actual = greet.GreetPerson(name);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        /* Handle nulls by introducing a stand-in. For example, when name is null, 
         * then the method should return the string “Hello, my friend.”
         * */
        public void IfNameIsNull_ReturnHelloMyFriend()
        {
            name = null;

            var expected = "Hello, my friend";
            var actual = greet.GreetPerson(name);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfNameIsAllCapsReturnHELLO()
        {
            name = "JERRY";
            var expected = "HELLO, JERRY";
            var actual = greet.GreetPerson(name);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void IfNameIsAnArray_GreetBothPeople()
        {
            names = new string[] { "Todd", "Sarah" };
            var expected = "Hello, Todd and Sarah";
            var actual = greet.GreetPerson(names);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfThreeNames_ReturnGreetingWithCommas()
        {
            names = new string[] { "Todd", "Sarah", "Bob" };
            var expected = "Hello, Todd, Sarah, and Bob.";
            var actual = greet.GreetPerson(names);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfArrayHasMixedRegularAndAllUppercaseNamesReturnAllUppercaseSecondSentence()
        {
            names = new string[] { "Todd", "SARAH", "Bob" };
            var expected = "Hello, Todd and Bob. AND HELLO SARAH!";
            var actual = greet.GreetPerson(names);

            Assert.AreEqual(expected, actual);
        }
    }
}
