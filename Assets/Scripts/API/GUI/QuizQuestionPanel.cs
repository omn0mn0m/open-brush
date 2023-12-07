using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TiltBrush
{
    public class QuizQuestionPanel : BasePanel
    {
        static public QuizQuestionPanel m_Instance;
        [SerializeField] private GameObject _questionText;
        [SerializeField] private GameObject _fib;
        [SerializeField] private GameObject _optionA;
        [SerializeField] private GameObject _optionB;
        [SerializeField] private GameObject _optionC;
        [SerializeField] private GameObject _optionD;
        [SerializeField] private GameObject _optionE;
        public string questionText;
    }
}

