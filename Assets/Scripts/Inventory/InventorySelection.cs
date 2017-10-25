using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySelection : MonoBehaviour
{

    public Inventory objects;
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
        if (!setup && objects.ToStringArray().GetLength(0) > 0)
        {
            int i = 0;

            int width = 250;
            int height = 30;
            i = 0;
            foreach (string str in objects.ToStringArray())
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

                EventTrigger.Entry entry2 = new EventTrigger.Entry();
                entry2.eventID = EventTriggerType.EndDrag;
                entry2.callback.AddListener((data) => { dragged(data, myText); });
                trigger.triggers.Add(entry2);
            }
            setup = true;
        }

    }

    public void dragged(BaseEventData data, Text text)
    {
        Debug.Log("Dragged");
    }
   
    public void clicked(string name, Text text)
    {
        GameObject go = objects.GetObjectByName(name);
        if (go != null)
        {
            if (lastSelection != null)
            {
                text.color = Color.white;
            }
            if (inspectorPosition.transform.GetChildCount() > 0)
            {
                for(int i =0; i < inspectorPosition.transform.GetChildCount(); i++)
                {
                    DestroyObject(inspectorPosition.transform.GetChild(i).gameObject);
                }
            }
            GameObject myref = Instantiate(go, inspectorPosition.transform);
            myref.AddComponent<Dnd>();
   
            text.color = Color.yellow;
            lastSelection = text;
        }
    }
}
