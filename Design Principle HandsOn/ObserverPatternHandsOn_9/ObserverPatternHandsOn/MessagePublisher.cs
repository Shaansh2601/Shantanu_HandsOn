using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternHandsOn
{
    class MessagePublisher:Subject
    {
        private List<Observer> observers = new List<Observer>();

        private int getState = 1;
        public int GetState { get => getState; set => value = getState; }

        public void Attach(Observer o)
        {

            observers.Add(o);

        }

        public void ChangeState(int val)
        {
            if (val != getState)
            {

                GetState = val;

                NotifyUpdate(new Message("Subject State has been changed"));
            }
        }

        public void Detach(Observer o)
        {
            observers.Remove(o);
        }
        public void NotifyUpdate(Message m)
        {


            observers.ForEach(x => x.Update(m));
        }
    }
}
