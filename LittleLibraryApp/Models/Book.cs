class Book
{
public int Id { get; set; }
public string Title { get; set; }
public string Author { get; set; }
public bool Fiction { get; set; }

public int Library { get; set; }
public Book()
{
    Title = "";
	Author = "";
	
}


public Book(int id, string title, string author, bool fiction, int library)
{

	Id = id;
	Title = title;
	Author = author;
	Fiction = fiction;
	Library = library;
}

public override string ToString()
{
	return "{'ID':" + Id
	+ ", 'Title':"
	+ Title + " ,Author:"
	+ Author + ",Fiction: "
	+ Fiction
	+ "Library Location: " + Library +"}";
}
}    