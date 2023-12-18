package Chess.model;

import java.awt.Point;
import java.util.ArrayList;
import java.util.List;

public class Queen extends Piece
{

    public int cnt = 1;
    public Queen(Point piecePosition, boolean white)
    {
        this.piecePosition = piecePosition;
        this.white = white;
        this.firstMove = true;
    }

    // Constructor for clone method
    private Queen(Point piecePosition, boolean white, boolean firstMove)
    {
        this.firstMove = firstMove;
        this.piecePosition = piecePosition;
        this.white = white;
    }

    @Override
    public String toString() {
        return "Q";
    }

    @Override
    public List<Move> calculatePossibleMoves(Board board, boolean checkKing)
    {
//        cnt++;
        int x = piecePosition.x;
        int y = piecePosition.y;
        List<Move> moves = new ArrayList<Move>();

        // if no board given, return empty list
        if (board == null)
            return moves;

//        if (cnt % 3 == 1)
//        {
            int[] dx = { 1, 0, -1, 0, 1, -1, 1, -1 };
            int[] dy = { 0, 1, 0, -1, 1, 1, -1, -1 };
            for (int i = 0; i < 8; ++i)
                addMovesInLine(board, moves, dx[i], dy[i]);

//        else if (cnt % 3 == 2)
//        {
//            //ma
//            int[] dx = { 1, -1, 1, -1, 2, 2, -2, -2 };
//            int[] dy = { 2, 2, -2, -2, -1, 1, -1, 1 };
//            // check L-shapes
//            for (int i = 0; i < 8; ++i) {
//                addIfValid(board, moves, new Point(x + dx[i], y + dy[i]));
//            }
//
//            //xe
//            int[] dx2 = { 1, 0, -1, 0 };
//            int[] dy2 = { 0, 1, 0, -1 };
//            for (int i = 0; i < 4; ++i)
//            {
//                addMovesInLine2(board, moves, dx2[i], dy2[i]);
//            }
//        }
//        else
//        {
//            //ma
//            int[] dx = { 1, -1, 1, -1, 2, 2, -2, -2 };
//            int[] dy = { 2, 2, -2, -2, -1, 1, -1, 1 };
//            // check L-shapes
//            for (int i = 0; i < 8; ++i) {
//                addIfValid(board, moves, new Point(x + dx[i], y + dy[i]));
//            }
//
//            //tuong
//            int[] dx3 = { 1, -1, 1, -1 };
//            int[] dy3 = { 1, 1, -1, -1 };
//            // add moves in diagonal lines to the list
//
//            for (int i = 0; i < 4; ++i)
//                addMovesInLine(board, moves, dx3[i], dy3[i]);
//        }



        // check that move doesn't put own king in check
        if(checkKing)
            this.removeMovesPutsKingInCheck(board, moves);

        return moves;
    }


    private void addMovesInLine(Board board, List<Move> moves, int xi, int yi)
    {
        int x = piecePosition.x;
        int y = piecePosition.y;

        Point pt = new Point(x + xi, y + yi);
        Piece pc;

        while(board.ValidSpot(pt))
        {
            pc = board.getPieceAt(pt);


            if(pc == null)
                moves.add(new Move(this, pt, pc));

            else if(pc.white != this.white)
            {
                moves.add(new Move(this, pt, pc));
                break;
            }

            else
                break;

            pt = new Point(pt.x + xi, pt.y + yi);
        }
    }

    private void addMovesInLine2(Board board, List<Move> moves, int xi, int yi)
    {
        int x = piecePosition.x;
        int y = piecePosition.y;

        Point pt = new Point(x + xi, y + yi);
        Piece pc;

        while(board.ValidSpot(pt))
        {
            pc = board.getPieceAt(pt);


            if(pc == null)
            {
                moves.add(new Move(this, pt, pc));
            }
            else if(pc.white != this.white)
            {
                moves.add(new Move(this, pt, pc));
                break;
            }
            else
                break;

            pt = new Point(pt.x + xi, pt.y + yi);
        }
    }

    private void addMovesInLine3(Board board, List<Move> moves, int xi, int yi)
    {
        int x = piecePosition.x;
        int y = piecePosition.y;

        Point pt = new Point(x + xi, y + yi);
        Piece pc;

        while(board.ValidSpot(pt)) {
            pc = board.getPieceAt(pt);
            if(pc == null)
                moves.add(new Move(this, pt, pc));
            else if(pc.white != this.white)
            {
                moves.add(new Move(this, pt, pc));
                break;
            }
            else
                break;

            pt = new Point(pt.x + xi, pt.y + yi);
        }
    }

    private void addIfValid(Board board, List<Move> moves, Point point)
    {
        // if the location is valid
        if(board.ValidSpot(point))
        {
            // and the location does not contain same color piece
            Piece pc = board.getPieceAt(point);
            if(pc == null || pc.white != this.white)
            {
                // all the move to the list
                moves.add(new Move(this, point, pc));
            }
        }
    }

    @Override
    public Queen clone() {return new Queen(this.piecePosition, this.white, this.firstMove);}
    @Override
    public String getImageName() {return "Queen";}
}
