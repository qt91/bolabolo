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

//Hien thi kieu xuat hien ra tu fill tu duoi len tren
public void Show()
{
    Sequence mySequence = DOTween.Sequence();
    mySequence.Append(gameObject.GetComponent<Image>().DOFillAmount(1,2));
}

//chay ra nhung 1 cai roi dung lai
void show()
    {
        Sequence mySequence = DOTween.Sequence();
        mySequence.Append(gameObject.GetComponent<RectTransform>().DOAnchorPos(new Vector2(5,0), 0.5f, false));
        mySequence.Append(gameObject.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-3, 0), 0.05f, false));
        mySequence.Append(gameObject.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, 0), 0.01f, false));
    }