using UnityEngine;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveManager : MonoBehaviour
{

    private Player player;

    private void Awake()
    {
        player = GameObject.FindObjectOfType<Player>();
    }

    public void Save()
    {
        // Opens or creates a file, depending if it exists or not.
        /* The first argument is the path. "Application.persistentDataPath" is a dedicated place where Unity
         * stores game data. "Player" will be the name of the file and ".dat" will be its extension
         * (you can name the extension whatever you want, but ".dat" is the industry standard). */
        /* The second argument is the action we'll take in the path we've chosen. In this case, we'll open the
         * "Player.dat" file if it already exists or create one if it doesn't. */
        FileStream file = new FileStream(Application.persistentDataPath + "/Player.dat", FileMode.OpenOrCreate);
        /* We're going to use the try-catch-finally blocks to make sure nothing too bad happens in case the
         * serialization process fails. */
        try
        {
            // "BinaryFormatter" is a class capable of serializing and deserializing objects.
            BinaryFormatter formatter = new BinaryFormatter();
            // We'll write what's in "player.myStats" to our file (Player.dat) and then serialize it.
            formatter.Serialize(file, player.myStats);
        }
        catch (SerializationException error)
        {
            // Should we face an error during this process, we'll show the error in the console.
            Debug.LogError("Error serializing data: " + error.Message);
        }
        finally
        {
            // Closing a file prevents its data from being leaked.
            file.Close();
        }
    }

    public void Load()
    {
        FileStream file = new FileStream(Application.persistentDataPath + "/Player.dat", FileMode.Open);
        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
            // This is where the game reads our deserialized file and attribute its values to the player.
            player.myStats = (Stats)formatter.Deserialize(file); //or "[...] as Stats"
        }
        catch (SerializationException error)
        {
            Debug.LogError("Error deserializing data: " + error.Message);
        }
        finally
        {
            file.Close();
        }
    }

}
