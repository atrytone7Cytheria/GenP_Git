
using UnityEngine;

public class follow : MonoBehaviour
{
   public Transform PLAYER;
   public Vector3 offset;
    void Update()
     // Update is called once per frame
   {
      transform.position = PLAYER.position + offset ;
    }
}
