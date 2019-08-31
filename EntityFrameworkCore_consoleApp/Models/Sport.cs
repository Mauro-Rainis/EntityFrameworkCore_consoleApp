namespace EntityFrameworkCore_consoleApp.Models
{
    class Sport
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public override string ToString()
        {
            return Id + " " + Nome;
        }
    }
}
