using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams.Model
{
    public class LocalDataProvider : IDataProvider
    {
        public IEnumerable<Patient> GetPatients()
        {
            return new Patient[]{
            new Patient{Age=19,TreatmentType = "Тип 1", SumOfTreatment = 2154.6, Name="Юлия", ReceiptDate = new DateTime(2021,4,21)},
            new Patient{Age=23,TreatmentType = "Тип 2", SumOfTreatment = 3579.8, Name="Руслан", ReceiptDate = new DateTime(2021,2,11)},
            new Patient{Age=34,TreatmentType = "Тип 3", SumOfTreatment = 1291.17, Name="Григорий", ReceiptDate= new DateTime(2021,3,14) },
            new Patient{Age=18,TreatmentType = "Тип 4", SumOfTreatment = 4554.4, Name="Евгений", ReceiptDate = new DateTime(2021,4,12)},
            new Patient{Age=24,TreatmentType = "Тип 5", SumOfTreatment = 6554.5, Name="Иван", ReceiptDate = new DateTime(2021,6,1)},
            new Patient{Age=25,TreatmentType = "Тип 6", SumOfTreatment = 8054.9, Name="Никита", ReceiptDate = new DateTime(2021,1,30)},
            new Patient{Age=45,TreatmentType = "Тип 7", SumOfTreatment = 4154.6, Name="Татьяна", ReceiptDate = new DateTime(2021,8,15)},
            new Patient{Age=43,TreatmentType = "Тип 8", SumOfTreatment = 4354.3, Name="Егор", ReceiptDate = new DateTime(2021,11,17)},
            new Patient{Age=38,TreatmentType = "Тип 9", SumOfTreatment = 5054.1, Name="Светлана", ReceiptDate = new DateTime(2021,12,10)},
            new Patient{Age=27,TreatmentType = "Тип 10", SumOfTreatment = 1154.8, Name="Владимир", ReceiptDate = new DateTime(2021,3,19)}
        };
        }
        public IEnumerable<PatientType> GetPatientTypes()
        {
            return new PatientType[] {
        new PatientType{ Title="Тип 111" },
        new PatientType{ Title="Тип 222" },
        new PatientType{ Title="Тип 333" },
        new PatientType{ Title="Тип 444" },
        new PatientType{ Title="Тип 555" },
        };
        }
    }
}
