using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main_Manager : MonoBehaviour
{
    [SerializeField] int energy;
    [SerializeField] int energy_time;

    [SerializeField] Image Main_Sprite;
    [SerializeField] Image Right_Sprite;
    [SerializeField] Image Left_Sprite;

    [SerializeField] Image[] Main_Image;
    [SerializeField] Image[] Right_Image;
    [SerializeField] Image[] Left_Image;
    [SerializeField] Image[] Ending_Image;
    [SerializeField] Image[] Fail_Image;

    

    int stage = 0;
    int progress = 0;


    // Start is called before the first frame update
    void Start()
    {
        stage = 1;progress = 1;// юс╫ц
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScreen(int stageNumber, int progressNumber) {
        Main_Sprite = Main_Image[(stageNumber - 1) * 4 + progressNumber];
        Right_Sprite = Right_Image[(stageNumber - 1) * 4 + progressNumber];
        Left_Sprite = Left_Image[(stageNumber - 1) * 4 + progressNumber];





    }




}
