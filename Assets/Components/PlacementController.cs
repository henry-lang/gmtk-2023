using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlacementController : MonoBehaviour
{

    public GameObject JumpPadPrefab;
    public GameObject PlatformPrefab;

    public GameObject JumpPadPlacementUI;
    public GameObject PlatformPlacementUI;

    private Button _jumpPlacementButton;
    private Button _platformPlacementButton;

    private GameObject currentPlacing;

    private bool placing;
    // Start is called before the first frame update
    
    void Start()
    {
        _jumpPlacementButton = JumpPadPlacementUI.GetComponent<Button>();
        _platformPlacementButton = PlatformPlacementUI.GetComponent<Button>();

        _jumpPlacementButton.onClick.AddListener(OnJumpPlacementButtonClick);
        _platformPlacementButton.onClick.AddListener(OnPlatformPlacementButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPlacing != null)
        {
            Vector3 placePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            placePos.z = 0;
            currentPlacing.transform.position = placePos;

            if (Input.GetMouseButtonDown(0))
            {
                placing = false;
                currentPlacing = null;
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                currentPlacing.transform.Rotate(new Vector3(0, 0, 45));
            }
        }
    }

    void OnJumpPlacementButtonClick()
    {
        if (!placing)
        {
            placing = true;
            currentPlacing = Instantiate(JumpPadPrefab, Vector3.zero, Quaternion.identity);
        }
    }
    
    void OnPlatformPlacementButtonClick()
    {
        if (!placing)
        {
            placing = true;
            currentPlacing = Instantiate(PlatformPrefab, Vector3.zero, Quaternion.identity);
        }
    }
}
