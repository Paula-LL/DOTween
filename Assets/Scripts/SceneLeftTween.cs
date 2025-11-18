using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLeftTween : MonoBehaviour
{
    public Transform destinationPoint; 
    public float duration;
    public Rigidbody cube1; 

    public void JumpToDestination() {
        DOTween.Sequence().Append(cube1.DOJump(destinationPoint.position,2.0f, 1 ,duration) );
        //cube1.DOJump(destinationPoint.position, duration);
    }
}
