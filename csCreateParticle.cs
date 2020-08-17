using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCreateParticle : MonoBehaviour
{
    public Object[] particles;
    public float area = 5.0f;
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        { 
            int selIdx = Random.Range(0, particles.Length);
            Object partObj = particles[selIdx];
            GameObject gameParticle =
                Instantiate(partObj) as GameObject;
            float pX = this.transform.position.x + Random.Range(-area, area);
            float pY = this.transform.position.y + Random.Range(0f, area);
            float pZ = this.transform.position.z + Random.Range(-area, area);
            gameParticle.transform.position = new Vector3(pX, pY, pZ);

            Destroy(gameParticle, 2f);
        }
    }
}
