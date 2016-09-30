using UnityEngine;
using System.Collections;

public class ImageDownloadToTesture : MonoBehaviour {

    public string url = "http://wx.qlogo.cn/mmopen/6ACL7JA1VIh1qFRK6ibacRgrAibt8a2rUxyqmjBcUibE88OtnxSkoUIE9hHlicbcb882kLOs3CFkia0Y7b2tAN0pVoQYQ6GaPQvql/0?v=1473411836";
    IEnumerator Start()
    {
        WWW www = new WWW(url);
        yield return www;
        //Renderer renderer = GetComponent<Renderer>();
        //renderer.material.mainTexture = www.texture;

        if (string.IsNullOrEmpty(www.error))
        {
            SetTexture(www.texture);
        }
    }

    /// <summary>  
    /// 填充纹理  
    /// </summary>  
    void SetTexture(Texture2D img)
    {
        //texture = img;  
          
        //GUI texture  
        if (GetComponent<GUITexture>() != null)
        {
            GetComponent<GUITexture>().texture = img;
            return;
        }

        //NGUI texture  
        UITexture texture = GetComponent<UITexture>();
        if (texture != null)
        {
            texture.mainTexture = img;
            return;
        }

        //NGUI sprite  
        //      UISprite sprite = GetComponent<UISprite>();  
        //      if(sprite != null)  
        //      {  
        //          img.name = "main";  
        //          List<Texture> texs = new List<Texture>();  
        //          texs.Add(img);  
        //          uiatlas =  new UIAtlas();  
        //          //uiatlas.spriteList.Add = texs;  
        //            
        //          sprite.atlas = uiatlas;  
        //          sprite.spriteName = "main";  
        //          return;  
        //      }  
    }

}
