#pragma strict

function OnCollisionEnter(collision : Collision)
{
 if(collision.gameObject.tag == "Present")
 {
   Destroy(collision.gameObject);
 }
 }