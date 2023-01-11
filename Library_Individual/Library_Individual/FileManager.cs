using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data.SqlClient;
using System.Data.Common;
using System.Transactions;

namespace Library_Individual
{
    public class FileManager
    {
        private const string filePathLibrary = @"..\..\..\..\LibraryData.xml";
        private const string filePathUsers = @"..\..\..\..\UsersData.csv";
        private const string filePathMembers = @"..\..\..\..\MembersData.csv";

        public Library LoadLibraryData()
        {
            try
            {
                Library libraryData = new Library();

                using (FileStream fs = new(filePathLibrary, FileMode.Open, FileAccess.Read))
                {
                    Type typeToSerialize = typeof(Library);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Book),
                        typeof(BookGenre),
                        typeof(Loan),
                    };

                    DataContractSerializer dcs = new(typeToSerialize, auxiliaryTypes);
                    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
                    libraryData = (Library)dcs.ReadObject(reader, true);

                    return libraryData;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void WriteLibraryData(Library data)
        {
            try
            {
                using (FileStream ClearFile = new(filePathLibrary, FileMode.Truncate, FileAccess.Write));
                using (FileStream fs = new(filePathLibrary, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    Type typeToSerialize = typeof(Library);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Book),
                        typeof(BookGenre),
                        typeof(Loan),
                    };

                    DataContractSerializer dcs = new(typeToSerialize);
                    dcs.WriteObject(fs, data);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public void WriteUsersToCSV(UserManager userManager)
        {
            using (StreamWriter writer = new StreamWriter(filePathUsers))
            {
                writer.WriteLine("Name,Id,Email,Password");
                foreach (User user in userManager.GetUsers())
                {
                    writer.WriteLine($"{user.Name},{user.Id},{user.Email},{user.Password}");
                }
            }
        }

        public void WriteMembersToCSV(Library library)
        {
            using (StreamWriter writer = new StreamWriter(filePathMembers))
            {
                writer.WriteLine("Name,Id,Email,Phone");
                foreach (Loan loan in library.GetLoans())
                {
                    writer.WriteLine($"{loan.Name},{loan.Id},{loan.Email},{loan.Phone}");
                }
            }
        }

        public UserManager LoadUsersData() 
        {
            using (StreamReader reader = new StreamReader(filePathUsers))
            {
                string line;
                string[] fields;
                UserManager userManager = new UserManager();
                //Read the header line and ignore it
                reader.ReadLine();

                //Read the rest of the lines and parse them into User objects
                while ((line = reader.ReadLine()) != null)
                {
                    fields = line.Split(',');
                    userManager.AddUserToList(new User(fields[0], Convert.ToInt32(fields[1]), fields[2], fields[3]));                      
                }
                return userManager;
            }
        }

        public void SaveToDatabase(Loan l)
        {
            string connectionString = "Server=mssqlstud.fhict.local;Database=dbi505708;User Id=dbi505708;Password=pulamare;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Begin a transaction on the connection
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        if(l.ReturnDate.Year != 1)
                        {
                            string query = @$"INSERT INTO LoanHistory (Name, Id, Email, Phone, LoanedBooks, BorrowDate, ReturnDate) VALUES ('{l.Name}', '{l.Id}','{l.Email}', '{l.Phone}', '{l.StringBooks()}', '{l.BorowDate}', '{l.ReturnDate}')";
                            using (SqlCommand command1 = new SqlCommand(query, conn, transaction))
                            {
                                int rowsAffected = command1.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        //If any exceptions were thrown, roll back the transaction
                        MessageBox.Show($"An error occurred: {ex.Message}");
                        transaction.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
