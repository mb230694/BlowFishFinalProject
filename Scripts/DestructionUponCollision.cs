using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestructionUponCollision : MonoBehaviour
{
    public new ParticleSystem particleSystem;
    Scoring scoreTrack;



    private void OnCollisionEnter(Collision collision)
    {
       scoreTrack = GameObject.FindGameObjectWithTag("ScoreSystem").GetComponent<Scoring>();
       scoreTrack.AddScore(1);
        if (collision.collider.CompareTag("CannonBallPlayer"))
            Destroy();
        
    }

    private void Destroy()
    {
        Instantiate(particleSystem,transform.position,Quaternion.identity);
        Destroy(gameObject);
        Destroy(particleSystem);
    }
}
