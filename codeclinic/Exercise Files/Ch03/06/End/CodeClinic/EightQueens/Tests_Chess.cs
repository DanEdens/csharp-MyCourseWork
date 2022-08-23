using Chess;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EightQueens
{
    [TestClass]
    public class Tests_Chess
    {
        [TestMethod]
        public void Test_010_EmptyBoardIsSafe()
        {
            var board = new ChessBoard("00000000");

            Assert.IsTrue(board.IsSafe());
        }

        [TestMethod]
        public void Test_011_BoardIsSafe()
        {
            var board = new ChessBoard("10000000");

            Assert.IsTrue(board.IsSafe());
        }

        [TestMethod]
        public void Test_012_BoardIsSafe()
        {
            var board = new ChessBoard("15863720");

            Assert.IsTrue(board.IsSafe());
        }

        [TestMethod]
        public void Test_019_EachKnownSolutionIsSafe()
        {
            var boards = from solution in ChessBoard.Solutions
                         select new ChessBoard(solution);

            Assert.IsTrue(boards.All(board => board.IsSafe()));
        }

        [TestMethod]
        public void Test_020_PlaceQueens()
        {
            // starting from an empty board, can we find one solution

            Assert.IsTrue(ChessBoard.PlaceQueens());
        }

        [TestMethod]
        public void Test_030_PlaceQueens()
        {
            // starting from an empty board, can we find all solutions

            var solutions = new List<ChessBoard>(92);
            ChessBoard.PlaceQueens(solutions);
            Assert.IsTrue(solutions.Count == 92);

            // confirm all found solutions are known
            Assert.IsTrue(solutions.All(board => ChessBoard.Solutions.Contains(board.ToString())));
        }
    }
}