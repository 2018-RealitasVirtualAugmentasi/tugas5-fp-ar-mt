using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Vuforia
{

    public class dataTarget : MonoBehaviour
    {
        public GameObject NaCl;
        string lastimagename;
        int i = 0;
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

                    //Evertime the target found it will show â€œname of targetâ€ on the TextTargetName. Button, Description and Panel will visible (active)

                    if (name == "Cl" || lastimagename == "Na")
                    {
                        Instantiate(NaCl, new Vector3(-75,-4,-10), Quaternion.identity);
                    }
                    lastimagename = name;
                }
                i = i + 1;
                if (i >= 10000) i = 0;
            }
        }

    }
}