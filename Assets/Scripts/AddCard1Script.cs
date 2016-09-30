using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AddCard1Script : MonoBehaviour
{

    private int mCardsCount = 0;
    public int mWidth = 0;
    private int mCardWidth = 80;
    private string mCardPre = "my_hand_1_";
    private List<int> mCardsNumList = new List<int>();
    public GameObject mPrefab;

    public int MCardsCount
    {
        get
        {
            return mCardsCount;
        }

        private set
        {
            mWidth = mCardWidth * value;
            mCardsCount = value;
        }
    }

    public void AddACard(int cardNum)
    {
        mCardsNumList.Add(cardNum);
        //mCardsNumList.Sort();
        this.gameObject.transform.DestroyChildren();
        GetComponent<UIWidget>().SetDimensions(mCardsNumList.Count * mCardWidth , 140);
        for (int index = 0; index < mCardsNumList.Count; ++index)
        {
            string name = string.Format("{0}0x{1:d2}", mCardPre, mCardsNumList[index]);

            GameObject go = (GameObject)Instantiate(mPrefab); ; //Resources.Load("Card1");
            Transform tr = go.transform.FindChild("CardFg");
            if (tr)
            {
                
                tr.gameObject.GetComponent<UISprite>().spriteName = name;
                go.transform.parent = this.gameObject.transform;
                go.transform.localPosition = new Vector3(index * mCardWidth  + mCardWidth / 2, 0, 0);
                go.transform.localScale = Vector3.one;
                //NGUITools.AddChild(this.gameObject,go);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            int cardN = Random.Range(1, 10);
            AddACard(cardN);
        }
    }


}
