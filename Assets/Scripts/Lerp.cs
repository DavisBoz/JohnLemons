using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public Transform mTarget;
    public float mTravelTime;

    Vector3 mStartPos;
    Vector3 mTargetPos;

    float mTimer;

    void Start()
    {
        mStartPos = transform.position;
        mTargetPos = mTarget.position;
        mTimer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        mTimer += Time.deltaTime;
        transform.position = Vector3.Lerp(mStartPos, mTargetPos, mTimer / mTravelTime);
    }
}
