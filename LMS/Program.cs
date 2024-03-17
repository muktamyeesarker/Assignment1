var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Library Management System!");


//Books
app.MapGet("/books", () =>
{
    return "There are all books";
}
    );


app.MapGet("/books/{id}", (HttpContext context) =>
{
    var BookId = context.Request.RouteValues["id"];
    return "ID is: " + BookId;
});

    

app.MapPost("/books", () =>
{
    return "Added a new book";
});

app.MapPut("/books/{id}", (HttpContext context) =>
{
    var BookId = context.Request.RouteValues["id"];
    return "ID is: " + BookId;
});

app.MapDelete("/books/{id}", (HttpContext context) =>
{
    var BookId = context.Request.RouteValues["id"];
    return "ID is: " + BookId;
});


//Borrowing books

app.MapGet("/borrowing_books", () =>
{
    return "There are all borrowing books from reader";
}
    );


app.MapGet("/borrowing_books/{id}", (HttpContext context) =>
{
    var BookId = context.Request.RouteValues["id"];
    return "ID is: " + BookId;
});


app.MapPost("/borrowing_books", () =>
{
    return "Added a new book";
});

app.MapPut("/borrowing_books/{id}", (HttpContext context) =>
{
    var BookId = context.Request.RouteValues["id"];
    return "ID is: " + BookId;
});

app.MapDelete("/borrowing_books/{id}", (HttpContext context) =>
{
    var BookId = context.Request.RouteValues["id"];
    return "ID is: " + BookId;
});



//Reader Management

app.MapGet("/readers data", () =>
{
    return "There are all readerss";
}
    );



app.MapGet("/readers/{id}", (HttpContext context) =>
{
    var BookId = context.Request.RouteValues["id"];
    return "ID is: " + BookId;
});



app.MapPost("/readers", () =>
{
    return "Added a new reader";
});

app.MapPut("/readers/{id}", (HttpContext context) =>
{
    var BookId = context.Request.RouteValues["id"];
    return "ID is: " + BookId;
});

app.MapDelete("/readers/{id}", (HttpContext context) =>
{
    var BookId = context.Request.RouteValues["id"];
    return "ID is: " + BookId;
});




app.Run();
