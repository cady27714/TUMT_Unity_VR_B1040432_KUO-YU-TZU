using UnityEngine;
using Valve.VR;

public class GameManager : MonoBehaviour
{
    public static bool haveKey;

    public void ThrowPickUp()
    {
        print("撿起物件");
    }

    public void ThrowDetach(GameObject obj)
    {
        print("放開物件");
        haveKey = true;
        Destroy(obj);
    }

    public void ThrowHeld()
    {
        print("拿著物件");
    }
}
