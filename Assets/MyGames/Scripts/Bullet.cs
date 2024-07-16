using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("DangSon/Bullet")]
public class Bullet : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision objectHit)
    {
        if (objectHit != null)
        {
            if(objectHit.collider.CompareTag("Wall"))
            {
             
             Destroy(gameObject);
            }
            CreateBulletImpactEfect(objectHit);
        }
    }
    private void CreateBulletImpactEfect(Collision objectHit)
    {
        ContactPoint contact = objectHit.contacts[0];
        GameObject hole = Instantiate(GameReferences.Instance.bulletEffectImpactPrefabs, contact.point, Quaternion.LookRotation(contact.normal));
        hole.transform.SetParent(objectHit.gameObject.transform);
    }
}
