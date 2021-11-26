using System;
using System.Collections.Generic;
using System.Text;

namespace lr1
{
    class LR2
    {
        private string kuda;
        private int ticket;
        private string typeofplane;
        
        public LR2() { }

        public LR2(string kuda, int ticket, string typeofplane)
        {
            this.kuda = kuda;
            this.ticket = ticket;
            this.typeofplane = typeofplane;
        }
        public string getKuda() { return kuda; }
        public string getTypeofplane() { return typeofplane; }
        public int getTicket() { return ticket; }
        public void setKuda(string j) { kuda = j; }
        public void setTypeofplane(string j) { typeofplane = j; }
        public void setTicket(int j) { ticket = j; }

        public string isCorrectTicket(int t)
        {
            if (t == ticket)
                return typeofplane;
            else
                return "не совпадает номер билета";
        }
    }
}
