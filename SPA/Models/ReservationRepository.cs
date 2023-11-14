namespace SPA.Models
{
    public class ReservationRepository
    {
        private static ReservationRepository repo = new ReservationRepository();

        public static ReservationRepository Current
        {
            get
            {
                return repo;
            }
        }

        private List<Reserve> data = new List<Reserve> {
            new Reserve {
                Id = 1, Name = "Петр", LastName = "Есенин", Location = "Стол 1"},
            new Reserve {
                Id = 2, Name = "Вася", LastName = "Гоголь", Location = "Стол 3"},
            new Reserve {
                Id = 3, Name = "Игорь", LastName = "Пушкин", Location = "Стол 1"},
        };

        public IEnumerable<Reserve> GetAll()
        {
            return data;
        }

        public Reserve Get(int id)
        {
            return data.FirstOrDefault(r => r.Id == id);
        }

        public Reserve Add(Reserve item)
        {
            item.Id = data.Count + 1;
            data.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            Reserve item = Get(id);
            if (item != null)
            {
                data.Remove(item);
            }
        }
    }
}
