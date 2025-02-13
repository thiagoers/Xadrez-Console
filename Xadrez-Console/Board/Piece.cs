namespace Board
{
    internal class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; set; }
        public int HowManyMoves { get; set; }
        public ChessBoard ChessBoard { get; set; }

        public Piece(ChessBoard chessBoard, Color color)
        {
            Position = null;
            Color = color;
            HowManyMoves = 0;
            ChessBoard = chessBoard;
        }
    }
}
