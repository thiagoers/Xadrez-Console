using System;
using Board;
using Chess;

namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    ChessBoard chessBoard = new ChessBoard(8, 8);
            //    chessBoard.PutPieceOn(new King(chessBoard, Color.Black), new Position(0, 4));
            //    chessBoard.PutPieceOn(new Tower(chessBoard, Color.Black), new Position(1, 2));
            //    chessBoard.PutPieceOn(new Tower(chessBoard, Color.Black), new Position(0, 9));

            //    BoardScreen.ShowBoard(chessBoard);
            //}
            //catch (BoardException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            ChessPosition cp = new ChessPosition('e', 5);

            Console.WriteLine(cp);
            Console.WriteLine(cp.ToPosition());

            Console.ReadLine();
        }
    }
}
