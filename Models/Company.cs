namespace MvcModelsApp.Models
{
    public class Company
    {
        public int Id { set; get; }
        public string? Title { set; get; }
        public string? Country { set; get; }
    }

    public class CompanyModel
    {
        public int Id { set; get; }
        public string? Title { set; get; }
    }
}
