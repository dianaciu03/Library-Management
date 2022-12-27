﻿namespace Library_Individual
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ComboBox cbGenreBook;
            System.Windows.Forms.ComboBox cbBookGenreSearch;
            System.Windows.Forms.ComboBox cbAvailableBooksGenre;
            this.tabControlUserForm = new System.Windows.Forms.TabControl();
            this.tabManageBooks = new System.Windows.Forms.TabPage();
            this.gbSearchBy = new System.Windows.Forms.GroupBox();
            this.btnRemoveSelectedBook = new System.Windows.Forms.Button();
            this.btnDisplayAllBooks = new System.Windows.Forms.Button();
            this.lblGenreSearch = new System.Windows.Forms.Label();
            this.tbAuthorSearch = new System.Windows.Forms.TextBox();
            this.lblAuthorSearch = new System.Windows.Forms.Label();
            this.tbTitleSearch = new System.Windows.Forms.TextBox();
            this.lblTitleSearch = new System.Windows.Forms.Label();
            this.pictureBoxManageBooks = new System.Windows.Forms.PictureBox();
            this.gbAddBook = new System.Windows.Forms.GroupBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.numCopies = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfCopies = new System.Windows.Forms.Label();
            this.tbDescriptionBook = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbISBNBook = new System.Windows.Forms.TextBox();
            this.lblISBNBook = new System.Windows.Forms.Label();
            this.dateTimePublicationDateBook = new System.Windows.Forms.DateTimePicker();
            this.numNumberOfPagesBook = new System.Windows.Forms.NumericUpDown();
            this.lblPublicationDateBook = new System.Windows.Forms.Label();
            this.lblNumberOfPagesBook = new System.Windows.Forms.Label();
            this.lblGenreBook = new System.Windows.Forms.Label();
            this.tbAuthorBook = new System.Windows.Forms.TextBox();
            this.lblAuthorBook = new System.Windows.Forms.Label();
            this.tbTitleBook = new System.Windows.Forms.TextBox();
            this.lblTitleBook = new System.Windows.Forms.Label();
            this.tabManageLoans = new System.Windows.Forms.TabPage();
            this.gbLoanStatus = new System.Windows.Forms.GroupBox();
            this.lblHistoryLoans = new System.Windows.Forms.Label();
            this.btnSubmitReturn = new System.Windows.Forms.Button();
            this.dateTimeReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblActiveLoans = new System.Windows.Forms.Label();
            this.bgAvailableBooks = new System.Windows.Forms.GroupBox();
            this.btnLoanForm = new System.Windows.Forms.Button();
            this.btnDisplayAvailableBooks = new System.Windows.Forms.Button();
            this.lblAvailableBooksGenre = new System.Windows.Forms.Label();
            this.tbAvailableBooksAuthor = new System.Windows.Forms.TextBox();
            this.lblAvailableBooksAuthor = new System.Windows.Forms.Label();
            this.tbAvailableBooksTitle = new System.Windows.Forms.TextBox();
            this.lblAvailableBooksTitle = new System.Windows.Forms.Label();
            this.lblAvailableTitles = new System.Windows.Forms.Label();
            this.lblTitleMidnightReads = new System.Windows.Forms.Label();
            this.lbDisplayBooks = new System.Windows.Forms.ListBox();
            this.lbAvailableTitles = new System.Windows.Forms.ListBox();
            this.lbActiveLoans = new System.Windows.Forms.ListBox();
            this.lbLoanHistory = new System.Windows.Forms.ListBox();
            cbGenreBook = new System.Windows.Forms.ComboBox();
            cbBookGenreSearch = new System.Windows.Forms.ComboBox();
            cbAvailableBooksGenre = new System.Windows.Forms.ComboBox();
            this.tabControlUserForm.SuspendLayout();
            this.tabManageBooks.SuspendLayout();
            this.gbSearchBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManageBooks)).BeginInit();
            this.gbAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPagesBook)).BeginInit();
            this.tabManageLoans.SuspendLayout();
            this.gbLoanStatus.SuspendLayout();
            this.bgAvailableBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbGenreBook
            // 
            cbGenreBook.Location = new System.Drawing.Point(79, 105);
            cbGenreBook.Name = "cbGenreBook";
            cbGenreBook.Size = new System.Drawing.Size(266, 31);
            cbGenreBook.TabIndex = 5;
            // 
            // cbBookGenreSearch
            // 
            cbBookGenreSearch.Location = new System.Drawing.Point(79, 106);
            cbBookGenreSearch.Name = "cbBookGenreSearch";
            cbBookGenreSearch.Size = new System.Drawing.Size(266, 31);
            cbBookGenreSearch.TabIndex = 11;
            // 
            // cbAvailableBooksGenre
            // 
            cbAvailableBooksGenre.Location = new System.Drawing.Point(86, 107);
            cbAvailableBooksGenre.Name = "cbAvailableBooksGenre";
            cbAvailableBooksGenre.Size = new System.Drawing.Size(378, 31);
            cbAvailableBooksGenre.TabIndex = 17;
            // 
            // tabControlUserForm
            // 
            this.tabControlUserForm.Controls.Add(this.tabManageBooks);
            this.tabControlUserForm.Controls.Add(this.tabManageLoans);
            this.tabControlUserForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlUserForm.Location = new System.Drawing.Point(12, 52);
            this.tabControlUserForm.Name = "tabControlUserForm";
            this.tabControlUserForm.Padding = new System.Drawing.Point(20, 4);
            this.tabControlUserForm.SelectedIndex = 0;
            this.tabControlUserForm.Size = new System.Drawing.Size(1328, 917);
            this.tabControlUserForm.TabIndex = 4;
            // 
            // tabManageBooks
            // 
            this.tabManageBooks.Controls.Add(this.gbSearchBy);
            this.tabManageBooks.Controls.Add(this.pictureBoxManageBooks);
            this.tabManageBooks.Controls.Add(this.gbAddBook);
            this.tabManageBooks.Location = new System.Drawing.Point(4, 39);
            this.tabManageBooks.Name = "tabManageBooks";
            this.tabManageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageBooks.Size = new System.Drawing.Size(1320, 874);
            this.tabManageBooks.TabIndex = 0;
            this.tabManageBooks.Text = "Manage books";
            this.tabManageBooks.UseVisualStyleBackColor = true;
            // 
            // gbSearchBy
            // 
            this.gbSearchBy.BackColor = System.Drawing.Color.Wheat;
            this.gbSearchBy.Controls.Add(this.lbDisplayBooks);
            this.gbSearchBy.Controls.Add(this.btnRemoveSelectedBook);
            this.gbSearchBy.Controls.Add(this.btnDisplayAllBooks);
            this.gbSearchBy.Controls.Add(cbBookGenreSearch);
            this.gbSearchBy.Controls.Add(this.lblGenreSearch);
            this.gbSearchBy.Controls.Add(this.tbAuthorSearch);
            this.gbSearchBy.Controls.Add(this.lblAuthorSearch);
            this.gbSearchBy.Controls.Add(this.tbTitleSearch);
            this.gbSearchBy.Controls.Add(this.lblTitleSearch);
            this.gbSearchBy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSearchBy.Location = new System.Drawing.Point(15, 391);
            this.gbSearchBy.Name = "gbSearchBy";
            this.gbSearchBy.Size = new System.Drawing.Size(832, 297);
            this.gbSearchBy.TabIndex = 3;
            this.gbSearchBy.TabStop = false;
            this.gbSearchBy.Text = "Search by";
            // 
            // btnRemoveSelectedBook
            // 
            this.btnRemoveSelectedBook.BackColor = System.Drawing.Color.White;
            this.btnRemoveSelectedBook.Location = new System.Drawing.Point(79, 225);
            this.btnRemoveSelectedBook.Name = "btnRemoveSelectedBook";
            this.btnRemoveSelectedBook.Size = new System.Drawing.Size(199, 40);
            this.btnRemoveSelectedBook.TabIndex = 14;
            this.btnRemoveSelectedBook.Text = "Remove selected book";
            this.btnRemoveSelectedBook.UseVisualStyleBackColor = false;
            // 
            // btnDisplayAllBooks
            // 
            this.btnDisplayAllBooks.BackColor = System.Drawing.Color.White;
            this.btnDisplayAllBooks.Location = new System.Drawing.Point(79, 179);
            this.btnDisplayAllBooks.Name = "btnDisplayAllBooks";
            this.btnDisplayAllBooks.Size = new System.Drawing.Size(199, 40);
            this.btnDisplayAllBooks.TabIndex = 13;
            this.btnDisplayAllBooks.Text = "Display all books";
            this.btnDisplayAllBooks.UseVisualStyleBackColor = false;
            // 
            // lblGenreSearch
            // 
            this.lblGenreSearch.AutoSize = true;
            this.lblGenreSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenreSearch.Location = new System.Drawing.Point(6, 110);
            this.lblGenreSearch.Name = "lblGenreSearch";
            this.lblGenreSearch.Size = new System.Drawing.Size(60, 23);
            this.lblGenreSearch.TabIndex = 10;
            this.lblGenreSearch.Text = "Genre:";
            // 
            // tbAuthorSearch
            // 
            this.tbAuthorSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAuthorSearch.Location = new System.Drawing.Point(79, 70);
            this.tbAuthorSearch.Name = "tbAuthorSearch";
            this.tbAuthorSearch.Size = new System.Drawing.Size(266, 30);
            this.tbAuthorSearch.TabIndex = 9;
            // 
            // lblAuthorSearch
            // 
            this.lblAuthorSearch.AutoSize = true;
            this.lblAuthorSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthorSearch.Location = new System.Drawing.Point(6, 73);
            this.lblAuthorSearch.Name = "lblAuthorSearch";
            this.lblAuthorSearch.Size = new System.Drawing.Size(67, 23);
            this.lblAuthorSearch.TabIndex = 8;
            this.lblAuthorSearch.Text = "Author:";
            // 
            // tbTitleSearch
            // 
            this.tbTitleSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTitleSearch.Location = new System.Drawing.Point(79, 34);
            this.tbTitleSearch.Name = "tbTitleSearch";
            this.tbTitleSearch.Size = new System.Drawing.Size(266, 30);
            this.tbTitleSearch.TabIndex = 7;
            // 
            // lblTitleSearch
            // 
            this.lblTitleSearch.AutoSize = true;
            this.lblTitleSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleSearch.Location = new System.Drawing.Point(6, 37);
            this.lblTitleSearch.Name = "lblTitleSearch";
            this.lblTitleSearch.Size = new System.Drawing.Size(46, 23);
            this.lblTitleSearch.TabIndex = 6;
            this.lblTitleSearch.Text = "Title:";
            // 
            // pictureBoxManageBooks
            // 
            this.pictureBoxManageBooks.Image = global::Library_Individual.Properties.Resources.books;
            this.pictureBoxManageBooks.Location = new System.Drawing.Point(853, 15);
            this.pictureBoxManageBooks.Name = "pictureBoxManageBooks";
            this.pictureBoxManageBooks.Size = new System.Drawing.Size(461, 673);
            this.pictureBoxManageBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxManageBooks.TabIndex = 2;
            this.pictureBoxManageBooks.TabStop = false;
            // 
            // gbAddBook
            // 
            this.gbAddBook.BackColor = System.Drawing.Color.Wheat;
            this.gbAddBook.Controls.Add(this.btnAddBook);
            this.gbAddBook.Controls.Add(this.numCopies);
            this.gbAddBook.Controls.Add(this.lblNumberOfCopies);
            this.gbAddBook.Controls.Add(this.tbDescriptionBook);
            this.gbAddBook.Controls.Add(this.lblDescription);
            this.gbAddBook.Controls.Add(this.tbISBNBook);
            this.gbAddBook.Controls.Add(this.lblISBNBook);
            this.gbAddBook.Controls.Add(this.dateTimePublicationDateBook);
            this.gbAddBook.Controls.Add(this.numNumberOfPagesBook);
            this.gbAddBook.Controls.Add(this.lblPublicationDateBook);
            this.gbAddBook.Controls.Add(this.lblNumberOfPagesBook);
            this.gbAddBook.Controls.Add(cbGenreBook);
            this.gbAddBook.Controls.Add(this.lblGenreBook);
            this.gbAddBook.Controls.Add(this.tbAuthorBook);
            this.gbAddBook.Controls.Add(this.lblAuthorBook);
            this.gbAddBook.Controls.Add(this.tbTitleBook);
            this.gbAddBook.Controls.Add(this.lblTitleBook);
            this.gbAddBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbAddBook.Location = new System.Drawing.Point(15, 15);
            this.gbAddBook.Name = "gbAddBook";
            this.gbAddBook.Size = new System.Drawing.Size(832, 360);
            this.gbAddBook.TabIndex = 1;
            this.gbAddBook.TabStop = false;
            this.gbAddBook.Text = "Add Book";
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(705, 317);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(114, 34);
            this.btnAddBook.TabIndex = 17;
            this.btnAddBook.Text = "Add book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            // 
            // numCopies
            // 
            this.numCopies.AllowDrop = true;
            this.numCopies.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numCopies.Location = new System.Drawing.Point(122, 321);
            this.numCopies.Name = "numCopies";
            this.numCopies.Size = new System.Drawing.Size(150, 30);
            this.numCopies.TabIndex = 16;
            // 
            // lblNumberOfCopies
            // 
            this.lblNumberOfCopies.AutoSize = true;
            this.lblNumberOfCopies.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfCopies.Location = new System.Drawing.Point(6, 323);
            this.lblNumberOfCopies.Name = "lblNumberOfCopies";
            this.lblNumberOfCopies.Size = new System.Drawing.Size(110, 23);
            this.lblNumberOfCopies.TabIndex = 15;
            this.lblNumberOfCopies.Text = "No of copies:";
            // 
            // tbDescriptionBook
            // 
            this.tbDescriptionBook.Location = new System.Drawing.Point(6, 174);
            this.tbDescriptionBook.Multiline = true;
            this.tbDescriptionBook.Name = "tbDescriptionBook";
            this.tbDescriptionBook.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescriptionBook.Size = new System.Drawing.Size(813, 137);
            this.tbDescriptionBook.TabIndex = 14;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(6, 148);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description:";
            // 
            // tbISBNBook
            // 
            this.tbISBNBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbISBNBook.Location = new System.Drawing.Point(515, 69);
            this.tbISBNBook.Name = "tbISBNBook";
            this.tbISBNBook.Size = new System.Drawing.Size(304, 30);
            this.tbISBNBook.TabIndex = 12;
            // 
            // lblISBNBook
            // 
            this.lblISBNBook.AutoSize = true;
            this.lblISBNBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblISBNBook.Location = new System.Drawing.Point(458, 72);
            this.lblISBNBook.Name = "lblISBNBook";
            this.lblISBNBook.Size = new System.Drawing.Size(51, 23);
            this.lblISBNBook.TabIndex = 11;
            this.lblISBNBook.Text = "ISBN:";
            // 
            // dateTimePublicationDateBook
            // 
            this.dateTimePublicationDateBook.AllowDrop = true;
            this.dateTimePublicationDateBook.CalendarFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePublicationDateBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePublicationDateBook.Location = new System.Drawing.Point(515, 33);
            this.dateTimePublicationDateBook.Name = "dateTimePublicationDateBook";
            this.dateTimePublicationDateBook.Size = new System.Drawing.Size(304, 30);
            this.dateTimePublicationDateBook.TabIndex = 10;
            // 
            // numNumberOfPagesBook
            // 
            this.numNumberOfPagesBook.AllowDrop = true;
            this.numNumberOfPagesBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numNumberOfPagesBook.Location = new System.Drawing.Point(515, 106);
            this.numNumberOfPagesBook.Name = "numNumberOfPagesBook";
            this.numNumberOfPagesBook.Size = new System.Drawing.Size(150, 30);
            this.numNumberOfPagesBook.TabIndex = 9;
            // 
            // lblPublicationDateBook
            // 
            this.lblPublicationDateBook.AutoSize = true;
            this.lblPublicationDateBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPublicationDateBook.Location = new System.Drawing.Point(371, 36);
            this.lblPublicationDateBook.Name = "lblPublicationDateBook";
            this.lblPublicationDateBook.Size = new System.Drawing.Size(138, 23);
            this.lblPublicationDateBook.TabIndex = 8;
            this.lblPublicationDateBook.Text = "Publication date:";
            // 
            // lblNumberOfPagesBook
            // 
            this.lblNumberOfPagesBook.AutoSize = true;
            this.lblNumberOfPagesBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfPagesBook.Location = new System.Drawing.Point(402, 109);
            this.lblNumberOfPagesBook.Name = "lblNumberOfPagesBook";
            this.lblNumberOfPagesBook.Size = new System.Drawing.Size(107, 23);
            this.lblNumberOfPagesBook.TabIndex = 6;
            this.lblNumberOfPagesBook.Text = "No of pages:";
            // 
            // lblGenreBook
            // 
            this.lblGenreBook.AutoSize = true;
            this.lblGenreBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenreBook.Location = new System.Drawing.Point(6, 109);
            this.lblGenreBook.Name = "lblGenreBook";
            this.lblGenreBook.Size = new System.Drawing.Size(60, 23);
            this.lblGenreBook.TabIndex = 4;
            this.lblGenreBook.Text = "Genre:";
            // 
            // tbAuthorBook
            // 
            this.tbAuthorBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAuthorBook.Location = new System.Drawing.Point(79, 69);
            this.tbAuthorBook.Name = "tbAuthorBook";
            this.tbAuthorBook.Size = new System.Drawing.Size(266, 30);
            this.tbAuthorBook.TabIndex = 3;
            // 
            // lblAuthorBook
            // 
            this.lblAuthorBook.AutoSize = true;
            this.lblAuthorBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthorBook.Location = new System.Drawing.Point(6, 72);
            this.lblAuthorBook.Name = "lblAuthorBook";
            this.lblAuthorBook.Size = new System.Drawing.Size(67, 23);
            this.lblAuthorBook.TabIndex = 2;
            this.lblAuthorBook.Text = "Author:";
            // 
            // tbTitleBook
            // 
            this.tbTitleBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTitleBook.Location = new System.Drawing.Point(79, 33);
            this.tbTitleBook.Name = "tbTitleBook";
            this.tbTitleBook.Size = new System.Drawing.Size(266, 30);
            this.tbTitleBook.TabIndex = 1;
            // 
            // lblTitleBook
            // 
            this.lblTitleBook.AutoSize = true;
            this.lblTitleBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleBook.Location = new System.Drawing.Point(6, 36);
            this.lblTitleBook.Name = "lblTitleBook";
            this.lblTitleBook.Size = new System.Drawing.Size(46, 23);
            this.lblTitleBook.TabIndex = 0;
            this.lblTitleBook.Text = "Title:";
            // 
            // tabManageLoans
            // 
            this.tabManageLoans.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.tabManageLoans.BackgroundImage = global::Library_Individual.Properties.Resources.background;
            this.tabManageLoans.Controls.Add(this.gbLoanStatus);
            this.tabManageLoans.Controls.Add(this.bgAvailableBooks);
            this.tabManageLoans.Location = new System.Drawing.Point(4, 39);
            this.tabManageLoans.Name = "tabManageLoans";
            this.tabManageLoans.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageLoans.Size = new System.Drawing.Size(1320, 874);
            this.tabManageLoans.TabIndex = 1;
            this.tabManageLoans.Text = "Manage loans";
            // 
            // gbLoanStatus
            // 
            this.gbLoanStatus.BackColor = System.Drawing.Color.Wheat;
            this.gbLoanStatus.Controls.Add(this.lbLoanHistory);
            this.gbLoanStatus.Controls.Add(this.lbActiveLoans);
            this.gbLoanStatus.Controls.Add(this.lblHistoryLoans);
            this.gbLoanStatus.Controls.Add(this.btnSubmitReturn);
            this.gbLoanStatus.Controls.Add(this.dateTimeReturnDate);
            this.gbLoanStatus.Controls.Add(this.lblReturnDate);
            this.gbLoanStatus.Controls.Add(this.lblActiveLoans);
            this.gbLoanStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbLoanStatus.Location = new System.Drawing.Point(557, 60);
            this.gbLoanStatus.Name = "gbLoanStatus";
            this.gbLoanStatus.Size = new System.Drawing.Size(733, 586);
            this.gbLoanStatus.TabIndex = 20;
            this.gbLoanStatus.TabStop = false;
            this.gbLoanStatus.Text = "Loan status";
            // 
            // lblHistoryLoans
            // 
            this.lblHistoryLoans.AutoSize = true;
            this.lblHistoryLoans.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHistoryLoans.Location = new System.Drawing.Point(54, 306);
            this.lblHistoryLoans.Name = "lblHistoryLoans";
            this.lblHistoryLoans.Size = new System.Drawing.Size(67, 23);
            this.lblHistoryLoans.TabIndex = 43;
            this.lblHistoryLoans.Text = "History:";
            // 
            // btnSubmitReturn
            // 
            this.btnSubmitReturn.BackColor = System.Drawing.Color.White;
            this.btnSubmitReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitReturn.Location = new System.Drawing.Point(577, 255);
            this.btnSubmitReturn.Name = "btnSubmitReturn";
            this.btnSubmitReturn.Size = new System.Drawing.Size(136, 30);
            this.btnSubmitReturn.TabIndex = 42;
            this.btnSubmitReturn.Text = "Submit return";
            this.btnSubmitReturn.UseVisualStyleBackColor = false;
            // 
            // dateTimeReturnDate
            // 
            this.dateTimeReturnDate.AllowDrop = true;
            this.dateTimeReturnDate.CalendarFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeReturnDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeReturnDate.Location = new System.Drawing.Point(132, 253);
            this.dateTimeReturnDate.Name = "dateTimeReturnDate";
            this.dateTimeReturnDate.Size = new System.Drawing.Size(361, 30);
            this.dateTimeReturnDate.TabIndex = 41;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDate.Location = new System.Drawing.Point(22, 259);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(104, 23);
            this.lblReturnDate.TabIndex = 40;
            this.lblReturnDate.Text = "Return date:";
            // 
            // lblActiveLoans
            // 
            this.lblActiveLoans.AutoSize = true;
            this.lblActiveLoans.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActiveLoans.Location = new System.Drawing.Point(16, 35);
            this.lblActiveLoans.Name = "lblActiveLoans";
            this.lblActiveLoans.Size = new System.Drawing.Size(105, 23);
            this.lblActiveLoans.TabIndex = 15;
            this.lblActiveLoans.Text = "Active loans:";
            // 
            // bgAvailableBooks
            // 
            this.bgAvailableBooks.BackColor = System.Drawing.Color.Wheat;
            this.bgAvailableBooks.Controls.Add(this.lbAvailableTitles);
            this.bgAvailableBooks.Controls.Add(this.btnLoanForm);
            this.bgAvailableBooks.Controls.Add(this.btnDisplayAvailableBooks);
            this.bgAvailableBooks.Controls.Add(cbAvailableBooksGenre);
            this.bgAvailableBooks.Controls.Add(this.lblAvailableBooksGenre);
            this.bgAvailableBooks.Controls.Add(this.tbAvailableBooksAuthor);
            this.bgAvailableBooks.Controls.Add(this.lblAvailableBooksAuthor);
            this.bgAvailableBooks.Controls.Add(this.tbAvailableBooksTitle);
            this.bgAvailableBooks.Controls.Add(this.lblAvailableBooksTitle);
            this.bgAvailableBooks.Controls.Add(this.lblAvailableTitles);
            this.bgAvailableBooks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bgAvailableBooks.Location = new System.Drawing.Point(33, 60);
            this.bgAvailableBooks.Name = "bgAvailableBooks";
            this.bgAvailableBooks.Size = new System.Drawing.Size(481, 586);
            this.bgAvailableBooks.TabIndex = 0;
            this.bgAvailableBooks.TabStop = false;
            this.bgAvailableBooks.Text = "Available books";
            // 
            // btnLoanForm
            // 
            this.btnLoanForm.BackColor = System.Drawing.Color.White;
            this.btnLoanForm.Location = new System.Drawing.Point(156, 536);
            this.btnLoanForm.Name = "btnLoanForm";
            this.btnLoanForm.Size = new System.Drawing.Size(161, 35);
            this.btnLoanForm.TabIndex = 20;
            this.btnLoanForm.Text = "Open loan form";
            this.btnLoanForm.UseVisualStyleBackColor = false;
            this.btnLoanForm.Click += new System.EventHandler(this.btnLoanForm_Click);
            // 
            // btnDisplayAvailableBooks
            // 
            this.btnDisplayAvailableBooks.BackColor = System.Drawing.Color.White;
            this.btnDisplayAvailableBooks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDisplayAvailableBooks.FlatAppearance.BorderSize = 2;
            this.btnDisplayAvailableBooks.Location = new System.Drawing.Point(132, 154);
            this.btnDisplayAvailableBooks.Name = "btnDisplayAvailableBooks";
            this.btnDisplayAvailableBooks.Size = new System.Drawing.Size(211, 35);
            this.btnDisplayAvailableBooks.TabIndex = 19;
            this.btnDisplayAvailableBooks.Text = "Display available books";
            this.btnDisplayAvailableBooks.UseVisualStyleBackColor = false;
            // 
            // lblAvailableBooksGenre
            // 
            this.lblAvailableBooksGenre.AutoSize = true;
            this.lblAvailableBooksGenre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvailableBooksGenre.Location = new System.Drawing.Point(13, 111);
            this.lblAvailableBooksGenre.Name = "lblAvailableBooksGenre";
            this.lblAvailableBooksGenre.Size = new System.Drawing.Size(60, 23);
            this.lblAvailableBooksGenre.TabIndex = 16;
            this.lblAvailableBooksGenre.Text = "Genre:";
            // 
            // tbAvailableBooksAuthor
            // 
            this.tbAvailableBooksAuthor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAvailableBooksAuthor.Location = new System.Drawing.Point(86, 71);
            this.tbAvailableBooksAuthor.Name = "tbAvailableBooksAuthor";
            this.tbAvailableBooksAuthor.Size = new System.Drawing.Size(378, 30);
            this.tbAvailableBooksAuthor.TabIndex = 15;
            // 
            // lblAvailableBooksAuthor
            // 
            this.lblAvailableBooksAuthor.AutoSize = true;
            this.lblAvailableBooksAuthor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvailableBooksAuthor.Location = new System.Drawing.Point(13, 74);
            this.lblAvailableBooksAuthor.Name = "lblAvailableBooksAuthor";
            this.lblAvailableBooksAuthor.Size = new System.Drawing.Size(67, 23);
            this.lblAvailableBooksAuthor.TabIndex = 14;
            this.lblAvailableBooksAuthor.Text = "Author:";
            // 
            // tbAvailableBooksTitle
            // 
            this.tbAvailableBooksTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAvailableBooksTitle.Location = new System.Drawing.Point(86, 35);
            this.tbAvailableBooksTitle.Name = "tbAvailableBooksTitle";
            this.tbAvailableBooksTitle.Size = new System.Drawing.Size(378, 30);
            this.tbAvailableBooksTitle.TabIndex = 13;
            // 
            // lblAvailableBooksTitle
            // 
            this.lblAvailableBooksTitle.AutoSize = true;
            this.lblAvailableBooksTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvailableBooksTitle.Location = new System.Drawing.Point(13, 38);
            this.lblAvailableBooksTitle.Name = "lblAvailableBooksTitle";
            this.lblAvailableBooksTitle.Size = new System.Drawing.Size(46, 23);
            this.lblAvailableBooksTitle.TabIndex = 12;
            this.lblAvailableBooksTitle.Text = "Title:";
            // 
            // lblAvailableTitles
            // 
            this.lblAvailableTitles.AutoSize = true;
            this.lblAvailableTitles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvailableTitles.Location = new System.Drawing.Point(13, 224);
            this.lblAvailableTitles.Name = "lblAvailableTitles";
            this.lblAvailableTitles.Size = new System.Drawing.Size(123, 23);
            this.lblAvailableTitles.TabIndex = 1;
            this.lblAvailableTitles.Text = "Available titles:";
            // 
            // lblTitleMidnightReads
            // 
            this.lblTitleMidnightReads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleMidnightReads.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitleMidnightReads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitleMidnightReads.Font = new System.Drawing.Font("Stencil", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleMidnightReads.Location = new System.Drawing.Point(347, 4);
            this.lblTitleMidnightReads.Name = "lblTitleMidnightReads";
            this.lblTitleMidnightReads.Size = new System.Drawing.Size(608, 54);
            this.lblTitleMidnightReads.TabIndex = 5;
            this.lblTitleMidnightReads.Text = "Midnight Reads";
            this.lblTitleMidnightReads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDisplayBooks
            // 
            this.lbDisplayBooks.FormattingEnabled = true;
            this.lbDisplayBooks.HorizontalScrollbar = true;
            this.lbDisplayBooks.ItemHeight = 23;
            this.lbDisplayBooks.Location = new System.Drawing.Point(385, 34);
            this.lbDisplayBooks.Name = "lbDisplayBooks";
            this.lbDisplayBooks.Size = new System.Drawing.Size(434, 234);
            this.lbDisplayBooks.TabIndex = 15;
            // 
            // lbAvailableTitles
            // 
            this.lbAvailableTitles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAvailableTitles.FormattingEnabled = true;
            this.lbAvailableTitles.ItemHeight = 23;
            this.lbAvailableTitles.Location = new System.Drawing.Point(13, 253);
            this.lbAvailableTitles.Name = "lbAvailableTitles";
            this.lbAvailableTitles.Size = new System.Drawing.Size(451, 257);
            this.lbAvailableTitles.TabIndex = 21;
            // 
            // lbActiveLoans
            // 
            this.lbActiveLoans.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbActiveLoans.FormattingEnabled = true;
            this.lbActiveLoans.ItemHeight = 23;
            this.lbActiveLoans.Location = new System.Drawing.Point(16, 61);
            this.lbActiveLoans.Name = "lbActiveLoans";
            this.lbActiveLoans.Size = new System.Drawing.Size(697, 165);
            this.lbActiveLoans.TabIndex = 44;
            // 
            // lbLoanHistory
            // 
            this.lbLoanHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLoanHistory.FormattingEnabled = true;
            this.lbLoanHistory.ItemHeight = 23;
            this.lbLoanHistory.Location = new System.Drawing.Point(22, 332);
            this.lbLoanHistory.Name = "lbLoanHistory";
            this.lbLoanHistory.Size = new System.Drawing.Size(697, 234);
            this.lbLoanHistory.TabIndex = 45;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 788);
            this.Controls.Add(this.lblTitleMidnightReads);
            this.Controls.Add(this.tabControlUserForm);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.tabControlUserForm.ResumeLayout(false);
            this.tabManageBooks.ResumeLayout(false);
            this.gbSearchBy.ResumeLayout(false);
            this.gbSearchBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManageBooks)).EndInit();
            this.gbAddBook.ResumeLayout(false);
            this.gbAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPagesBook)).EndInit();
            this.tabManageLoans.ResumeLayout(false);
            this.gbLoanStatus.ResumeLayout(false);
            this.gbLoanStatus.PerformLayout();
            this.bgAvailableBooks.ResumeLayout(false);
            this.bgAvailableBooks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlUserForm;
        private TabPage tabManageBooks;
        private TabPage tabManageLoans;
        private GroupBox gbAddBook;
        private NumericUpDown numNumberOfPagesBook;
        private Label lblPublicationDateBook;
        private Label lblNumberOfPagesBook;
        private ComboBox cbGenreBook;
        private Label lblGenreBook;
        private TextBox tbAuthorBook;
        private Label lblAuthorBook;
        private TextBox tbTitleBook;
        private Label lblTitleBook;
        private Label lblTitleMidnightReads;
        private DateTimePicker dateTimePublicationDateBook;
        private PictureBox pictureBoxManageBooks;
        private Button btnAddBook;
        private NumericUpDown numCopies;
        private Label lblNumberOfCopies;
        private TextBox tbDescriptionBook;
        private Label lblDescription;
        private TextBox tbISBNBook;
        private Label lblISBNBook;
        private GroupBox gbSearchBy;
        private Label lblGenreSearch;
        private TextBox tbAuthorSearch;
        private Label lblAuthorSearch;
        private TextBox tbTitleSearch;
        private Label lblTitleSearch;
        private Button btnRemoveSelectedBook;
        private Button btnDisplayAllBooks;
        private GroupBox gbLoanStatus;
        private GroupBox bgAvailableBooks;
        private Button btnDisplayAvailableBooks;
        private Label lblAvailableBooksGenre;
        private TextBox tbAvailableBooksAuthor;
        private Label lblAvailableBooksAuthor;
        private TextBox tbAvailableBooksTitle;
        private Label lblAvailableBooksTitle;
        private Label lblAvailableTitles;
        private Label lblActiveLoans;
        private DateTimePicker dateTimeReturnDate;
        private Label lblReturnDate;
        private Label lblHistoryLoans;
        private Button btnSubmitReturn;
        private Button btnLoanForm;
        private ListBox lbDisplayBooks;
        private ListBox lbLoanHistory;
        private ListBox lbActiveLoans;
        private ListBox lbAvailableTitles;
    }
}