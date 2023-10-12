using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCompTest : MonoBehaviour
{
    //public GameObject image; //取得照片物件
    //public Texture2D imageChangeFemaleToMale; //定義要換的材質
    //public Texture2D imageChangMaleToFemale;
    public GameObject male;
    public GameObject female;
    public GameObject leftArrow;
    public GameObject rightArrow;


    public void ChangeImageFemaleToMale()
    {
        //image.GetComponent<RawImage>().texture = imageChangeFemaleToMale;
        leftArrow.SetActive(false);
        rightArrow.SetActive(true);
        female.SetActive(false);
        male.SetActive(true);
    }

    public void ChangeImageMaleToFemale()
    {
        leftArrow.SetActive(true);
        rightArrow.SetActive(false);
        male.SetActive(false);
        female.SetActive(true);
    }
}
