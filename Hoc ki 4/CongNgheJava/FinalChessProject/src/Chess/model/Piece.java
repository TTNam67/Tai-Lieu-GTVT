package Chess.model;

import java.awt.Point;
import java.io.Serializable;
import java.util.List;
/*
- "abstract": it cannot be directly instantiated, and must be subclassed to be used
- "Cloneable": object can be cloned
- "Serializable": object can be serialized or converted into a stream of bytes
to be stored on disk or transmitted over a network.

By implementing these interfaces, the Piece class provides support for creating
new objects of the class through cloning, and also provides support for storing
or transmitting objects of the class in binary format.
 */

// This class represents for Pieces
public abstract class Piece implements Cloneable, Serializable
{
    protected boolean white; //is this white piece ot not?
    protected Point piecePosition; // Position of the piece
    protected boolean firstMove = true; // Is this the first move?
    // Calculate all possible moves, and return a list contains these moves
    public abstract List<Move> calculatePossibleMoves(Board board, boolean checkKing);

    //Getters
    public Point getPiecePosition() {return piecePosition;}

    public boolean isFirstMove() {return firstMove;}
    public boolean isWhite() {return this.white;}

    //Setters

    public void setFirstMove(boolean firstMove) {this.firstMove = firstMove;}

    public void setPiecePosition(Point piecePosition) {this.piecePosition = piecePosition;}

    public void setWhite(boolean white) {this.white = white;}

    // Trong số các nước đi khả thi, loại bỏ đi các nước đi có thể đưa quân vua vào 1 nước bị chiếu
    // In the possible moves, eliminate all the moves that makes the king get checked
    protected void removeMovesPutsKingInCheck(Board board, List<Move> movesList)
    {
        for(int i = 0; i < movesList.size(); ++i)
        {
            if(board.movePutsKingInCheck(movesList.get(i), this.white))
            {
                movesList.remove(movesList.get(i));
                --i;
            }
        }
    }

    // Move the piece to "destination"
    public void moveTo(Point destination)
    {
        this.firstMove = false;
        this.piecePosition = destination;
    }

    public abstract String toString();
    @Override
    protected abstract Piece clone();

    public abstract String getImageName();
}

/*
Đọc script Queen.java để hiểu cách triển khai 1 loại quân cờ
 */
