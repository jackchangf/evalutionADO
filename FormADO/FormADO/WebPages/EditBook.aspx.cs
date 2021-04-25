using FormADO.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormADO.WebPages
{
    public partial class EditBook : System.Web.UI.Page
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ConnectionString;

        int bookId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["bookid"] != "")
                bookId = Convert.ToInt16(Request.QueryString["bookid"]);
            else
                Response.Redirect("Books.aspx");

            if (!IsPostBack)
            {
                FillBookData();
            }
        }

        private void FillBookData()
        {
            //create dataaccesslayer book,
            Book book = new Book();

            // use the method GetBookDate to get a book
            book = book.GetBookData(connectionString, bookId);

            //display it to ui

            txtTitle.Text = book.Title;
            txtIsbn.Text = book.Isbn;
            txtPublisher.Text = book.PublisherName;
            txtAuthor.Text = book.AuthorName;
            txtCategory.Text = book.CategoryName;
            radioQuestion1.SelectedValue = book.Question1.ToString();
            txtQuestion2.Text = book.Question2;
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //create new book to pass to the dataaccess, from ui
            Book book = new Book();

            book.BookId = bookId;
            book.Title = txtTitle.Text;
            book.Isbn = txtIsbn.Text;
            book.PublisherName = txtPublisher.Text;
            book.AuthorName = txtAuthor.Text;
            book.CategoryName = txtCategory.Text;
            book.Question1 = Convert.ToInt32(radioQuestion1.SelectedItem.Value);
            book.Question2 = txtQuestion2.Text;

            //call dataaccesslayer method to editbook
            book.EditBook(connectionString, book);

            Response.Redirect("Books.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Books.aspx");
        }


    }
}