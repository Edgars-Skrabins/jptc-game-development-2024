using UnityEngine;

public class Player : Singleton<Player>
{
    public Transform GetPlayerTF()
    {
        return transform;
    }

    public Vector3 GetPlayerPosition()
    {
        return transform.position;
    }
}