using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public static class GameUI
    {

        public static InputField GetInputField(string gameObjectName)
        {
            GameObject inputFieldGo = GameObject.Find(gameObjectName);
            return inputFieldGo.GetComponent<InputField>();
        }

        public static Text GetTextField(string name)
        {
            GameObject inputFieldGo = GameObject.Find(name);
            return inputFieldGo.GetComponent<Text>();
        }

    }
}
