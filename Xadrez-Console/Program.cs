using System;
using Board;
using Chess;

namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChessBoard chessBoard = new ChessBoard(8, 8);
            chessBoard.PutPieceOn(new King(chessBoard, Color.Black), new Position(0, 4));
            chessBoard.PutPieceOn(new Tower(chessBoard, Color.Black), new Position(1, 2));

            BoardScreen.ShowBoard(chessBoard);

            Console.ReadLine();
        }
    }
}
