using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bullet", menuName = "ScriptableObjects/Bullets" )]
public class BulletType : ScriptableObject
{
    public GameObject bulletVisual;
    public int damage;


}
