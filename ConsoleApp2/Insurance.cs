using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Insurance
    {
        //дата выдачи и окончания
        //
        public DateTime CreationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
         public string OwnerFullName { get; set; }
        public Insurance(DateTime creationDate, DateTime expirationDate,
            string ownerFullName)
        {
            CreationDate = creationDate;
            ExpirationDate= expirationDate;
            OwnerFullName = ownerFullName;
        }
    }
}
