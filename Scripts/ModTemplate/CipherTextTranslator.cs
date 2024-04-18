using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace AstralCodex
{
    internal class CipherTextTranslator : MonoBehaviour
    {
        const string FormattingPrefix = "<b>"; //The string to prefix the text with to format it
        const string FormattingSuffix = "</b>"; //The string to suffix the text with to format it

        Text text; //The text component to translate on this GameObject

        void Start ()
        {
            text = GetComponent<Text>();
            if (text == null)
            {
                Main.modHelper.Console.WriteLine("ATTEMPTING TO TRANSLATE CIPHER TEXT ON GAMEOBJECT WITH NO TEXT COMPONENT: "+gameObject.name, OWML.Common.MessageType.Error);
                return;
            }

            string translatedText = Main.newHorizons.GetTranslationForOtherText(text.text);
            text.text = FormattingPrefix + translatedText + FormattingSuffix;
        }
    }
}
