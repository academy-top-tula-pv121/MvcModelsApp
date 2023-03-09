namespace MvcModelsApp.Models.ViewModels
{
    public class ComplexModel
    {
        public IEnumerable<CompanyModel> Companies { get; set; } = new List<CompanyModel>();
        public IEnumerable<Employe> Employes { get; set; } = new List<Employe>();
    }
}
