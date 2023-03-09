namespace MvcModelsApp.Models
{
    public class Employe
    {
        public int Id { set; get; }
        public string? Name { set; get; }
        public int Age { set; get; }
        public Company? Company { set; get; }
    }
}
