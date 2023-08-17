public class EndThrowTransition : Transition
{
    private ThrowingState _throwingState;

    private void Awake()
    {
        _throwingState = GetComponent<ThrowingState>();
    }

    private void Update()
    {
        if (_throwingState.IsThrowed)
        {
            NeedTransit = true;
        }
    }
}