using UnityEngine;

public class TeleportInteratble : MonoBehaviour
{


    [Header("動畫控制器")]
    public Animator animatorControl;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "HeadCollider" && GameManager.haveKey)
        {
            animatorControl.SetBool("box", true);
        }
    }

}
