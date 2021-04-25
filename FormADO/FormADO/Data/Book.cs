using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace FormADO.Data
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string PublisherName { get; set; }
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }
        public int Question1 { get; set; }
        public string Question2 { get; set; }

        public List<Book> GetBooks(string connectionString)
        {
            List<Book> bookList = new List<Book>();
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "select BookId, Title, Isbn, PublisherName, AuthorName, CategoryName, ISNULL(Question1, 0)Question1, ISNULL(Question2,'')Question2 from GetBookData";
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Book book = new Book();
                    book.BookId = Convert.ToInt32(dr["BookId"]);
                    book.Title = dr["Title"].ToString();
                    book.Isbn = dr["ISBN"].ToString();
                    book.PublisherName = dr["PublisherName"].ToString();
                    book.AuthorName = dr["AuthorName"].ToString();
                    book.CategoryName = dr["CategoryName"].ToString();
                    book.Question1 = Convert.ToInt32(dr["Question1"]);
                    book.Question2 = dr["Question2"].ToString();
                    bookList.Add(book);
                }
            }
            return bookList;
        }

        public void CreateBook(string connectionString, Book book)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("CreateBook", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Title", book.Title));
                    cmd.Parameters.Add(new SqlParameter("@Isbn", book.Isbn));
                    cmd.Parameters.Add(new SqlParameter("@PublisherName", book.PublisherName));
                    cmd.Parameters.Add(new SqlParameter("@AuthorName", book.AuthorName));
                    cmd.Parameters.Add(new SqlParameter("@CategoryName", book.CategoryName));
                    cmd.Parameters.Add(new SqlParameter("@Question1", book.Question1));
                    cmd.Parameters.Add(new SqlParameter("@Question2", book.Question2));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Book GetBookData(string connectionString, int bookId)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "select BookId, Title, Isbn, PublisherName, AuthorName, CategoryName, ISNULL(Question1, 0)Question1, ISNULL(Question2,'')Question2 from GetBookData where BookId = @paraId";
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            cmd.Parameters.AddWithValue("@paraId", bookId);
            SqlDataReader dr = cmd.ExecuteReader();
            Book book = new Book();
            if (dr != null)
            {
                while (dr.Read())
                {
                    book.BookId = Convert.ToInt32(dr["BookId"]);
                    book.Title = dr["Title"].ToString();
                    book.Isbn = dr["ISBN"].ToString();
                    book.PublisherName = dr["PublisherName"].ToString();
                    book.AuthorName = dr["AuthorName"].ToString();
                    book.CategoryName = dr["CategoryName"].ToString();
                    book.Question1 = Convert.ToInt32(dr["Question1"]);
                    book.Question2 = dr["Question2"].ToString();
                }
            }
            return book;
        }

        public void EditBook(string connectionString, Book book)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateBook", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@BookId", book.BookId));
                    cmd.Parameters.Add(new SqlParameter("@Title", book.Title));
                    cmd.Parameters.Add(new SqlParameter("@Isbn", book.Isbn));
                    cmd.Parameters.Add(new SqlParameter("@PublisherName", book.PublisherName));
                    cmd.Parameters.Add(new SqlParameter("@AuthorName", book.AuthorName));
                    cmd.Parameters.Add(new SqlParameter("@CategoryName", book.CategoryName));
                    cmd.Parameters.Add(new SqlParameter("@Question1", book.Question1));
                    cmd.Parameters.Add(new SqlParameter("@Question2", book.Question2));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteBook(string connectionString, int bookId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteBook", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@BookId", bookId));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}