using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TiltBrush
{
    public class QuizEachPanel : BasePanel
    {
        static public QuizEachPanel m_Instance;
        [SerializeField] private GameObject _createQuiz;
        [SerializeField] private GameObject _editQuiz;
        [SerializeField] private GameObject _takeQuiz;
    }
}

