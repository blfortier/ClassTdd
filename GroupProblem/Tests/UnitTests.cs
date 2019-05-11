using GroupProblem;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void IfEmptyArray_ReturnTrue()
        {
            string[] test_names = new string[] { };
            int[] test_numbers = new int[] { };
            SequenceLauncher _sequenceLauncher = new SequenceLauncher();
            var actual = _sequenceLauncher.LaunchSequenceChecker(test_names, test_numbers);

            Assert.AreEqual(actual, true);
        }

        [Test]
        public void IfUnordered_ReturnFalse()
        {
            string[] test_names = new string[] { "stage1", "stage1"};
            int[] test_numbers = new int[] { 2, 1 };
            SequenceLauncher _sequenceLauncher = new SequenceLauncher();
            var actual = _sequenceLauncher.LaunchSequenceChecker(test_names, test_numbers);
            Assert.AreEqual(actual, false);
        }

        [Test]
        public void IfOrdered_ReturnTrue()
        {
            string[] test_names = new string[] { "stage1", "stage1" };
            int[] test_numbers = new int[] { 1, 2 };
            SequenceLauncher _sequenceLauncher = new SequenceLauncher();
            var actual = _sequenceLauncher.LaunchSequenceChecker(test_names, test_numbers);
            Assert.AreEqual(actual, true);
        }

        [Test]
        public void CheckMultiSystemNamesForDesOrder()
        {
            string[] test_names = new string[] { "stage1", "stage1", "stage2" };
            int[] test_numbers = new int[] { 2, 1, 5 };
            SequenceLauncher _sequenceLauncher = new SequenceLauncher();
            var actual = _sequenceLauncher.LaunchSequenceChecker(test_names, test_numbers);
            Assert.AreEqual(actual, false);
        }


    }
}
