using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Library_Individual
{
    public class FileManager
    {
        private const string filePathLibrary = @"..\..\..\..\LibraryData.txt";
        private const string filePathUsers = @"..\..\..\..\UsersData.csv";

        public Library LoadLibraryData()
        {
            try
            {
                Library libraryData = new Library();

                using (FileStream fs = new(filePathLibrary, FileMode.Open, FileAccess.Read))
                {
                    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
                    Type typeToSerialize = typeof(Library);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Book),
                        typeof(Genre),
                        typeof(Loan),
                        typeof(User)
                    };

                    DataContractSerializer dcs = new(typeToSerialize, auxiliaryTypes);
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
                using (FileStream ClearFile = new(filePathLibrary, FileMode.Truncate, FileAccess.Write)) ;
                using (FileStream fs = new(filePathLibrary, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    Type typeToSerialize = typeof(Library);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Book),
                        typeof(Genre),
                        typeof(Loan),
                        typeof(User)
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

        public UserManager LoadUsersData() 
        {
            using (StreamReader reader = new StreamReader(filePathUsers))
            {
                string line;
                string[] fields;
                UserManager userManager = new UserManager();
                //Read the header line and ignore it
                line = reader.ReadLine();

                //Read the rest of the lines and parse them into User objects
                while ((line = reader.ReadLine()) != null)
                {
                    fields = line.Split(',');
                    userManager.AddUserToList(new User(fields[0], Convert.ToInt32(fields[1]), fields[2], fields[3]));                      
                }
                return userManager;
            }
        }
    }
}
