using DonaldKnuthAlgoX.Tests.Utils;
using System.Collections.Generic;
using NUnit.Framework;

namespace DonaldKnuthAlgoX.Tests
{
    [TestFixture]
    class AlgotithmTests
    {
        [Test]
        [TestCase(12, new int[] { 1, 9, 6, 3 })]
        public void BoardStackNotEmpty(int boardSize, int[] expectedResult)
        {
            int columnsInBoard;
            HashSet<int> uniqueCalculatedStackContent = new BoardBuilder().WithSize(boardSize)
                                                                          .WithRow(new[] { 3, 6, 7 })
                                                                          .WithRow(new[] { 7, 10, 11 })
                                                                          .WithRow(new[] { 6, 9, 10 })
                                                                          .WithRow(new[] { 0, 1, 3 })
                                                                          .WithRow(new[] { 5, 6, 10 })
                                                                          .WithRow(new[] { 4, 5, 8 })
                                                                          .WithRow(new[] { 2, 5, 6 })
                                                                          .WithRow(new[] { 2, 6, 7 })
                                                                          .WithRow(new[] { 0, 1, 2 })
                                                                          .WithRow(new[] { 4, 8, 9 })
                                                                          .WithRow(new[] { 6, 7, 11 })
                                                                          .WithRow(new[] { 6, 10, 11 })
                                                                          .CalculateResultingStackContent(out columnsInBoard);

            Assert.That(boardSize, Is.EqualTo(columnsInBoard));
            CollectionAssert.AreEquivalent(expectedResult, uniqueCalculatedStackContent);
        }
        [Test]
        [TestCase(45)]
        public void BoardStackIsEmpty(int boardSize)
        {
            int columnsInBoard;
            HashSet<int> uniqueCalculatedStackContent = new BoardBuilder().WithSize(boardSize)
                                                                          .WithRow(new[] { 24, 33, 34 })
                                                                          .WithRow(new[] { 34, 43, 44 })
                                                                          .WithRow(new[] { 33, 42, 43 })
                                                                          .WithRow(new[] { 13, 14, 24 })
                                                                          .WithRow(new[] { 32, 33, 43 })
                                                                          .WithRow(new[] { 31, 32, 41 })
                                                                          .WithRow(new[] { 23, 32, 33 })
                                                                          .WithRow(new[] { 23, 33, 34 })
                                                                          .WithRow(new[] { 13, 14, 23 })
                                                                          .WithRow(new[] { 31, 41, 42 })
                                                                          .WithRow(new[] { 33, 34, 44 })
                                                                          .WithRow(new[] { 33, 43, 44 })
                                                                          .CalculateResultingStackContent(out columnsInBoard);

            Assert.That(boardSize, Is.EqualTo(columnsInBoard));
            Assert.That(uniqueCalculatedStackContent, Is.All.Empty);
        }
    }
}
