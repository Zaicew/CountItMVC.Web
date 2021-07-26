namespace CountItMVC.Domain.Model
{
    public class CustomerContactInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }







        //(1) how to make 1vs1 relation in DB:
        public int CustomerRef { get; set; }
        public virtual Customer Customer { get; set; }

    }
}