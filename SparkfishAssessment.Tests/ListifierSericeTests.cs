using NUnit.Framework;
using SparkfishAssessment.Services.Listifier;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Tests for an index in the middle of the collection
        /// </summary>
        [Test]
        public void TestIndexInMiddleOfRange()
        {
            var _service = new ListifierService();
            var value = _service.GetValueByIndex(100, 200, 50);
            Assert.AreEqual(value, 150);
        }

        /// <summary>
        /// Tests for an index at the start of the collection
        /// </summary>
        [Test]
        public void TestIndexAtStartOfRange()
        {
            var _service = new ListifierService();
            var value = _service.GetValueByIndex(100, 200, 0);
            Assert.AreEqual(value, 100);
        }

        /// <summary>
        /// Tests for an index at the end of the collection
        /// </summary>
        [Test]
        public void TestIndexAtEndOfRange()
        {
            var _service = new ListifierService();

            var value = _service.GetValueByIndex(100, 200, 100);
            Assert.AreEqual(value, 200);
        }

        /// <summary>
        /// Tests for an index before the start of the collection
        /// </summary>
        [Test]
        public void TestIndexOutsideStartOfRange()
        {
            var _service = new ListifierService();

            try
            {
                var value = _service.GetValueByIndex(100, 200, -1);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tetss for an index after the end of the collection
        /// </summary>
        [Test]
        public void TestIndexOutsideEndOfRange()
        {
            var _service = new ListifierService();

            try
            {
                var value = _service.GetValueByIndex(100, 200, 101);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}