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
    public partial class NewBook : System.Web.UI.Page
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //passing values from the UI to the backend parameter book to be passed to dataaccesslayer Data.Book.cs
            //create an instance of the dataaccesslayer book
            Book book = new Book();

            book.Title = txtTitle.Text;
            book.Isbn = txtIsbn.Text;
            book.PublisherName = txtPublisher.Text;
            book.AuthorName = txtAuthor.Text;
            book.CategoryName = txtCategory.Text;
            book.Question1 = Convert.ToInt32(radioQuestion1.SelectedItem.Value);
            book.Question2 = txtQuestion2.Text;

            //call the dataaccesslayer method createbook
            book.CreateBook(connectionString, book);

            Response.Redirect("Books.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Books.aspx");
        }
    }
}