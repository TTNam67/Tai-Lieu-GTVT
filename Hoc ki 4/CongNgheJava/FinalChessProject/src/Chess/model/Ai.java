package Chess.model;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

public class Ai implements Serializable
{
    private boolean white;
    private int depth; // how depth the Ai will calculate?

    public Ai(boolean white, int depth)
    {
        this.white = white;
        this.depth = depth;
    }

    // Returns the color of the pieces the AI controls
    public boolean isWhite() {
        return this.white;
    }

    // Returns a move for the ai to make based on a min/max algorithm
    public Move getMove(Board game) {
        if (game == null) {
            return null;
        }
        if (game.isWhiteTurn() != this.white) {
            return null;
        }

        // initialize best value and best move variables
        int bestValue = Integer.MIN_VALUE;
        Move bestMove = null;

        // get the best move for the ai (max) from the available moves
        for (Move m : getMoves(game)) {
            // get the value of the move (min)
            int moveValue = min(game.tryMove(m), depth - 1, bestValue, Integer.MAX_VALUE);

            // if the value is > than bestValue, current move is best
            if (moveValue > bestValue || bestValue == Integer.MIN_VALUE) {
                bestValue = moveValue;
                bestMove = m;
            }
        }

        return bestMove;
    }

    // Returns the value of the best move for the ai for the given board
    private int max(Board game, int depth, int alpha, int beta) {
        // end search if game over or depth limit reached
        if (depth == 0) {
            return valueOfBoard(game);
        }

        List<Move> possibleMoves = getMoves(game);

        // if no moves can be made, game has ended
        if (possibleMoves.size() == 0)
        {
            return valueOfBoard(game);
        }

        // get the best move for the ai (max) from the available moves
        for (Move m : possibleMoves) {
            // get the value of the move
            int moveValue = min(game.tryMove(m), depth - 1, alpha, beta);

            // see if it is better than previous best move
            if (moveValue > alpha) {
                alpha = moveValue;
            }
            // if the alpha value (value of the best move found for the ai by
            // this method) is greater than the beta value (the best move for
            // the opponent so far found by the min method that called this
            // method) then we know that the min method will not choose this
            // path and we can stop the search
            if (alpha >= beta) {
                return alpha;
            }
        }

        return alpha;
    }

    private int min(Board game, int depth, int alpha, int beta) {
        // end search if game over or depth limit reached
        if (depth == 0) {
            return valueOfBoard(game);
        }

        List<Move> possibleMoves = getMoves(game);

        // if no moves can be made, game has ended
        if (possibleMoves.size() == 0) {
            return valueOfBoard(game);
        }

        // get the best move for the player (min) from the available moves
        for (Move m : possibleMoves) {
            int moveValue = max(game.tryMove(m), depth - 1, alpha, beta);
            if (moveValue < beta) {
                beta = moveValue;
            }
            // if the alpha value (best move found for the ai so far by the
            // max method that called this method) is greater than the beta
            // value (best move found for the opponent by this method) then
            // we know that the max method will not choose this path and we
            // can stop the search.
            if (alpha >= beta) {
                return beta;
            }
        }
        return beta;
    }

    // Returns all the possible moves for the board.
    private List<Move> getMoves(Board game) {
        List<Move> moves = new ArrayList<Move>();

        for (Piece p : game.getAllPieces()) {
            if (p.isWhite() == game.isWhiteTurn()) {
                moves.addAll(p.calculatePossibleMoves(game, true));
            }
        }
        return moves;
    }

    // Calculates the value of a board for the AI.
    private int valueOfBoard(Board gameBoard) {
        int value = 0;
        int aiPieces = 0;
        int aiMoves = 0;
        int playerPieces = 0;
        int playerMoves = 0;
        int aiCaptures = 0;
        int playerCaptures = 0;

        // give the board state a value based on the number of pieces on the
        // board and the number of available moves

        for (Piece pc : gameBoard.getAllPieces()) {
            if (pc.isWhite() == this.white) {
                // account for number of pieces on board
                aiPieces += valueOfPiece(pc);

                if (this.white == gameBoard.isWhiteTurn()) {
                    List<Move> validMoves = pc.calculatePossibleMoves(gameBoard, true);
                    for (Move m : validMoves) {
                        // account for how many moves can be made
                        aiMoves++;
                        if (m.getCapturedPiece() != null) {
                            // account for possible captures
                            aiCaptures += valueOfPiece(m.getCapturedPiece());
                        }
                    }
                }
            } else {
                playerPieces += valueOfPiece(pc);

                if (this.white != gameBoard.isWhiteTurn()) {
                    List<Move> validMoves = pc.calculatePossibleMoves(gameBoard, true);
                    for (Move m : validMoves) {
                        // account for how many moves can be made
                        playerMoves++;
                        if (m.getCapturedPiece() != null) {
                            // account for possible captures
                            playerCaptures += valueOfPiece(m.getCapturedPiece());
                        }
                    }
                }
            }
        }

        value = (aiPieces - playerPieces) + (aiMoves - playerMoves) + (aiCaptures - playerCaptures);

        // if a side can make no valid moves, the game is over
        if (gameBoard.isWhiteTurn() == this.white && aiMoves == 0) {
            // if the ai can make no moves, it has lost. this is bad.
            value = Integer.MIN_VALUE;
        } else if (gameBoard.isWhiteTurn() != this.white && playerMoves == 0) {
            // if the player can make no more moves, we win. this is good.
            value = Integer.MAX_VALUE;
        }

        return value;
    }

    // A method for evaluating the value of a piece
    private int valueOfPiece(Piece pc) {
        if (pc instanceof Pawn) {
            return 1;
        } else if (pc instanceof Knight || pc instanceof Bishop) {
            return 3;
        } else if (pc instanceof Rook) {
            return 5;
        } else if (pc instanceof Queen) {
            return 9;
        } else if (pc instanceof King) {
            return 100;
        }
        return 0;
    }
}
