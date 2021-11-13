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
    }

}
