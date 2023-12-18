package Chess.model;

import java.awt.Point;

// Class's purpose is only contain the info of the castle move
public class CastleMove extends Move
{
    private Piece rook;
    private Point moveRookTo;

    public CastleMove(Piece king, Point moveKingTo, Piece rook, Point moveRookTo)
    {
        super(king, moveKingTo, null);
        this.moveRookTo = moveRookTo;
        this.rook = rook;
    }

    public Point getRookMoveTo() {
        return moveRookTo;
    }

    public Piece getRook() {
        return rook;
    }
}
