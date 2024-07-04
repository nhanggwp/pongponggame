
using UnityEngine;

public class Paddle : MonoBehaviour
{
      protected Rigidbody2D _rigidbody;
        public float speed=10f;
    private void Awake(){ //function that unity provied for unity automatically call( call one time during the life cycle of game object)
        _rigidbody=GetComponent<Rigidbody2D>();// search the same object which have the datatype is RigidBody 2D 
    }
    public void ResetPosition(){
    _rigidbody.position=new Vector2(_rigidbody.position.x,0);
    _rigidbody.velocity=Vector3.zero;
}
}
