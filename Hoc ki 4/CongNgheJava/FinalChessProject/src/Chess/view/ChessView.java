package Chess.view;

import javax.swing.JFrame;

import Chess.constant.GameConstant;
import Chess.controller.ChessController;

public class ChessView extends JFrame
{
    // GUI
    private BoardPanel boardPanel;
    // Convert data sent from controller into GUI.
    private ChessController chessGame;

    public ChessView(ChessController chessGame)
    {
        super("Chess");
        this.chessGame = chessGame;
    }

    public void initComponents()
    {
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setMinimumSize(GameConstant.BOARD_PANEL_DIMENSION);
        this.setLocationRelativeTo(null);

        boardPanel = new BoardPanel(this.chessGame);
        this.add(boardPanel);
        this.pack();
    }

    public BoardPanel getBoardPanel() {
        return boardPanel;
    }
}
