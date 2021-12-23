using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_service
{
    class Question
    {
        private string ques;
        private string answer;
        public Question(string question, string answer) {
            this.ques = question;
            this.answer = answer;
        }
        public string getanswer() {
            return this.answer;
        }
    }
}
