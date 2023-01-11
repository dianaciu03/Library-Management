namespace Library_Individual
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
            this.tabControlUserForm = new System.Windows.Forms.TabControl();
            this.tabManageBooks = new System.Windows.Forms.TabPage();
            this.gbSearchBy = new System.Windows.Forms.GroupBox();
            this.numCopiesAdd = new System.Windows.Forms.NumericUpDown();
            this.lblNrCopies = new System.Windows.Forms.Label();
            this.btnAddCopies = new System.Windows.Forms.Button();
            this.btnSearchForBook = new System.Windows.Forms.Button();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.lbDisplayBooks = new System.Windows.Forms.ListBox();
            this.btnRemoveSelectedBook = new System.Windows.Forms.Button();
            this.btnDisplayAllBooks = new System.Windows.Forms.Button();
            this.lblGenreSearch = new System.Windows.Forms.Label();
            this.tbAuthorSearch = new System.Windows.Forms.TextBox();
            this.lblAuthorSearch = new System.Windows.Forms.Label();
            this.tbTitleSearch = new System.Windows.Forms.TextBox();
            this.lblTitleSearch = new System.Windows.Forms.Label();
            this.pictureBoxManageBooks = new System.Windows.Forms.PictureBox();
            this.gbAddBook = new System.Windows.Forms.GroupBox();
            this.tbNoPages = new System.Windows.Forms.TextBox();
            this.cbGenreBook = new System.Windows.Forms.ComboBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.numCopies = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfCopies = new System.Windows.Forms.Label();
            this.tbDescriptionBook = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbISBNBook = new System.Windows.Forms.TextBox();
            this.lblISBNBook = new System.Windows.Forms.Label();
            this.dateTimePublicationDateBook = new System.Windows.Forms.DateTimePicker();
            this.lblPublicationDateBook = new System.Windows.Forms.Label();
            this.lblNumberOfPagesBook = new System.Windows.Forms.Label();
            this.lblGenreBook = new System.Windows.Forms.Label();
            this.tbAuthorBook = new System.Windows.Forms.TextBox();
            this.lblAuthorBook = new System.Windows.Forms.Label();
            this.tbTitleBook = new System.Windows.Forms.TextBox();
            this.lblTitleBook = new System.Windows.Forms.Label();
            this.tabManageLoans = new System.Windows.Forms.TabPage();
            this.gbLoanStatus = new System.Windows.Forms.GroupBox();
            this.lbLoanHistory = new System.Windows.Forms.ListBox();
            this.lbActiveLoans = new System.Windows.Forms.ListBox();
            this.lblHistoryLoans = new System.Windows.Forms.Label();
            this.btnSubmitReturn = new System.Windows.Forms.Button();
            this.lblActiveLoans = new System.Windows.Forms.Label();
            this.bgAvailableBooks = new System.Windows.Forms.GroupBox();
            this.cbAvailableBooksGenre = new System.Windows.Forms.ComboBox();
            this.lbAvailableTitles = new System.Windows.Forms.ListBox();
            this.btnLoanForm = new System.Windows.Forms.Button();
            this.btnDisplayAvailableBooks = new System.Windows.Forms.Button();
            this.lblAvailableBooksGenre = new System.Windows.Forms.Label();
            this.tbAvailableBooksAuthor = new System.Windows.Forms.TextBox();
            this.lblAvailableBooksAuthor = new System.Windows.Forms.Label();
            this.tbAvailableBooksTitle = new System.Windows.Forms.TextBox();
            this.lblAvailableBooksTitle = new System.Windows.Forms.Label();
            this.lblAvailableTitles = new System.Windows.Forms.Label();
            this.lblTitleMidnightReads = new System.Windows.Forms.Label();
            this.tabControlUserForm.SuspendLayout();
            this.tabManageBooks.SuspendLayout();
            this.gbSearchBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCopiesAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManageBooks)).BeginInit();
            this.gbAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCopies)).BeginInit();
            this.tabManageLoans.SuspendLayout();
            this.gbLoanStatus.SuspendLayout();
            this.bgAvailableBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUserForm
            // 
            this.tabControlUserForm.Controls.Add(this.tabManageBooks);
            this.tabControlUserForm.Controls.Add(this.tabManageLoans);
            this.tabControlUserForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlUserForm.Location = new System.Drawing.Point(12, 50);
            this.tabControlUserForm.Name = "tabControlUserForm";
            this.tabControlUserForm.Padding = new System.Drawing.Point(20, 4);
            this.tabControlUserForm.SelectedIndex = 0;
            this.tabControlUserForm.Size = new System.Drawing.Size(1328, 786);
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
            this.tabManageBooks.Size = new System.Drawing.Size(1320, 743);
            this.tabManageBooks.TabIndex = 0;
            this.tabManageBooks.Text = "Manage books";
            this.tabManageBooks.UseVisualStyleBackColor = true;
            // 
            // gbSearchBy
            // 
            this.gbSearchBy.BackColor = System.Drawing.Color.Wheat;
            this.gbSearchBy.Controls.Add(this.numCopiesAdd);
            this.gbSearchBy.Controls.Add(this.lblNrCopies);
            this.gbSearchBy.Controls.Add(this.btnAddCopies);
            this.gbSearchBy.Controls.Add(this.btnSearchForBook);
            this.gbSearchBy.Controls.Add(this.comboBoxGenre);
            this.gbSearchBy.Controls.Add(this.lbDisplayBooks);
            this.gbSearchBy.Controls.Add(this.btnRemoveSelectedBook);
            this.gbSearchBy.Controls.Add(this.btnDisplayAllBooks);
            this.gbSearchBy.Controls.Add(this.lblGenreSearch);
            this.gbSearchBy.Controls.Add(this.tbAuthorSearch);
            this.gbSearchBy.Controls.Add(this.lblAuthorSearch);
            this.gbSearchBy.Controls.Add(this.tbTitleSearch);
            this.gbSearchBy.Controls.Add(this.lblTitleSearch);
            this.gbSearchBy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSearchBy.Location = new System.Drawing.Point(15, 391);
            this.gbSearchBy.Name = "gbSearchBy";
            this.gbSearchBy.Size = new System.Drawing.Size(832, 344);
            this.gbSearchBy.TabIndex = 3;
            this.gbSearchBy.TabStop = false;
            this.gbSearchBy.Text = "Search by";
            // 
            // numCopiesAdd
            // 
            this.numCopiesAdd.AllowDrop = true;
            this.numCopiesAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numCopiesAdd.Location = new System.Drawing.Point(102, 197);
            this.numCopiesAdd.Name = "numCopiesAdd";
            this.numCopiesAdd.Size = new System.Drawing.Size(88, 30);
            this.numCopiesAdd.TabIndex = 20;
            // 
            // lblNrCopies
            // 
            this.lblNrCopies.AutoSize = true;
            this.lblNrCopies.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNrCopies.Location = new System.Drawing.Point(6, 199);
            this.lblNrCopies.Name = "lblNrCopies";
            this.lblNrCopies.Size = new System.Drawing.Size(90, 23);
            this.lblNrCopies.TabIndex = 19;
            this.lblNrCopies.Text = "No copies:";
            // 
            // btnAddCopies
            // 
            this.btnAddCopies.BackColor = System.Drawing.Color.White;
            this.btnAddCopies.Location = new System.Drawing.Point(196, 190);
            this.btnAddCopies.Name = "btnAddCopies";
            this.btnAddCopies.Size = new System.Drawing.Size(149, 40);
            this.btnAddCopies.TabIndex = 18;
            this.btnAddCopies.Text = "Modify copies";
            this.btnAddCopies.UseVisualStyleBackColor = false;
            this.btnAddCopies.Click += new System.EventHandler(this.btnAddCopies_Click);
            // 
            // btnSearchForBook
            // 
            this.btnSearchForBook.BackColor = System.Drawing.Color.White;
            this.btnSearchForBook.Location = new System.Drawing.Point(79, 144);
            this.btnSearchForBook.Name = "btnSearchForBook";
            this.btnSearchForBook.Size = new System.Drawing.Size(266, 40);
            this.btnSearchForBook.TabIndex = 17;
            this.btnSearchForBook.Text = "Search";
            this.btnSearchForBook.UseVisualStyleBackColor = false;
            this.btnSearchForBook.Click += new System.EventHandler(this.btnSearchForBook_Click);
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(79, 107);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(266, 31);
            this.comboBoxGenre.TabIndex = 16;
            // 
            // lbDisplayBooks
            // 
            this.lbDisplayBooks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDisplayBooks.FormattingEnabled = true;
            this.lbDisplayBooks.HorizontalScrollbar = true;
            this.lbDisplayBooks.ItemHeight = 23;
            this.lbDisplayBooks.Location = new System.Drawing.Point(371, 34);
            this.lbDisplayBooks.Name = "lbDisplayBooks";
            this.lbDisplayBooks.Size = new System.Drawing.Size(448, 303);
            this.lbDisplayBooks.TabIndex = 15;
            this.lbDisplayBooks.DoubleClick += new System.EventHandler(this.lbDisplayBooks_DoubleClick);
            // 
            // btnRemoveSelectedBook
            // 
            this.btnRemoveSelectedBook.BackColor = System.Drawing.Color.White;
            this.btnRemoveSelectedBook.Location = new System.Drawing.Point(79, 297);
            this.btnRemoveSelectedBook.Name = "btnRemoveSelectedBook";
            this.btnRemoveSelectedBook.Size = new System.Drawing.Size(266, 40);
            this.btnRemoveSelectedBook.TabIndex = 14;
            this.btnRemoveSelectedBook.Text = "Remove selected book";
            this.btnRemoveSelectedBook.UseVisualStyleBackColor = false;
            this.btnRemoveSelectedBook.Click += new System.EventHandler(this.btnRemoveSelectedBook_Click);
            // 
            // btnDisplayAllBooks
            // 
            this.btnDisplayAllBooks.BackColor = System.Drawing.Color.White;
            this.btnDisplayAllBooks.Location = new System.Drawing.Point(79, 251);
            this.btnDisplayAllBooks.Name = "btnDisplayAllBooks";
            this.btnDisplayAllBooks.Size = new System.Drawing.Size(266, 40);
            this.btnDisplayAllBooks.TabIndex = 13;
            this.btnDisplayAllBooks.Text = "Display all books";
            this.btnDisplayAllBooks.UseVisualStyleBackColor = false;
            this.btnDisplayAllBooks.Click += new System.EventHandler(this.btnDisplayAllBooks_Click);
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
            this.pictureBoxManageBooks.Size = new System.Drawing.Size(461, 720);
            this.pictureBoxManageBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxManageBooks.TabIndex = 2;
            this.pictureBoxManageBooks.TabStop = false;
            // 
            // gbAddBook
            // 
            this.gbAddBook.BackColor = System.Drawing.Color.Wheat;
            this.gbAddBook.Controls.Add(this.tbNoPages);
            this.gbAddBook.Controls.Add(this.cbGenreBook);
            this.gbAddBook.Controls.Add(this.btnAddBook);
            this.gbAddBook.Controls.Add(this.numCopies);
            this.gbAddBook.Controls.Add(this.lblNumberOfCopies);
            this.gbAddBook.Controls.Add(this.tbDescriptionBook);
            this.gbAddBook.Controls.Add(this.lblDescription);
            this.gbAddBook.Controls.Add(this.tbISBNBook);
            this.gbAddBook.Controls.Add(this.lblISBNBook);
            this.gbAddBook.Controls.Add(this.dateTimePublicationDateBook);
            this.gbAddBook.Controls.Add(this.lblPublicationDateBook);
            this.gbAddBook.Controls.Add(this.lblNumberOfPagesBook);
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
            // tbNoPages
            // 
            this.tbNoPages.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNoPages.Location = new System.Drawing.Point(515, 106);
            this.tbNoPages.Name = "tbNoPages";
            this.tbNoPages.Size = new System.Drawing.Size(304, 30);
            this.tbNoPages.TabIndex = 19;
            // 
            // cbGenreBook
            // 
            this.cbGenreBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbGenreBook.FormattingEnabled = true;
            this.cbGenreBook.Location = new System.Drawing.Point(79, 106);
            this.cbGenreBook.Name = "cbGenreBook";
            this.cbGenreBook.Size = new System.Drawing.Size(266, 31);
            this.cbGenreBook.TabIndex = 18;
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
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
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
            this.tbDescriptionBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.tabManageLoans.Size = new System.Drawing.Size(1320, 743);
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
            this.gbLoanStatus.Controls.Add(this.lblActiveLoans);
            this.gbLoanStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbLoanStatus.Location = new System.Drawing.Point(557, 60);
            this.gbLoanStatus.Name = "gbLoanStatus";
            this.gbLoanStatus.Size = new System.Drawing.Size(733, 602);
            this.gbLoanStatus.TabIndex = 20;
            this.gbLoanStatus.TabStop = false;
            this.gbLoanStatus.Text = "Loan status";
            // 
            // lbLoanHistory
            // 
            this.lbLoanHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLoanHistory.FormattingEnabled = true;
            this.lbLoanHistory.ItemHeight = 23;
            this.lbLoanHistory.Location = new System.Drawing.Point(22, 332);
            this.lbLoanHistory.Name = "lbLoanHistory";
            this.lbLoanHistory.Size = new System.Drawing.Size(697, 257);
            this.lbLoanHistory.TabIndex = 45;
            this.lbLoanHistory.DoubleClick += new System.EventHandler(this.lbLoanHistory_DoubleClick);
            // 
            // lbActiveLoans
            // 
            this.lbActiveLoans.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbActiveLoans.FormattingEnabled = true;
            this.lbActiveLoans.ItemHeight = 23;
            this.lbActiveLoans.Location = new System.Drawing.Point(16, 61);
            this.lbActiveLoans.Name = "lbActiveLoans";
            this.lbActiveLoans.Size = new System.Drawing.Size(697, 188);
            this.lbActiveLoans.TabIndex = 44;
            this.lbActiveLoans.DoubleClick += new System.EventHandler(this.lbActiveLoans_DoubleClick);
            // 
            // lblHistoryLoans
            // 
            this.lblHistoryLoans.AutoSize = true;
            this.lblHistoryLoans.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHistoryLoans.Location = new System.Drawing.Point(22, 306);
            this.lblHistoryLoans.Name = "lblHistoryLoans";
            this.lblHistoryLoans.Size = new System.Drawing.Size(67, 23);
            this.lblHistoryLoans.TabIndex = 43;
            this.lblHistoryLoans.Text = "History:";
            // 
            // btnSubmitReturn
            // 
            this.btnSubmitReturn.BackColor = System.Drawing.Color.White;
            this.btnSubmitReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitReturn.Location = new System.Drawing.Point(289, 255);
            this.btnSubmitReturn.Name = "btnSubmitReturn";
            this.btnSubmitReturn.Size = new System.Drawing.Size(161, 37);
            this.btnSubmitReturn.TabIndex = 42;
            this.btnSubmitReturn.Text = "Submit return";
            this.btnSubmitReturn.UseVisualStyleBackColor = false;
            this.btnSubmitReturn.Click += new System.EventHandler(this.btnSubmitReturn_Click);
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
            this.bgAvailableBooks.Controls.Add(this.cbAvailableBooksGenre);
            this.bgAvailableBooks.Controls.Add(this.lbAvailableTitles);
            this.bgAvailableBooks.Controls.Add(this.btnLoanForm);
            this.bgAvailableBooks.Controls.Add(this.btnDisplayAvailableBooks);
            this.bgAvailableBooks.Controls.Add(this.lblAvailableBooksGenre);
            this.bgAvailableBooks.Controls.Add(this.tbAvailableBooksAuthor);
            this.bgAvailableBooks.Controls.Add(this.lblAvailableBooksAuthor);
            this.bgAvailableBooks.Controls.Add(this.tbAvailableBooksTitle);
            this.bgAvailableBooks.Controls.Add(this.lblAvailableBooksTitle);
            this.bgAvailableBooks.Controls.Add(this.lblAvailableTitles);
            this.bgAvailableBooks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bgAvailableBooks.Location = new System.Drawing.Point(33, 60);
            this.bgAvailableBooks.Name = "bgAvailableBooks";
            this.bgAvailableBooks.Size = new System.Drawing.Size(481, 602);
            this.bgAvailableBooks.TabIndex = 0;
            this.bgAvailableBooks.TabStop = false;
            this.bgAvailableBooks.Text = "Available books";
            // 
            // cbAvailableBooksGenre
            // 
            this.cbAvailableBooksGenre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAvailableBooksGenre.FormattingEnabled = true;
            this.cbAvailableBooksGenre.Location = new System.Drawing.Point(86, 108);
            this.cbAvailableBooksGenre.Name = "cbAvailableBooksGenre";
            this.cbAvailableBooksGenre.Size = new System.Drawing.Size(378, 31);
            this.cbAvailableBooksGenre.TabIndex = 22;
            // 
            // lbAvailableTitles
            // 
            this.lbAvailableTitles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAvailableTitles.FormattingEnabled = true;
            this.lbAvailableTitles.ItemHeight = 23;
            this.lbAvailableTitles.Location = new System.Drawing.Point(13, 263);
            this.lbAvailableTitles.Name = "lbAvailableTitles";
            this.lbAvailableTitles.Size = new System.Drawing.Size(451, 257);
            this.lbAvailableTitles.TabIndex = 21;
            this.lbAvailableTitles.DoubleClick += new System.EventHandler(this.lbAvailableTitles_DoubleClick);
            // 
            // btnLoanForm
            // 
            this.btnLoanForm.BackColor = System.Drawing.Color.White;
            this.btnLoanForm.Location = new System.Drawing.Point(146, 554);
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
            this.btnDisplayAvailableBooks.Click += new System.EventHandler(this.btnDisplayAvailableBooks_Click);
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
            this.lblAvailableTitles.Location = new System.Drawing.Point(13, 234);
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
            this.lblTitleMidnightReads.Size = new System.Drawing.Size(608, 43);
            this.lblTitleMidnightReads.TabIndex = 5;
            this.lblTitleMidnightReads.Text = "Midnight Reads";
            this.lblTitleMidnightReads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 832);
            this.Controls.Add(this.lblTitleMidnightReads);
            this.Controls.Add(this.tabControlUserForm);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.tabControlUserForm.ResumeLayout(false);
            this.tabManageBooks.ResumeLayout(false);
            this.gbSearchBy.ResumeLayout(false);
            this.gbSearchBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCopiesAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManageBooks)).EndInit();
            this.gbAddBook.ResumeLayout(false);
            this.gbAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCopies)).EndInit();
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
        private Label lblPublicationDateBook;
        private Label lblNumberOfPagesBook;
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
        private Label lblHistoryLoans;
        private Button btnSubmitReturn;
        private Button btnLoanForm;
        private ListBox lbDisplayBooks;
        private ListBox lbLoanHistory;
        private ListBox lbActiveLoans;
        private ListBox lbAvailableTitles;
        private ComboBox comboBoxGenre;
        private ComboBox cbAvailableBooksGenre;
        private ComboBox cbGenreBook;
        private TextBox tbNoPages;
        private Button btnSearchForBook;
        private NumericUpDown numCopiesAdd;
        private Label lblNrCopies;
        private Button btnAddCopies;
    }
}