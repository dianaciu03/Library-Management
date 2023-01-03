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

        public Library LoadData()
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

        public void WriteData(Library data)
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
    }
}
