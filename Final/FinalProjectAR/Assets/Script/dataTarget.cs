using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Vuforia
{

    public class dataTarget : MonoBehaviour
    {
        public GameObject NaCl;
        public GameObject CaCl2;
        public GameObject MgCl2;
        public GameObject KCl;
        public GameObject HCl;
        string lastimagename;
        int i = 0;
        float xxx,yyy,zzz;
		void Update()
        {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

            foreach (TrackableBehaviour tb in tbs)
            {
                if (i % 300 == 0)
                {
                    string name = tb.TrackableName;
                    ImageTarget it = tb.Trackable as ImageTarget;
                    Vector2 size = it.GetSize();

                    Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

                    if (name == "Cl" && lastimagename == "Na")
                    {
                    	MgCl2.SetActive(false);
                    	CaCl2.SetActive(false);
                    	KCl.SetActive(false);
                    	HCl.SetActive(false);
                        Instantiate(NaCl, new Vector3(-75, -4, -10), Quaternion.identity);
                    }
                    else if (name == "Cl" && lastimagename == "Ca")
                    {
                    	NaCl.SetActive(false);
                    	MgCl2.SetActive(false);
                    	KCl.SetActive(false);
                    	HCl.SetActive(false);
						yyy = -2.5f;
                    	zzz = 68.3f;
                        Instantiate(CaCl2, new Vector3(-105, yyy, zzz), Quaternion.identity);
                    }
                    if (name == "Cl" && lastimagename == "Mg")
                    {
                    	NaCl.SetActive(false);
                    	CaCl2.SetActive(false);
                    	KCl.SetActive(false);
                    	HCl.SetActive(false);
                    	yyy = -2.5f;
                        Instantiate(MgCl2, new Vector3(-105, yyy, 23), Quaternion.identity);
                    }
                    if (name == "Cl" && lastimagename == "K")
                    {
                    	NaCl.SetActive(false);
                    	CaCl2.SetActive(false);
                    	MgCl2.SetActive(false);
                    	HCl.SetActive(false);
                    	yyy = -2.5f;
                        Instantiate(KCl, new Vector3(-75, yyy, 38), Quaternion.identity);
                    }
                    if (name == "Cl" && lastimagename == "H")
                    {
                    	NaCl.SetActive(false);
                    	CaCl2.SetActive(false);
                    	MgCl2.SetActive(false);
                    	KCl.SetActive(false);
                    	yyy = -2.5f;
                    	zzz = 53.5f;
                        Instantiate(HCl, new Vector3(-75, yyy, zzz), Quaternion.identity);
                    }
                    lastimagename = name;
                }
                i = i + 1;
                if (i >= 10000) i = 0;
            }
        }

    }
}
