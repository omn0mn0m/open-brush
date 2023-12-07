using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;


namespace TiltBrush
{
    public class QuizAccount : MonoBehaviour
    {
        static public QuizAccount m_Instance;
        //[SerializeField] private TMP_InputField[] _userInputFields;
        [SerializeField] private Button[] _buttons;
        [SerializeField] private GameObject _login;
        [SerializeField] private GameObject _create;
        [SerializeField] private TMP_Text _debugText;
        public string username;
        public string password;
        public string signUpusername;
        public string signUpupassword;
        public string signUpname;
        private string m_authentication_file;

        private void Start()
        {
            //_debugText.text = "";
            //m_authentication_file = App.UserQuizAuthPath();
        }
        void Awake()
        {
            m_Instance = this;
        }
        private void LoginExists()
        {
            List<string> usernames = new List<string>();
            List<string> passwords = new List<string>();
            FileInfo theSourceFile = new FileInfo(m_authentication_file);
            StreamReader reader = theSourceFile.OpenText();

            string text;

            do
            {
                text = reader.ReadLine();
                string[] values = text.Split(","[0]);
                if (username == values[0] && password == values[1])
                {
                    _debugText.text = "Login Success";
                    return;
                }
            } while (text != null);
            
            _debugText.text = "Wrong Username or Password, try again";
            return;


        }
        public void LoginAcct()
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                _debugText.text = "Input fields cannot be empty";
                return;
            }

            LoginExists();
        }

        public void CreateAcct()
        {
            if (string.IsNullOrEmpty(signUpname) || string.IsNullOrEmpty(signUpupassword) || string.IsNullOrEmpty(signUpusername) )
            {
                _debugText.text = "Input fields cannot be empty";
                return;
            }

            if (signUpusername.Length > 3 && signUpupassword.Length > 3)
            {
                
                _debugText.text = "Success Account Created";
                TextWriter tw = new StreamWriter(m_authentication_file, true);
                string newLine = signUpname + "," + signUpusername + "," + signUpupassword + "\n";
                tw.WriteLine(newLine);

                // close the stream
                tw.Close();
                OpenLoginAcctMenu();
            }
            else
            {
                _debugText.text = "Username and Password must be at least 4 characters";
            }
        }

        public void OpenCreateAcctMenu()
        {
            _login.SetActive(false);
            _create.SetActive(true);
        }

        public void OpenLoginAcctMenu()
        {
            _login.SetActive(true);
            _create.SetActive(false);
        }
    }
}
