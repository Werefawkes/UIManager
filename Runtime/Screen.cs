using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Foxthorne.FoxScreens
{
    [AddComponentMenu("Foxthorne/FoxScreens/Screen")]
    public class Screen : MonoBehaviour
    {
        [Header("Settings")]
        public string screenName;
        public int screenID;
        public bool isHudElement = false;
        public bool autoNameObject = true;


        string hudPrefix = "HUD";
        string screenPrefix = "SCR";

        public bool IsOpen { get; private set; }

		private void OnValidate()
		{
            if (autoNameObject)
			{
				string prefix;
				if (isHudElement)
				{
                    prefix = hudPrefix;
				}
                else
				{
                    prefix = screenPrefix;
				}

                name = $"[{prefix}-{screenID}] {screenName}";
            }
        }

		public void Open()
		{
            IsOpen = true;

            // code to enable the screen gameobjects
		}

        public void Close()
		{
            IsOpen = false;

            // code to disable the screen gameobjects
        }
    }
}
