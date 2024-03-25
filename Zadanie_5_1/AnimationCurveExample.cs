using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCurveExample : MonoBehaviour
{
    [SerializeField] private AnimationCurve _movingCurve;
    public AnimationCurve lerpCurve;
    private float currentTime;
    private float totalTime;
    // Start is called before the first frame update
    void Start()
    {
        totalTime = _movingCurve.keys[_movingCurve.keys.Length-1].time;

    }
    private void FixedUpdate()
    {
        gameObject.transform.position = 
            new Vector3(_movingCurve.Evaluate(currentTime), transform.position.y,
                                                                     transform.position.z);
        currentTime += Time.fixedDeltaTime;
        if (currentTime >= totalTime) {
        currentTime = 0;
        }
      }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
