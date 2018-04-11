using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace _06._04
{
    public partial class Form1 : Form
    {
        DataTable dataTableBook = null;
        DataTable dataTableAuthor = null;
        DataTable dataTablePublisher = null;
        public Form1()
        {
            InitializeComponent();
            GetAll(dataGridBooks);
            GetAll(dataGridAuthors);
            GetAll(dataGridPublishers);
        }

        private void GetAll(DataGridView dataGrid)
        {
            using (Library2Entities db = new Library2Entities())
            {
                if (dataGrid.Name.ToString() == "dataGridBooks")
                {
                    dataTableBook = new DataTable();
                    dataTableBook.Columns.Add("Id");
                    dataTableBook.Columns.Add("Title");
                    dataTableBook.Columns.Add("IdAuthor");
                    dataTableBook.Columns.Add("Pages");
                    dataTableBook.Columns.Add("Price");
                    dataTableBook.Columns.Add("IdPublisher");
                    foreach (var item in db.Book)
                    {
                        DataRow dataRow = dataTableBook.NewRow();
                        dataRow["Id"] = item.Id;
                        dataRow["Title"] = item.Title;
                        dataRow["IdAuthor"] = item.IdAuthor;
                        dataRow["Pages"] = item.Pages;
                        dataRow["Price"] = item.Price;
                        dataRow["IdPublisher"] = item.IdPublisher;
                        dataTableBook.Rows.Add(dataRow);
                    }
                    dataGridBooks.DataSource = null;
                    dataGridBooks.DataSource = dataTableBook;
                }
                else if (dataGrid.Name.ToString() == "dataGridAuthors")
                {
                    dataTableAuthor = new DataTable();
                    dataTableAuthor.Columns.Add("Id");
                    dataTableAuthor.Columns.Add("FirstName");
                    dataTableAuthor.Columns.Add("LastName");
                    foreach (var item in db.Author)
                    {
                        DataRow dataRow = dataTableAuthor.NewRow();
                        dataRow["Id"] = item.Id;
                        dataRow["FirstName"] = item.FirstName;
                        dataRow["LastName"] = item.LastName;
                        dataTableAuthor.Rows.Add(dataRow);
                    }
                    dataGridAuthors.DataSource = null;
                    dataGridAuthors.DataSource = dataTableAuthor;
                }
                else if (dataGrid.Name.ToString() == "dataGridPublishers")
                {
                    dataTablePublisher = new DataTable();
                    dataTablePublisher.Columns.Add("Id");
                    dataTablePublisher.Columns.Add("PublisherName");
                    dataTablePublisher.Columns.Add("Address");
                    foreach (var item in db.Publisher)
                    {
                        DataRow dataRow = dataTablePublisher.NewRow();
                        dataRow["Id"] = item.Id;
                        dataRow["PublisherName"] = item.PublisherName;
                        dataRow["Address"] = item.Address;
                        dataTablePublisher.Rows.Add(dataRow);
                    }
                    dataGridPublishers.DataSource = null;
                    dataGridPublishers.DataSource = dataTablePublisher;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Library2Entities db = new Library2Entities())
            {
                if (tabBox.SelectedTab.Name== "tabBooks")
                {
                    int index = dataGridBooks.CurrentRow.Index;
                    Book book = new Book();
                    book.Title = dataGridBooks["Title", index].Value.ToString();
                    book.IdAuthor = Convert.ToInt32(dataGridBooks["IdAuthor", index].Value);
                    book.Pages = Convert.ToInt32(dataGridBooks["Pages", index].Value);
                    book.Price = Convert.ToInt32(dataGridBooks["Price", index].Value);
                    book.IdPublisher = Convert.ToInt32(dataGridBooks["IdPublisher", index].Value);
                    db.Book.Add(book);
                    db.SaveChanges();
                    GetAll(dataGridBooks);
                }
                else if (tabBox.SelectedTab.Name == "tabAuthors")
                {
                    int index = dataGridAuthors.CurrentRow.Index;
                    Author author = new Author();
                    author.FirstName = dataGridAuthors["FirstName", index].Value.ToString();
                    author.LastName = dataGridAuthors["LastName", index].Value.ToString();
                    db.Author.Add(author);
                    db.SaveChanges();
                    GetAll(dataGridAuthors);
                }
                else if (tabBox.SelectedTab.Name == "tabPublishers")
                {
                    int index = dataGridPublishers.CurrentRow.Index;
                    Publisher publisher = new Publisher();
                    publisher.PublisherName = dataGridPublishers["PublisherName", index].Value.ToString();
                    publisher.Address = dataGridPublishers["Address", index].Value.ToString();
                    db.Publisher.Add(publisher);
                    db.SaveChanges();
                    GetAll(dataGridPublishers);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (Library2Entities db = new Library2Entities())
            {
                if (tabBox.SelectedTab.Name == "tabBooks")
                {
                    int index = dataGridBooks.CurrentRow.Index;
                    int id = Convert.ToInt32(dataGridBooks[0, index].Value);
                    db.Book.Find(id).Title = dataGridBooks["Title", index].Value.ToString();
                    db.Book.Find(id).IdAuthor = Convert.ToInt32(dataGridBooks["IdAuthor", index].Value);
                    db.Book.Find(id).Pages = Convert.ToInt32(dataGridBooks["Pages", index].Value);
                    db.Book.Find(id).Price = Convert.ToInt32(dataGridBooks["Price", index].Value);
                    db.Book.Find(id).IdPublisher = Convert.ToInt32(dataGridBooks["IdPublisher", index].Value);
                    db.SaveChanges();
                    GetAll(dataGridBooks);
                }
                else if (tabBox.SelectedTab.Name == "tabAuthors")
                {
                    int index = dataGridAuthors.CurrentRow.Index;
                    int id = Convert.ToInt32(dataGridAuthors[0, index].Value);
                    db.Author.Find(id).FirstName = dataGridAuthors["FirstName", index].Value.ToString();
                    db.Author.Find(id).LastName = dataGridAuthors["LastName", index].Value.ToString();
                    db.SaveChanges();
                    GetAll(dataGridAuthors);
                }
                else if (tabBox.SelectedTab.Name == "tabPublishers")
                {
                    int index = dataGridPublishers.CurrentRow.Index;
                    int id = Convert.ToInt32(dataGridPublishers[0, index].Value);
                    db.Publisher.Find(id).PublisherName = dataGridPublishers["PublisherName", index].Value.ToString();
                    db.Publisher.Find(id).Address = dataGridPublishers["Address", index].Value.ToString();
                    db.SaveChanges();
                    GetAll(dataGridPublishers);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (Library2Entities db = new Library2Entities())
            {
                if (tabBox.SelectedTab.Name == "tabBooks")
                {
                    if (dataGridBooks.SelectedRows.Count > 0)
                    {
                        int index = dataGridBooks.SelectedRows[0].Index;
                        int id =  Convert.ToInt32(dataGridBooks[0, index].Value);
                        Book book = db.Book.Find(id);
                        db.Book.Remove(book);
                        db.SaveChanges();
                        GetAll(dataGridBooks);
                    }
                }
                else if (tabBox.SelectedTab.Name == "tabAuthors")
                {
                    if (dataGridAuthors.SelectedRows.Count > 0)
                    {
                        int index = dataGridAuthors.SelectedRows[0].Index;
                        int id = Convert.ToInt32(dataGridAuthors[0, index].Value);
                        Author author = db.Author.Find(id);
                        db.Author.Remove(author);
                        db.SaveChanges();
                        GetAll(dataGridAuthors);
                    }
                }
                else if (tabBox.SelectedTab.Name == "tabPublishers")
                {
                    if (dataGridPublishers.SelectedRows.Count > 0)
                    {
                        int index = dataGridPublishers.SelectedRows[0].Index;
                        int id = Convert.ToInt32(dataGridPublishers[0, index].Value);
                        Publisher publisher = db.Publisher.Find(id);
                        db.Publisher.Remove(publisher);
                        db.SaveChanges();
                        GetAll(dataGridPublishers);
                    }
                }
            }
        }
    }
}
