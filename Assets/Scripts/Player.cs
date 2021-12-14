using UnityEngine;

public class Player : MonoBehaviour
{

    public Stats myStats;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UIManager Manager = FindObjectOfType<UIManager>();
            Manager.RandomizeStats();
        }
        /* Since Unity doesn't understand what the struct's variables
         * we're going to modify in the inspector means, we need to 
         * make these attributions. */
        /* Furthermore, with this line, it's possible to ignore the 
         * existence of the "transform" method and only modify your
         * gameObject's coordinates with "myStats.myPos" instead.
         * This is recommended because "myStats.myPos" is a data
         * which we'll be serializing and, thus, saving. */
        transform.position = myStats.myPos.GetPos();
    }

}
