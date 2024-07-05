using BookManagement.BLL.Services;
using BookManagement.DAL.Models;
using System;
using System.Windows;

namespace BookManagement_HoangNgocTrinh
{
    public partial class BookDetailWindow : Window
    {
        private readonly BookService _service = new();
        private readonly CategoryService _categoryService = new();
        private readonly Book _bookToUpdate;

        public BookDetailWindow()
        {
            InitializeComponent();
        }

        public BookDetailWindow(Book book) : this()
        {
            _bookToUpdate = book;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BookCategoryIdComboBox.ItemsSource = _categoryService.GetAllCategories();
            BookCategoryIdComboBox.DisplayMemberPath = "BookGenreType";
            BookCategoryIdComboBox.SelectedValuePath = "BookCategoryId";

            if (_bookToUpdate != null)
            {
                LoadBookDetails();
            }
        }

        private void LoadBookDetails()
        {
            BookIdTextBox.Text = _bookToUpdate.BookId.ToString();
            BookNameTextBox.Text = _bookToUpdate.BookName;
            DescriptionTextBox.Text = _bookToUpdate.Description;
            QuantityTextBox.Text = _bookToUpdate.Quantity.ToString();
            PriceTextBox.Text = _bookToUpdate.Price.ToString();
            AuthorTextBox.Text = _bookToUpdate.Author;
            PublicationDateDatePicker.SelectedDate = _bookToUpdate.PublicationDate;
            BookCategoryIdComboBox.SelectedValue = _bookToUpdate.BookCategoryId;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (_bookToUpdate != null)
            {
                _bookToUpdate.BookName = BookNameTextBox.Text;
                _bookToUpdate.Description = DescriptionTextBox.Text;
                _bookToUpdate.PublicationDate = (DateTime)PublicationDateDatePicker.SelectedDate;
                _bookToUpdate.Quantity = int.Parse(QuantityTextBox.Text);
                _bookToUpdate.Price = double.Parse(PriceTextBox.Text);
                _bookToUpdate.Author = AuthorTextBox.Text;
                _bookToUpdate.BookCategoryId = (int)BookCategoryIdComboBox.SelectedValue;

                _service.UpdateBook(_bookToUpdate);
            }
            else
            {
                Book book = new Book
                {
                    BookId = int.Parse(BookIdTextBox.Text),
                    BookName = BookNameTextBox.Text,
                    Description = DescriptionTextBox.Text,
                    PublicationDate = (DateTime)PublicationDateDatePicker.SelectedDate,
                    Quantity = int.Parse(QuantityTextBox.Text),
                    Price = double.Parse(PriceTextBox.Text),
                    Author = AuthorTextBox.Text,
                    BookCategoryId = (int)BookCategoryIdComboBox.SelectedValue
                };

                _service.CreateBook(book);
            }

            this.Close();
        }
    }
}
