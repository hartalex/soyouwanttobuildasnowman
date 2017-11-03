using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySelection : MonoBehaviour
{

    public GameObject contentPanel;
    public GameObject inspectorPosition;
    public Font font;
    private bool setup = false;
    private Text lastSelection = null;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!setup && Inventory.ToStringArray().GetLength(0) > 0)
        {
            int i = 0;

            int width = 250;
            int height = 30;
            i = 0;
            foreach (string str in Inventory.ToStringArray())
            {
                GameObject ngo = new GameObject(str);
                ngo.layer = 5;
                ngo.transform.SetParent(contentPanel.transform);
                Text myText = ngo.AddComponent<Text>();
                myText.text = str;
                myText.rectTransform.localScale = new Vector3(1, 1, 1);
                myText.rectTransform.anchorMin = new Vector2(0, 1);
                myText.rectTransform.anchorMax = new Vector2(0, 1);
                myText.rectTransform.localPosition = new Vector2(10 + width / 2, -(height / 2) - (i++ * height));
                myText.font = font;
                myText.fontSize = 20;
                myText.rectTransform.sizeDelta = new Vector2(width, height);
               
                EventTrigger trigger = ngo.AddComponent<EventTrigger>();
                EventTrigger.Entry entry = new EventTrigger.Entry();
                entry.eventID = EventTriggerType.PointerClick;
                entry.callback.AddListener((data) => { clicked(str, myText); });
                trigger.triggers.Add(entry);

            }
            setup = true;
        }

    }
       
    public void clicked(string name, Text text)
    {
        GameObject go = Inventory.GetObjectByName(name);
        if (go != null)
        {
            if (lastSelection != null)
            {
                lastSelection.color = Color.white;
            }
            if (inspectorPosition.transform.childCount > 0)
            {
                for(int i =0; i < inspectorPosition.transform.childCount; i++)
                {
                    DestroyObject(inspectorPosition.transform.GetChild(i).gameObject);
                }
            }
            GameObject myref = Instantiate(go, inspectorPosition.transform);
            myref.AddComponent<DragNDrop>();
            Rotate rotate = myref.AddComponent<Rotate>();
            rotate.X = true;
            rotate.Z = true;
            rotate.force = 15;
            BodyPartHover bph = myref.GetComponent<BodyPartHover>();
            if (bph != null)
            {
                bph.isEnabled = false;
            }

            text.color = Color.yellow;
            lastSelection = text;
        }
    }

}
