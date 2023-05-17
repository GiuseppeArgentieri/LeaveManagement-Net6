namespace LeaveManagement.web.Data
{
    public abstract class BaseEntity //non puoi istanziarla, funziona solo con l'ineritance
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateDatemodified { get; set; }
    }
}
