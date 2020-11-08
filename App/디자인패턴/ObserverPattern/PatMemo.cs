using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class PatMemo : IUpdate
    {
        Patient patient = null;
        public PatMemo(Patient patient)
        {
            this.patient = patient;
        }
        public void Update()
        {
            Console.WriteLine("이름:{0} \n관심환자 여부:{1}, \n관심메모:{2}", patient.Name, patient.Fav, patient.Memo);
        }
    }
}
