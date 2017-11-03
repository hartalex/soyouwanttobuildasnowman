using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectHover : MonoBehaviour {
    public bool isEnabled = true;
    float Step;
    float YOffset = 20f;
  //  float SpinOffset = .1f;
    RectTransform m_RectTransform;
    float m_XAxis, m_YAxis, initialYAxis;

    void Start()
    {
        //Store where we were placed in the editor
        Vector3 InitialPosition = transform.position;
        Step = 0;
        m_RectTransform = GetComponent<RectTransform>();
        m_XAxis = m_RectTransform.anchoredPosition.x;
        m_YAxis = m_RectTransform.anchoredPosition.y;
        initialYAxis = m_YAxis;
    }

    void FixedUpdate()
    {
        if (isEnabled)
        {
            Step += 0.01f;
            //Make sure Steps value never gets too out of hand 
            if (Step > 999999)
            {
                Step = 1f;
            }

            m_YAxis = (Mathf.Sin(Step) * YOffset) + initialYAxis;

            //Float up and down along the y axis, 
            m_RectTransform.anchoredPosition = new Vector2(m_XAxis, m_YAxis);
            //m_RectTransform.localRotation = Quaternion.EulerAngles(0, 0, (Mathf.Sin(Step) * SpinOffset));
        }
    }
}
