using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

namespace AstralCodex
{
    class Wire : MonoBehaviour
    {
        #region Material Properties
        const string SpeedProperty = "_Speed";
        const string HighlightColorProperty = "_HighlightColor";
        const string BaseColorProperty = "_BaseColor";
        #endregion

        #region Material Property Values
        private float[] speeds = {0.5f, 0.25f}; //The speed stripes on the wire move when on vs. off
        private Color[] highlightColors = { new Color(0, 1, 0.576f), new Color(1, 0, 0.271f) }; //The color of the stripes on the wire when on vs. off
        private Color[] baseColors = { new Color(0, 0.498f, 0.518f), new Color(1, 0.792f, 0.769f) }; //The base color of the wire when on vs. off
        #endregion

        #region Variables
        public bool on = false; //Whether this wire is currently on
        protected List<Material> materials; //The materials controlled by this wire group
        //protected GameObject reveal; //The GameObject containing the reveal for this wire
        protected NomaiComputer computer; //The computer containing the portion of the Codec revealed by this wire
        protected GameObject projection; //The root GameObject of the lidar projection for this wire
        #endregion

        #region Initialization
        void Awake()
        {
            //Component reference
            materials = new List<Material>();
            MeshRenderer[] renderers = GetComponentsInChildren<MeshRenderer>();
            foreach (MeshRenderer renderer in renderers)
            {
                materials.Add(renderer.material);
            }
        }

        //Called by derived wires in their Start() function
        public void Initialize()
        {
            //Set initial state
            /*if (reveal != null)
            {
                reveal.SetActive(false);
                ShipLogFactListTriggerVolume revealTrigger = reveal.GetComponent<ShipLogFactListTriggerVolume>();
                revealTrigger._player = false;
            }*/
            projection?.SetActive(false);
            computer?.ClearAllEntries();
        }
        #endregion

        #region Turn On/Off
        //Called by derived wires in their Update() function
        public void TurnOn()
        {
            if (on == false)
            {
                on = true;
                //Main.modHelper.Console.WriteLine(gameObject.name + " turned on", MessageType.Success);
                //reveal?.SetActive(true);
                projection?.SetActive(true);
                computer?.DisplayAllEntries();

                UpdateMaterialProperties(on);
            }
        }

        //Called by derived wires in their Update() function
        public void TurnOff()
        {
            if (on == true)
            {
                on = false;
                //Main.modHelper.Console.WriteLine(gameObject.name + " turned off", MessageType.Success);
                //reveal?.SetActive(false);
                projection?.SetActive(false);
                computer?.ClearAllEntries();

                UpdateMaterialProperties(on);
            }
        }

        void UpdateMaterialProperties(bool on)
        {
            int propertyValueIndex = on ? 0 : 1;

            foreach (Material mat in materials)
            {
                mat.SetFloat(SpeedProperty, speeds[propertyValueIndex]);
                mat.SetColor(HighlightColorProperty, highlightColors[propertyValueIndex]);
                mat.SetColor(BaseColorProperty, baseColors[propertyValueIndex]);
            }
        }
        #endregion
    }
}
