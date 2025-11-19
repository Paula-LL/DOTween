using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLeftTween : MonoBehaviour
{
    public Transform destinationPoint; 
    public float duration;
    public Rigidbody cube1;

    Vector3 cube1Pos;

    Tween seqLeft;

    public void Start()
    {
        cube1Pos = cube1.transform.position;
    }

    public void OnRestartClick()
    {
        cube1.transform.position = cube1Pos;
        seqLeft.Kill();
    }

    public void JumpToDestination() {
        seqLeft = DOTween.Sequence().Append(cube1.DOJump(destinationPoint.position,2.0f, 1 ,duration) );
    }
}
