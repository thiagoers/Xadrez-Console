using Board;

namespace Xadrez_Console
{
    class BoardScreen
    {
        public static void ShowBoard(ChessBoard chessBoard)
        {
            for (int i = 0; i < chessBoard.Rows; i++)
            {
                for (int j = 0; j < chessBoard.Columns; j++)
                {
                    if(chessBoard.GetPiece(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else{
                        Console.Write(chessBoard.GetPiece(i,j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
