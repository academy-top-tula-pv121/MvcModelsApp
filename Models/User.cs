namespace MvcModelsApp.Models
{
    /*
    Модели данных
    Модели которые получают содержимое их хранилищ (БД, xml файлы и тп)

    Модели представления
    Модели для передачи данных в представление или получение данных из представления 

    Промежуточные модели
     */
    public record class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public User(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
