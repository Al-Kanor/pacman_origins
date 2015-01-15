using UnityEngine;
using System.Collections;

public class ResourcesManagmentScript : MonoBehaviour {
    #region Members
    public int m_CurrentGold;
    public int p_CurrentGold {
        get {
            return m_CurrentGold;
        }
        set {
            m_CurrentGold = value;
            Debug.Log (m_CurrentGold.ToString ());
        }
    }
    public const int c_StartGold = 100;
    #endregion

    void Awake () {
        p_CurrentGold = c_StartGold;
    }
}
