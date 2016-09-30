using UnityEngine;
using System.Collections;

public class ImageDownloadScripts : MonoBehaviour
{

    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}

    public string url = "http://wx.qlogo.cn/mmopen/6ACL7JA1VIh1qFRK6ibacRgrAibt8a2rUxyqmjBcUibE88OtnxSkoUIE9hHlicbcb882kLOs3CFkia0Y7b2tAN0pVoQYQ6GaPQvql/0?v=1473411836";
    IEnumerator Start()
    {
        WWW www = new WWW(url);
        yield return www;
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = www.texture;
    }

    public void OnImageDownloadEnd() {

    }

}

