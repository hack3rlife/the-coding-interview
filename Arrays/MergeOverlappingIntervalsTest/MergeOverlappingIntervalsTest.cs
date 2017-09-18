using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays.test
{
    [TestClass ()]
    public class MergeOverlappingIntervalsTest
    {
        [TestMethod ()]
        public void MergeTest1()
        {
            // arrange
            var intervals = new List<Interval> ()
            {
                new Interval (4, 6),
                new Interval (8, 11),
                new Interval (20, 25),
                new Interval (27, 30),
                new Interval (35, 60),
            };

            var interval = new Interval (1, 3);

            // act
            var actualIntervals = MergeOverlappingIntervals.Merge (intervals, interval);

            // assert
            var expectedIntervals = new List<Interval> ()
            {
                new Interval (1, 3),
                new Interval (4, 6),
                new Interval (8, 11),
                new Interval (20, 25),
                new Interval (27, 30),
                new Interval (35, 60),
            };

            CollectionAssert.AreEqual (expectedIntervals, actualIntervals);
        }

        [TestMethod ()]
        public void MergeTest2()
        {
            // arrange
            var intervals = new List<Interval> ()
            {
                new Interval (4, 6),
                new Interval (8, 11),
                new Interval (20, 25),
                new Interval (27, 30),
                new Interval (35, 60),
             };

            var interval = new Interval (23, 26);

            // act
            var actualIntervals = MergeOverlappingIntervals.Merge (intervals, interval);

            // assert
            var expectedIntervals = new List<Interval> ()
            {
                new Interval (4, 6),
                new Interval (8, 11),
                new Interval (20, 26),
                new Interval (27, 30),
                new Interval (35, 60),
             };

            CollectionAssert.AreEqual (expectedIntervals, actualIntervals);
        }

        [TestMethod ()]
        public void MergeTest3()
        {
            // arrange
            var intervals = new List<Interval> ()
            {
                new Interval (4, 6),
                new Interval (8, 11),
                new Interval (20, 25),
                new Interval (27, 30),
                new Interval (35, 60),
             };

            var interval = new Interval (61, 70);

            // act
            var actualIntervals = MergeOverlappingIntervals.Merge (intervals, interval);

            // assert
            var expectedIntervals = new List<Interval> ()
            {
                new Interval (4, 6),
                new Interval (8, 11),
                new Interval (20, 25),
                new Interval (27, 30),
                new Interval (35, 60),
                new Interval (61, 70),
             };

            CollectionAssert.AreEqual (expectedIntervals, actualIntervals);
        }

        [TestMethod ()]
        public void MergeTest4()
        {
            // arrange
            var intervals = new List<Interval> ()
            {
                new Interval (4, 6),
                new Interval (8, 11),
                new Interval (20, 25),
                new Interval (27, 30),
                new Interval (35, 60),
             };

            var interval = new Interval (3, 61);

            // act
            var actualIntervals = MergeOverlappingIntervals.Merge (intervals, interval);

            // assert
            var expectedIntervals = new List<Interval> ()
            {
                new Interval (3, 61),
             };

            CollectionAssert.AreEqual (expectedIntervals, actualIntervals);
        }

        [TestMethod ()]
        public void MergeTest5()
        {
            // arrange
            var intervals = new List<Interval> ()
            {
                new Interval (4, 6),
                new Interval (8, 11),
                new Interval (20, 25),
                new Interval (27, 30),
                new Interval (35, 60),
            };

            var interval = new Interval (1, 5);

            // act
            var actualIntervals = MergeOverlappingIntervals.Merge (intervals, interval);

            // assert
            var expectedIntervals = new List<Interval> ()
            {
                new Interval (1,6),
                new Interval (8, 11),
                new Interval (20, 25),
                new Interval (27, 30),
                new Interval (35, 60),
            };

            CollectionAssert.AreEqual (expectedIntervals, actualIntervals);
        }

        [TestMethod ()]
        public void MergeTest6()
        {
            // arrange
            var intervals = new List<Interval> ()
            {
                new Interval (4, 6),
                new Interval (8, 11),
                new Interval (20, 25),
                new Interval (27, 30),
                new Interval (35, 60),
            };

            var interval = new Interval (1, 7);

            // act
            var actualIntervals = MergeOverlappingIntervals.Merge (intervals, interval);

            // assert
            var expectedIntervals = new List<Interval> ()
            {
                new Interval (1,7),
                new Interval (8, 11),
                new Interval (20, 25),
                new Interval (27, 30),
                new Interval (35, 60),
            };

            CollectionAssert.AreEqual (expectedIntervals, actualIntervals);
        }

        [TestMethod ()]
        public void MergeTest7()
        {
            // arrange
            var intervals = new List<Interval> ()
            {
                new Interval (4, 6),
                new Interval (8, 11),
                new Interval (20, 25),
                new Interval (27, 30),
                new Interval (35, 60),
            };

            var interval = new Interval (23, 28);

            // act
            var actualIntervals = MergeOverlappingIntervals.Merge (intervals, interval);

            // assert
            var expectedIntervals = new List<Interval> ()
            {
                new Interval (4,6),
                new Interval (8, 11),
                new Interval (20, 30),
                new Interval (35, 60),
            };

            CollectionAssert.AreEqual (expectedIntervals, actualIntervals);
        }
    }
}