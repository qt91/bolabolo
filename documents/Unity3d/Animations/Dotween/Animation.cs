void AMAniUpDown()
{
    //using DG.Tweening;
    Sequence mySequence = DOTween.Sequence();
    float Time = Random.Range(1, 2f);//Random speed or fix speed
    mySequence.Append(gameObject.transform.DOMoveY(gameObject.transform.position.y + 1, Time));//Move to up
    mySequence.Append(gameObject.transform.DOMoveY(gameObject.transform.position.y, Time));//Move to origin
    mySequence.Append(gameObject.transform.DOMoveY(gameObject.transform.position.y - 1, Time));//Move to down
    mySequence.Append(gameObject.transform.DOMoveY(gameObject.transform.position.y, Time));//Move to origin
    //mySequence.PrependInterval(1);
    mySequence.SetLoops(9999);//Loop
}