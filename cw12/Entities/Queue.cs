namespace cw12.Entities
{
    public class Queue
    {

        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        //public Sickness Sickness { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public int DocterId { get; set; }
        public int PatientId { get; set; }

    }
}
