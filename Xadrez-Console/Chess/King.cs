using Board;

namespace Chess
{
    internal class King : Piece
    {
        public King(ChessBoard chessBoard, Color color) : base(chessBoard, color)
        {

        }

        public override string ToString()
        {
            return "K";
        }
    }
}
