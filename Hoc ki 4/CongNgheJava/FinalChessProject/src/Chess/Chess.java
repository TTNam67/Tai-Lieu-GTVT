package Chess;


import javax.swing.SwingUtilities;

import Chess.controller.ChessController;

public class Chess {
    public static void main(String[] args)
    {
        SwingUtilities.invokeLater(new Runnable()
        {
            @Override
            public void run()
            {
                ChessController game = new ChessController();
                game.start();
            }
        });
    }
}
