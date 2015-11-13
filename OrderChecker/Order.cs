using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderChecker
{
    public class Order
    {
        private string _checkMe;
        private List<int> _numbers= new List<int>();
        private bool _answer;
        private string _response;

        private void convertToNumbers()
        {
            var currentString = new StringBuilder();
            foreach (char a in _checkMe)
            {
                if (a == '-' || a == '\0')
                {
                    _numbers.Add(Convert.ToInt32(currentString.ToString()));
                    currentString.Clear();
                }
                else
                {
                    currentString.Append(a);
                }
            }
        }

        public Order(string numbers)
        {
            _checkMe = numbers + "-";
        }

        public string Check()
        {
            convertToNumbers();
            if (_numbers[0] < _numbers[1])
            {
                for(int i = 0; i < _numbers.Count - 1; i++)
                {
                    if (_numbers[i+1] - _numbers[i]!= 1)
                    {
                        _answer = false;
                        break;
                    }
                    _answer = true;

                }
                
            }
            else
            {
                for (int i = 0; i < _numbers.Count - 1; i++)
                {
                    if (i == 0)
                    {
                        continue;
                    }
                    else if (_numbers[i] - _numbers[i + 1] != 1)
                    {
                        _answer = false;
                        break;
                    }
                       
                    else
                    {
                        _answer = true; ;
                        continue;
                    }
                    
                }
                

            }
            if (_answer)
                _response = "Consecutive";
            else
                _response = "Not Consecutive";
            return _response;
        }

        public string printList()
        {
            var sList = new StringBuilder();
            foreach(int i in _numbers)
            {
                sList.Append(i.ToString());
            }

            return sList.ToString();
        }

    }
}
