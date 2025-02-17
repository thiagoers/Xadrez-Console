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

        public Piece GetPiece(Position position)
        {
            return Pieces[position.Row, position.Column];
        }

        public void PutPieceOn(Piece piece, Position position)
        {
            if (PieceExists(position))
            {
                throw new BoardException("Posição já ocupada.");
            }
            Pieces[position.Row, position.Column] = piece;
            piece.Position = position;
        }

        public bool TestPosition(Position position)
        {
            if(position.Row < 0 || position.Row >= Rows || position.Column < 0 || position.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position position)
        {
            if(!TestPosition(position))
            {
                throw new BoardException("Invalid Position.");
            }
        }

        public bool PieceExists(Position position)
        {
            ValidatePosition(position);
            return GetPiece(position) != null;
        }
    }
}
