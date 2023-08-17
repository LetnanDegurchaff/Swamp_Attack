using UnityEngine;

public class WannaThrowTransition : Transition
{
    private float _transitionDelay;
    private float _delaySpread;
    private float _elapsedTime;

    private void Start()
    {
        _transitionDelay = 1f;
        _delaySpread = 0.25f;
        _transitionDelay += Random.Range(-_delaySpread, _delaySpread);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime > _transitionDelay) 
        {
            NeedTransit = true;
            _elapsedTime = 0;
        }
    }
}