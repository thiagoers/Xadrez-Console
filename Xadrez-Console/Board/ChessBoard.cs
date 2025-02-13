namespace Board
{
    internal class ChessBoard
    {
        public int Columns { get; set; }
        public int Rows { get; set; }
        private Piece[,] Pieces { get; set; }

        public ChessBoard(int columns, int rows)
        {
            Columns = columns;
            Rows = rows;
            Pieces = new Piece[columns,rows];
        }

        public Piece GetPiece(int row, int column)
        {
            return Pieces[row, column];
        }

        public void PutPieceOn(Piece piece, Position position)
        {
            Pieces[position.Row, position.Column] = piece;
            piece.Position = position;
        }
    }
}
