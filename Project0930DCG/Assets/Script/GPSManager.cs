using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GPSManager : MonoBehaviour {

    // Use this for initialization

    public Text latitude_show;
    public Text longitude_show;
    public Text lastUpdated;
    public Text Searching;
    public Text isEnabled;
    public Text status;
    public Button Search;
    public Button GameStart;

    public float Latitude;
    public float Longitude;

    void Start()  
    {
        Input.location.Start(0.1f);       
        if (Input.location.lastData.longitude.ToString() == null)
            Debug.Log("longitude is null");
        GameStart.interactable = false;

        int wait = 1000;

        if (Input.location.isEnabledByUser)
        {
            while (Input.location.status == LocationServiceStatus.Initializing && wait > 0)
            {
                wait--;
                Searching.text = "위치 검색중입니다..";

            }
            if (Input.location.status == LocationServiceStatus.Failed)
            {
            }
            else
            {
                InvokeRepeating("RetrieveGPSData", 0f, 0.1f);
            }

        }

        else
        {
            Debug.Log("GPS is not availabe!");
        }
        

    }
    void Update()
    {
        
    }
    
    public void StartButton_Click()
    {
        Application.LoadLevel("Game");
        Debug.Log("잠시 후 게임을 시작합니다.");
    }

        public void Button_Click()
    {               
        SetGPS();
               
        if (Latitude >= 36.00000 && Longitude >= 127.0000)
        {
            Searching.text = "식목원에 도착했습니다!";                      
            GameStart.interactable = true;        
        }
        
    }

    void SetGPS()
    {
        Input.location.Start(0.1f);
        LocationInfo location = Input.location.lastData;
        Latitude = Input.location.lastData.latitude;
        Longitude = Input.location.lastData.longitude;
        latitude_show.text = "위도: " + Latitude;
        longitude_show.text = "경도: " + Longitude;
        lastUpdated.text = new DateTime(1970, 1, 1).AddSeconds(location.timestamp).ToString();
        isEnabled.text = Input.location.isEnabledByUser.ToString();
        status.text = Input.location.status.ToString();
    }
}
