using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePrefab : MonoBehaviour
{
    public GameObject m_prefab = null;
    public Transform m_parent = null;
    public Vector3 m_position = Vector3.zero;

    GameObject m_instantiatedObject = null;
    public GameObject instantiatedObject {  get { return m_instantiatedObject; } }
    // Start is called before the first frame update
    void Start()
    {
        if (m_prefab == null)
            return;

        m_instantiatedObject = Instantiate(m_prefab, m_parent);
        m_instantiatedObject.transform.localPosition = m_position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}