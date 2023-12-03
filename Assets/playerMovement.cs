
using UnityEngine;

public class player1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float force=2000f;
    public float side=500f;
    // Update is called once per frame
    void FixedUpdate()
    {
      rb.AddForce(0,0,force*Time.deltaTime);  
      if(Input.GetKey("d")){
        rb.AddForce(side*Time.deltaTime,0,0,ForceMode.VelocityChange);
      }
       if(Input.GetKey("a")){
        rb.AddForce(-side*Time.deltaTime,0,0,ForceMode.VelocityChange);
      }
    //   if(rb.position.y<-1f){
    //     FindObjectOfType<GameManager>().EndGame();
    //   }
    }
}
