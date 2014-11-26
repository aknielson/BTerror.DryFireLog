using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BTerror.DryFireLog.DataLayer;
using BTerror.DryFireLog.Models;

namespace BTerror.DryFileLog.DryFireLog.ServiceLibrary
{
    [ServiceContract]
    public interface IDryFireLogService
    {
        [OperationContract]
        Book GetBookById();


    }
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DryFireLogService" in both code and config file together.
    public class DryFireLogService : IDryFireLogService
    {
        public Book GetBookById()
        {
            Book returnval = new Book();
            using (var context = new DryFireLogModelContext())
            {
                var woot = context.Books.ToList().First();

                returnval.Author = woot.Author;
                returnval.BookId = woot.BookId;
                returnval.Drills = woot.Drills.ToList();
                returnval.Things = woot.Things;
                returnval.Title = woot.Title;
                returnval.Version = woot.Version;
            }
            return returnval;
        }
    }
}
