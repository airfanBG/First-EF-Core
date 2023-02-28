// See https://aka.ms/new-console-template for more information
using First_EF_Core.Data;
using First_EF_Core.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
using (BooksDbContex db=new BooksDbContex())
{
    //Author author = new Author()
    //{
    //    AuthorName = "Ivan Vazov"
    //};
    //db.Authors.Add(author);
    //db.SaveChanges();
   // var res = db.Authors.Where(x=>x.AuthorName=="Ivan Vazov").ToList();
}

//SqlConnection sql = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorks2019;Integrated Security=True;TrustServerCertificate=True;");
//SqlCommand cmd = new SqlCommand("select * from Person.Person",sql);
//sql.Open();
//var result= cmd.ExecuteReader();
//result.Read();
//sql.Close();