using Board;

namespace Chess
{
    internal class Tower : Piece
    {
        public Tower(ChessBoard chessBoard, Color color) : base(chessBoard, color)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
