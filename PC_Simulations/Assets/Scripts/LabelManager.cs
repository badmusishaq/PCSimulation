using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] englishLabel;
    
    [SerializeField]
    private GameObject[] russianLabel;

    private bool isEnglish;
    //private bool isRussian;
    
    // Start is called before the first frame update
    void Start()
    {
        isEnglish = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnglish)
        {
            for (int i = 0; i < englishLabel.Length; i++)
            {
                englishLabel[i].SetActive(true);
                russianLabel[i].SetActive(false);
            }
        }
        else
        {
            for (int i = 0; i < englishLabel.Length; i++)
            {
                englishLabel[i].SetActive(false);
                russianLabel[i].SetActive(true);
            }
        }
    }

    public void SelectEnglish()
    {
        isEnglish = true;
    }

    public void SelectRussian()
    {
        isEnglish = false;
    }
}
