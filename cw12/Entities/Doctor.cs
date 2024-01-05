namespace cw12.Entities
{
    public class Doctor : User
    {
        public Sickness Skill { get; set; }
        public int Price { get; set; }

        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
