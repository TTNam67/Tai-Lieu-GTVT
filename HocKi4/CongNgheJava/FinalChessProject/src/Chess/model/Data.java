package Chess.model;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

public class Data
{

    // Singleton Pattern
    private static Data instance = null;

    public static Data getInstance()
    {
        if (instance == null)
            instance = new Data();
        return instance;
    }

    public File[] getAllSavedFile()
    {
        try
        {
            // gets all the saved games in the /SAVES folder
            File directory = new File("saves");

            // creates the saves folder if it does not already exist
            if (!directory.exists())
                directory.mkdir();

            File[] saves = directory.listFiles();

            // if no saves found
            if (saves.length == 0)
                return null;

            return saves;
        }
        catch (Exception e)
        {
            // in case of an exception
            return null;
        }
    }

    public void saveBoard(String name, Board gameBoard) throws Exception
    {
        FileOutputStream fos = null;
        ObjectOutputStream oos = null;
        if (name == null)
        {
            return;
        }

        // check that the saves folder exists
        File directory = new File("saves");
        // creates folder if it doesn't exist
        if (!directory.exists())
        {
            directory.mkdir();
        }

        // get an ObjectOutputStream for a new save file
        fos = new FileOutputStream(new File("saves/" + name + ".CSV"));
        oos = new ObjectOutputStream(fos);

        // write the board to the file
        oos.writeObject(gameBoard);

        // close the stream
        oos.close();
        fos.close();
    }

    public Board loadBoard(File file)
    {
        Board gameBoard = null;
        FileInputStream fis = null;
        ObjectInputStream ois = null;
        try
        {
            // get an ObjectInputStream from the file
            fis = new FileInputStream(file);
            ois = new ObjectInputStream(fis);

            // read the board from the file
            gameBoard = (Board)ois.readObject();
            return gameBoard;
            // close the streams
        }
        catch (Exception e)
        {
            // in case of an exception
            return null;
        }
        finally
        {
            try
            {
                if (ois != null)
                {
                    ois.close();
                }
                if (fis != null)
                {
                    fis.close();
                }
            }
            catch (IOException e)
            {
                e.printStackTrace();
                return null;
            }
        }
    }
}
