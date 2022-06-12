namespace InterviewLab.Lab1.Question
{
    public class Book
	{
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public string isbn { get; set; }
		public Book(string name, string authorName, int year, int price, string isbn)
		{
			this.Name = name;
			this.AuthorName = authorName;
			this.Year = year;
			this.Price = price;
			this.isbn = isbn;
		}
	}
}
