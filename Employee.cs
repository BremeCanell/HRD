using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HRD
{
    public class Employee
    {
        public string ID_Emp;
        public string Qual_ID;
        public string Po_ID;
        public string Name;
        public string LName;
        public string Pat;
        public DateTime DBirth;
        public string PSeries;
        public string PNumber;
        public string PWho;
        public DateTime PWhen;
        public string Reg;
        public string Res;
        public string Email;
        public string Tg;
        public string Phone;
        public string PosName;
        public string QualName;
        public Employee(
            string id_emp,
            string qual_id,
            string po_id,
            string name,
            string lName,
            DateTime dBirth,
            string pSeries,
            string pNumber,
            string pWho,
            DateTime pWhen,
            string reg,
            string res,
            string phone,
            string posName,
            string qualName,
            string pat = "",
            string email = "",
            string tg = ""
            ) { 
            ID_Emp = id_emp;
            Qual_ID = qual_id;
            Po_ID = po_id;
            Name = name;
            LName = lName;
            Pat = pat;
            DBirth = dBirth;
            PSeries = pSeries;
            PNumber = pNumber;
            PWho = pWho;
            PWhen = pWhen;
            Reg = reg;
            Res = res;
            Email = email;
            Tg = tg;
            Phone = phone;
            PosName = posName;
            QualName = qualName;
        }
        public Employee(
            string id_emp,
            string name,
            string lName,
            string pat,
            string posName,
            string qualName)
        {
            ID_Emp = id_emp;
            Name = name;
            LName = lName;
            Pat = pat;
            PosName = posName;
            QualName = qualName;
        }
    }
}
