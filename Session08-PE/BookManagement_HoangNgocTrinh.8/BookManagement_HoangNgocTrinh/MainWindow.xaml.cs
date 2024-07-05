using BookManagement.BLL.Services;
using BookManagement.DAL.Models;
using System;
using System.Linq;
using System.Windows;

namespace BookManagement_HoangNgocTrinh
{
    public partial class MainWindow : Window
    {
        private BookService _service = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BookMainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            BookListDataGrid.ItemsSource = null;
            BookListDataGrid.ItemsSource = _service.GetAllBooks();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BookDetailWindow bookDetailWindow = new();
            bookDetailWindow.ShowDialog();
            LoadDataGrid();
        }
        //Nút search thần thánh :v
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string bookName = BookNameTextBox.Text.Trim().ToLower();
            string description = DescriptionTextBox.Text.Trim().ToLower();

            var filteredBooks = _service.GetAllBooks().Where(b =>
                (string.IsNullOrEmpty(bookName) || b.BookName.ToLower().Contains(bookName)) &&
                (string.IsNullOrEmpty(description) || b.Description.ToLower().Contains(description))).ToList();

            BookListDataGrid.ItemsSource = null;
            BookListDataGrid.ItemsSource = filteredBooks;
        }
        //Update
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (BookListDataGrid.SelectedItem is Book selectedBook)
            {
                BookDetailWindow bookDetailWindow = new BookDetailWindow(selectedBook);
                bookDetailWindow.ShowDialog();
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Please select a book to update.");
            }
        }
        //Delete
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (BookListDataGrid.SelectedItem is Book selectedBook)
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    _service.DeleteBook(selectedBook.BookId);
                    LoadDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
