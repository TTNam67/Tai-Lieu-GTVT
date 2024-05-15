package Chess.model;

import java.awt.Point;
import java.util.ArrayList;
import java.util.List;

public class Pawn extends Piece
{

    public boolean enPassantOK = false; //If this pawn can be captured by a "en Passant move"?

    public Pawn(Point piecePosition, boolean white)
    {
        this.piecePosition = piecePosition;
        this.white = white;
        this.firstMove = true;
    }

    //Constructor clone method
    private Pawn(Point piecePosition, boolean white, boolean firstMove)
    {
        this.firstMove = firstMove;
        this.piecePosition = piecePosition;
        this.white = white;
    }

    @Override
    public String toString() {
        return "P";
    }

    @Override
    public List<Move> calculatePossibleMoves(Board board, boolean checkKing)
    {
        List<Move> moves = new ArrayList<Move>();

        // if no board given, return empty list
        if (board == null) return moves;

        int x = piecePosition.x;
        int y = piecePosition.y;
        int toward; // If this pawn is white, it moves toward the upper side of the board, black otherwise

        if (this.white) toward = -1;
        else toward = 1;

        // checks moves where the pawn can take an advanced move
        advance(moves, board, x, y, toward);

        // checks moves where the pawn captures another piece
        capture(moves, board, x, y, toward);

        // checks en passant moves
        enPassantMove(moves, board, x, y, toward);

        // check that move doesn't put own king in check
        if (checkKing) this.removeMovesPutsKingInCheck(board, moves);

        return moves;
    }

    private void capture(List<Move> moves, Board board, int x, int y, int toward)
    {
        Piece pc;
        Point pt;

        for (int i : new int[]{1, -1})
        {
            pt = new Point(x + i, y + toward);
            if (board.ValidSpot(pt))
            {
                pc = board.getPieceAt(pt);
                if (pc != null)
                {
                    if(this.white != pc.white)
                    {
                        moves.add(new Move(this, pt, pc));
                    }
                }

            }
        }
    }

    private void advance(List<Move> moves, Board board, int x, int y, int toward)
    {
        Piece pc;
        Point pt;

        pt = new Point(x, y + toward);
        if (board.ValidSpot(pt))
        {
            pc = board.getPieceAt(pt);
            if(pc == null)
            {
                moves.add(new Move(this, pt, pc));
                pt = new Point(x, y + toward * 2);
                pc = board.getPieceAt(pt);

                if (board.ValidSpot(pt) && pc == null && this.firstMove)
                {
                    moves.add(new Move(this, pt, pc));
                }
            }
        }
    }



    private void enPassantMove(List<Move> moves, Board board, int x, int y, int toward)
    {
        if (this.white && this.piecePosition.y == 3
                || !this.white && this.piecePosition.y == 4)
        {
            for (int i : new int[]{1, -1})
            {
                if(IsEnemyPawnAt(board, new Point(x + i, y)))
                {
                    moves.add(new Move(this, new Point(x + i, y + toward),
                            board.getPieceAt(new Point(x + i, y))));
                }

            }
        }
    }


    // Can this pawn capture a pawn in position "pos" with a "en Passant" move
    private boolean IsEnemyPawnAt(Board board, Point pos)
    {
        Piece piece = board.getPieceAt(pos);
        if(piece != null)
        {
            if (piece instanceof Pawn && piece.isWhite() !=  this.white)
            {
                if (((Pawn)piece).enPassantOK)
                    return true;
            }

        }

        return false;
    }

    @Override
    public Pawn clone() {return new Pawn(this.piecePosition, this.white, this.firstMove);}
    @Override
    public String getImageName() {return "Pawn";}
}
