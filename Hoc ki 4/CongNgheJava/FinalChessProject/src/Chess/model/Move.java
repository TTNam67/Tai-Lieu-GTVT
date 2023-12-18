package Chess.model;

import java.awt.Point;

//Class's purpose is only contain the info of the move
public class Move
{
    private Piece movedPiece; // The piece makes the move
    private Piece capturedPiece; // The piece be captured
    private Point moveTo; // The destination of the move
    public Move(Piece movedPiece, Point destionation, Piece capturedPiece)
    {
        this.movedPiece = movedPiece;
        this.moveTo = destionation;
        this.capturedPiece = capturedPiece;
    }

    // Check if the "movedPiece" is null
    public boolean isMovedPieceNull() {
        return this.movedPiece == null;
    }

    // Getters
    public Piece getMovedPiece() {
        return movedPiece;
    }

    public Piece getCapturedPiece() {
        return capturedPiece;
    }

    public Point getMoveTo() {
        return moveTo;
    }

    // Setters
    public void setCapturedPiece(Piece capturedPiece) {
        this.capturedPiece = capturedPiece;
    }

    public void setMovedPiece(Piece movedPiece) {
        this.movedPiece = movedPiece;
    }

    public void setMoveTo(Point destionation) {
        this.moveTo = destionation;
    }

    @Override
    public String toString()
    {
        return "[movedPiece=" + movedPiece + ", capturedPiece=" + capturedPiece + ", moveTo=" + moveTo + "]";
    }
}
