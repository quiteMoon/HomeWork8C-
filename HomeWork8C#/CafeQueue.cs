using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8C_
{
    internal class CafeQueue
    {
        private Queue<string> queue = new Queue<string>();
        private Dictionary<string, DateTime> reservations = new Dictionary<string, DateTime>();
        private int totalTables;
        private int occupiedTables = 0;

        public CafeQueue(int tableCount)
        {
            totalTables = tableCount;
        }

        public void AddVisitor(string visitorName, DateTime? reservationTime = null)
        {
            if (reservationTime.HasValue)
            {
                reservations[visitorName] = reservationTime.Value;
                Console.WriteLine($"Відвідувач {visitorName} доданий до резерву на {reservationTime.Value}.");
            }
            else
            {
                queue.Enqueue(visitorName);
                Console.WriteLine($"Відвідувач {visitorName} доданий у чергу.");
            }
        }

        public void FreeTable()
        {
            if (reservations.Count > 0)
            {
                string reservedVisitor = GetNextReservation();
                reservations.Remove(reservedVisitor);
                Console.WriteLine($"Столик надано зарезервованому відвідувачу {reservedVisitor}.");
            }
            else if (queue.Count > 0)
            {
                string nextVisitor = queue.Dequeue();
                Console.WriteLine($"Столик надано відвідувачу {nextVisitor} з черги.");
            }
            else
            {
                Console.WriteLine("Черга порожня, столик вільний.");
            }

            occupiedTables--;
        }

        private string GetNextReservation()
        {
            string nextVisitor = null;
            DateTime earliestTime = DateTime.MaxValue;

            foreach (var reservation in reservations)
            {
                if (reservation.Value < earliestTime)
                {
                    earliestTime = reservation.Value;
                    nextVisitor = reservation.Key;
                }
            }

            return nextVisitor;
        }

        public void OccupyTable()
        {
            if (occupiedTables < totalTables)
            {
                Console.WriteLine("Столик зайнятий.");
                occupiedTables++;
            }
            else
            {
                Console.WriteLine("Немає вільних столиків. Додайте відвідувача у чергу або резерв.");
            }
        }
    }
}
