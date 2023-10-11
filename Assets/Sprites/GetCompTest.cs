using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCompTest : MonoBehaviour
{
    public GameObject image; //取得照片物件
    public Texture2D imageChangeFemaleToMale; //定義要換的材質
    public Texture2D imageChangMaleToFemale;

    public void ChangeImageFemaleToMale()
    {
        image.GetComponent<RawImage>().texture = imageChangeFemaleToMale;
    }

    public void ChangeImageMaleToFemale()
    {

    }
}
