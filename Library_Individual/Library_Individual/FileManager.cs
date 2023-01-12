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
        private const string filePathEmployees = @"..\..\..\..\EmployeesData.csv";
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
                        typeof(Member)
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
                        typeof(Member)
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

        public void WriteEmployeesToCSV(UserManager userManager)
        {
            using (StreamWriter writer = new StreamWriter(filePathEmployees))
            {
                writer.WriteLine("Name,Id,Email,Password");
                foreach (Employee employee in userManager.GetEmployees())
                {
                    writer.WriteLine($"{employee.Name},{employee.Id},{employee.Email},{employee.Password}");
                }
            }
        }

        public void WriteMembersToCSV(UserManager userManager)
        {
            using (StreamWriter writer = new StreamWriter(filePathMembers))
            {
                writer.WriteLine("Name,Id,Email,Phone");
                foreach (Member member in userManager.GetMembers())
                {
                    writer.WriteLine($"{member.Name},{member.Id},{member.Email},{member.Phone}");
                }
            }
        }

        public UserManager LoadEmployeesData(UserManager userManager) 
        {
            using (StreamReader reader = new StreamReader(filePathEmployees))
            {
                string line;
                string[] fields;

                //Read the header line and ignore it
                reader.ReadLine();

                //Read the rest of the lines and parse them into User objects
                while ((line = reader.ReadLine()) != null)
                {
                    fields = line.Split(',');
                    userManager.AddEmployeeToList(new Employee(fields[0], Convert.ToInt32(fields[1]), fields[2], fields[3]));                      
                }
                return userManager;
            }
        }

        public UserManager LoadMembersData(UserManager userManager)
        {
            using (StreamReader reader = new StreamReader(filePathMembers))
            {
                string line;
                string[] fields;

                //Read the header line and ignore it
                reader.ReadLine();

                //Read the rest of the lines and parse them into User objects
                while ((line = reader.ReadLine()) != null)
                {
                    fields = line.Split(',');
                    userManager.AddMemberToList(new Member(fields[0], Convert.ToInt32(fields[1]), fields[2], Convert.ToInt32(fields[3])));
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
                            string query = @$"INSERT INTO LoanHistory (Name, Id, Email, Phone, LoanedBooks, BorrowDate, ReturnDate) VALUES ('{l.Borrower.Name}', '{l.Borrower.Id}','{l.Borrower.Email}', '{l.Borrower.Phone}', '{l.StringBooks()}', '{l.BorowDate}', '{l.ReturnDate}')";
                            using (SqlCommand command1 = new SqlCommand(query, conn, transaction))
                            {
                                int rowsAffected = command1.ExecuteNonQuery();
                                MessageBox.Show(rowsAffected.ToString());
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
