using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneRightTween : MonoBehaviour
{
    public Transform destinationPointRight;
    public Transform point1;
    public float duration;
    public Rigidbody cube2, cube3;

    public Vector3 vector = new Vector3(2, 1, 2);


    Vector3 cube2Pos;
    Vector3 cube3Pos;

    //Sequence sequenceAnimation = DOTween.Sequence();

    public void Start()
    {
        cube2Pos = cube2.transform.position;
        cube3Pos = cube3.transform.position;
    }

    public void OnRestartClick() {

        cube2.transform.position = cube2Pos;
        cube3.transform.position = cube3Pos ;
        //sequenceAnimation.Rewind();
    }

    public void TweenSequence() {
        DOTween.Sequence().Append(cube2.DOMove(destinationPointRight.position, duration).SetEase(Ease.InOutBack))
            .Join(cube3.DOJump(point1.position, 2.0f, 1, duration*2))
            .Append(cube3.DOJump(destinationPointRight.position, 2.0f, 2 , duration))
            .Join(cube2.DOJump(destinationPointRight.position, 3.5f, 4, duration*3))
            .Append(cube2.DORotate(vector, duration-1, RotateMode.LocalAxisAdd)).OnComplete(()=> { Debug.Log("Actions Completed"); });
    }
}
