namespace Lab2
{
    public struct Author
    {
        private string lastname;
        private string name;

        public Author(string _lastname, string _name)
        {
            lastname = _lastname;
            name = _name;
        }

        public string Lastname { get => lastname; }
        public string Name { get => name; }

        public string GetFullFIO() => $"{Lastname} {Name}";
    }
    public abstract class Library
    {
        protected Author fio;
        protected string name;
        protected int pages;
        protected string publishingHouse;

        public Author FIO { get => fio; set { fio = value; } }
        public string Name { get => name; set { name = value; } }
        public int Pages { get => pages; set { pages = value; } }   
        public string PublishingHouse { get => publishingHouse; set { publishingHouse = value; } }
        public Library(Author _fio, string _name, int _pages, string _publHome)
        {
            fio = _fio;
            name = _name;
            pages = _pages;
            publishingHouse = _publHome;
        }

        public abstract string GetInfo();
    }
    public class Book : Library
    {
        protected string genre;
        
        public string Genre { get => genre; set { genre = value; } }

        public Book(Author _fio, string _name, int _pages, string _publHome, string _genre):base(_fio, _name, _pages, _publHome)
        {
            genre = _genre;
        }

        public override string ToString() => "Книга";
        public override string GetInfo() => $"\n{this.ToString()}\nАвтор:{this.FIO.GetFullFIO()}\nНазвание:{this.Name}\nКол-во страниц:{this.Pages}\nИздательство:{this.PublishingHouse}\nЖанр:{this.Genre}\n";
        }
    public class Magazine : Library
    {
        protected string category;
        public string Category { get => category; set { category = value; } }

        public Magazine(Author _fio, string _name, int _pages, string _publHome, string _category) : base(_fio, _name, _pages, _publHome)
        {
            category = _category;
        }
        public override string ToString() => "Журнал";

        public override string GetInfo() => $"\n{this.ToString()}\nАвтор:{this.FIO.GetFullFIO()}\nНазвание:{this.Name}\nКол-во страниц:{this.Pages}\nИздательство:{this.PublishingHouse}\nКатегория:{this.Category}\n";
    }
}
   
