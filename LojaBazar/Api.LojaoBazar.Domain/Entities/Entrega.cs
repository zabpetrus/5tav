namespace Api.LojaoBazar.Domain.Entities
{
    public class Entrega
    {
        private int Id { get; set; }

        private bool Status { get; set; }

        public void setId(int v) { Id = v; }

        public void setStatus(bool v) { Status = v; }

        public int getId() { return Id; }

        public bool getStatus() { return Status; }

    }
}
